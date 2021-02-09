using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColourService
    {
        List<Colour> GetAll();
        List<Colour> GetAllByColourId(int id);
        void Add(Colour colour);
        void Delete(Colour colour);
        void Update(Colour colour);
    }
}
