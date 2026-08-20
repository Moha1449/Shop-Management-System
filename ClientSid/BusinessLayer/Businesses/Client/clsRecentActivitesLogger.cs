using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;


namespace ClientSideBusinessLayer.Businesses.Client
{
    public sealed class clsRecentActivatesLogger
    {
        private static int _ActivatesCount = 0;

        private static string _ActivatesLoggerPath => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ActivatesLogger.txt");

        internal enum enActivates { NewUserAdded, UserDeleted, UserUpdated }

        public enum enFileState { FileNotFound, ActivityReadSuccessfully, ErrorDuringTheReading, LogWasDeleted, ErrorDuringTheDeleting }

        private static string _ConvertTheActivityToString(enActivates Activity)
        {
            switch (Activity)
            {
                case enActivates.NewUserAdded:
                    return "Added A New User";
                case enActivates.UserDeleted:
                    return "Deleted An User";
                case enActivates.UserUpdated:
                    return "Updated An User";
            }

            return "";
        }

        internal static async Task LogTheActivityAsync(enActivates Activity)
        {
            try
            {
                if (!File.Exists(_ActivatesLoggerPath))
                    File.Create(_ActivatesLoggerPath);

                if (_ActivatesCount >= 30)
                    return;


                using (StreamWriter Writer = File.AppendText(_ActivatesLoggerPath))
                {
                    await Writer.WriteLineAsync(_ConvertTheActivityToString(Activity));
                }


            }
            catch (Exception Ex)
            {
                await clsErrorLogger.LogErrorAsync(Ex.Message);
            }
        }

        public static async Task<enFileState> GetActivatesAsync(List<string> Activates)
        {
            if (!File.Exists(_ActivatesLoggerPath))
                return enFileState.FileNotFound;

            try
            {
                using (FileStream ActivityLog = File.OpenRead(_ActivatesLoggerPath))
                using (StreamReader Reader = new StreamReader(ActivityLog))
                {
                    string Activity = string.Empty;

                    while ((Activity = await Reader.ReadLineAsync()) != null)
                    {
                        Activates.Add(Activity);
                    }

                    _ActivatesCount = Activates.Count;
                }

                return enFileState.ActivityReadSuccessfully;
            }
            catch (Exception Ex)
            {
                await clsErrorLogger.LogErrorAsync(Ex.Message);
                return enFileState.ErrorDuringTheReading;
            }
        }
    }
}
