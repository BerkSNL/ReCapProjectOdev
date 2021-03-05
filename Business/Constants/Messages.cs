using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Car added.";
        public static string CarDetailInvalid = "Car name should at least have 2 characters and daily price should be higher than zero!";
        public static string CarListed = "Car listed.";
        public static string CarsListed = "Cars listed.";
        public static string CarDetailsListed = "Car details listed.";
        public static string CarsListedByColour = "Cars listed by the specified colour.";
        public static string CarsListedByBrand = "Cars listed by the specified brand.";
        public static string CarUpdated = "Car updated.";
        public static string CarRemoved = "Car removed.";
        public static string CarNameAlreadyExists = "This car is already in the database!";
         
        public static string BrandAdded = "Brand added.";
        public static string BrandUpdated = "Brand updated.";
        public static string BrandRemoved = "Brand removed.";
        public static string BrandsListed = "All brands listed.";
         
        public static string ColourAdded = "Colour added.";
        public static string ColourUpdated = "Colour updated.";
        public static string ColourRemoved = "Colour removed.";
        public static string ColoursListed = "All colours listed.";
         
        public static string UserAdded = "User added.";
        public static string UserUpdated = "User updated.";
        public static string UserDeleted = "User removed.";
        public static string UsersListed = "All users listed.";
         
        public static string CustomerAdded = "Customer added.";
        public static string CustomerUpdated = "Customer updated.";
        public static string CustomerDeleted = "Customer removed.";
        public static string CustomersListed = "All customers listed.";
         
        public static string RentalAdded = "Rental added.";
        public static string RentalUpdated = "Rental updated.";
        public static string RentalDeleted = "Rental removed.";
        public static string RentalsListed = "All rentals listed.";
        public static string RentalDetailsListed = "Rental details listed.";
        public static string AlreadyRented = "The car is already rented by another customer.";
         
        public static string CarImageLimitExceeded = "You cannot upload more than 5 images for the same car!";
         
        public static string AuthorisationDenied = "Authorisation denied!";
        public static string AccessTokenCreated = "Access Token Created.";
        public static string UserRegistered = "Registration successful.";
        public static string UserNotFound = "User not found!";
        public static string PasswordError = "Wrong password!";
        public static string SuccessfulLogin = "Login successful.";
        public static string UserAlreadyExists = "This email address is already in use!";
    }
}
