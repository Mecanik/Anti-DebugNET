using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anti_DebugNET
{
    class Program
    {
        static void Main(string[] args)
        {
            // Recommended to scan before anything else, and not inside any threads
            // It's not a big deal scan anyway, but it will ruine script-kids day :)
            AntiDebugTools.Scanner.ScanAndKill();

            if (AntiDebug.DebugProtect1.PerformChecks() == 1)
            {
                Environment.FailFast("");
            }

            if (AntiDebug.DebugProtect2.PerformChecks() == 1)
            {
                Environment.FailFast("");
            }

            System.Threading.Thread workerThread = new System.Threading.Thread(() =>
            {
                while (true)
                {
                    AntiDebugTools.Scanner.ScanAndKill();

                    if (AntiDebug.DebugProtect1.PerformChecks() == 1)
                    {
                        Environment.FailFast("");
                    }

                    if (AntiDebug.DebugProtect2.PerformChecks() == 1)
                    {
                        Environment.FailFast("");
                    }

                    System.Threading.Thread.Sleep(1000);
                }
            });

            AntiDebug.DebugProtect3.HideOSThreads();

            AntiDump.DumpProtect1.AntiDump();

            Console.ReadLine();
        }
    }
}
