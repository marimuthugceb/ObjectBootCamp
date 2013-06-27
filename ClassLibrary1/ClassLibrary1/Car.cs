using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Car
    {
        public string Color;
        public int Speed;
        public string Brand;
        public string NumberOfSeats;
        public string CarType;
        public string EnginePower;
        public bool IsAutoGear;
        public int NumberOfGear;
        public long Price;
        public string Mileage;
        public bool Idle;
        public int Gear;

        public void Accelerate(int Speed)
        {
            this.Speed = Speed;
        }

        public void StopCar()
        {
            this.Idle = true;
        }


        public void StartCar()
        {
            this.Idle = false;
        }

        public void ChangeGear(int Gear)
        {
            this.Gear = Gear;
        }


    }
}
