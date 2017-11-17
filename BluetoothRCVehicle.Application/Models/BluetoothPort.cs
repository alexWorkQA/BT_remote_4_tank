using BluetoothRCVehicle.Application.Wrapper;

namespace BluetoothRCVehicle.Application.Models
{
    /// <summary>
    /// Bluetooth Port wraps Serial Port
    /// </summary>
   public class BluetoothPort : BluetoothWrapper
    {
        public BluetoothPort(int BaudRate, string PortName) : base(BaudRate, PortName)
        {
        }
        /// <summary>
        /// Check if port is Open
        /// </summary>
        public bool IsOpen { get { return serialPort.IsOpen; } }

        /// <summary>
        /// Write command to serial port
        /// </summary>
        /// <param name="command"></param>

        public void Write(string command)
        {
            serialPort.Write(command);
        }

        /// <summary>
        /// Open BT port
        /// </summary>
        public void Open()
        {
            serialPort.Open();
        }

        /// <summary>
        /// Close BT port
        /// </summary>
        public void Close()
        {
            serialPort.Close();
        }
    }
}
