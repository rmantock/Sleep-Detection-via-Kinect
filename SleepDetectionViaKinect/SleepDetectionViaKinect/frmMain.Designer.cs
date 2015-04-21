namespace SleepDetectionViaKinect
{
    partial class frmMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chSleepActivity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnTrackSleep = new System.Windows.Forms.Button();
            this.btnEndSleep = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chSleepActivity)).BeginInit();
            this.SuspendLayout();
            // 
            // chSleepActivity
            // 
            chartArea4.Name = "ChartArea1";
            this.chSleepActivity.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chSleepActivity.Legends.Add(legend4);
            this.chSleepActivity.Location = new System.Drawing.Point(12, 12);
            this.chSleepActivity.Name = "chSleepActivity";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Sleep Activity";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chSleepActivity.Series.Add(series4);
            this.chSleepActivity.Size = new System.Drawing.Size(622, 348);
            this.chSleepActivity.TabIndex = 0;
            this.chSleepActivity.Text = "chart1";
            // 
            // btnTrackSleep
            // 
            this.btnTrackSleep.Location = new System.Drawing.Point(559, 366);
            this.btnTrackSleep.Name = "btnTrackSleep";
            this.btnTrackSleep.Size = new System.Drawing.Size(75, 23);
            this.btnTrackSleep.TabIndex = 1;
            this.btnTrackSleep.Text = "&Track Sleep";
            this.btnTrackSleep.UseVisualStyleBackColor = true;
            this.btnTrackSleep.Click += new System.EventHandler(this.btnTrackSleep_Click);
            // 
            // btnEndSleep
            // 
            this.btnEndSleep.Location = new System.Drawing.Point(478, 366);
            this.btnEndSleep.Name = "btnEndSleep";
            this.btnEndSleep.Size = new System.Drawing.Size(75, 23);
            this.btnEndSleep.TabIndex = 2;
            this.btnEndSleep.Text = "&End Sleep";
            this.btnEndSleep.UseVisualStyleBackColor = true;
            this.btnEndSleep.Click += new System.EventHandler(this.btnEndSleep_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(397, 366);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 401);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEndSleep);
            this.Controls.Add(this.btnTrackSleep);
            this.Controls.Add(this.chSleepActivity);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chSleepActivity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chSleepActivity;
        private System.Windows.Forms.Button btnTrackSleep;
        private System.Windows.Forms.Button btnEndSleep;
        private System.Windows.Forms.Button btnExit;
    }
}

