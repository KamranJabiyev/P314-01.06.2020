using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoNs;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("BMW", "X6", "black", 300);
            DemoNs.Car car1 = new DemoNs.Car();
            Test test = new Test();
            //Bus bus = new Bus("Hundai", "H6", "white", 240, 10);
            //Console.WriteLine(bus.Info());
            #region Public -class,all class members - her yerden el chatan olur
            //car.MaxSpeed = 400;
            //Console.WriteLine(car.MaxSpeed);
            #endregion

            #region Private - all class members - hemin class-in code blokunda el chatan olur
            //car.Brand = "aaaa";
            //Console.WriteLine(car.Brand);
            //car.SetMaxSpeed(300);
            //Console.WriteLine(car.GetMaxSpeed());
            //car.MaxSpeed = 300;
            //Console.WriteLine(car.MaxSpeed);
            #endregion

            #region Protected - all class members - hemin classin ve miras almish class-da elchatan olur(set-get)
            //car.horsePower = 20000;
            #endregion

            #region Public readonly - field - miras aldigimiz class-lar,
            //instance aldigimiz objectler,eyni class-in oz method-larinda da get oluna bilir
            //hemin class-in ctor,teyin olundugu yerde set oluna bilir
            //Console.WriteLine(car.Capacity);
            #endregion

            #region Private readonly - field -eyni class-in oz method-larinda da get oluna bilir
            //hemin class-in ctor,teyin olundugu yerde set oluna bilir
            //Console.WriteLine(car.Capacity);
            #endregion
        }
    }
}
