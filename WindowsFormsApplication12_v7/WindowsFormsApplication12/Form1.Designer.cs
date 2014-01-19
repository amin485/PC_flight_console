namespace WindowsFormsApplication12
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.serialPortRead = new System.IO.Ports.SerialPort(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.trackBar8 = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.trackBar9 = new System.Windows.Forms.TrackBar();
            this.trackBar10 = new System.Windows.Forms.TrackBar();
            this.trackBar6 = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.trackBar7 = new System.Windows.Forms.TrackBar();
            this.label12 = new System.Windows.Forms.Label();
            this.trackBar11 = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar11)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPortRead
            // 
            this.serialPortRead.BaudRate = 256000;
            this.serialPortRead.PortName = "COM3";
            this.serialPortRead.ReadBufferSize = 40960;
            this.serialPortRead.ReceivedBytesThreshold = 40;
            this.serialPortRead.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.serialPortRead_Error);
            this.serialPortRead.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortRead_DataReceived);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Init";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Init_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(467, 10);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(425, 86);
            this.textBox1.TabIndex = 1;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea7.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea7.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea7);
            legend7.BackColor = System.Drawing.Color.WhiteSmoke;
            legend7.DockedToChartArea = "ChartArea1";
            legend7.Name = "Legend1";
            this.chart1.Legends.Add(legend7);
            this.chart1.Location = new System.Drawing.Point(420, 102);
            this.chart1.Name = "chart1";
            series7.BackImageTransparentColor = System.Drawing.Color.WhiteSmoke;
            series7.BackSecondaryColor = System.Drawing.Color.WhiteSmoke;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series7.LabelBackColor = System.Drawing.Color.WhiteSmoke;
            series7.Legend = "Legend1";
            series7.MarkerColor = System.Drawing.Color.Red;
            series7.MarkerSize = 2;
            series7.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series7.Name = "Series1";
            this.chart1.Series.Add(series7);
            this.chart1.Size = new System.Drawing.Size(493, 300);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // trackBar1
            // 
            this.trackBar1.Enabled = false;
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(147, 54);
            this.trackBar1.Maximum = 4400;
            this.trackBar1.Minimum = 2300;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(112, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.TabStop = false;
            this.trackBar1.TickFrequency = 100;
            this.trackBar1.Value = 2400;
            // 
            // trackBar2
            // 
            this.trackBar2.Enabled = false;
            this.trackBar2.LargeChange = 1;
            this.trackBar2.Location = new System.Drawing.Point(299, 178);
            this.trackBar2.Maximum = 4400;
            this.trackBar2.Minimum = 2300;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.Size = new System.Drawing.Size(45, 94);
            this.trackBar2.TabIndex = 4;
            this.trackBar2.TabStop = false;
            this.trackBar2.TickFrequency = 100;
            this.trackBar2.Value = 2400;
            // 
            // trackBar3
            // 
            this.trackBar3.Enabled = false;
            this.trackBar3.LargeChange = 1;
            this.trackBar3.Location = new System.Drawing.Point(161, 178);
            this.trackBar3.Maximum = 4400;
            this.trackBar3.Minimum = 2300;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar3.Size = new System.Drawing.Size(45, 94);
            this.trackBar3.TabIndex = 5;
            this.trackBar3.TabStop = false;
            this.trackBar3.TickFrequency = 100;
            this.trackBar3.Value = 2400;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Aileron in";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Elevator in";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Throttle in";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Aileron cmd";
            // 
            // trackBar4
            // 
            this.trackBar4.Enabled = false;
            this.trackBar4.LargeChange = 1;
            this.trackBar4.Location = new System.Drawing.Point(147, 111);
            this.trackBar4.Maximum = 4400;
            this.trackBar4.Minimum = 2300;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(117, 45);
            this.trackBar4.TabIndex = 9;
            this.trackBar4.TabStop = false;
            this.trackBar4.TickFrequency = 100;
            this.trackBar4.Value = 2400;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Pitch cmd";
            // 
            // trackBar5
            // 
            this.trackBar5.Enabled = false;
            this.trackBar5.LargeChange = 1;
            this.trackBar5.Location = new System.Drawing.Point(367, 178);
            this.trackBar5.Maximum = 4400;
            this.trackBar5.Minimum = 2300;
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar5.Size = new System.Drawing.Size(45, 94);
            this.trackBar5.TabIndex = 11;
            this.trackBar5.TabStop = false;
            this.trackBar5.TickFrequency = 100;
            this.trackBar5.Value = 2400;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Right vtail cmd";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Rudder in.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(216, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Throttle cmd";
            // 
            // trackBar8
            // 
            this.trackBar8.Enabled = false;
            this.trackBar8.LargeChange = 1;
            this.trackBar8.Location = new System.Drawing.Point(219, 178);
            this.trackBar8.Maximum = 4400;
            this.trackBar8.Minimum = 2300;
            this.trackBar8.Name = "trackBar8";
            this.trackBar8.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar8.Size = new System.Drawing.Size(45, 94);
            this.trackBar8.TabIndex = 17;
            this.trackBar8.TabStop = false;
            this.trackBar8.TickFrequency = 100;
            this.trackBar8.Value = 2400;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(279, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Air speed";
            // 
            // trackBar9
            // 
            this.trackBar9.Enabled = false;
            this.trackBar9.Location = new System.Drawing.Point(282, 54);
            this.trackBar9.Maximum = 65536;
            this.trackBar9.Name = "trackBar9";
            this.trackBar9.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar9.Size = new System.Drawing.Size(45, 102);
            this.trackBar9.TabIndex = 19;
            this.trackBar9.TickFrequency = 100;
            this.trackBar9.Value = 500;
            // 
            // trackBar10
            // 
            this.trackBar10.Enabled = false;
            this.trackBar10.Location = new System.Drawing.Point(12, 178);
            this.trackBar10.Maximum = 65536;
            this.trackBar10.Name = "trackBar10";
            this.trackBar10.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar10.Size = new System.Drawing.Size(45, 94);
            this.trackBar10.TabIndex = 21;
            this.trackBar10.TickFrequency = 100;
            this.trackBar10.Value = 500;
            // 
            // trackBar6
            // 
            this.trackBar6.Enabled = false;
            this.trackBar6.LargeChange = 1;
            this.trackBar6.Location = new System.Drawing.Point(12, 111);
            this.trackBar6.Maximum = 4300;
            this.trackBar6.Minimum = 2400;
            this.trackBar6.Name = "trackBar6";
            this.trackBar6.Size = new System.Drawing.Size(112, 45);
            this.trackBar6.TabIndex = 23;
            this.trackBar6.TabStop = false;
            this.trackBar6.TickFrequency = 100;
            this.trackBar6.Value = 2400;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Wheel cmd";
            // 
            // trackBar7
            // 
            this.trackBar7.Enabled = false;
            this.trackBar7.LargeChange = 1;
            this.trackBar7.Location = new System.Drawing.Point(12, 54);
            this.trackBar7.Maximum = 1910;
            this.trackBar7.Minimum = 1090;
            this.trackBar7.Name = "trackBar7";
            this.trackBar7.Size = new System.Drawing.Size(117, 45);
            this.trackBar7.TabIndex = 25;
            this.trackBar7.TabStop = false;
            this.trackBar7.TickFrequency = 100;
            this.trackBar7.Value = 1910;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(71, 162);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Alt (GPS)";
            // 
            // trackBar11
            // 
            this.trackBar11.Enabled = false;
            this.trackBar11.Location = new System.Drawing.Point(74, 178);
            this.trackBar11.Maximum = 65536;
            this.trackBar11.Minimum = 500;
            this.trackBar11.Name = "trackBar11";
            this.trackBar11.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar11.Size = new System.Drawing.Size(45, 94);
            this.trackBar11.TabIndex = 26;
            this.trackBar11.TickFrequency = 100;
            this.trackBar11.Value = 500;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Ultrasonic";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(959, 556);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.trackBar11);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.trackBar6);
            this.Controls.Add(this.trackBar10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.trackBar9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.trackBar8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackBar5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.trackBar7);
            this.Name = "Form1";
            this.Text = "Flight Console";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.IO.Ports.SerialPort serialPortRead;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBar5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar trackBar8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar trackBar9;
        private System.Windows.Forms.TrackBar trackBar10;
        private System.Windows.Forms.TrackBar trackBar6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TrackBar trackBar7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TrackBar trackBar11;
        private System.Windows.Forms.Label label10;
    }
}

