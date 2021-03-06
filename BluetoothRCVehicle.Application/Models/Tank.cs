﻿using BluetoothRCVehicle.Application.Models;
using System;

namespace BluetoothRCVehicle.Application
{
    /// <summary>
    /// Tank class with movements
    /// </summary>

   public class Tank : Vehicle
    {
        BluetoothPort bt_Port;

        public Tank(BluetoothPort bt_Port)
        {
            this.bt_Port = bt_Port;
        }


        public override void Backward()
        {
            bt_Port.Write("B");
        }

        public override void Forward()
        {
            bt_Port.Write("F");
        }

        public override void Left()
        {
            bt_Port.Write("L");
        }

        public override void Right()
        {
            bt_Port.Write("R");
        }

        public override void Stop()
        {
            bt_Port.Write("S");
        }
    }
}
