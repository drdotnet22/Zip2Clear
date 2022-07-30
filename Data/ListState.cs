using Microsoft.EntityFrameworkCore;

namespace Zip2Clear.Data
{
    public class ListState
    {
        public IEnumerable<Declaration> declarations { get; set; }
        public IEnumerable<Vendor> vendors { get; set; } 
        public IEnumerable<Invoice> invoices { get; set; }
        public IEnumerable<Item> items { get; set; }
        public IEnumerable<Tariff> tariff { get; set; }
        public IEnumerable<Uom> uom { get; set; }
    }
}
