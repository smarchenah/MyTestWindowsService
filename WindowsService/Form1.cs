using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyTestWindowsService;
using System.ServiceProcess;
using System.IO;
using System.Diagnostics;

namespace WindowsService
{
    public partial class Form1 : Form
    {        
        Logger log = new Logger();                     

        public Form1()
        {
            InitializeComponent();                       
        }

        /// <summary>
        /// Event that Start the Service
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            // Start the service if the current status is stopped.            
            log.WriteLog("@@@@@ STARTING THE SERVICE @@@@@");            
            
            try
            {
                using (ServiceController sc = new ServiceController("Service1"))
                {
                    log.WriteLog("The SergioWindowsService status is currently set to " + sc.Status.ToString().ToUpper());
                    lblMain1.Text = sc.ServiceName; lblMain2.Text = sc.DisplayName; lblMain3.Text = sc.Status.ToString();
                    lblMain1.Visible = true; lblMain2.Visible = true; lblMain3.Visible = true;
                    if (sc.Status == ServiceControllerStatus.Stopped)
                    {
                        // Start the service, and wait until its status is "Running".
                        sc.Start();
                        sc.WaitForStatus(ServiceControllerStatus.Running);

                        // Display the current service status.
                        log.WriteLog("The SergioWindowsService status is now set to " + sc.Status.ToString().ToUpper());
                        btnStart.Enabled = false;
                        btnRestart.Enabled = true;
                        btnStop.Enabled = true;
                        lblMain3.Text = sc.Status.ToString();
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                log.WriteLogException("ERROR - ", ex);
            }
        }

        /// <summary>
        /// Event that Re-Start the Service
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRestart_Click(object sender, EventArgs e)
        {
            //Restarting the Service            
            try
            {
                using (ServiceController sc = new ServiceController("Service1"))
                {
                    if (sc.CanStop)
                    {
                        using (ServiceController scMail = new ServiceController("WSMailing"))
                        {
                            if (scMail.Status == ServiceControllerStatus.Running)
                            {
                                scMail.Stop();
                            }
                        }
                        sc.Stop();
                        sc.WaitForStatus(ServiceControllerStatus.Stopped);

                        log.WriteLog("");
                        log.WriteLog("@@@@@ RESTARTING THE SERVICE @@@@@");

                        sc.Start();
                        sc.WaitForStatus(ServiceControllerStatus.Running);
                        btnStart.Enabled = false;
                        btnRestart.Enabled = true;
                        btnStop.Enabled = true;                        
                    }
                }                
            }
            catch (Exception ex)
            {
                log.WriteLogException("ERROR", ex);
            }

        }

        /// <summary>
        /// Event that Stop the Service
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                bool MainServiceStopped = false;
                using (ServiceController sc = new ServiceController("Service1"))
                {
                    if (sc.CanStop)
                    {
                        using (ServiceController sc2 = new ServiceController("WSMailing"))
                        {
                            sc2.Stop();
                            sc2.WaitForStatus(ServiceControllerStatus.Stopped);
                        }
                        sc.Stop();                        
                        sc.WaitForStatus(ServiceControllerStatus.Stopped);
                        btnStart.Enabled = true;
                        btnRestart.Enabled = false;
                        btnStop.Enabled = false;                        
                        MainServiceStopped = (sc.Status == ServiceControllerStatus.Stopped) ? true : false;
                    }
                }
                
                if (MainServiceStopped)
                {
                    log.WriteLog("");
                    log.WriteLog("@@@@@ THE SERVICE IS STOPPED @@@@@");
                }
                ReadInfo();
            }
            catch (Exception ex)
            {
                log.WriteLogException("ERROR", ex);
            }
        }

        /// <summary>
        /// Read the information of the File
        /// </summary>
        private void ReadInfo()
        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(@"C:\test\ServiceLog.txt"))
                {
                    string line;
                    // Read and display lines from the file until the end of the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        if(line.Contains("@"))
                        {
                            ListViewItem item = new ListViewItem();
                            item.ForeColor = Color.Red;
                            item.Text = line;
                            lstInfo.Items.Add(item);
                        }
                        else if(line.Contains("="))
                        {
                            ListViewItem item = new ListViewItem();
                            item.ForeColor = Color.Green;
                            item.Text = line;
                            lstInfo.Items.Add(item);
                        }
                        else if (line.Contains("$"))
                        {
                            ListViewItem item = new ListViewItem();
                            item.ForeColor = Color.Blue;
                            item.Text = line;
                            lstInfo.Items.Add(item);
                        }
                        else
                        {
                            lstInfo.Items.Add(line);
                        }
                    }
                    sr.Close();
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                log.WriteLogException("The file could not be read:", e);
            }

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            lstInfo.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.Delete(@"C:\test\ServiceLog.txt");
        }

        /// <summary>
        /// Event to Start the Mailing Windows Service
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartMailing_Click(object sender, EventArgs e)
        {
            // Start the service if the current status is stopped.
            log.WriteLog("$$$$$ MAILING STARTING $$$$$");
            try
            {
                using (ServiceController sc = new ServiceController("WSMailing"))
                {
                    lblMail1.Text = sc.ServiceName; lblMail2.Text = sc.DisplayName; lblMail3.Text = sc.Status.ToString();
                    lblMail1.Visible = true; lblMail2.Visible = true; lblMail3.Visible = true;
                    log.WriteLog("The MailingService status is currently set to " + sc.Status.ToString().ToUpper());
                    if (sc.Status == ServiceControllerStatus.Stopped)
                    {
                        // Start the service, and wait until its status is "Running".
                        sc.Start();
                        sc.WaitForStatus(ServiceControllerStatus.Running);

                        // Display the current service status.
                        log.WriteLog("The Mailing status is now set to " + sc.Status.ToString().ToUpper());                        
                        lblMail3.Text = sc.Status.ToString();
                        btnStartMailing.Enabled = false;
                        btnStopMailing.Enabled = true;
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                log.WriteLogException("ERROR - ", ex);
            }
        }

        /// <summary>
        /// Event to Stop the Mailing Windows Service
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopMailing_Click(object sender, EventArgs e)
        {
            try
            {
                using (ServiceController sc = new ServiceController("WSMailing"))
                {
                    if (sc.CanStop)
                    {
                        sc.Stop();
                        sc.WaitForStatus(ServiceControllerStatus.Stopped);
                        btnStartMailing.Enabled = true;
                        btnStopMailing.Enabled = false;
                        lblMail3.Text = sc.Status.ToString();
                        ReadInfo();
                    }
                }
            }
            catch (Exception ex)
            {
                log.WriteLogException("ERROR", ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                bool isAppRunning = IsProcessOpen("App");
                if (!isAppRunning)
                {
                    Process p = new Process();
                    if (Environment.Is64BitOperatingSystem)
                        p.StartInfo.FileName = @"C:\Program Files (x86)\Creative Solutions\App\App.exe";
                    else
                        p.StartInfo.FileName = @"C:\Program Files\Creative Solutions\App\App.exe";
                    p.Start();


                }
            }
            catch (Exception ex)
            {
                log.WriteLogException("ERROR", ex);
            }
        }

        public bool IsProcessOpen(string name)
        {
            //here we're going to get a list of all running processes on
            //the computer
            foreach (Process clsProcess in Process.GetProcesses())
            {
                if (clsProcess.ProcessName.Contains(name))
                {
                    //if the process is found to be running then we
                    //return a true
                    return true;
                }
            }
            //otherwise we return a false
            return false;
        }
    }
}
