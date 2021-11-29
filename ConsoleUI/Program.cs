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
            //CarGetAll();

            //CarAdd();


            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success==true)
            {
                foreach (var car in carManager.GetCarDetails().Data)
                {
                    Console.WriteLine(car.CarName + " " + car.BrandName + " " + car.ColorName + " " + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }

        private static void CarAdd()
        {
            Car car1 = new Car
            {
                Id = 3,
                BrandId = 3,
                ColorId = 3,
                ModelYear = "2009",
                Description = "En iyisinin iyisi",
                CarName = "BWM",
                DailyPrice = 150,

            };

            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(car1);
        }

        private static void CarGetAll()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.CarName + car.BrandId + car.ColorId + car.DailyPrice + car.Description + car.Id);
            }
        }
    }
}
