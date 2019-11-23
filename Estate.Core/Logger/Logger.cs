using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estate.Core.IO;

namespace Estate.Core.Logger
{
    public class Logger
    {
        InputOutput WriterReader;
        private static Logger logInstance;
        string appPath;

        public string AppPath { get => appPath; set => appPath = value; }

        protected Logger(string appPath)
        {
            this.AppPath = appPath;
            WriterReader = new InputOutput(appPath, "Logs.txt");
        }
        protected Logger()
        {
        }
        public int NewLog(string logsText)
        {
            WriterReader.Write(logsText);
            return 1;
        }
        public static Logger getInstance(string appPath)
        {
            if (logInstance == null)
            {
                logInstance = new Logger(appPath);
            }
            return logInstance;
        }
        public static Logger getInstance()
        {
            if (logInstance == null)
            {
                logInstance = new Logger();
                
            }
            return logInstance;
        }

    }
}
