using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyTestWindowsService
{
    public class Logger
    {

        private string fileName;        

        /// <summary>
        /// Constructor with a path file
        /// </summary>
        /// <param name="file"></param>
        public Logger(string file)
        {
            fileName = file;            
        }

        // Constructor
        public Logger()
        {
            fileName = @"C:\test\ServiceLog.txt";            
        }

        /// <summary>
        /// Method to write in the logFile
        /// </summary>
        /// <param name="logText"></param>
        public void WriteLog(string logText)
        {
            StreamWriter myFile;   
            try
            {                     
                using (myFile = File.AppendText(fileName))
                {
                    myFile.WriteLine(DateTime.Now.ToString() + " - " + logText);
                }
            }
            catch (Exception ex)
            {
                WriteLogException("Simple Service Error on: ", ex);
            }
        }

        /// <summary>
        /// Method to write an Exception in the logFile
        /// </summary>
        /// <param name="ex"></param>
        public void WriteLogException(string test, Exception ex)
        {
            try
            {
                using (StreamWriter w = File.AppendText(fileName))
                {
                    w.WriteLine("--------------------------------------------------------------------------------");
                    w.WriteLine(DateTime.Now.ToString() + " - EXCEPCION");
                    w.WriteLine("Message: " + ex.Message);
                    w.WriteLine("Source: " + ex.Source);
                    w.WriteLine("TargetSite: " + ex.TargetSite);
                    w.WriteLine("StackTrace: " + ex.StackTrace);
                    w.WriteLine("InnerException: " + ex.InnerException);
                    w.WriteLine("--------------------------------------------------------------------------------");
                }
            }
            catch { }
        }

    }
}
