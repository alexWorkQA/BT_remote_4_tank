using System;
using System.IO.Ports;

namespace WpfApplication_First_practice.Models
{
    /// <summary>
    /// Bluetooth Port wraps Serial Port
    /// </summary>
    class BluetoothPort
    {
        private SerialPort serialPort;

        public SerialPort BT
        {
            get {
                serialPort = new SerialPort("COM5", 9600);
                return serialPort; }

            set { serialPort = value; }
        }

        public bool IsOpen { get; internal set; }

        internal void Write(string command)
        {
            serialPort.Write(command);
        }

        internal void Open()
        {
            serialPort.Open();
        }

        internal void Close()
        {
            serialPort.Close();
        }
    }
}
