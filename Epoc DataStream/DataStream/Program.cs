using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataStream
{
    class Program
    {
        private static void StoreHeadsetData(string eventInfo)
        {
            DatabaseConnector dbConnector = new DatabaseConnector(@"Data Source=localhost;User ID=Tester;Password=test;Integrated Security=False");

            dbConnector.ExecuteSqlCommandForSingleValue("IntegrationDb", "INSERT INTO IntegrationDb.dbo.EpocHeadsetDataStream (Data) " + "SELECT '" + eventInfo + "'");
        }

        static void Main(string[] args)
        {
            string output = "";
            ProcessStartInfo pi = new ProcessStartInfo(@"C:\community-sdk\bin\win32\MotionDataLogger.exe", "");
            pi.RedirectStandardOutput = true;
            pi.UseShellExecute = false;
            pi.CreateNoWindow = true;

            Process proc = new Process();
            proc.StartInfo = pi;
            proc.Start();

            while (true)
            {
                Thread.Sleep(10);

                output=proc.StandardOutput.ReadLine();
                if (output.Contains("Algo_HoriEye")) {
                    if (output.Contains("Left"))
                    {
                        Console.WriteLine("Left");
                        StoreHeadsetData("left");
                    }
                    else if (output.Contains("Right"))
                    {
                        Console.WriteLine("Right");
                        StoreHeadsetData("right");
                    }
                    else if (output.Contains("Blink"))
                    {
                        Console.WriteLine("Blink");
                        StoreHeadsetData("blink");
                    }
                }
            }
            
        }
    }
}
