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
    internal class TransactionLineConfiguration : IEntityTypeConfiguration<TransactionLine>
    {
        public void Configure(EntityTypeBuilder<TransactionLine> builder)
        {
            builder.HasKey(transaction => transaction.ID);

            builder.HasOne(transactionLine => transactionLine.Transaction).WithMany(transaction => transaction.TransactionLines).HasForeignKey(transaction => transaction.TransactionID);
            builder.HasOne(transactionLine => transactionLine.Engineer).WithOne().HasForeignKey<TransactionLine>(transactionLine => transactionLine.EngineerID);
            builder.HasOne(transactionLine => transactionLine.ServiceTask).WithOne().HasForeignKey<TransactionLine>(transactionLine => transactionLine.ServiceTaskID);
        }
    }
}
