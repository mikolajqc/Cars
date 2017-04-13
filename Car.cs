using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAIN_Projekt
{
    class Car
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

        public DateTime ProductionYear
        {
            get;
            set;
        }

        public string Type
        {
            get;
            set;
        }

        public Car(string brand, long maxSpeed, DateTime productionYear, string type)
        {
            Brand = brand;
            MaxSpeed = maxSpeed;
            ProductionYear = productionYear;
            Type = type;
        }
    }
}
