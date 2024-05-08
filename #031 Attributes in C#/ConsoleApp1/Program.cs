using CAAttributes;
using System.Diagnostics;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Update[] updates = {
             new Update (1, "security update"),
             new Update (2, "ui enhancements"),
             new Update (3, "No. of bug fixes update"),
             new Update (4, "security update"),
            };

            UpdateProcessor.Download(updates);
            UpdateProcessor.Install(updates);
            UpdateProcessor.DownloadAndInstall(updates);
        }

    }



    namespace CAAttributes
    {
        [DebuggerDisplay("No: {no}, Title: {title}")]
        class Update
        {
            private int no;
            private string title;

            public Update(int no, string title)
            {
                this.no = no;
                this.title = title;
            }

            public override string ToString()
            {
                return $"{no} - {title}"; // 1 - security update
            }
        }
    }
}
