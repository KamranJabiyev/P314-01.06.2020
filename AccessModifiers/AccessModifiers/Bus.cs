using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Bus:Car
    {
        public int PasengerCount;
        public Bus(string brand, string model, string color, int maxSpeed,int pasengerCount):base(brand,model,color,maxSpeed)
        {
            horsePower = 2000;
            PasengerCount = pasengerCount;
        }
        public override string Info()
        {
            return $"{ base.Info()} - Passenger Count:{PasengerCount} {horsePower}";
        }
    }
}
