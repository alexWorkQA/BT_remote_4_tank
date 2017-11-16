using WpfApplication_First_practice.Models;

namespace WpfApplication_First_practice.Factory
{
    /// <summary>
    /// BT factory to create BT
    /// </summary>
    public class BluetoothPortFactory
    {
        static BluetoothPort bt_Port;
        /// <summary>
        /// Method returns single instance of Bluetooth port with PortName and BaudRate
        /// </summary>
        /// <returns></returns>
        public static BluetoothPort getBlutoothPortinstance()
        {
            if (bt_Port == null)
            {
                string PortName = "COM1";
                int BaudRate = 9600;
                bt_Port = new BluetoothPort(BaudRate, PortName);
                return bt_Port;
            }
            else return bt_Port;
        }

    }
}
