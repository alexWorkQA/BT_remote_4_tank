namespace BluetoothRCVehicle.Application.Models
{
    /// <summary>
    /// Abstract class
    /// </summary>
    public abstract class Vehicle : Moveable
    {
        /// <summary>
        /// move vehicle Backward
        /// </summary>
        public abstract void Backward();
        /// <summary>
        /// move vehicle Forward
        /// </summary>
        public abstract void Forward();
        /// <summary>
        /// move vehicle Left
        /// </summary>
        public abstract void Left();
        /// <summary>
        /// move vehicle Right
        /// </summary>
        public abstract void Right();
        /// <summary>
        /// Stop vehicle
        /// </summary>
        public abstract void Stop();
    }
}
