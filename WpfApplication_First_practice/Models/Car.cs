using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication_First_practice.Models
{
    class Car : Vehicle
    {
        BluetoothPort bt_Port;

        public Car(BluetoothPort bt_Port)
        {
            this.bt_Port = bt_Port;
        }

        public override void Backward()
        {
            throw new NotImplementedException();
        }

        public override void Forward()
        {
            throw new NotImplementedException();
        }

        public override void Left()
        {
            throw new NotImplementedException();
        }

        public override void Right()
        {
            throw new NotImplementedException();
        }

        public override void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
