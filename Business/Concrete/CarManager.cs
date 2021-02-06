using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _iCarDal;

        public CarManager(ICarDal iCarDal)
        {
            _iCarDal = iCarDal;
        }

        public List<Car> GetAll()
        {
            return _iCarDal.GetAll();
        }

        public List<Car> GetAllByBrand(int brandId)
        {
            return _iCarDal.GetAll(c => c.Id == brandId);
        }

        public List<Car> GetAllByColour(int colourId)
        {
            return _iCarDal.GetAll(c => c.Id == colourId);
        }

    }
}
