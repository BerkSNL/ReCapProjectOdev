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
        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            using (CarContext context = new CarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join co in context.Colours
                             on c.ColourId equals co.Id
                             join ci in context.CarImages
                             on c.Id equals ci.CarId
                             select new CarDetailDto
                             {
                                 ModelName = c.ModelName,
                                 CarId = c.Id,
                                 ColourName = co.ColourName,
                                 BrandName = b.BrandName,
                                 DailyPrice = c.DailyPrice,
                                 Date = ci.Date,
                                 ImagePath = ci.ImagePath
                             };

                return result.ToList();
            }
        }
    }
}
