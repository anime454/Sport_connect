using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sport_connect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SerialPort mySerialPort = new SerialPort();
        public delegate void UpdateTextBoxDelegate(string value);

        public void Form1_Load(object sender, EventArgs e)
        {
            mySerialPort.PortName = "COM7";
            mySerialPort.BaudRate = 9600;
            mySerialPort.Parity = Parity.None;
            mySerialPort.StopBits = StopBits.One;
            mySerialPort.DataBits = 8;
            mySerialPort.Handshake = Handshake.None;
            mySerialPort.RtsEnable = true;

            disable_botton();
            Thread thread = new Thread(new ThreadStart(UpdateTextBoxThread));
            thread.Start();
            try
            {
                mySerialPort.Open();
                MessageBox.Show("Connect");
                enable_botton();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error");
            }
        }
        public void UpdateTextBoxThread()
        {
        }
        public void InvokeUpdateTextBox(string loop)
        {
            textBox1.Text = loop;
        }

        public static void enable_botton()
        {
            Form1 bt = new Form1();
            bt.button1.Enabled = false;
            bt.button2.Enabled = false;
        }

        public static void disable_botton()
        {
            Form1 bt = new Form1();
            bt.button1.Enabled = false;
            bt.button2.Enabled = false;
        }

        public void DataReceivedHandler(
                        object sender,
                        SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadLine();
            Invoke(new UpdateTextBoxDelegate(InvokeUpdateTextBox), indata);
            Console.WriteLine(indata);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            byte[] operation = BitConverter.GetBytes(255);
            byte[] value = BitConverter.GetBytes(15);
            mySerialPort.Write(operation , 0, 1);
            mySerialPort.Write(value , 0, 1);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            byte[] operation = BitConverter.GetBytes(254);
            byte[] value = BitConverter.GetBytes(15);
            mySerialPort.Write(operation , 0, 1);
            mySerialPort.Write(value , 0, 1);

        }

   
        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
