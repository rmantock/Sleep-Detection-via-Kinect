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

namespace SleepDetectionViaKinect
{
    public partial class frmMain : Form
    {
        private double startTime;
        private Series sleepActivity = new Series();
        private DataPoint dp;
        private double currentYValue = 0.0;
        private bool end = false;
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            sleepActivity = chSleepActivity.Series["Sleep Activity"];
        }
        private void btnTrackSleep_Click(object sender, EventArgs e)
        {
            startTime = System.DateTime.Now.ToOADate();
            dp = new DataPoint(startTime, currentYValue);

            for(int x = 0; x < 10; x++)
            {
                CreateNewDataPoint(x + 1);
                if (end == true)
                {
                    break;
                }
            }
            chSleepActivity.SaveImage(System.DateTime.Now.ToString() + "SleepTracker", ChartImageFormat.Jpeg);
        }

        //Helper Methods
        private void CreateNewDataPoint(double amountChanged)
        {
            double currentTime = System.DateTime.Now.ToOADate();
            dp = new DataPoint(currentTime, amountChanged);
        }
    }
}
