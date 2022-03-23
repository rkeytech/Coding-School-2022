using App.EF.Context;
using App.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.EF.Repository
{
    public class TransactionLineRepo : IEntityRepo<TransactionLine>
    {
        public async Task Create(TransactionLine entity)
        {
            using var context = new MyAppContext();
            context.TransactionLines.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            using var context = new MyAppContext();
            var foundTransactionLine = context.TransactionLines.SingleOrDefault(transLine => transLine.ID == id);
            if (foundTransactionLine is null)
                return;
            context.TransactionLines.Remove(foundTransactionLine);
            await context.SaveChangesAsync();
        }

        public List<TransactionLine> GetAll()
        {
            using var context = new MyAppContext();
            return context.TransactionLines.ToList();
        }

        public TransactionLine? GetById(Guid id)
        {
            using var context = new MyAppContext();
            return context.TransactionLines.Where(transLine => transLine.ID == id).SingleOrDefault();
        }

        public async Task Update(Guid id, TransactionLine entity)
        {
            using var context = new MyAppContext();
            var foundTransactionLine = context.TransactionLines.SingleOrDefault(transLine => transLine.ID == id);
            if (foundTransactionLine is null)
                return;
            await context.SaveChangesAsync();
        }
    }
}
