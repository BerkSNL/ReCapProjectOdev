using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        //Car
        public static string CarAdded = "Car added.";
        public static string CarDetailInvalid = "Car name should at least have 2 characters and daily price should be higher than zero!";
        public static string CarListed = "Car listed.";
        public static string CarsListed = "Cars listed.";
        public static string CarDetailsListed = "Car details listed.";
        public static string CarsListedByColour = "Cars listed by the specified colour.";
        public static string CarsListedByBrand = "Cars listed by the specified brand.";
        public static string CarUpdated = "Car updated.";
        public static string CarRemoved = "Car removed.";
        //Brand
        public static string BrandAdded = "Brand added.";
        public static string BrandUpdated = "Brand updated.";
        public static string BrandRemoved = "Brand removed.";
        public static string BrandsListed = "All brands listed.";

        //Colour
        public static string ColourAdded = "Colour added.";
        public static string ColourUpdated = "Colour updated.";
        public static string ColourRemoved = "Colour removed.";
        public static string ColoursListed = "All colours listed.";
    }
}
