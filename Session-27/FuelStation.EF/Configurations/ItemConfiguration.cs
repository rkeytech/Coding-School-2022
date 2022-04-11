using FuelStation.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Configurations
{
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasKey(employee => employee.ID);
            builder.Property(employee => employee.ID).ValueGeneratedOnAdd();

            builder.Property(employee => employee.Code).HasMaxLength(maxLength: 50);
            builder.Property(employee => employee.Description).HasMaxLength(maxLength: 250);
            builder.Property(employee => employee.Cost).HasPrecision(10, 2);
            builder.Property(employee => employee.Price).HasPrecision(10, 2);
        }
    }
}
