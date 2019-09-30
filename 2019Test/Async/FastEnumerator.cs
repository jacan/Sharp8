using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace _2019Test.Async
{
    public class FastEnumerator
    {
        public async IAsyncEnumerable<WarehouseItem> GetAllWorkhouseItemsAsync()
        {
            for (int i = 0; i < 10; i++)
            {
                var randum = new Random();
                await Task.Delay(randum.Next(100, 2000));
                
                var newWarehouseItem = new WarehouseItem() { AmountOnShelf = 1 };
                yield return newWarehouseItem;

                
            }
        }
    }
}

