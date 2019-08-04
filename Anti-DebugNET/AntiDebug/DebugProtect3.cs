using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Anti_DebugNET.Utils;
using Anti_DebugNET.Utils.WinStructs;
using System.Diagnostics;

namespace Anti_DebugNET.AntiDebug
{
    class DebugProtect3
    {
        [DllImport("ntdll.dll")]
        internal static extern NtStatus NtSetInformationThread(IntPtr ThreadHandle, ThreadInformationClass ThreadInformationClass, IntPtr ThreadInformation, int ThreadInformationLength);

        [DllImport("kernel32.dll")]
        static extern IntPtr OpenThread(ThreadAccess dwDesiredAccess, bool bInheritHandle, uint dwThreadId);
        [DllImport("kernel32.dll")]
        static extern uint SuspendThread(IntPtr hThread);
        [DllImport("kernel32.dll")]
        static extern int ResumeThread(IntPtr hThread);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern bool CloseHandle(IntPtr handle);

        public static void HideOSThreads()
        {
            ProcessThreadCollection currentThreads = Process.GetCurrentProcess().Threads;

            foreach (ProcessThread thread in currentThreads)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("[GetOSThreads]: thread.Id {0:X}", thread.Id);

                IntPtr pOpenThread = OpenThread(ThreadAccess.SET_INFORMATION, false, (uint)thread.Id);

                if (pOpenThread == IntPtr.Zero)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("[GetOSThreads]: skipped thread.Id {0:X}", thread.Id);
                    continue;
                }

                if (HideFromDebugger(pOpenThread))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("[GetOSThreads]: thread.Id {0:X} hidden from debbuger.", thread.Id);
                }

                CloseHandle(pOpenThread);
            }
        }

        /// <summary>
        /// Hide the thread from debug events.
        /// </summary>
        public static bool HideFromDebugger(IntPtr Handle)
        {
            NtStatus nStatus = NtSetInformationThread(Handle, ThreadInformationClass.ThreadHideFromDebugger, IntPtr.Zero, 0);

            if(nStatus == NtStatus.Success)
            {
                return true;
            }

            return false;
        }
    }
}
