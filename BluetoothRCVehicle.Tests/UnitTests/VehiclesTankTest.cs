using BluetoothRCVehicle.Application;
using BluetoothRCVehicle.Application.Factory;
using BluetoothRCVehicle.Application.Models;
using NUnit.Framework;

namespace BluetoothRCVehicle.Tests.UnitTests
{
    [TestFixture]
    public class VehiclesTankTest
    {
        Vehicle vehicle;
        BluetoothPort port;

        [SetUp]
        public void CreateNewTank()
        {
            port = BluetoothPortFactory.getBlutoothPortinstance();
            vehicle = new Tank(port);
        }

        [Test]
        public void NewTankNotEmpty()
        {
            Assert.IsNotNull(vehicle);
        }


    }
}
