using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixProdotto.Models
{
    public class Order
    {
        public string Id { get; set; }
        public DateTime date { get; set; }
        public virtual List<Product> Products { get; set; }
        public string ClientId { get; set; }
        public virtual ApplicationUser Client { get; set; }
        public string SupplierId { get; set; }
        public virtual ApplicationUser Supplier { get; set; }
    }
}
