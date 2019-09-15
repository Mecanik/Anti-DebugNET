using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Anti_DebugNET.AntiDebug
{
    class DebugProtect1
    {
        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool CheckRemoteDebuggerPresent(IntPtr hProcess, [MarshalAs(UnmanagedType.Bool)] ref bool isDebuggerPresent);

        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool IsDebuggerPresent();

        /// <summary>
        /// Peform basic checks, method 1
        /// Checks are very fast, there is no CPU overhead.
        /// </summary>
        public static int PerformChecks()
        {
            if(CheckDebuggerManagedPresent() == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("CheckDebuggerManagedPresent: HIT");
                return 1;
            }

            if (CheckDebuggerUnmanagedPresent() == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("CheckDebuggerUnmanagedPresent: HIT");
                return 1;
            }

            if (CheckRemoteDebugger() == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("CheckRemoteDebugger: HIT");
                return 1;
            }

            return 0;
        }

        /// <summary>
        /// Asks the CLR for the presence of an attached managed debugger, and never even bothers to check for the presence of a native debugger.
        /// </summary>
        private static int CheckDebuggerManagedPresent()
        {
            if (System.Diagnostics.Debugger.IsAttached)
            {
                return 1;
            }

            return 0;
        }

        /// <summary>
        /// Asks the kernel for the presence of an attached native debugger, and has no knowledge of managed debuggers.
        /// </summary>
        private static int CheckDebuggerUnmanagedPresent()
        {
            if (IsDebuggerPresent())
            {
                return 1;
            }

            return 0;
        }

        /// <summary>
        /// Checks whether a process is being debugged.
        /// </summary>
        /// <remarks>
        /// The "remote" in CheckRemoteDebuggerPresent does not imply that the debugger
        /// necessarily resides on a different computer; instead, it indicates that the 
        /// debugger resides in a separate and parallel process.
        /// </remarks>
        private static int CheckRemoteDebugger()
        {
            var isDebuggerPresent = (bool)false;

            var bApiRet = CheckRemoteDebuggerPresent(System.Diagnostics.Process.GetCurrentProcess().Handle, ref isDebuggerPresent);

            if (bApiRet && isDebuggerPresent)
            {
                return 1;
            }

            return 0;
        }
    }
}
