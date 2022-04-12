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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(customer => customer.ID);
            builder.Property(customer => customer.ID).ValueGeneratedOnAdd();

            builder.Property(customer => customer.Username).HasMaxLength(maxLength: 50);
            builder.Property(customer => customer.Password).HasMaxLength(maxLength: 50);

            builder.HasOne(employee => employee.Employee).WithOne()
                   .HasForeignKey<User>(user => user.EmployeeID)
                   .IsRequired(true);
        }
    }
}
