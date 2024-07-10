using System;
namespace firstTry
{
    public class TwoWheeler
    {
        private int reg;
        private string name;
        private string brand;

        public int Reg
        {
            get { return reg; }
            set { reg = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
    }

    class Bike : TwoWheeler
    {
        private string cc;
        private string fuelCapacity;

        public string Cc
        {
            get { return cc; }
            set { cc = value; }
        }

        public string FuelCapacity
        {
            get { return fuelCapacity; }
            set { fuelCapacity = value; }
        }
    }

    class ElectricBike : Bike
    {
        private string range;
        public string Range
        {
            get { return range; }
            set { range = value; }
        }
    }
}

