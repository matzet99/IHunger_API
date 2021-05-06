﻿using IHunger.Domain.Interfaces.Repository;
using IHunger.Domain.Models;
using IHunger.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace IHunger.Infra.Data.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(DataIdentityDbContext db) : base(db)
        {
        }
    }
}
