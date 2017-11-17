using System.IO.Ports;

namespace BluetoothRCVehicle.Application.Wrapper
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
