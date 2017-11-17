using BluetoothRCVehicle.Application;
using BluetoothRCVehicle.Application.Factory;
using BluetoothRCVehicle.Application.Models;
using NUnit.Framework;

namespace BluetoothRCVehicle.Tests.UnitTests
{
    [TestFixture]
    public class VehiclesTankTest
    {
        Vehicle vehicleTank;
        Vehicle vehicleCar;
        BluetoothPort port;

        [SetUp]
        public void CreateNewTank()
        {
            port = BluetoothPortFactory.getBlutoothPortinstance();
            vehicleTank = new Tank(port);
        }

        [SetUp]
        public void CreateNewCar()
        {
            port = BluetoothPortFactory.getBlutoothPortinstance();
            vehicleCar = new Car(port);
        }

        [Test]
        public void NewTankNotEmpty()
        {
            Assert.IsNotNull(vehicleTank);
        }

        [Test]
        public void NewCarNotEmpty()
        {
            Assert.IsNotNull(vehicleCar);
        }


    }
}
