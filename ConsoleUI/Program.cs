using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Abstract;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            
            

            EfCarDal efCarDal = new EfCarDal();
            Car car = new Car();
            car.Id = 1;
            car.ModelName = "AMG";
            car.ColourId = 4;
            car.BrandId = 1;
            car.DailyPrice = 20000;
            car.ModelYear = "2020";
            //efCarDal.Add(car);

            foreach (var cars in carManager.GetAllByColour(1))
            {
                Console.WriteLine(cars.ModelName);
            }

        }
    }
}
