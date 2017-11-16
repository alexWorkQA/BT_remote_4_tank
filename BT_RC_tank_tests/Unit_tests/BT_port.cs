using NUnit.Framework;
using NUnit.Compatibility;
using WpfApplication_First_practice.Models;
using WpfApplication_First_practice.Factory;


namespace BT_RC_tank_tests
{
    [TestFixture]
    public class UnitTest
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
            port.Close();
            Assert.IsFalse(port.IsOpen);
        }
    }
}
