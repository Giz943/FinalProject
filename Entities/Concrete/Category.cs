﻿using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class Category : IEntity
    {
        //Çıplak class kalmasın
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        //deneme
    }
}
