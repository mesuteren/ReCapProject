using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("-------xxx--------");
                Console.WriteLine("{0} / {1} / {2}", car.CarName, car.DailyPrice, car.Description);

                            
            }

            Console.WriteLine("-------xxx--------");
        }
    }
}
