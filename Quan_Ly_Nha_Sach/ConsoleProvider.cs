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

        private static ConsoleProvider instance;
        private ConsoleProvider()
        {
         
        }
        public static ConsoleProvider Instance 
        {
            get
            {
                if(instance == null)
                    ConsoleProvider.instance = new ConsoleProvider();
                return ConsoleProvider.instance;
            }
            private set
            {
                ConsoleProvider.instance = value;
            }
        }
        public void showConsole()
        {
            AllocConsole();
        }
    }
}
