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
        int isclick = 1;
        public void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(ports);
            //mySerialPort.PortName = "COM6";
            //mySerialPort.BaudRate = 9600;
            //mySerialPort.Parity = Parity.None;
            //mySerialPort.StopBits = StopBits.One;
            //mySerialPort.DataBits = 8;
            //mySerialPort.Handshake = Handshake.None;
            //mySerialPort.RtsEnable = true;

            Thread thread = new Thread(new ThreadStart(UpdateTextBoxThread));
            thread.Start();
            //try
            //{
            //    mySerialPort.Open();
            //    MessageBox.Show("Connect");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("error");
            //}
        }
        public void UpdateTextBoxThread()
        {
        }
        public void InvokeUpdateTextBox(string value)
        {
            int ivalue = int.Parse(value);

            if ( isclick == 1 ) {
                textBox1.Text = value;
            } else if ( isclick == 2 ) {
                textBox3.Text = value;
            } else if ( isclick == 3 ) {
                textBox4.Text = value;
            } else if ( isclick == 4 ) {
                textBox5.Text = value;
            } else if ( isclick == 5 ) {
                textBox6.Text = value;
            } else if ( isclick == 6 ) {
                textBox8.Text = value;
            }
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
            int customValue = int.Parse(textBox2.Text);
            if (customValue > 180 || customValue < 0) { MessageBox.Show("invalid value"); }
            else
            {
                byte[] operation = BitConverter.GetBytes(255);
                byte[] value = BitConverter.GetBytes(customValue);
                byte[] servo_id = BitConverter.GetBytes(201);
                mySerialPort.Write(operation, 0, 1);
                mySerialPort.Write(value, 0, 1);
                mySerialPort.Write(servo_id, 0, 1);
                isclick = 1;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int customValue = int.Parse(textBox2.Text);
            if (customValue > 180 || customValue < 0) { MessageBox.Show("invalid value"); } 
            else { 
                mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                byte[] operation = BitConverter.GetBytes(254);
                byte[] value = BitConverter.GetBytes(customValue);
                byte[] servo_id = BitConverter.GetBytes(201);
                mySerialPort.Write(operation , 0, 1);
                mySerialPort.Write(value , 0, 1);
                mySerialPort.Write(servo_id, 0, 1);
                isclick = 1;
            }
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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int customValue = int.Parse(textBox2.Text);
            if (customValue > 180 || customValue < 0) { MessageBox.Show("invalid value"); } else
            {
                mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                byte[] operation = BitConverter.GetBytes(255);
                byte[] value = BitConverter.GetBytes(customValue);
                byte[] servo_id = BitConverter.GetBytes(202);
                mySerialPort.Write(operation , 0, 1);
                mySerialPort.Write(value , 0, 1);
                mySerialPort.Write(servo_id, 0, 1);
                isclick = 2;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int customValue = int.Parse(textBox2.Text);
            if (customValue > 180 || customValue < 0) { MessageBox.Show("invalid value"); } else
            {
                mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                byte[] operation = BitConverter.GetBytes(255);
                byte[] value = BitConverter.GetBytes(customValue);
                byte[] servo_id = BitConverter.GetBytes(203);
                mySerialPort.Write(operation , 0, 1);
                mySerialPort.Write(value , 0, 1);
                mySerialPort.Write(servo_id, 0, 1);
                isclick = 3;

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int customValue = int.Parse(textBox2.Text);
            if (customValue > 180 || customValue < 0) { MessageBox.Show("invalid value"); } else
            {
                mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                byte[] operation = BitConverter.GetBytes(255);
                byte[] value = BitConverter.GetBytes(customValue);
                byte[] servo_id = BitConverter.GetBytes(204);
                mySerialPort.Write(operation , 0, 1);
                mySerialPort.Write(value , 0, 1);
                mySerialPort.Write(servo_id, 0, 1);
                isclick = 4;

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int customValue = int.Parse(textBox2.Text);
            if (customValue > 180 || customValue < 0) { MessageBox.Show("invalid value"); } else
            {
                mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                byte[] operation = BitConverter.GetBytes(255);
                byte[] value = BitConverter.GetBytes(customValue);
                byte[] servo_id = BitConverter.GetBytes(205);
                mySerialPort.Write(operation, 0, 1);
                mySerialPort.Write(value, 0, 1);
                mySerialPort.Write(servo_id, 0, 1);
                isclick = 5;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int customValue = int.Parse(textBox2.Text);
            if (customValue > 180 || customValue < 0) { MessageBox.Show("invalid value"); }
            else
            {
                mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                byte[] operation = BitConverter.GetBytes(255);
                byte[] value = BitConverter.GetBytes(customValue);
                byte[] servo_id = BitConverter.GetBytes(206);
                mySerialPort.Write(operation , 0, 1);
                mySerialPort.Write(value , 0, 1);
                mySerialPort.Write(servo_id, 0, 1);
                isclick = 6;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int customValue = int.Parse(textBox2.Text);
            if (customValue > 180 || customValue < 0) { MessageBox.Show("invalid value"); } else
            {
                mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                byte[] operation = BitConverter.GetBytes(254);
                byte[] value = BitConverter.GetBytes(customValue);
                byte[] servo_id = BitConverter.GetBytes(202);
                mySerialPort.Write(operation , 0, 1);
                mySerialPort.Write(value , 0, 1);
                mySerialPort.Write(servo_id, 0, 1);
                isclick = 2;

            }

        }

        private void button6_Click(object sender, EventArgs e)
        {

            int customValue = int.Parse(textBox2.Text);
            if (customValue > 180 || customValue < 0) { MessageBox.Show("invalid value"); } else
            {
                mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                byte[] operation = BitConverter.GetBytes(254);
                byte[] value = BitConverter.GetBytes(customValue);
                byte[] servo_id = BitConverter.GetBytes(203);
                mySerialPort.Write(operation , 0, 1);
                mySerialPort.Write(value , 0, 1);
                mySerialPort.Write(servo_id, 0, 1);
                isclick = 3;

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int customValue = int.Parse(textBox2.Text);
            if (customValue > 180 || customValue < 0) { MessageBox.Show("invalid value"); } else
            {
                mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                byte[] operation = BitConverter.GetBytes(254);
                byte[] value = BitConverter.GetBytes(customValue);
                byte[] servo_id = BitConverter.GetBytes(204);
                mySerialPort.Write(operation , 0, 1);
                mySerialPort.Write(value , 0, 1);
                mySerialPort.Write(servo_id, 0, 1);
                isclick = 4;

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

            int customValue = int.Parse(textBox2.Text);
            if (customValue > 180 || customValue < 0) { MessageBox.Show("invalid value"); }
            else
            {
                mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                byte[] operation = BitConverter.GetBytes(254);
                byte[] value = BitConverter.GetBytes(customValue);
                byte[] servo_id = BitConverter.GetBytes(205);
                mySerialPort.Write(operation, 0, 1);
                mySerialPort.Write(value, 0, 1);
                mySerialPort.Write(servo_id, 0, 1);
                isclick = 5;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
            int customValue = int.Parse(textBox2.Text);
            if (customValue > 180 || customValue < 0) { MessageBox.Show("invalid value"); } 
            else
            {
                mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                byte[] operation = BitConverter.GetBytes(254);
                byte[] value = BitConverter.GetBytes(customValue);
                byte[] servo_id = BitConverter.GetBytes(206);
                mySerialPort.Write(operation , 0, 1);
                mySerialPort.Write(value , 0, 1);
                mySerialPort.Write(servo_id, 0, 1);
                isclick = 6;

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            mySerialPort.PortName = comboBox1.SelectedItem.ToString(); 
            mySerialPort.BaudRate = 9600;
            mySerialPort.Parity = Parity.None;
            mySerialPort.StopBits = StopBits.One;
            mySerialPort.DataBits = 8;
            mySerialPort.Handshake = Handshake.None;
            mySerialPort.RtsEnable = true;

            try
            {
                mySerialPort.Open();
                MessageBox.Show("Connect");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error");
            }

        }
    }
}
