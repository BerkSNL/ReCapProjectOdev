using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarContext context = new CarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join co in context.Colours
                             on c.ColourId equals co.Id
                             select new CarDetailDto
                             {
                                 ModelName = c.ModelName,
                                 CarId = c.Id,
                                 ColourName = co.ColourName,
                                 BrandName = b.BrandName,
                                 DailyPrice = c.DailyPrice
                             };

                return result.ToList();
            }
        }
    }
}
