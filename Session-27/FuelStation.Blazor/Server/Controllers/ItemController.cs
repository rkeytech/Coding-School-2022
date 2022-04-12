using FuelStation.Blazor.Shared;
using FuelStation.EF.Repositories;
using FuelStation.Model.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Blazor.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly IEntityRepo<Item> _itemRepo;

        public ItemController(IEntityRepo<Item> itemRepo)
        {
            _itemRepo = itemRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<ItemListViewModel>> Get()
        {
            var results = await _itemRepo.GetAllAsync();
            return results.Select(x => new ItemListViewModel
            {
                ID = x.ID,
                Code = x.Code,
                Description = x.Description,
                Cost = x.Cost,
                Price = x.Price,
                ItemType = x.ItemType.ToString()
            });
        }
        
        [HttpGet("{id}")]
        public async Task<ItemEditViewModel> Get(uint id)
        {
            ItemEditViewModel viewmodel = new ItemEditViewModel();
            if (id != 0)
            {
                var foundItem = await _itemRepo.GetByIdAsync(id);
                viewmodel.ID = foundItem.ID;
                viewmodel.Code = foundItem.Code;
                viewmodel.Description = foundItem.Description;
                viewmodel.Cost = foundItem.Cost;
                viewmodel.Price = foundItem.Price;
                viewmodel.ItemType = foundItem.ItemType;
            }
            return viewmodel;
        }
        
        [HttpPost]
        public async Task Post(ItemEditViewModel item)
        {
            var newItem = new Item()
            {
                Code = item.Code,
                Description = item.Description,
                Cost = item.Cost,
                Price = item.Price,
                ItemType = item.ItemType
            };
            
            await _itemRepo.AddAsync(newItem);
        }

        [HttpDelete("{id}")]
        public async Task Delete(uint id)
        {
            await _itemRepo.DeleteAsync(id);
        }

        [HttpPut]
        public async Task<ActionResult> Put(ItemEditViewModel item)
        {
            var itemToUpdate = await _itemRepo.GetByIdAsync(item.ID);
            if (itemToUpdate == null) return NotFound();
            
            itemToUpdate.Code = item.Code;
            itemToUpdate.Description = item.Description;
            itemToUpdate.Cost = item.Cost;
            itemToUpdate.Price = item.Price;
            itemToUpdate.ItemType = item.ItemType;

            await _itemRepo.UpdateAsync(item.ID, itemToUpdate);
            return Ok();
        }

    }
}
