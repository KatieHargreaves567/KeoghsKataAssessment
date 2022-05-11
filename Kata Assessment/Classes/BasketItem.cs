using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_Assessment.Classes
{
    internal class BasketItem
    {
        public Product product { get; set; }
        public int quantity { get; set; }
        //item total accounts for promotion discounts
        public decimal itemTotal { get; set; }
        public BasketItem(Product product, int quantity)
        {
            this.product = product;
            this.quantity = quantity;

            //temporary
            this.itemTotal = product.unitPrice * quantity;
        }
    }
}
