using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Net;
using System.Net.Mail;
using Outlook = Microsoft.Office.Interop.Outlook;
using MyTestWindowsService;
using System.Timers;

namespace MailingWindowsService
{
    public partial class WSMailing : ServiceBase
    {
        public Timer timer;
        Logger log = new Logger();

        public WSMailing()
        {
            InitializeComponent();
            this.CanStop = true;
            this.CanPauseAndContinue = false;
        }

        protected override void OnStart(string[] args)
        {            
            timer = new System.Timers.Timer();
            timer.Elapsed += new System.Timers.ElapsedEventHandler(GetMail);
            timer.Interval = 60000;
            timer.Enabled = true;
            timer.AutoReset = true;
            timer.Start();
        }

        protected override void OnStop()
        {
            log.WriteLog("$$$$$$$$$$ MAILING STOPPED $$$$$$$$$$");
            this.timer.Dispose();
        }

        /// <summary>
        /// Send an Email with the previous configuration
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetMail(object sender, ElapsedEventArgs e)
        {
            log.WriteLog("");
            log.WriteLog("$$$$$$$$$$ MAILING STARTED $$$$$$$$$$");
            SmtpClient client = new SmtpClient("exchange", 587);
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Credentials = new System.Net.NetworkCredential("intracalltest@incas.com", "Start!123");
            client.EnableSsl = false;
            client.Timeout = 60000;

            try
            {                
                string from = "intracalltest@INCAS.com";
                string to = "marchena@INCAS.com";
                string subject = "Welcome SERGIO";
                string body = "You Have Successfully Entered to Mailing Windows Service World!!!";

                using (MailMessage msg = new MailMessage(from, to, subject, body))
                {
                    log.WriteLog("SENDING EMAIL TO " + to);
                    //Attachment att = new Attachment("c:\\test\\ServiceLog.txt"); //Attach a File
                    //msg.Attachments.Add(att);
                    client.Send(msg);
                }
            }
            catch (Exception ex)
            {
                log.WriteLogException("ERROR", ex);
            }
        }
    }
}
