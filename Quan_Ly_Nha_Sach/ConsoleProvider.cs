using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Quan_Ly_Nha_Sach
{
    public class ConsoleProvider
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool AllocConsole();
        private ConsoleProvider()
        {
         
        }
        public static ConsoleProvider Instance = new ConsoleProvider();
        public void showConsole()
        {
            AllocConsole();
        }
    }
}
