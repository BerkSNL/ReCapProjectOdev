﻿using Business.Concrete;
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
            foreach (var cars in carManager.GetAll())
            {
                Console.WriteLine(cars.ModelName);
            }

            EfCarDal efCarDal = new EfCarDal();
            Car car = new Car();
            car.ModelName = "s";
            car.ColourId = 4;
            car.BrandId = 5;
            car.DailyPrice = 0;
            car.ModelYear = "2020";
            efCarDal.Add(car);

        }
    }
}
