using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car Crud Ops
            //CarAllTest();
            //CarByIdTest();
            //CarAddTest();
            //CarDeleteTest();
            //CarUpdateTest();

            //Brand Crud Ops
            //BrandAllTest();
            //BrandAddTest();
            //BrandUpdateTest();
            //BrandDeleteTest();

            //Colour Crud Ops
            //ColourAllTest();
            //ColourAddTest();
            //ColourDeleteTest();
            //ColourUpdateTest();

            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine($"{car.BrandName} {car.ModelName} / Colour: {car.ColourName} / Daily Price: {car.DailyPrice}");
            }
        }

        private static void ColourUpdateTest()
        {
            ColourManager colourManager = new ColourManager(new EfColourDal());
            Colour colour = new Colour();
            colour.Id = 4;
            Console.WriteLine("Before the Update");
            Console.WriteLine();
            ColourAllTest();
            Console.WriteLine();
            colour.ColourName = "Gray";
            colourManager.Update(colour);
            Console.WriteLine();
            Console.WriteLine("After the Update");
            Console.WriteLine();
            ColourAllTest();
        }

        private static void ColourDeleteTest()
        {
            ColourManager colourManager = new ColourManager(new EfColourDal());
            Colour colour = new Colour();
            colour.Id = 7;
            colour.ColourName = "Green";
            colourManager.Add(colour);
            Console.WriteLine("Duplicate added for test");
            Console.WriteLine();
            ColourAllTest();
            Console.WriteLine();
            Console.WriteLine();
            colourManager.Delete(colour);
            Console.WriteLine("Duplicate removed");
            Console.WriteLine();
            ColourAllTest();
        }

        private static void ColourAddTest()
        {
            Colour colour = new Colour();
            colour.Id = 6;
            colour.ColourName = "Green";
            ColourManager colourManager = new ColourManager(new EfColourDal());
            colourManager.Add(colour);
            ColourAllTest();
        }

        private static void BrandDeleteTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand brand = new Brand();
            brand.Id = 5;
            brand.BrandName = "Volvo";
            brandManager.Add(brand);
            Console.WriteLine("Duplicate added for test");
            Console.WriteLine();
            BrandAllTest();
            Console.WriteLine();
            Console.WriteLine("Duplicate removed");
            Console.WriteLine();
            brandManager.Delete(brand);
            BrandAllTest();
        }

        private static void BrandUpdateTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand brand = new Brand();
            brand.Id = 4;
            Console.WriteLine("Before the Update");
            Console.WriteLine();
            BrandAllTest();
            Console.WriteLine();
            brand.BrandName = "Jeep";
            brandManager.Update(brand);
            Console.WriteLine();
            Console.WriteLine("After the Update");
            Console.WriteLine();
            BrandAllTest();
        }

        private static void BrandAddTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand brand = new Brand();
            brand.Id = 4;
            brand.BrandName = "Volvo";
            brandManager.Add(brand);
            BrandAllTest();
        }

        private static void CarByIdTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetById(1);
            Console.WriteLine(result.ModelName);
        }

        private static void CarUpdateTest()
        {
            Car car = new Car();
            car.Id = 2;
            car.ModelName = "Explorer";
            car.ModelYear = "2020";
            car.BrandId = 2;
            car.ColourId = 2;
            car.Description = "SUV";
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var vehicle in carManager.GetAll())
            {
                Console.WriteLine(vehicle.ModelName + " " + vehicle.ModelYear);
            }
            Console.WriteLine();
            Console.WriteLine("Before the Update");
            car.ModelName = "Kuga";
            car.ModelYear = "2021";
            car.BrandId = 2;
            car.ColourId = 3;
            car.Description = "SUV";
            Console.WriteLine();
            carManager.Update(car);
            Console.WriteLine("After the Update");
            Console.WriteLine();
            foreach (var vehicle in carManager.GetAll())
            {
                Console.WriteLine(vehicle.ModelName + " " + vehicle.ModelYear);
            }
        }

        private static void CarDeleteTest()
        {
            Car car = new Car();
            car.Id = 3;
            car.ModelName = "Explorer";
            car.ModelYear = "2020";
            car.BrandId = 2;
            car.ColourId = 2;
            car.Description = "SUV";
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(car);
            Console.WriteLine("Duplicate added for test");
            Console.WriteLine();
            CarAllTest();
            carManager.Delete(car);
            Console.WriteLine();
            Console.WriteLine("Duplicate removed");
            Console.WriteLine();
            CarAllTest();
        }

        private static void CarAddTest()
        {
            Car car = new Car();
            car.Id = 2;
            car.ModelName = "Explorer";
            car.ModelYear = "2020";
            car.BrandId = 2;
            car.ColourId = 2;
            car.Description = "SUV";
            car.DailyPrice = 200;
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(car);
            CarAllTest();
        }

        private static void ColourAllTest()
        {
            ColourManager colourManager = new ColourManager(new EfColourDal());
            foreach (var colour in colourManager.GetAll())
            {
                Console.WriteLine(colour.ColourName);
            }
        }

        private static void BrandAllTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void CarAllTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.ModelName);
            }
        }
    }
}
