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

namespace IIC_ARM
{
    public partial class Form1 : Form
    {
        SerialPort myport = new SerialPort();
        private void INIT(string port= "COM4")
        {
            try
            {
                myport = new SerialPort();
                myport.BaudRate = 9600;
                myport.PortName =port;
                myport.Open();
                
            }
            catch (Exception e)
            {

                MessageBox.Show("error  " + e.Message);

            }


        }
        public Form1()
        {
            InitializeComponent();
           panel2.Enabled = false;
           var x= SerialPort.GetPortNames();
            foreach (string m in x)
            {
                portlist.Items.Add(m);
            } 

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
     

        private void button1_Click(object sender, EventArgs e)
        {
            if (portlist.SelectedItem!=null)
            {
                panel2.Enabled = true;
                portlist.Enabled = false;
                btnstart.Enabled = false;
                btnstop.Enabled = true;
                INIT(portlist.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("please select port");
            }
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            myport.Close();
            btnstart.Enabled = true;
            portlist.Enabled = true;
            panel2.Enabled = false;
            btnstop.Enabled = false;
        }

       

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void sl1_Click(object sender, EventArgs e)
        {
            int x = gs1.Value;
            gs1.Value = x -5;
            myport.WriteLine("s1"+gs1.Value.ToString());
        }

        private void sl2_Click(object sender, EventArgs e)
        {
            int x = gs2.Value;
            gs2.Value = x - 5;
            myport.WriteLine("s2" + gs2.Value.ToString());
        }

        private void sl3_Click(object sender, EventArgs e)
        {
            int x = gs3.Value;
            gs3.Value = x - 5;
            myport.WriteLine("s3" + gs3.Value.ToString());
        }

        private void sl4_Click(object sender, EventArgs e)
        {
            int x = gs4.Value;
            gs4.Value = x - 1;
            myport.WriteLine("s4" + gs4.Value.ToString());
        }

        private void sr1_Click(object sender, EventArgs e)
        {
            int x = gs1.Value;
            gs1.Value = x + 5;
            myport.WriteLine("s1" + gs1.Value.ToString());
        }

        private void sr2_Click(object sender, EventArgs e)
        {
            int x = gs2.Value;
            gs2.Value = x + 5;
            myport.WriteLine("s2" + gs2.Value.ToString());
        }

        private void sr3_Click(object sender, EventArgs e)
        {
            int x = gs3.Value;
            gs3.Value = x + 5;
            myport.WriteLine("s3" + gs3.Value.ToString());
        }

        private void sr4_Click(object sender, EventArgs e)
        {
           int x= gs4.Value;
            gs4.Value = x + 1;
            myport.WriteLine("s4" + gs4.Value.ToString());
        }

        private void gs4_MouseCaptureChanged(object sender, EventArgs e)
        {
            myport.WriteLine("s4" + gs4.Value.ToString());
        }

        private void gs3_MouseCaptureChanged(object sender, EventArgs e)
        {
            myport.WriteLine("s3" + gs3.Value.ToString());
        }

        private void gs2_MouseCaptureChanged(object sender, EventArgs e)
        {
            myport.WriteLine("s2" + gs2.Value.ToString());
        }

        private void gs1_MouseCaptureChanged(object sender, EventArgs e)
        {
           myport.WriteLine("s1" + gs1.Value.ToString());
   
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gs4_Scroll(object sender, EventArgs e)
        {

        }
    }
}
