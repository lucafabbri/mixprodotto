using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixProdotto.Models
{
    public class Catalog
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public virtual List<Product> Products { get; set; }
        public string SupplierId { get; set; }
        public virtual ApplicationUser Supplier { get; set; }
    }
}
