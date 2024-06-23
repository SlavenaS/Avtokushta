using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtokushtaProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("n=?");
                int n = int.Parse(Console.ReadLine());
                List<Owner> owners = new List<Owner>();
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("vehicleId, engineId, bodyId, brand, price, year, ownerId");
                    var data = Console.ReadLine().Split();
                    Owner own = new Owner(int.Parse(data[0]), int.Parse(data[1]), int.Parse(data[2]), data[3], decimal.Parse(data[4]), int.Parse(data[5]), int.Parse(data[6]));
                    owners.Add(own);
                }
                owners.Sort();
                foreach (var item in owners)
                {
                    item.Print();
                }
                IComparatorPrice comparator = new IComparatorPrice();
                Console.WriteLine(string.Join(Environment.NewLine, owners.Select(x => x.Price)));
                StreamWriter writer = new StreamWriter("Cars");
                using (writer)
                {
                    foreach (var car in owners)
                    {
                        writer.WriteLine($"{car.OwnerId},{car.VehicleId},{car.EngineId},{car.BodyId},{car.Brand},{car.Price},{car.Year}");
                    }

                }

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
