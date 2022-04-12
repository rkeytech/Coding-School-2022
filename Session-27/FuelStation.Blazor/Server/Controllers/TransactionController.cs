using FuelStation.Blazor.Shared;
using FuelStation.EF.Repositories;
using FuelStation.Model.Entities;
using FuelStation.Model.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Blazor.Server.Controllers
{
    //TODO: Create the transaction controller to work properly
    [ApiController]
    [Route("[controller]")]
    public class TransactionController : ControllerBase
    {
        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly TransactionHandler _transactionHandler;

        public TransactionController(IEntityRepo<Transaction> transactionRepo, TransactionHandler transactionHandler)
        {
            _transactionRepo = transactionRepo;
            _transactionHandler = transactionHandler;
        }

        [HttpGet]
        public async Task<IEnumerable<TransactionListViewModel>> Get()
        {
            var results = await _transactionRepo.GetAllAsync();
            return results.Select(x => new TransactionListViewModel
            {
                ID = x.ID,
                Date = x.Date,
                Employee = $"{x.Employee?.Surname} {x.Employee?.Name}",
                Customer = $"{x.Customer?.Surname} {x.Customer?.Name}",
                PaymentMethod = x.PaymentMethod.ToString(),
                TotalValue = x.TotalValue
            });
        }
        
        //[HttpGet("{id}")]
        //public async Task<ItemEditViewModel> Get(uint id)
        //{
        //    ItemEditViewModel viewmodel = new ItemEditViewModel();
        //    if (id != 0)
        //    {
        //        var foundItem = await _transactionRepo.GetByIdAsync(id);
        //        viewmodel.ID = foundItem.ID;
        //        viewmodel.Code = foundItem.Code;
        //        viewmodel.Description = foundItem.Description;
        //        viewmodel.Cost = foundItem.Cost;
        //        viewmodel.Price = foundItem.Price;
        //        viewmodel.ItemType = foundItem.ItemType;
        //    }
        //    return viewmodel;
        //}
        
        [HttpPost]
        public async Task Post(TransactionEditViewModel transaction)
        {
            var newTransaction = new Transaction()
            {
                EmployeeID = transaction.EmployeeID,
                CustomerID = transaction.CustomerID,
                PaymentMethod = transaction.PaymentMethod,
                TotalValue = _transactionHandler.CalculateTransactionTotalValue(
                                                    (List<double>)transaction.TransactionLines.Select(x => x.TotalValue)
                                                ),
            };
            
            await _transactionRepo.AddAsync(newTransaction);
        }

        [HttpDelete("{id}")]
        public async Task Delete(uint id)
        {
            await _transactionRepo.DeleteAsync(id);
        }

        //[HttpPut]
        //public async Task<ActionResult> Put(ItemEditViewModel item)
        //{
        //    var itemToUpdate = await _transactionRepo.GetByIdAsync(item.ID);
        //    if (itemToUpdate == null) return NotFound();
            
        //    itemToUpdate.Code = item.Code;
        //    itemToUpdate.Description = item.Description;
        //    itemToUpdate.Cost = item.Cost;
        //    itemToUpdate.Price = item.Price;
        //    itemToUpdate.ItemType = item.ItemType;

        //    await _transactionRepo.UpdateAsync(item.ID, itemToUpdate);
        //    return Ok();
        //}

    }
}
