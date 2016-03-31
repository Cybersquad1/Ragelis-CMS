using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;

namespace Ragelis
{
    public partial class RagelisCMS : Form
    {
        private volatile bool _stopCycle = false;
        SerialPort _serialPort;

        public RagelisCMS()
        {
            InitializeComponent();
            
            try
            {
                _serialPort = new SerialPort("COM13", 2400);
                _serialPort.ReadTimeout = 60000;
                _serialPort.WriteTimeout = 60000;

                //port.DtrEnabled = true; //un-comment this line to cause the arduino to re-boot when the serial connects
                _serialPort.Open();
            }
            catch (Exception serialPortOpenException)
            {
                Console.WriteLine("Cant open COM port: " + serialPortOpenException.Message);
            }

            Thread cycle = new Thread(new ThreadStart(readSerial));
            cycleCompleted += new AsyncCompletedEventHandler(cycle_Completed);
            cycle.Start();
        }

        private void readSerial()
        {
            UIdata returnData = new UIdata();
            returnData.status = "WAITING";
            char[] delimiterChars = { '\n', '\r' };
            while (!_stopCycle)
            {
                try
                {
                    string message = _serialPort.ReadLine();
                    string[] words = message.Split(delimiterChars);

                    foreach (string s in words)
                    {

                        if (s.StartsWith("+COPS:"))
                        {
                            string[] GSMprovider = message.Split(',');
                            string provider = GSMprovider[GSMprovider.Length - 1].Replace('"',' ');
                            if (provider.StartsWith("+COPS:"))
                            {
                                returnData.status = "NO NETWORK";
                            } else
                            {
                                returnData.gsmProvider = provider;
                            }
                            
                        }
                        else if (s.StartsWith("+CSQ:"))
                        {
                            string[] GSMsignal = message.Split(',', ':', ' ');
                            string signalStrenght = GSMsignal[2];
                            returnData.gsmSignalStrenght = signalStrenght;
                        }
                        else if (s.StartsWith("REVISION"))
                        {
                            string[] revision = message.Split(',');
                            returnData.revision = revision[1];
                        }
                        else if (s.StartsWith("+CLIP:"))
                        {
                            string[] incommingCall = message.Split(',', ':', ' ');
                            string caller = incommingCall[2];
                            returnData.incommingCall = caller.Replace('"', ' '); ;
                        }
                        else if (s.StartsWith("RING"))
                        {
                            returnData.status = "INCOMMING";        //incomming call
                        }
                        else if (s.StartsWith("NO CARRIER"))
                        {
                            returnData.status = "WAITING";          //waiting for call
                        }
                        else if (s.StartsWith("ATH"))
                        {
                            returnData.status = "WAITING";
                        }
                        else if (s.StartsWith("ATA"))
                        {
                            returnData.status = "CONNECTED";        //connected
                        }
                        else if (s.StartsWith("BUSY"))
                        {
                            returnData.status = "WAITING";        //busy
                        }
                        else if (s.StartsWith("ATD"))
                        {
                            returnData.status = "DIALING";          //dialing 
                        }
                        else if (s.StartsWith("NO DIALTONE"))
                        {
                            returnData.status = "NO NETWORK";
                        }
                        else if (s.StartsWith("AT+COPS") || s.StartsWith("AT+CSQ"))
                        {
                            Console.Write(".");
                        }
                        else if (s != "" && s != "OK")
                        {
                            Console.WriteLine(s);
                        }
                        
                    }
                }
                catch (Exception ex)
                {
                    Console.Write("Error: " + ex.Message);
                }

                //signal completion by firing an event
                OnThread1Completed(new AsyncCompletedEventArgs(null, false, returnData));
                Thread.Sleep(100);
            }
            if (true)
            {
                _serialPort.Close();
            }
            
        }

        void cycle_Completed(object sender, AsyncCompletedEventArgs e)
        {
            if (this.InvokeRequired)
            {//marshal the call if we are not on the GUI thread                
                BeginInvoke(new AsyncCompletedEventHandler(cycle_Completed),
                  new object[] { sender, e });
            }
            else
            {
                if (e.Error == null) {                    
                    UIdata returnedData = e.UserState as UIdata;
                    statusHybrid.Text = returnedData.revision;
                    statusProvider.Text = returnedData.gsmProvider;
                    statusSignalStrenght.Text = returnedData.gsmSignalStrenght;
                    
                    if (returnedData.status == "INCOMMING") {
                        indicatorCalling.Text = returnedData.incommingCall;
                        indicatorCalling.BackColor = Color.Red;
                        btn_pickUp.Enabled = true;
                        btn_hangOff.Enabled = true;
                        tb_DialNumber.Enabled = false;
                        btn_dial.Enabled = false;
                        statusMain.BackColor = Color.Green;

                    
                    } else if (returnedData.status == "DIALING")
                    {
                        indicatorCalling.Text = tb_DialNumber.Text;
                        indicatorCalling.BackColor = Color.Orange;
                        btn_pickUp.Enabled = false;
                        btn_hangOff.Enabled = true;
                        tb_DialNumber.Enabled = false;
                        btn_dial.Enabled = false;
                        statusMain.BackColor = Color.Green;
                    }
                    else if (returnedData.status == "WAITING") {
                        indicatorCalling.Text = "";
                        indicatorCalling.BackColor = Color.White;
                        btn_pickUp.Enabled = false;
                        btn_hangOff.Enabled = false;
                        tb_DialNumber.Enabled = true;
                        btn_dial.Enabled = true;
                        statusMain.BackColor = Color.Green;
                    }
                    else if (returnedData.status == "NO NETWORK")
                    {
                        indicatorCalling.Text = "";
                        indicatorCalling.BackColor = Color.White;
                        btn_pickUp.Enabled = false;
                        btn_hangOff.Enabled = false;
                        tb_DialNumber.Enabled = false;
                        btn_dial.Enabled = false;
                        statusProvider.Text = "NO NETWORK";
                        statusMain.BackColor = Color.Red;
                    }
                    statusMain.Text = returnedData.status;
                } else {
                    Console.WriteLine("The following error occurred:" + Environment.NewLine + e.Error.ToString());
                }
            }
        }


        public event AsyncCompletedEventHandler cycleCompleted;
        protected virtual void OnThread1Completed(AsyncCompletedEventArgs e)
        {
            //copy locally
            AsyncCompletedEventHandler handler = cycleCompleted;
            if (handler != null)
            {
                handler(this, e);
            }
        }
        

        private void applicationClosingDetected(object sender, FormClosingEventArgs e)
        {
            _stopCycle = true;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_pickUp_Click(object sender, EventArgs e)
        {
            _serialPort.Write("ATA\r");
        }

        private void btn_hangOff_Click(object sender, EventArgs e)
        {
            _serialPort.Write("ATH\r");
        }

        private void btn_dial_Click(object sender, EventArgs e)
        {
            if (statusMain.Text == "WAITING" && tb_DialNumber.Text != "")
            {
                _serialPort.Write("ATD+"+ tb_DialNumber.Text + ";\r");
            }
        }

    }
    public class UIdata
    {
        public string gsmProvider;
        public string gsmSignalStrenght;
        public string incommingCall;
        public string revision;
        public string status;
    }
}

