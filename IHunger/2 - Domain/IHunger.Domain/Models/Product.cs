﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IHunger.Domain.Models
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public Boolean Vegan { get; set; }
        public Boolean Vegetarian { get; set; }
        public Boolean Kosher { get; set; }
        public string Image { get; set; }

        #region EFCRelations
        public CategoryProduct CategoryProduct { get; set; }
        public IEnumerable<Item> Items { get; set; }

        #endregion
    }
}