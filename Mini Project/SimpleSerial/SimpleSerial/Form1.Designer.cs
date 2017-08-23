namespace SimpleSerial
{
    partial class Form1
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
            this.groupBox_Serial_Setting = new System.Windows.Forms.GroupBox();
            this.comboBox_Standard_Baudrate = new System.Windows.Forms.ComboBox();
            this.label_Baudrate = new System.Windows.Forms.Label();
            this.label_Available_Port = new System.Windows.Forms.Label();
            this.comboBox_Available_SerialPorts = new System.Windows.Forms.ComboBox();
            this.groupBox_Serial_Transmit = new System.Windows.Forms.GroupBox();
            this.button_Transmit_Data = new System.Windows.Forms.Button();
            this.textBox_Data_Transmit = new System.Windows.Forms.TextBox();
            this.label_Data_Transmit = new System.Windows.Forms.Label();
            this.groupBox_Serial_Receive = new System.Windows.Forms.GroupBox();
            this.label_Receive_Data = new System.Windows.Forms.Label();
            this.textBox_Receive_Data = new System.Windows.Forms.TextBox();
            this.button_Receive_Data = new System.Windows.Forms.Button();
            this.groupBox_Log = new System.Windows.Forms.GroupBox();
            this.textBox_System_Log = new System.Windows.Forms.TextBox();
            this.groupBox_Serial_Setting.SuspendLayout();
            this.groupBox_Serial_Transmit.SuspendLayout();
            this.groupBox_Serial_Receive.SuspendLayout();
            this.groupBox_Log.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Serial_Setting
            // 
            this.groupBox_Serial_Setting.Controls.Add(this.comboBox_Standard_Baudrate);
            this.groupBox_Serial_Setting.Controls.Add(this.label_Baudrate);
            this.groupBox_Serial_Setting.Controls.Add(this.label_Available_Port);
            this.groupBox_Serial_Setting.Controls.Add(this.comboBox_Available_SerialPorts);
            this.groupBox_Serial_Setting.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Serial_Setting.Name = "groupBox_Serial_Setting";
            this.groupBox_Serial_Setting.Size = new System.Drawing.Size(473, 78);
            this.groupBox_Serial_Setting.TabIndex = 0;
            this.groupBox_Serial_Setting.TabStop = false;
            this.groupBox_Serial_Setting.Text = "Serial Setting";
            // 
            // comboBox_Standard_Baudrate
            // 
            this.comboBox_Standard_Baudrate.FormattingEnabled = true;
            this.comboBox_Standard_Baudrate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400"});
            this.comboBox_Standard_Baudrate.Location = new System.Drawing.Point(321, 30);
            this.comboBox_Standard_Baudrate.Name = "comboBox_Standard_Baudrate";
            this.comboBox_Standard_Baudrate.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Standard_Baudrate.TabIndex = 3;
            this.comboBox_Standard_Baudrate.SelectedIndexChanged += new System.EventHandler(this.comboBox_Standard_Baudrate_SelectedIndexChanged);
            // 
            // label_Baudrate
            // 
            this.label_Baudrate.AutoSize = true;
            this.label_Baudrate.Location = new System.Drawing.Point(265, 34);
            this.label_Baudrate.Name = "label_Baudrate";
            this.label_Baudrate.Size = new System.Drawing.Size(50, 13);
            this.label_Baudrate.TabIndex = 2;
            this.label_Baudrate.Text = "Baudrate";
            // 
            // label_Available_Port
            // 
            this.label_Available_Port.AutoSize = true;
            this.label_Available_Port.Location = new System.Drawing.Point(18, 33);
            this.label_Available_Port.Name = "label_Available_Port";
            this.label_Available_Port.Size = new System.Drawing.Size(77, 13);
            this.label_Available_Port.TabIndex = 1;
            this.label_Available_Port.Text = "Available Ports";
            // 
            // comboBox_Available_SerialPorts
            // 
            this.comboBox_Available_SerialPorts.FormattingEnabled = true;
            this.comboBox_Available_SerialPorts.Location = new System.Drawing.Point(101, 30);
            this.comboBox_Available_SerialPorts.Name = "comboBox_Available_SerialPorts";
            this.comboBox_Available_SerialPorts.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Available_SerialPorts.TabIndex = 0;
            this.comboBox_Available_SerialPorts.SelectedIndexChanged += new System.EventHandler(this.comboBox_Available_SerialPorts_SelectedIndexChanged);
            // 
            // groupBox_Serial_Transmit
            // 
            this.groupBox_Serial_Transmit.Controls.Add(this.button_Transmit_Data);
            this.groupBox_Serial_Transmit.Controls.Add(this.textBox_Data_Transmit);
            this.groupBox_Serial_Transmit.Controls.Add(this.label_Data_Transmit);
            this.groupBox_Serial_Transmit.Location = new System.Drawing.Point(12, 96);
            this.groupBox_Serial_Transmit.Name = "groupBox_Serial_Transmit";
            this.groupBox_Serial_Transmit.Size = new System.Drawing.Size(231, 124);
            this.groupBox_Serial_Transmit.TabIndex = 1;
            this.groupBox_Serial_Transmit.TabStop = false;
            this.groupBox_Serial_Transmit.Text = "Serial Transmit";
            // 
            // button_Transmit_Data
            // 
            this.button_Transmit_Data.Location = new System.Drawing.Point(21, 61);
            this.button_Transmit_Data.Name = "button_Transmit_Data";
            this.button_Transmit_Data.Size = new System.Drawing.Size(193, 48);
            this.button_Transmit_Data.TabIndex = 0;
            this.button_Transmit_Data.Text = "Transmit";
            this.button_Transmit_Data.UseVisualStyleBackColor = true;
            this.button_Transmit_Data.Click += new System.EventHandler(this.button_Transmit_Data_Click);
            // 
            // textBox_Data_Transmit
            // 
            this.textBox_Data_Transmit.Location = new System.Drawing.Point(54, 23);
            this.textBox_Data_Transmit.Name = "textBox_Data_Transmit";
            this.textBox_Data_Transmit.Size = new System.Drawing.Size(160, 20);
            this.textBox_Data_Transmit.TabIndex = 0;
            // 
            // label_Data_Transmit
            // 
            this.label_Data_Transmit.AutoSize = true;
            this.label_Data_Transmit.Location = new System.Drawing.Point(18, 26);
            this.label_Data_Transmit.Name = "label_Data_Transmit";
            this.label_Data_Transmit.Size = new System.Drawing.Size(30, 13);
            this.label_Data_Transmit.TabIndex = 4;
            this.label_Data_Transmit.Text = "Data";
            // 
            // groupBox_Serial_Receive
            // 
            this.groupBox_Serial_Receive.Controls.Add(this.label_Receive_Data);
            this.groupBox_Serial_Receive.Controls.Add(this.textBox_Receive_Data);
            this.groupBox_Serial_Receive.Controls.Add(this.button_Receive_Data);
            this.groupBox_Serial_Receive.Location = new System.Drawing.Point(254, 96);
            this.groupBox_Serial_Receive.Name = "groupBox_Serial_Receive";
            this.groupBox_Serial_Receive.Size = new System.Drawing.Size(231, 124);
            this.groupBox_Serial_Receive.TabIndex = 2;
            this.groupBox_Serial_Receive.TabStop = false;
            this.groupBox_Serial_Receive.Text = "Serial Receive";
            // 
            // label_Receive_Data
            // 
            this.label_Receive_Data.AutoSize = true;
            this.label_Receive_Data.Location = new System.Drawing.Point(16, 73);
            this.label_Receive_Data.Name = "label_Receive_Data";
            this.label_Receive_Data.Size = new System.Drawing.Size(73, 13);
            this.label_Receive_Data.TabIndex = 5;
            this.label_Receive_Data.Text = "Receive Data";
            // 
            // textBox_Receive_Data
            // 
            this.textBox_Receive_Data.Location = new System.Drawing.Point(19, 89);
            this.textBox_Receive_Data.Name = "textBox_Receive_Data";
            this.textBox_Receive_Data.Size = new System.Drawing.Size(193, 20);
            this.textBox_Receive_Data.TabIndex = 5;
            // 
            // button_Receive_Data
            // 
            this.button_Receive_Data.Location = new System.Drawing.Point(19, 19);
            this.button_Receive_Data.Name = "button_Receive_Data";
            this.button_Receive_Data.Size = new System.Drawing.Size(193, 48);
            this.button_Receive_Data.TabIndex = 5;
            this.button_Receive_Data.Text = "Receive Data";
            this.button_Receive_Data.UseVisualStyleBackColor = true;
            this.button_Receive_Data.Click += new System.EventHandler(this.button_Receive_Data_Click);
            // 
            // groupBox_Log
            // 
            this.groupBox_Log.Controls.Add(this.textBox_System_Log);
            this.groupBox_Log.Location = new System.Drawing.Point(12, 238);
            this.groupBox_Log.Name = "groupBox_Log";
            this.groupBox_Log.Size = new System.Drawing.Size(473, 115);
            this.groupBox_Log.TabIndex = 1;
            this.groupBox_Log.TabStop = false;
            this.groupBox_Log.Text = "Log";
            // 
            // textBox_System_Log
            // 
            this.textBox_System_Log.Location = new System.Drawing.Point(6, 19);
            this.textBox_System_Log.Multiline = true;
            this.textBox_System_Log.Name = "textBox_System_Log";
            this.textBox_System_Log.Size = new System.Drawing.Size(461, 90);
            this.textBox_System_Log.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 517);
            this.Controls.Add(this.groupBox_Log);
            this.Controls.Add(this.groupBox_Serial_Receive);
            this.Controls.Add(this.groupBox_Serial_Transmit);
            this.Controls.Add(this.groupBox_Serial_Setting);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox_Serial_Setting.ResumeLayout(false);
            this.groupBox_Serial_Setting.PerformLayout();
            this.groupBox_Serial_Transmit.ResumeLayout(false);
            this.groupBox_Serial_Transmit.PerformLayout();
            this.groupBox_Serial_Receive.ResumeLayout(false);
            this.groupBox_Serial_Receive.PerformLayout();
            this.groupBox_Log.ResumeLayout(false);
            this.groupBox_Log.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Serial_Setting;
        private System.Windows.Forms.ComboBox comboBox_Standard_Baudrate;
        private System.Windows.Forms.Label label_Baudrate;
        private System.Windows.Forms.Label label_Available_Port;
        private System.Windows.Forms.ComboBox comboBox_Available_SerialPorts;
        private System.Windows.Forms.GroupBox groupBox_Serial_Transmit;
        private System.Windows.Forms.Button button_Transmit_Data;
        private System.Windows.Forms.TextBox textBox_Data_Transmit;
        private System.Windows.Forms.Label label_Data_Transmit;
        private System.Windows.Forms.GroupBox groupBox_Serial_Receive;
        private System.Windows.Forms.Label label_Receive_Data;
        private System.Windows.Forms.TextBox textBox_Receive_Data;
        private System.Windows.Forms.Button button_Receive_Data;
        private System.Windows.Forms.GroupBox groupBox_Log;
        private System.Windows.Forms.TextBox textBox_System_Log;
    }
}

