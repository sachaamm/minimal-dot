using System.IO;

namespace ConsoleApp1.Utility
{
    public class PathUtility
    {
        public static string ConfigPath()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(ExecPath());
            return directoryInfo.Parent.Parent.FullName;
        }

        static string ExecPath()
        {
            return Directory.GetCurrentDirectory();
        }
    }
}