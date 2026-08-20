using System;
using System.IO;
using System.Threading.Tasks;



namespace ClientSideBusinessLayer
{
    internal static class clsErrorLogger
    {
        private  static string ErrorsLogPath => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ErrorLogger.txt");

        internal static async Task<bool> LogErrorAsync(string Details)
        {
            if (Details == null)
                return false;

            try
            {
                if (!File.Exists(ErrorsLogPath))
                {
                    File.Create(ErrorsLogPath);
                }

                using(FileStream File = new FileStream(ErrorsLogPath,FileMode.Append))
                {
                    using(StreamWriter Writer  = new StreamWriter(File))
                    {
                       await Writer.WriteLineAsync($"[{DateTime.Now}] "+ Details);
                        return true;
                    }
                }
            }
            catch (Exception Ex)
            {
                 return false;
            }
        }
    }
}
