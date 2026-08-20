

namespace APIsAccessData.ErrorsHandler
{
    internal static class clsErrorLogger
    {
        private static string ErrorFilePath { get 
            { return @"C:\Users\IP3 SLIM\source\repos\Shop_Management_System\ErrorLogsFile.txt"; } }

        internal static async Task LogErrorAsync(string Details)
        {
            if(!File.Exists(ErrorFilePath)) 
                File.Create(ErrorFilePath);

            using (FileStream ErrorFile = new FileStream(ErrorFilePath,FileMode.Append))
            {
                using(StreamWriter ErrorWriter = new StreamWriter(ErrorFile))
                {
                    string ErrorFormat = $"Details : {Details} Logged In [{DateTime.Now}]";

                   await ErrorWriter.WriteLineAsync(ErrorFormat);
                }
            }
        }
    }
}
