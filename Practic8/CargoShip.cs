using System;
using System.Collections.Generic;
using System.Text;

namespace Practic8
{
    class CargoShip : IShip, ICargoTransport 
    {
        public int LoadCapacity { get; set; }
        public string Name { get; set; }

        public CargoShip()
        {
            Name = null;
            LoadCapacity = 0;
        }
        public CargoShip(string name, int capacity)
        {
            Name = name;
            LoadCapacity = capacity;
        }
        public string ShowInfo()
        {
            return $"Грузоподъёмность транспорта: {Name}  = {LoadCapacity}";
        }
        public int CompareTo(object obj)
        {
            CargoShip temp = (CargoShip)obj;
            if (this.LoadCapacity > temp.LoadCapacity) return 1;
            else if (this.LoadCapacity < temp.LoadCapacity) return -1;
            else return 0;
        }
        public object Clone()
        {
            CargoShip cloneCargoShip = new CargoShip();
            cloneCargoShip.Name = this.Name;
            cloneCargoShip.LoadCapacity = this.LoadCapacity;
            return cloneCargoShip;
        }
        public CargoShip ShallowClone()
        {
            return (CargoShip)this.MemberwiseClone();
        }
        
    }
}
