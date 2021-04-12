using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Document
    {
        public List<Vehicle> vehicles = new List<Vehicle>();

        public event Action<Vehicle> AddVehicleEvent;
        public event Action<Vehicle> UpdateVehicleEvent;
        public event Action<Vehicle> DeleteVehicleEvent;

        public void AddVehicle(Vehicle vehicleToAdd)
        {
            this.vehicles.Add(vehicleToAdd);

            AddVehicleEvent?.Invoke(vehicleToAdd);
        }

        public void UpdateVehicle(Vehicle vehicleToUpdate)
        {
            UpdateVehicleEvent?.Invoke(vehicleToUpdate);
        }

        public void DeleteVehicle(Vehicle vehicleToDelete)
        {
            vehicles.Remove(vehicleToDelete);

            DeleteVehicleEvent?.Invoke(vehicleToDelete);
        }
    }
}
