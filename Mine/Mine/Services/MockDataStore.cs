using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mine.Models;

namespace Mine.Services
{
    public class MockDataStore : IDataStore<ItemModel>
    {
        readonly List<ItemModel> items;

        public MockDataStore()
        {
            items = new List<ItemModel>()
            {
                new ItemModel { Id = Guid.NewGuid().ToString(), Text = "Cookie", Description="Increase Calories by 200.", Value=5},
                new ItemModel { Id = Guid.NewGuid().ToString(), Text = "Beard", Description="Increase manliness by 1000." , Value=1},
                new ItemModel { Id = Guid.NewGuid().ToString(), Text = "Extra arm", Description="Increase Dexterity by 100." , Value=4},
                new ItemModel { Id = Guid.NewGuid().ToString(), Text = "Angel wings", Description="You can escape from a losing battle.", Value=3 },
                new ItemModel { Id = Guid.NewGuid().ToString(), Text = "Devil fruit", Description="Grants user special attack granted by the devil but at a cost...", Value=2 }
            };
        }

        public async Task<bool> AddItemAsync(ItemModel item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(ItemModel item)
        {
            var oldItem = items.Where((ItemModel arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((ItemModel arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<ItemModel> ReadAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<ItemModel>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}