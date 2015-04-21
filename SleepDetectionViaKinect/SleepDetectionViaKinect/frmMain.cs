using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.Kinect;
using Microsoft.Kinect.Toolkit;
using System.Windows.Media.Imaging;

namespace SleepDetectionViaKinect
{
    public partial class frmMain : Form
    {
        private double startTime;
        private Series sleepActivity = new Series();
        private DataPoint dp;
        private double currentYValue = 0.0;
        private bool end = false;
        private KinectSensor sensor;
        private WriteableBitmap bitMapOne;

        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            sleepActivity = chSleepActivity.Series["Sleep Activity"];
            if (sensor != null)
            {
                sensor.SkeletonStream.Enable();
                sensor.Start();
            }
        }
        private void btnTrackSleep_Click(object sender, EventArgs e)
        {
            startTime = System.DateTime.Now.ToOADate();
            dp = new DataPoint(startTime, currentYValue);

            while (!end) {
                //this.sensor.DepthFrameReady
                //CreateNewDataPoint(x + 1);
                if (end == true)
                {
                    break;
                }
                System.Threading.Thread.Sleep(1000);
            }
            chSleepActivity.SaveImage(System.DateTime.Now.ToString() + "SleepTracker", ChartImageFormat.Jpeg);
        }
        private void btnEndSleep_Click(object sender, EventArgs e)
        {
            end = true;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        
        //Helper Methods
        private void CreateNewDataPoint(double amountChanged)
        {
            double currentTime = System.DateTime.Now.ToOADate();
            dp = new DataPoint(currentTime, amountChanged);
        }

        //Kinect Methods
        
    }
}
