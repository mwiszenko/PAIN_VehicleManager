using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Vehicles.TypeSelectorControl;

namespace Vehicles
{
    public class Vehicle
    {
        public string Model
        {
            get; set;
        }

        public Types Type
        {
            get; set;
        }

        public DateTime ProductionDate
        {
            get; set;
        }

        public double MaxVelocity
        {
            get; set;
        }

        public Vehicle(string model, Types type, DateTime productionDate, double maxVelocity)
        {
            this.Model = model;
            this.Type = type;
            this.ProductionDate = productionDate;
            this.MaxVelocity = maxVelocity;
        }
    }
}