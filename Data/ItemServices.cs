using Microsoft.EntityFrameworkCore;

namespace Zip2Clear.Data
{
    public class ItemServices
    {
        #region Private members
        private MyDbContext dbContext;
        #endregion

        #region Constructor
        public ItemServices(MyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        #endregion

        #region Public methods
        /// <summary>
        /// This method returns the list of item
        /// </summary>
        /// <returns></returns>
        public async Task<List<Item>> GetItemAsync()
        {
            return await dbContext.Item.ToListAsync();
        }

        /// <summary>
        /// This method add a new item to the DbContext and saves it
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public async Task<Item> AddItemAsync(Item item)
        {
            try
            {
                dbContext.Item.Add(item);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return item;
        }

        /// <summary>
        /// This method update and existing item and saves the changes
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public async Task<Item> UpdateItemAsync(Item item)
        {
            try
            {
                var itemExist = dbContext.Item.FirstOrDefault(p => p.ItemId == item.ItemId);
                if (itemExist != null)
                {
                    dbContext.Update(item);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return item;
        }

        /// <summary>
        /// This method removes and existing item from the DbContext and saves it
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public async Task DeleteItemAsync(Item item)
        {
            try
            {
                dbContext.Item.Remove(item);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
