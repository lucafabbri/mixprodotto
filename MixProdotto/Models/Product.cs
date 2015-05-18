using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixProdotto.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Descritpion { get; set; }
        public double Quantity { get; set; }
        public Um Unit { get; set; }
        double Price { get; set; }
        public virtual List<Order> Orders { get; set; }
        public string CatalogId { get; set; }
        public virtual Catalog Catalog { get; set; }
        public virtual List<ApplicationUser> Lovers { get; set; }
    }
}
