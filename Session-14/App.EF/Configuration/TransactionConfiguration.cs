using App.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.EF.Configuration
{
    internal class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasKey(transaction => transaction.ID);

            builder.HasOne(transaction => transaction.Manager).WithOne().HasForeignKey<Transaction>(transaction => transaction.ManagerID);
            builder.HasOne(transaction => transaction.Customer).WithOne().HasForeignKey<Transaction>(transaction => transaction.CustomerID);
            builder.HasOne(transaction => transaction.Car).WithOne().HasForeignKey<Transaction>(transaction => transaction.CarID);
        }
    }
}
