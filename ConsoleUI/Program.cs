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
            //CarByBrandTest();
            //CarByColourTest();
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
            ColourUpdateTest();

            //DtoTest();

        }

        private static void CarByColourTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetAllByColourId(1);
            foreach (var car in result.Data)
            {
                Console.WriteLine($"{car.ModelName} / Colour ID: {car.ColourId}");
            }
            Console.WriteLine();
            Console.WriteLine(result.Message);
        }

        private static void CarByBrandTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetAllByBrandId(1);
            foreach (var car in result.Data)
            {
                Console.WriteLine($"{car.ModelName} / Brand ID: { car.Id}");
            }
            Console.WriteLine();
            Console.WriteLine(result.Message);
        }

        private static void DtoTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in carManager.GetCarDetails().Data)
                {
                    Console.WriteLine($"{car.BrandName} {car.ModelName} / Colour: {car.ColourName} / Daily Price: {car.DailyPrice}");
                }
                Console.WriteLine();
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
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
            var result = colourManager.Update(colour);
            Console.WriteLine();
            Console.WriteLine(result.Message);
            Console.WriteLine();
            Console.WriteLine("After the Update");
            Console.WriteLine();
            ColourAllTest();
        }

        private static void ColourDeleteTest()
        {
            ColourManager colourManager = new ColourManager(new EfColourDal());
            Colour colour = new Colour();
            colour.Id = 8;
            colour.ColourName = "Green";
            colourManager.Add(colour);
            Console.WriteLine("Duplicate added for test");
            Console.WriteLine();
            ColourAllTest();
            Console.WriteLine();
            var result = colourManager.Delete(colour);
            Console.WriteLine(result.Message);
            Console.WriteLine();
            Console.WriteLine("Duplicate removed");
            Console.WriteLine();
            ColourAllTest();
        }

        private static void ColourAddTest()
        {
            Colour colour = new Colour();
            colour.Id = 7;
            colour.ColourName = "Purple";
            ColourManager colourManager = new ColourManager(new EfColourDal());
            var result = colourManager.Add(colour);
            Console.WriteLine(result.Message);
            Console.WriteLine();
            ColourAllTest();
        }

        private static void BrandDeleteTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand brand = new Brand();
            brand.Id = 6;
            brand.BrandName = "Volvo";
            brandManager.Add(brand);
            Console.WriteLine("Duplicate added for test");
            Console.WriteLine();
            BrandAllTest();
            Console.WriteLine();
            var result = brandManager.Delete(brand);
            Console.WriteLine(result.Message);
            Console.WriteLine();
            Console.WriteLine("Duplicate removed");
            Console.WriteLine();
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
            brand.BrandName = "Volvo";
            var result = brandManager.Update(brand);
            Console.WriteLine();
            Console.WriteLine(result.Message);
            Console.WriteLine();
            Console.WriteLine("After the Update");
            Console.WriteLine();
            BrandAllTest();
        }

        private static void BrandAddTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand brand = new Brand();
            brand.Id = 5;
            brand.BrandName = "Volkswagen";
            var result = brandManager.Add(brand);
            Console.WriteLine(result.Message);
            Console.WriteLine();
            BrandAllTest();
        }

        private static void CarByIdTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetById(1);
            Console.WriteLine(result.Data.ModelName);
        }

        private static void CarUpdateTest()
        {
            Car car = new Car();
            car.Id = 2;
            car.ModelName = "Explorer";
            car.ModelYear = "2020";
            car.BrandId = 2;
            car.ColourId = 3;
            car.Description = "SUV";
            car.DailyPrice = 300;
            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine("Before the Update");
            foreach (var vehicle in carManager.GetAll().Data)
            {
                Console.WriteLine(vehicle.ModelName + " " + vehicle.ModelYear + " " + vehicle.DailyPrice);
            }
            Console.WriteLine();
            Console.WriteLine();
            var result = carManager.Update(car);
            Console.WriteLine("After the Update");
            Console.WriteLine();
            foreach (var vehicle in carManager.GetAll().Data)
            {
                Console.WriteLine(vehicle.ModelName + " " + vehicle.ModelYear + " " + vehicle.DailyPrice);
            }
            Console.WriteLine();
            if (result.Success == true)
            {

                Console.WriteLine(car.Id + ". " + result.Message);
            }
        }

        private static void CarDeleteTest()
        {
            Car car = new Car();
            car.Id = 6;
            car.ModelName = "Explorer";
            car.ModelYear = "2020";
            car.BrandId = 2;
            car.ColourId = 2;
            car.Description = "SUV";
            car.DailyPrice = 300;
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(car);
            Console.WriteLine("Duplicate added for test");
            Console.WriteLine();
            CarAllTest();
            var result = carManager.Delete(car);
            Console.WriteLine();
            if (result.Success == true)
            {
                Console.WriteLine(result.Message);
            }
            Console.WriteLine("Duplicate removed");
            Console.WriteLine();
            CarAllTest();

        }

        private static void CarAddTest()
        {
            Car car = new Car();
            car.Id = 5;
            car.ModelName = "Focus";
            car.ModelYear = "2020";
            car.BrandId = 2;
            car.ColourId = 2;
            car.Description = "Hatchback";
            car.DailyPrice = 100;
            CarManager carManager = new CarManager(new EfCarDal());
            
            var result = carManager.Add(car);
            if (result.Success == true)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void ColourAllTest()
        {
            ColourManager colourManager = new ColourManager(new EfColourDal());
            var result = colourManager.GetAll().Data;
            foreach (var colour in result)
            {
                Console.WriteLine(colour.ColourName);
            }
            Console.WriteLine();
            Console.WriteLine(colourManager.GetAll().Message);
        }

        private static void BrandAllTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetAll().Data;
            foreach (var brand in result)
            {
                Console.WriteLine(brand.BrandName);
            }
            Console.WriteLine();
            Console.WriteLine(brandManager.GetAll().Message);
        }

        private static void CarAllTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetAll().Data;
            foreach (var car in result)
            {
                Console.WriteLine(car.ModelName);
            }
            Console.WriteLine();
            Console.WriteLine(carManager.GetAll().Message); 
        }
    }
}
