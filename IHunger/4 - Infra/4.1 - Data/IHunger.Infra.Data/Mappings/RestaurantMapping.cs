﻿using IHunger.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace IHunger.Infra.Data.Mappings
{
    public class RestaurantMapping : IEntityTypeConfiguration<Restaurant>
    {
        public void Configure(EntityTypeBuilder<Restaurant> builder)
        {
            builder.HasKey(r => r.Id);

            builder.Property(r => r.Name)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(r => r.Description)
               .IsRequired()
               .HasColumnType("varchar(200)");
            
            builder.Property(r => r.Image)
               .IsRequired()
               .HasColumnType("varchar(100)");

            builder.HasMany(r => r.Products)
                .WithOne(c => c.Restaurant)
                .HasForeignKey(c => c.RestaurantId);

            builder.HasMany(r => r.Comments)
                .WithOne(c => c.Restaurant)
                .HasForeignKey(c => c.RestaurantId);

            builder.ToTable("restaurant");
        }
    }
}
