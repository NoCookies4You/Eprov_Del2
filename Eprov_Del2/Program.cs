using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eprov_Del2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool choosing = true;
            while (choosing)
            {
                Console.WriteLine("Hur många bilar ska skapas?");
                string input = Console.ReadLine();

                List<Car> carList = new List<Car>();

                bool isNum = false;
                int carAmount;
                isNum = int.TryParse(input, out carAmount);
                Random generator = new Random();
                if (isNum == true)
                {

                    for (int i = 0; i < carAmount; i++)
                    {
                        int typeDefiner = generator.Next(0, 1);
                        Car newCar;
                        if (typeDefiner == 0)
                        {
                            newCar = new ContrabandCar();
                        }
                        else
                        {
                            newCar = new CleanCar();
                        }
                        carList.Add(newCar);
                    }
                    Console.WriteLine(carAmount + " bilar skapades");
                    choosing = false;
                }
                else
                {
                    Console.WriteLine("det där är inget nummer");
                }
                
            }
            Console.ReadLine();
        }

    }
}
