using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; }

        private int _maxSpeed;
        protected int horsePower;
        private readonly int Capacity;

        #region Encapsulation
        public int MaxSpeed
        {
            set
            {
                if (value > 0 && value < 400)
                {
                    _maxSpeed = value;
                    return;
                }
                Console.WriteLine("Duzgun suret daxil edin");
            }
            get
            {
                return _maxSpeed;
            }
        }
        //public void SetMaxSpeed(int speed)
        //{
        //    if (speed > 0 && speed < 400)
        //    {
        //        _maxSpeed = speed;
        //        return;
        //    }
        //    Console.WriteLine("Duzgun suret daxil edin");
        //}

        //public int GetMaxSpeed()
        //{
        //    return _maxSpeed;
        //}
        #endregion

        public virtual string Info()
        {
            return $"{Brand} {Model} {Color} {_maxSpeed}";
        }

        private void Test()
        {
            Console.WriteLine(Capacity);
        }
        public Car()
        {
            Console.WriteLine("Car created");
        }

        public Car(string brand,string model)
        {
            Brand = brand;
            Model = model;
        }

        public Car(string brand, string model,string color,int maxSpeed):this(brand,model)
        {
            Capacity = 50;
            Color = color;
            _maxSpeed = maxSpeed;
        }
    }
}
