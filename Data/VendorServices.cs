using Microsoft.EntityFrameworkCore;

namespace Zip2Clear.Data
{
    public class VendorServices
    {
        #region Private members
        private MyDbContext dbContext;
        #endregion

        #region Constructor
        public VendorServices(MyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        #endregion

        #region Public methods

        /// <summary>
        /// This method returns the list of invoice
        /// </summary>
        /// <returns></returns>
        public async Task<List<Vendor>> GetVendorAsync()
        {
            return await dbContext.Vendor.ToListAsync();
        }

        /// <summary>
        /// This method add a new product to the DbContext and saves it
        /// </summary>
        /// <param name="vendor"></param>
        /// <returns></returns>
        public async Task<Vendor> AddVendorAsync(Vendor vendor)
        {
            try
            {
                dbContext.Vendor.Add(vendor);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return vendor;
        }

        /// <summary>
        /// This method update and existing product and saves the changes
        /// </summary>
        /// <param name="vendor"></param>
        /// <returns></returns>
        public async Task<Vendor> UpdateVendorAsync(Vendor vendor)
        {
            try
            {
                var vendorExist = dbContext.Vendor.FirstOrDefault(p => p.Id == vendor.Id);
                if (vendorExist != null)
                {
                    dbContext.Update(vendor);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return vendor;
        }

        /// <summary>
        /// This method removes and existing product from the DbContext and saves it
        /// </summary>
        /// <param name="vendor"></param>
        /// <returns></returns>
        public async Task DeleteVendorAsync(Vendor vendor)
        {
            try
            {
                dbContext.Vendor.Remove(vendor);
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