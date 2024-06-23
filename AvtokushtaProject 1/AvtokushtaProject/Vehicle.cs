using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtokushtaProject
{
    public abstract class Vehicle : IVehicle
    {

        public int vehicleId;
        public int VehicleId
        {
            get { return vehicleId; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentNullException("value");
                }
                vehicleId = value;
            }
        }
        public int engineId;
        public int EngineId
        {
            get { return engineId; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentNullException("value");
                }
                engineId = value;
            }
        }
        public int bodyId;
        public int BodyId
        {
            get { return bodyId; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentNullException("value");
                }
                bodyId = value;
            }
        }
        public string brand;
        public string Brand
        {
            get { return brand; }
            set
            {
                if (value == "")
                {
                    throw new ArgumentNullException("value");
                }
                brand = value;
            }
        }
        public decimal price;
        public decimal Price
        {
            get { return price; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentNullException("value");
                }
                price = value;
            }
        }
        public int year;
        public int Year
        {
            get { return year; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentNullException("value");
                }
                year = value;
            }
        }
        public Vehicle(int vehicleId, int engineId, int bodyId, string brand, decimal price, int year)
        {

            this.VehicleId = vehicleId;
            this.EngineId = engineId;
            this.BodyId = bodyId;
            this.Brand = brand;
            this.Price = price;
            this.Year = year;
        }
        public virtual void Print()
        {
            Console.WriteLine($"{vehicleId}, {engineId}, {bodyId}, {brand}, {price}, {year}");
        }
        public abstract int CalculateAge();
    }
}
