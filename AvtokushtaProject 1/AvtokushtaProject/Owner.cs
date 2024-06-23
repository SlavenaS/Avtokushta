using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtokushtaProject
{
    public class Owner : Vehicle
    {
        public int ownerId;
        public int OwnerId
        {
            get { return ownerId; }
            set
            {
                if (value==0)
                {
                    throw new ArgumentNullException("value");
                }
                ownerId = value;
            }
        }
        public Owner(int vehicleId, int engineId, int bodyId, string brand, decimal price, int year, int ownerid) : base(vehicleId, engineId, bodyId, brand, price, year)
        {
            this.OwnerId = ownerid;
        }
        public override void Print() 
        {
            base.Print();
            Console.WriteLine($"{ownerId}");
        }
        public override int CalculateAge()
        {
            return DateTime.Now.Year - Year;
        }
    }
}
