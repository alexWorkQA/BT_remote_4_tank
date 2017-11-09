using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication_First_practice
{
    class bluetooth_Test
    {
        public static void bt_Test()
        {
            SerialPort bt_Port = new SerialPort();
            bt_Port.BaudRate = 9600;
            bt_Port.PortName = "COM5";
            bt_Port.Open();
            for (int i =0; i < 100; i++)
            {
                bt_Port.Write("T");
            }
        }
    }
}
