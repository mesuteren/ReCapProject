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

            Console.WriteLine("---User List---");

            UserManager userManager = new UserManager(new EfUserDal());

            //userManager.Add(new User { FirstName="Mesut", LastName="Eren", Email="mesut.eren@outlook.com", Password="12345" });


            foreach (var user in userManager.GetAll().Data)
            {
                Console.WriteLine(user.FirstName +" "+ user.LastName +" "+user.Email );
            }
        }

        private static void BrandTest()
        {
            Console.WriteLine("---Brand List---");

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            
            //brandManager.Add(new Brand { Name = "Mercedes" });
            

            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.Name);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            
            var result = carManager.GetCarDetails();

            //carManager.Delete(new Car {CarId=2 });
            //carManager.Add(new Car { BrandId = 1, ColorId = 1, CarName = "Passat", DailyPrice = 250, ModelYear = "2020", Description = "Otomatik vites" });
            //carManager.Add(new Car { BrandId = 1, ColorId = 1, CarName = "Jetta", DailyPrice = 0, ModelYear = "2019", Description = "Manuel vites" });
            if (result.Success==true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("-------xxx--------");
                    Console.WriteLine("{0} / {1} / {2} / {3} / {4}",
                        car.CarName,
                        car.BrandName,
                        car.ColorName,
                        car.DailyPrice,
                        car.Description);
                }
            }
            else
            {
                    Console.WriteLine(result.Message);
            }
            

            Console.WriteLine("-------xxx--------");
        }
    }
}
