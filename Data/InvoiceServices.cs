using Microsoft.EntityFrameworkCore;

namespace Zip2Clear.Data
{
    public class InvoiceServices
    {
        #region Private members
        private MyDbContext dbContext;
        #endregion

        #region Constructor
        public InvoiceServices(MyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        #endregion

        #region Public methods

        /// <summary>
        /// This method returns the list of invoice
        /// </summary>
        /// <returns></returns>
        public async Task<List<Invoice>> GetInvoiceAsync()
        {
            return await dbContext.Invoice.Include(i => i.Vendor).ToListAsync();
        }

        /// <summary>
        /// This method returns the list of invoices in a declaration
        /// </summary>
        /// <returns></returns>
        public async Task<List<Invoice>> GetInvoicesByDeclarationAsync(Declaration declaration)
        {
            return await dbContext.Invoice.Where(i => i.Declaration == declaration).Include(i => i.Vendor).ToListAsync();
        }

        /// <summary>
        /// This method add a new product to the DbContext and saves it
        /// </summary>
        /// <param name="invoice"></param>
        /// <returns></returns>
        public async Task<Invoice> AddInvoiceAsync(Invoice invoice)
        {
            try
            {
                dbContext.Invoice.Add(invoice);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return invoice;
        }

        /// <summary>
        /// This method update and existing product and saves the changes
        /// </summary>
        /// <param name="invoice"></param>
        /// <returns></returns>
        public async Task<Invoice> UpdateInvoiceAsync(Invoice invoice)
        {
            try
            {
                var invoiceExist = dbContext.Invoice.FirstOrDefault(p => p.InvoiceId == invoice.InvoiceId);
                if (invoiceExist != null)
                {
                    dbContext.Update(invoice);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return invoice;
        }

        /// <summary>
        /// This method removes and existing product from the DbContext and saves it
        /// </summary>
        /// <param name="invoice"></param>
        /// <returns></returns>
        public async Task DeleteInvoiceAsync(Invoice invoice)
        {
            try
            {
                dbContext.Invoice.Remove(invoice);
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