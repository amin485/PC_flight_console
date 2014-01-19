using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//add by AK
using System.Threading;
using System.IO;
using System.Text;

namespace WindowsFormsApplication12
{
    //*********************************************************
    //*********************************************************
    //******************class Program**************************
    //*********************************************************
    //*********************************************************
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        //---------------------------------------------------------
        //---------------Main Fucntion-----------------------------
        //---------------------------------------------------------
        static void Main()
        {        
            postproc1 postproc1_inst = new postproc1(); //creating an instance of postproc1 class

            //creating an instance of Thread class for GUI form
            Thread Thread1_Form1 = new Thread(new ThreadStart(postproc1_inst.ThreadFunction1_Form1));
            //Thread1_Form1.Priority = ThreadPriority.Normal; //for maintaining the GUI form
            Thread1_Form1.Start();
            Console.WriteLine("Thread ThreadFunction1_Form1 started");

            //creating an instance of Thread class for Postproc
            Thread Thread2_Postproc = new Thread(new ThreadStart(postproc1_inst.ThreadFunction2_Postproc));
            //Thread2_Postproc.Priority = ThreadPriority.Highest; //for real-time data manipulation
            Thread2_Postproc.Start();
            Console.WriteLine("Thread ThreadFunction2_Postproc started");
            
            //while (true) ;// loop forever

        }//main
    }//class programs

    //*********************************************************
    //*********************************************************
    //******************class postproc1************************
    //*********************************************************
    //*********************************************************
    public class postproc1
    {
        //---------------------------------------------------------
        //---------------class golbal variables--------------------
        //---------------------------------------------------------
        public static int PKTSIZE = 64;
        public static byte[] data = new byte[PKTSIZE];
        public static uint counter_old=0, counter_current=0, counter_err_count=0;
        public static int counter_raw_old=0, diff=0;
        public static byte checksum=0;
        public static int Aileron_in = 0, Elevator_in = 0, Throttle_in = 0, Flight_Option_1 = 0, Rudder_in = 0;
        public static int ultrasonic = 0, air_speed = 0, STD_accel_x = 0, STD_accel_y = 0, STD_accel_z = 0;
        public static int cmd_throttle = 0, cmd_wheel = 0, Control_signal_pitch = 0, Control_signal_roll = 0;
        public static long latitude = 0, longitude = 0;

        string path = @"c:\Flight_records\Flight_record.log";
        
        Form1 Form1_inst = new Form1();
        //---------------------------------------------------------
        //---------------ThreadFunction1_Form1---------------------
        //---------------------------------------------------------
        public void ThreadFunction1_Form1()
        {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false); //@check - causes errors when active
            //Form1_inst.AddData(8);
            Application.Run(Form1_inst);
        }//ThreadFunction1_Form1

        //---------------------------------------------------------
        //---------------ThreadFunction2_Postproc------------------
        //---------------------------------------------------------
        public void ThreadFunction2_Postproc()
        {
            //Byte[] file_write_bytes_buffer = new UTF8Encoding(true).GetBytes("This is to test the OpenWrite method.testtest");
            // Open the stream and write to it. 

            FileStream filestream = File.Open(path, FileMode.Append, FileAccess.Write);

            while (true)
            {
                if (Form1.comByteIn.Count > 150)
                {
                    if (Form1.comByteIn.Dequeue() == 82)
                    {
                        if (Form1.comByteIn.Dequeue() == 88)
                        {
                            if (Form1.comByteIn.Dequeue() == 62)
                            {
                                //READING THE DATA from SERIAL PORT
                                for (int i = 0; i < PKTSIZE; i++)
                                {
                                    data[i] = (byte)Form1.comByteIn.Dequeue();
                                    //data_in += data;
                                }

                                //Counter calculations
                                diff = data[1] - counter_raw_old;
                                if (diff == 1 | diff ==-255)
                                {
                                    counter_current++;
                                }
                                else
                                {
                                    counter_err_count++;
                                    Console.WriteLine("Counter missing counts: {0}", counter_err_count);
                                }
                                counter_raw_old = data[1];
                             
                                checksum = 0;
                                // checksum
                                for (int i = 0; i < PKTSIZE-1; i++)
                                {
                                    checksum += data[i];
                                }

                                if (checksum == data[PKTSIZE-1])
                                {
                                    //inputs from joystick
                                    Flight_Option_1 = saturate_servo((data[29] << 8) + data[30]);
                                    Aileron_in = saturate_servo(6700 - ((data[21] << 8) + data[22]));
                                    Elevator_in = saturate_servo((data[23] << 8) + data[24]);
                                    Throttle_in = saturate_servo((data[25] << 8) + data[26]);
                                    Rudder_in = saturate_servo_TIM2(3000 - ((data[27] << 8) + data[28]));
                                    //servo commands
                                    Control_signal_roll = saturate_servo(6700 - ((data[15] << 8) + data[16]));
                                    Control_signal_pitch = saturate_servo((data[17] << 8) + data[18]);
                                    cmd_throttle = saturate_servo((data[13] << 8) + data[14]);
                                    cmd_wheel = saturate_servo(6700 - ((data[19] << 8) + data[20]));
                                    //sensors
                                    ultrasonic = (data[11] << 8) + data[12];
                                    STD_accel_x = data[31];
                                    STD_accel_y = data[32];
                                    STD_accel_z = data[33];
                                    air_speed = (data[9] << 8) + data[10];
                                    //GPS
                                    latitude = data[34]<<24 + data[35]<<16 + data[36]<<8 + data[37];
                                    longitude = data[38] << 24 + data[39] << 16 + data[40] << 8 + data[41];
                                    GPS_altitude_cm = data[42] << 8 + data[43];
                                    GPS_speed_cmsec = data[44] << 8 + data[45];
                                    GPS_course_deg_100 = data[46] << 8 + data[47];
                                    GPS_sattelites = data[48];
                                    //MPU9150
                                    MPU_accel_x = data[3] << 8 + data[4];
                                    MPU_accel_y = data[5] << 8 + data[6];
                                    MPU_accel_z = data[7] << 8 + data[8];
                                    MPU_gyro_x = data[3] << 8 + data[4];
                                    MPU_gyro_y = data[5] << 8 + data[6];
                                    MPU_gyro_z = data[7] << 8 + data[8];


                                    Console.WriteLine("latitude in: {0}", latitude);
                                    Console.WriteLine("longitude in: {0}", longitude);
                                    
                                    //WRITE TO FILE
                                    string file_write_string = string.Format("{0:X2} {1:X4} {2:X4} {3:X4} {4:X4} {5:X4} {6:X4} {7:X4} {8:X4} {9:X4} {10:X4} {11:X2} {12:X2} {13:X2} {14:X4}\r\n",
                                    diff,
                                    Flight_Option_1,
                                    Aileron_in,
	                                Elevator_in,
                                    Throttle_in,
                                    Rudder_in,
                                    Control_signal_roll,
                                    Control_signal_pitch,
                                    cmd_throttle,
                                    cmd_wheel,
                                    ultrasonic,
                                    STD_accel_x,
                                    STD_accel_y,
                                    STD_accel_z,
                                    air_speed
                                    );

                                    Byte[] file_write_bytes = new UTF8Encoding(true).GetBytes(file_write_string);
                                    filestream.WriteAsync(file_write_bytes, 0, file_write_bytes.Length);

                                    //Adjusting the graphics
                                    Form1_inst.AddData_trackbar1(Aileron_in);
                                    Form1_inst.AddData_trackbar2(Elevator_in);
                                    Form1_inst.AddData_trackbar3(Throttle_in);

                                    Form1_inst.AddData_trackbar4(Control_signal_roll);
                                    Form1_inst.AddData_trackbar5(Control_signal_pitch);
                                    Form1_inst.AddData_trackbar6(cmd_wheel);
                                    Form1_inst.AddData_trackbar7(Rudder_in);
                                    Form1_inst.AddData_trackbar8(cmd_throttle);
                                    Form1_inst.AddData_trackbar9(air_speed);
                                    Form1_inst.AddData_trackbar10(ultrasonic);
                                    Form1_inst.AddData_trackbar11(0);

                                    Form1_inst.AddData_chart1(Aileron_in);

                                }
                                else
                                {
                                    Console.WriteLine("Checksum failed on COM port!");
                                }
                                    

                            }//if 62
                        }//if 88
                    }//if 82
                    
                }//if
            }//while(true)
        }//ThreadFunction2_Postproc

        public int saturate_servo(int value)
        {
             return Math.Min(Math.Max(value, 2400), 4300);       
        }

        public int saturate_servo_TIM2(int value)
        {
            return Math.Min(Math.Max(value, 1090), 1910);
        }

    }//class postproc1

}//namespace

