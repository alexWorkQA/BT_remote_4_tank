using NUnit.Framework;
using BluetoothRCVehicle.Application.Models;
using BluetoothRCVehicle.Application.Factory;

namespace BluetoothRCVehicle.Tests
{
    [TestFixture]
    public class TestForBTPort    
    {
        BluetoothPort port;


        [SetUp]
        public void CreateBTPort()
        {
            port = BluetoothPortFactory.getBlutoothPortinstance();
        }

        [Test]
        public void CreatedBTPortNotNull()
        {
            Assert.IsNotNull(port);
        }

        [Test]
        public void BTPortNameIsCOM1()
        {

            Assert.AreEqual(port.serialPort.PortName, "COM1");
        }

        [Test]
        public void BTPortBaudRateIs9600()
        {
            Assert.AreEqual(port.serialPort.BaudRate, 9600);
        }

        [Test]
        public void BTPortCouldBeOpened()
        {
            port.Open();
            Assert.IsTrue(port.IsOpen);
        }

        [Test]
        public void BTPortCouldBeClosed()
        {
            port.Open();
            port.Close();
            Assert.IsFalse(port.IsOpen);
        }
    }
}
