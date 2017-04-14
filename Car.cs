using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAIN_Projekt
{
    public class Car
    {
        public string Brand
        {
            get;
            set;
        }

        public long MaxSpeed
        {
            get;
            set;
        }

        public long ProductionYear
        {
            get;
            set;
        }

        public CarType Type
        {
            get;
            set;
        }

        public Car(string brand, long maxSpeed, long productionYear, CarType type)
        {
            Brand = brand;
            MaxSpeed = maxSpeed;
            ProductionYear = productionYear;
            Type = type;
        }
    }
}
