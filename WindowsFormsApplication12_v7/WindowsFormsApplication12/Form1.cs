using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//add by AK
using System.Threading;

namespace WindowsFormsApplication12
{
    public partial class Form1 : Form
    {
        //public Queue variable - comByteIn
        public static Queue<int> comByteIn = new Queue<int>();
        delegate void AddDataCallback(int data_to_add);

        public Form1()
        {
            InitializeComponent();
        }//init form1

        private void Init_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPortRead.IsOpen) // && !serialPortWrite.IsOpen)
                {
                    //set status
                    textBox1.Text = "Communication to the ground board is successfully established!\n";
                    serialPortRead.Open();
                    button1.Enabled = false;
                }
                else
                {
                    textBox1.Text = "One of the serial COM ports are not available.";
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//init - button click

        
        private void serialPortRead_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

            while (serialPortRead.BytesToRead > 0)
            {
                try
                {
                    comByteIn.Enqueue(serialPortRead.ReadByte());
                    //Console.Write((char)comByteIn.Last());
                }
                catch (System.TimeoutException)
                {
                }

            }
        }//serialPortRead_DataReceived
 

        //updating trackbar data
        public void AddData_trackbar1(int data_to_add)
        {
            if (this.trackBar1.InvokeRequired)
            {
                AddDataCallback d = new AddDataCallback(AddData_trackbar1);
                this.Invoke(d, new object[] { data_to_add });
            }
        else
            {
                this.trackBar1.Value = data_to_add;
            }
        }

        //updating trackbar data
        public void AddData_trackbar2(int data_to_add)
        {
            if (this.trackBar2.InvokeRequired)
            {
                AddDataCallback d = new AddDataCallback(AddData_trackbar2);
                this.Invoke(d, new object[] { data_to_add });
            }
            else
            {
                this.trackBar2.Value = data_to_add;
            }
        }

        //updating trackbar data
        public void AddData_trackbar3(int data_to_add)
        {
            if (this.trackBar3.InvokeRequired)
            {
                AddDataCallback d = new AddDataCallback(AddData_trackbar3);
                this.Invoke(d, new object[] { data_to_add });
            }
            else
            {
                this.trackBar3.Value = data_to_add;
            }
        }

        //updating trackbar data
        public void AddData_trackbar4(int data_to_add)
        {
            if (this.trackBar4.InvokeRequired)
            {
                AddDataCallback d = new AddDataCallback(AddData_trackbar4);
                this.Invoke(d, new object[] { data_to_add });
            }
            else
            {
                this.trackBar4.Value = data_to_add;
            }
        }

        //updating trackbar data
        public void AddData_trackbar5(int data_to_add)
        {
            if (this.trackBar5.InvokeRequired)
            {
                AddDataCallback d = new AddDataCallback(AddData_trackbar5);
                this.Invoke(d, new object[] { data_to_add });
            }
            else
            {
                this.trackBar5.Value = data_to_add;
            }
        }

        //updating trackbar data
        public void AddData_trackbar6(int data_to_add)
        {
            if (this.trackBar6.InvokeRequired)
            {
                AddDataCallback d = new AddDataCallback(AddData_trackbar6);
                this.Invoke(d, new object[] { data_to_add });
            }
            else
            {
                this.trackBar6.Value = data_to_add;
            }
        }

        //updating trackbar data
        public void AddData_trackbar7(int data_to_add)
        {
            if (this.trackBar7.InvokeRequired)
            {
                AddDataCallback d = new AddDataCallback(AddData_trackbar7);
                this.Invoke(d, new object[] { data_to_add });
            }
            else
            {
                this.trackBar7.Value = data_to_add;
            }
        }

        //updating trackbar data
        public void AddData_trackbar8(int data_to_add)
        {
            if (this.trackBar8.InvokeRequired)
            {
                AddDataCallback d = new AddDataCallback(AddData_trackbar8);
                this.Invoke(d, new object[] { data_to_add });
            }
            else
            {
                this.trackBar8.Value = data_to_add;
            }
        }

        //updating trackbar data
        public void AddData_trackbar9(int data_to_add)
        {
            if (this.trackBar9.InvokeRequired)
            {
                AddDataCallback d = new AddDataCallback(AddData_trackbar9);
                this.Invoke(d, new object[] { data_to_add });
            }
            else
            {
                this.trackBar9.Value = data_to_add;
            }
        }

        //updating trackbar data
        public void AddData_trackbar10(int data_to_add)
        {
            if (this.trackBar10.InvokeRequired)
            {
                AddDataCallback d = new AddDataCallback(AddData_trackbar10);
                this.Invoke(d, new object[] { data_to_add });
            }
            else
            {
                this.trackBar10.Value = data_to_add;
            }
        }

        //updating trackbar data
        public void AddData_trackbar11(int data_to_add)
        {
            if (this.trackBar11.InvokeRequired)
            {
                AddDataCallback d = new AddDataCallback(AddData_trackbar11);
                this.Invoke(d, new object[] { data_to_add });
            }
            else
            {
                this.trackBar11.Value = data_to_add;
            }
        }

        //updating chart data
        public void AddData_chart1(int data_to_add)
        {
            if (this.chart1.InvokeRequired)
            {
                AddDataCallback d = new AddDataCallback(AddData_chart1);
                this.Invoke(d, new object[] { data_to_add });
            }
            else
            {
                this.chart1.Series["Series1"].Points.AddY(data_to_add);                
            }
        }

        private void serialPortRead_Error(object sender, System.IO.Ports.SerialErrorReceivedEventArgs e)
        {
            Console.WriteLine("Serial port error!");
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



    }//class Form1
}//namespace
