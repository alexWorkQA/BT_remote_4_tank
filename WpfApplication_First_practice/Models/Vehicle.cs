using System;

namespace WpfApplication_First_practice.Models
{
    /// <summary>
    /// Abstract class
    /// </summary>
    abstract class Vehicle : Moveable
    {
        public abstract void Backward();
        public abstract void Forward();
        public abstract void Left();
        public abstract void Right();
        public abstract void Stop();
    }
}
