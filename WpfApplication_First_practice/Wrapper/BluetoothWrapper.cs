using System.IO.Ports;

namespace WpfApplication_First_practice.Wrapper
{
    /// <summary>
    /// BluttothWrapper class extended SerialPort
    /// created for customize correct BT port
    /// </summary>
    public class BluetoothWrapper
    {
       public SerialPort serialPort;

        public BluetoothWrapper(int BaudRate, string PortName)
        {
            serialPort = new SerialPort(PortName, BaudRate);
        }

    }
}
