using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Timers;
using System.IO;

namespace MyTestWindowsService
{
    public partial class Service1 : ServiceBase
    {
        public System.Timers.Timer timer;
        Logger log = new Logger();        

        /// <summary>
        /// Constructor
        /// </summary>
        public Service1()
        {
            InitializeComponent();
            this.CanStop = true;
            this.CanPauseAndContinue = false;            
        }        

        protected override void OnStart(string[] args)
        {            
            log.WriteLog("");
            log.WriteLog("========== SIMPLE SERVICE STARTED ==========");
            log.WriteLog("");
            timer = new System.Timers.Timer();
            timer.Elapsed += new System.Timers.ElapsedEventHandler(CallMailing);
            timer.Interval = 3000; //Set a 3 seconds intervals
            timer.Enabled = true;
            timer.AutoReset = true;            
            this.ScheduleService();
            timer.Start();
        }

        protected override void OnStop()
        {
            log.WriteLog("");
            log.WriteLog("========== SIMPLE SERVICE STOPPED ==========");
            this.timer.Dispose();
        }

        /// <summary>
        /// Test each 10 seconds if the file exists. If exists call the Mailing Windows Service and send an Email with the LogFile attached.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CallMailing(object sender, ElapsedEventArgs e)
        {
            string filePath = @"C:\test\ServiceLog.txt";
            if(File.Exists(filePath))
            {
                using (ServiceController serviceController = new ServiceController("WSMailing"))
                {                    
                    serviceController.Start();
                }
            }            
        }

        public void ScheduleService()
        {
            try
            {
                timer = new System.Timers.Timer();
                DateTime startTime = DateTime.Now;
                //Set the Default Time.
                DateTime scheduledTime = DateTime.MinValue;                
                TimeSpan timeSpan = scheduledTime.Subtract(DateTime.Now);
                string schedule = string.Format("{0} hour(s) {1} minute(s) {2} seconds(s)", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
                log.WriteLog("Simple Service scheduled to run after: " + schedule);
                
                //Get the difference in Minutes between the Scheduled and Current Time.
                System.Threading.Thread.Sleep(1000);
                DateTime endTime = DateTime.Now;
                TimeSpan dueTime = endTime.Subtract(startTime);
                string schedule2 = string.Format("{0} minute(s) {1} seconds(s) {2} milliseconds(s)", dueTime.Minutes, dueTime.Seconds, dueTime.Milliseconds);
                log.WriteLog("It has taken: " + schedule2 + " to open the Service.");
                
            }
            catch (Exception ex)
            {
                log.WriteLogException("Simple Service Error on: ", ex);

                //Stop the Windows Service.
                using (System.ServiceProcess.ServiceController serviceController = new System.ServiceProcess.ServiceController("SimpleService"))
                {
                    serviceController.Stop();
                }
            }
        }

    }

}
