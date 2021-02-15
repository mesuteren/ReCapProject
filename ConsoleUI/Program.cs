using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CarTest();

            //BrandTest();

            //Console.WriteLine("---Color List---");

            //ColorManager colorManager = new ColorManager(new EfColorDal());

            //colorManager.Add(new Color { Name = "Siyah" });


            //foreach (var color in colorManager.GetAll())
            //{
            //    Console.WriteLine(color.Name);
            //}


        }

        private static void BrandTest()
        {
            Console.WriteLine("---Brand List---");

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            
            //brandManager.Add(new Brand { Name = "Mercedes" });
            

            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.Name);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            //carManager.Delete(new Car {CarId=2 });
            //carManager.Add(new Car { BrandId = 1, ColorId = 1, CarName = "Passat", DailyPrice = 250, ModelYear = "2020", Description = "Otomatik vites" });
            //carManager.Add(new Car { BrandId = 1, ColorId = 1, CarName = "Jetta", DailyPrice = 0, ModelYear = "2019", Description = "Manuel vites" });
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("-------xxx--------");
                Console.WriteLine("{0} / {1} / {2} / {3} / {4}", 
                    car.CarName, 
                    car.BrandName, 
                    car.ColorName, 
                    car.DailyPrice,
                    car.Description);

            }

            Console.WriteLine("-------xxx--------");
        }
    }
}
