﻿using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailDto : IDto
    {
        public int CarId { get; set; }
        public string ModelName { get; set; }
        public string ColourName { get; set; }
        public string BrandName { get; set; }
        public decimal DailyPrice { get; set; }
        public DateTime Date { get; set; }
        public string ImagePath { get; set; }
    }
}
