using Microsoft.EntityFrameworkCore;

namespace Zip2Clear.Data
{
    public class DeclarationServices
    {
        #region Private members
        private MyDbContext dbContext;
        #endregion

        #region Constructor
        public DeclarationServices(MyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        #endregion

        #region Public methods
        /// <summary>
        /// This method returns the list of product
        /// </summary>
        /// <returns></returns>
        public async Task<List<Declaration>> GetDeclarationAsync()
        {
            return await dbContext.Declaration.ToListAsync();
        }

        /// <summary>
        /// This method add a new product to the DbContext and saves it
        /// </summary>
        /// <param name="declaration"></param>
        /// <returns></returns>
        public async Task<Declaration> AddDeclarationAsync(Declaration declaration)
        {
            try
            {
                dbContext.Declaration.Add(declaration);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return declaration;
        }

        /// <summary>
        /// This method update and existing product and saves the changes
        /// </summary>
        /// <param name="declaration"></param>
        /// <returns></returns>
        public async Task<Declaration> UpdateDeclarationAsync(Declaration declaration)
        {
            try
            {
                var declarationExist = dbContext.Declaration.FirstOrDefault(p => p.Id == declaration.Id);
                if (declarationExist != null)
                {
                    dbContext.Update(declaration);
                    await dbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return declaration;
        }

        /// <summary>
        /// This method removes and existing product from the DbContext and saves it
        /// </summary>
        /// <param name="declaration"></param>
        /// <returns></returns>
        public async Task DeleteDeclarationAsync(Declaration declaration)
        {
            try
            {
                dbContext.Declaration.Remove(declaration);
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
