using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anti_DebugNET
{
    class Program
    {
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        static extern void RaiseException(uint dwExceptionCode, uint dwExceptionFlags, uint nNumberOfArguments, IntPtr lpArguments);

        public const int EH_NONCONTINUABLE = 0x01;
        public const int ERROR_INVALID_DATA = 0xD;

        static void Main(string[] args)
        {

            if(AntiDebug.DebugProtect1.PerformChecks() == 1)
            {
                // Exceptions are caught by debuggers
                // RaiseException(ERROR_INVALID_DATA, EH_NONCONTINUABLE, 0, new IntPtr(1));
                Environment.FailFast("");
            }

            if (AntiDebug.DebugProtect2.PerformChecks() ==1)
            {
                // RaiseException(ERROR_INVALID_DATA, EH_NONCONTINUABLE, 0, new IntPtr(1));
                Environment.FailFast("");
            }

            System.Threading.Thread workerThread = new System.Threading.Thread(() =>
            {
                while (true)
                {
                    if(AntiDebug.DebugProtect1.PerformChecks() == 1)
                    {
                        Environment.FailFast("");
                    }

                    if(AntiDebug.DebugProtect2.PerformChecks() == 1)
                    {
                        Environment.FailFast("");
                    }

                    System.Threading.Thread.Sleep(500);
                }
            });

            AntiDebug.DebugProtect3.HideOSThreads();

            AntiDump.DumpProtect1.AntiDump();

            Console.ReadLine();
        }
    }
}
