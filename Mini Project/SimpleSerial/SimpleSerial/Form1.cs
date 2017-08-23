using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports;

namespace SimpleSerial
{
    public partial class Form1 : Form
    {
        string Selected_Port_Baudrate;

        public Form1()
        {
            InitializeComponent();

            comboBox_Available_SerialPorts.Items.AddRange(SerialPort.GetPortNames());

            string SystemInformation;

            SystemInformation = " Machine Name = " + System.Environment.MachineName;
            SystemInformation = SystemInformation + Environment.NewLine + " OS Version = " + System.Environment.OSVersion;
            SystemInformation = SystemInformation + Environment.NewLine + " Processor Cores = " + Environment.ProcessorCount;

            textBox_System_Log.Text = SystemInformation;

            groupBox_Serial_Transmit.Enabled = false;
            groupBox_Serial_Receive.Enabled = false;

            comboBox_Standard_Baudrate.Enabled = false;
        }

        private void comboBox_Available_SerialPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selected_Port_Baudrate = comboBox_Available_SerialPorts.SelectedItem.ToString() + " Selected";

            textBox_System_Log.Text = Selected_Port_Baudrate;

            comboBox_Standard_Baudrate.Enabled = true;
        }

        private void comboBox_Standard_Baudrate_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selected_Port_Baudrate = Selected_Port_Baudrate + Environment.NewLine;
            Selected_Port_Baudrate = Selected_Port_Baudrate + comboBox_Standard_Baudrate.SelectedItem.ToString() + " bps selected";
            textBox_System_Log.Text = Selected_Port_Baudrate;

            groupBox_Serial_Transmit.Enabled = true;
            groupBox_Serial_Receive.Enabled = true;
        }

        private void button_Transmit_Data_Click(object sender, EventArgs e)
        {
            groupBox_Serial_Receive.Enabled = false;

            string Port_Name = comboBox_Available_SerialPorts.SelectedItem.ToString();
            int Baud_Rate = Convert.ToInt32(comboBox_Standard_Baudrate.SelectedItem);
            string Data = textBox_Data_Transmit.Text;

            SerialPort COMport = new SerialPort(Port_Name, Baud_Rate);

            try
            {
                COMport.Open();
            }
            catch (UnauthorizedAccessException SerialException)
            {
                MessageBox.Show(SerialException.ToString());
                textBox_System_Log.Text = Port_Name + Environment.NewLine + Baud_Rate;
                textBox_System_Log.Text = textBox_System_Log.Text + Environment.NewLine + SerialException.ToString();
                COMport.Close();
            }
            catch(System.IO.IOException SerialException)
            {
                MessageBox.Show(SerialException.ToString());
                textBox_System_Log.Text = Port_Name + Environment.NewLine + Baud_Rate;
                textBox_System_Log.Text = textBox_System_Log.Text + Environment.NewLine + SerialException.ToString();
                COMport.Close();
            }
            catch(InvalidOperationException SerialException)
            {
                MessageBox.Show(SerialException.ToString());
                textBox_System_Log.Text = Port_Name + Environment.NewLine + Baud_Rate;
                textBox_System_Log.Text = textBox_System_Log.Text + Environment.NewLine + SerialException.ToString();
                COMport.Close();
            }
            catch
            {
                MessageBox.Show("ERROR in Opening Serial PORT -- Unknown ERROR");
                COMport.Close();
            }

            if(COMport.IsOpen == true)
            {
                COMport.WriteLine(Data);
                COMport.Close();
                groupBox_Serial_Receive.Enabled = true;

                textBox_System_Log.Text = Port_Name + Environment.NewLine + Baud_Rate;
                textBox_System_Log.Text = textBox_System_Log.Text + Environment.NewLine + Data + " Written to Port";

            }
            else
            {
                groupBox_Serial_Receive.Enabled = true;
                MessageBox.Show("Unable to Write to COM port ");
                COMport.Close();
            }
            
        }

        private void button_Receive_Data_Click(object sender, EventArgs e)
        {
            groupBox_Serial_Transmit.Enabled = false;

            string Port_Name = comboBox_Available_SerialPorts.SelectedItem.ToString();
            int Baud_Rate = Convert.ToInt32(comboBox_Standard_Baudrate.SelectedItem);
            string ReceivedData = "";

            SerialPort COMport = new SerialPort(Port_Name, Baud_Rate);

            COMport.ReadTimeout = 3500;

            try
            {
                COMport.Open();
            }
            catch(UnauthorizedAccessException SerialException)
            {
                MessageBox.Show(SerialException.ToString());
                textBox_System_Log.Text = Port_Name + Environment.NewLine + Baud_Rate;
                textBox_System_Log.Text = textBox_System_Log.Text + Environment.NewLine + SerialException.ToString();
                COMport.Close();
            }
            catch(System.IO.IOException SerialException)
            {
                MessageBox.Show(SerialException.ToString());
                textBox_System_Log.Text = Port_Name + Environment.NewLine + Baud_Rate;
                textBox_System_Log.Text = textBox_System_Log.Text + Environment.NewLine + SerialException.ToString();
                COMport.Close();
            }
            catch(InvalidOperationException SerialException)
            {
                MessageBox.Show(SerialException.ToString());
                textBox_System_Log.Text = Port_Name + Environment.NewLine + Baud_Rate;
                textBox_System_Log.Text = textBox_System_Log.Text + Environment.NewLine + SerialException.ToString();
                COMport.Close();
            }
            catch
            {
                MessageBox.Show("ERROR in Opening Serial PORT -- UnKnown ERROR");
                COMport.Close();
            }

            try
            {
                if(COMport.IsOpen == true)
                {
                    textBox_System_Log.Text = Port_Name + Environment.NewLine + Baud_Rate;

                    ReceivedData = COMport.ReadLine();

                    textBox_System_Log.Text = textBox_System_Log.Text + Environment.NewLine + Environment.NewLine + "Waiting for Data";

                    textBox_Receive_Data.Text = ReceivedData;

                    COMport.Close();

                    textBox_System_Log.Text = textBox_System_Log.Text + Environment.NewLine + ReceivedData + " Received from Port";

                    groupBox_Serial_Transmit.Enabled = true;
                }
                else
                {
                    groupBox_Serial_Transmit.Enabled = true;
                    MessageBox.Show("Unable to Write to COM port ");
                    groupBox_Serial_Transmit.Enabled = true;
                    COMport.Close();
                }
            }
            catch(TimeoutException SerialTimeOutException)
            {
                MessageBox.Show(COMport.ReadTimeout.ToString() + " milliSeconds Passed" + Environment.NewLine + "Operation Timed Out");
                MessageBox.Show(SerialTimeOutException.ToString());

                textBox_System_Log.Text = COMport.ReadTimeout.ToString() + " milliSeconds Passed" + Environment.NewLine + "Operation Timed Out";
                textBox_System_Log.Text = textBox_System_Log.Text + Environment.NewLine + SerialTimeOutException.ToString();

                COMport.Close();

                groupBox_Serial_Transmit.Enabled = true;
            }
        }
    }
}
