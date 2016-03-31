namespace Ragelis
{
    partial class RagelisCMS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RagelisCMS));
            this.btn_Exit = new System.Windows.Forms.Button();
            this.indicatorCalling = new System.Windows.Forms.Button();
            this.btn_pickUp = new System.Windows.Forms.Button();
            this.btn_hangOff = new System.Windows.Forms.Button();
            this.tb_DialNumber = new System.Windows.Forms.TextBox();
            this.btn_dial = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusHybrid = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusProvider = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusSignalStrenght = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(12, 338);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(440, 43);
            this.btn_Exit.TabIndex = 10;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // indicatorCalling
            // 
            this.indicatorCalling.BackColor = System.Drawing.SystemColors.Control;
            this.indicatorCalling.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.indicatorCalling.Enabled = false;
            this.indicatorCalling.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indicatorCalling.ForeColor = System.Drawing.Color.White;
            this.indicatorCalling.Location = new System.Drawing.Point(12, 12);
            this.indicatorCalling.Name = "indicatorCalling";
            this.indicatorCalling.Size = new System.Drawing.Size(441, 52);
            this.indicatorCalling.TabIndex = 94;
            this.indicatorCalling.TabStop = false;
            this.indicatorCalling.UseVisualStyleBackColor = false;
            // 
            // btn_pickUp
            // 
            this.btn_pickUp.Enabled = false;
            this.btn_pickUp.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pickUp.ForeColor = System.Drawing.Color.Green;
            this.btn_pickUp.Location = new System.Drawing.Point(12, 70);
            this.btn_pickUp.Name = "btn_pickUp";
            this.btn_pickUp.Size = new System.Drawing.Size(215, 41);
            this.btn_pickUp.TabIndex = 1;
            this.btn_pickUp.Text = "Pick Up";
            this.btn_pickUp.UseVisualStyleBackColor = true;
            this.btn_pickUp.Click += new System.EventHandler(this.btn_pickUp_Click);
            // 
            // btn_hangOff
            // 
            this.btn_hangOff.Enabled = false;
            this.btn_hangOff.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hangOff.ForeColor = System.Drawing.Color.Red;
            this.btn_hangOff.Location = new System.Drawing.Point(238, 70);
            this.btn_hangOff.Name = "btn_hangOff";
            this.btn_hangOff.Size = new System.Drawing.Size(215, 41);
            this.btn_hangOff.TabIndex = 2;
            this.btn_hangOff.Text = "Hang Off";
            this.btn_hangOff.UseVisualStyleBackColor = true;
            this.btn_hangOff.Click += new System.EventHandler(this.btn_hangOff_Click);
            // 
            // tb_DialNumber
            // 
            this.tb_DialNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_DialNumber.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_DialNumber.Location = new System.Drawing.Point(13, 147);
            this.tb_DialNumber.Name = "tb_DialNumber";
            this.tb_DialNumber.Size = new System.Drawing.Size(440, 33);
            this.tb_DialNumber.TabIndex = 3;
            this.tb_DialNumber.Text = "+370";
            this.tb_DialNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_dial
            // 
            this.btn_dial.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dial.ForeColor = System.Drawing.Color.Green;
            this.btn_dial.Location = new System.Drawing.Point(12, 193);
            this.btn_dial.Name = "btn_dial";
            this.btn_dial.Size = new System.Drawing.Size(441, 41);
            this.btn_dial.TabIndex = 4;
            this.btn_dial.Text = "Dial";
            this.btn_dial.UseVisualStyleBackColor = true;
            this.btn_dial.Click += new System.EventHandler(this.btn_dial_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.AllowMerge = false;
            this.statusStrip.AutoSize = false;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusMain,
            this.statusHybrid,
            this.statusProvider,
            this.statusSignalStrenght});
            this.statusStrip.Location = new System.Drawing.Point(0, 384);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(465, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.Stretch = false;
            this.statusStrip.TabIndex = 95;
            this.statusStrip.Text = "Status";
            // 
            // statusMain
            // 
            this.statusMain.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.statusMain.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.statusMain.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusMain.Name = "statusMain";
            this.statusMain.Size = new System.Drawing.Size(19, 17);
            this.statusMain.Text = "--";
            // 
            // statusHybrid
            // 
            this.statusHybrid.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.statusHybrid.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.statusHybrid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusHybrid.Name = "statusHybrid";
            this.statusHybrid.Size = new System.Drawing.Size(57, 17);
            this.statusHybrid.Text = "No hybrid";
            // 
            // statusProvider
            // 
            this.statusProvider.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.statusProvider.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.statusProvider.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusProvider.Name = "statusProvider";
            this.statusProvider.Size = new System.Drawing.Size(67, 17);
            this.statusProvider.Text = "No provider";
            // 
            // statusSignalStrenght
            // 
            this.statusSignalStrenght.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.statusSignalStrenght.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.statusSignalStrenght.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusSignalStrenght.Name = "statusSignalStrenght";
            this.statusSignalStrenght.Size = new System.Drawing.Size(55, 17);
            this.statusSignalStrenght.Text = "No Signal";
            // 
            // RagelisCMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 406);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btn_dial);
            this.Controls.Add(this.tb_DialNumber);
            this.Controls.Add(this.btn_hangOff);
            this.Controls.Add(this.btn_pickUp);
            this.Controls.Add(this.indicatorCalling);
            this.Controls.Add(this.btn_Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RagelisCMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ragelis-CMS";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.applicationClosingDetected);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button indicatorCalling;
        private System.Windows.Forms.Button btn_pickUp;
        private System.Windows.Forms.Button btn_hangOff;
        private System.Windows.Forms.TextBox tb_DialNumber;
        private System.Windows.Forms.Button btn_dial;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusProvider;
        private System.Windows.Forms.ToolStripStatusLabel statusSignalStrenght;
        private System.Windows.Forms.ToolStripStatusLabel statusHybrid;
        private System.Windows.Forms.ToolStripStatusLabel statusMain;
    }
}

