using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Kinect;

namespace CodeCamp12KinectAOADemo
{
    public partial class Form1 : Form
    {
        KinectSensor sensor;
        int sensorAngle = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.sensor = KinectSensor.KinectSensors[0];
            this.sensor.Start();
            this.sensorAngle = this.sensor.ElevationAngle;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            try
            {

                this.sensorAngle += 5;
                this.sensor.ElevationAngle = this.sensorAngle;
            }
            catch
            {
                //Nothing
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            try
            {
                this.sensorAngle -= 5;
                this.sensor.ElevationAngle = this.sensorAngle;
            }
            catch
            {
                //Nothing
            }
            
        }
    }
}
