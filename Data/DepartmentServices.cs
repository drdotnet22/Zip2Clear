using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace Zip2Clear.Data
{
    public class DepartmentServices
    {
        #region Private members
        private MyDbContext dbContext;
        private InvoiceServices invoiceServices;
        #endregion

        #region Constructor
        public DepartmentServices(MyDbContext dbContext, InvoiceServices invoiceServices)
        {
            this.dbContext = dbContext;
            this.invoiceServices = invoiceServices;
        }

        #endregion

        #region Public methods
        public async Task<decimal> CalculateProcessingFeeAsync(Declaration declaration, Department department)
        {
            IEnumerable<Item> itemsInDeclaration = dbContext.Item.Where(i => i.Invoice.Declaration == declaration).Include(i => i.Invoice).ToList();
            IEnumerable<Item> itemsByDepartment = itemsInDeclaration.Where(i => i.Invoice.Department == department);
            decimal processingFee = 0;
            if (itemsInDeclaration.Any())
            {
                decimal itemsValue = 0;
                foreach (Item item in itemsByDepartment)
                {
                    itemsValue += item.Value;
                    if (item.Invoice.Shipping > 0)
                    {
                        decimal invoiceTotal = await invoiceServices.CalculateInvoiceTotalAsync(item.Invoice);
                        decimal itemsInInvoiceTotal = invoiceTotal - item.Invoice.Shipping;
                        decimal itemShippingPercentage = item.Value / itemsInInvoiceTotal;
                        decimal shippingOnItem = item.Invoice.Shipping * itemShippingPercentage;
                        itemsValue += shippingOnItem;
                    }
                }
                processingFee = itemsValue * 0.01m; //Processing fee is currently at 1%
            }
            return processingFee;
        }

        public async Task<decimal> CalculateEnvironmentalLevyAsync(Declaration declaration, Department department)
        {
            IEnumerable<Item> itemsInDeclaration = dbContext.Item.Where(i => i.Invoice.Declaration == declaration).Include(i => i.Invoice).ToList();
            IEnumerable<Item> itemsByDepartment = itemsInDeclaration.Where(i => i.Invoice.Department == department);
            decimal environmentalLevyTotal = 0;
            foreach (Item item in itemsByDepartment)
            {
                environmentalLevyTotal += item.EnvironmentalLevy;
            }
            return environmentalLevyTotal;
        }

        public async Task<decimal> CalculateShippingOnDepartmentBill(Declaration declaration, Department department)
        {
            IEnumerable<Item> itemsInDeclaration = dbContext.Item.Where(i => i.Invoice.Declaration == declaration).Include(i => i.Invoice).ToList();
            IEnumerable<Item> itemsByDepartment = itemsInDeclaration.Where(i => i.Invoice.Department == department);
            decimal shippingOnDepartmentItems = 0;
            foreach (Item item in itemsByDepartment)
            {
                decimal invoiceTotal = await invoiceServices.CalculateInvoiceTotalAsync(item.Invoice);
                shippingOnDepartmentItems += item.Invoice.Shipping * item.Value / (invoiceTotal - item.Invoice.Shipping);
            }
            return shippingOnDepartmentItems;
        }
        
        public async Task<DepartmentBillValues> CalculateDepartmentBill(Declaration declaration, Department department)
        {
            IEnumerable<Item> itemsInDeclaration = dbContext.Item.Where(i => i.Invoice.Declaration == declaration).Include(i => i.Invoice).ToList();
            IEnumerable<Item> itemsByDepartment = itemsInDeclaration.Where(i => i.Invoice.Department == department);
            
            //Total of items
            decimal itemsTotal = 0;
            foreach (Item item in itemsByDepartment)
            {
                itemsTotal += item.Value;
            }

            //Duty total
            decimal dutyTotal = 0;
            foreach (Item item in itemsByDepartment)
            {
                dutyTotal += item.Value * (item.TariffExciseRate + item.TariffGeneralRate);
            }

            //Shipping
            decimal shippingTotal = 0;
            foreach (Item item in itemsByDepartment)
            {
                decimal invoiceTotal = await invoiceServices.CalculateInvoiceTotalAsync(item.Invoice);
                shippingTotal += item.Invoice.Shipping * item.Value / (invoiceTotal - item.Invoice.Shipping);
            }

            //Environmental Levy
            decimal environmentalLevyTotal = 0;
            foreach (Item item in itemsByDepartment)
            {
                environmentalLevyTotal += item.EnvironmentalLevy;
            }

            //Processing Fee
            decimal processingFee = itemsTotal * 0.01m;

            //VAT
            decimal vat = (itemsTotal + dutyTotal + shippingTotal + environmentalLevyTotal + processingFee) * 0.1m;

            DepartmentBillValues values = new DepartmentBillValues();
            values.Shipping = shippingTotal;
            values.EnvironmentalLevy = environmentalLevyTotal;
            values.ProcessingFee = processingFee;
            values.VAT = vat;
            values.Total = shippingTotal + environmentalLevyTotal + processingFee + vat;
            return values;
        }
        #endregion
    }
    public class DepartmentBillValues()
    {
        public decimal Shipping { get; set; }
        public decimal EnvironmentalLevy { get; set; }
        public decimal ProcessingFee { get; set; }
        public decimal VAT { get; set; }
        public decimal Total { get; set; }
    }
}
