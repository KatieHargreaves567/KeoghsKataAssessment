using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Kata_Assessment.Classes.Promotion;

namespace Kata_Assessment.Classes
{
    internal class Product
    {
        public string SKU { get; set; }
        public string displayName { get; set; }
        public decimal unitPrice { get; set; }
        public Promotion? applicablePromotion { get; set; }

        public Product(string SKU, string displayName, decimal unitPrice, Promotion applicablePromotion)
        {
            this.SKU = SKU;
            this.displayName = displayName;
            this.unitPrice = unitPrice;
            this.applicablePromotion = applicablePromotion;
        }
       
        //Note: in a database-driven application, the below method would be a database call
        public static Product getProductBySKU(string SKU)
        {
            if (SKU == "A")
            {
                return new Product("A", "Luxury Dice Bag", 10, null);
            }
            else if (SKU == "B")
            {
                return new Product("B", "Clear Resin Dice Set", 15, getPromotionByID(1));
            }
            else if (SKU == "C")
            {
                return new Product("C", "Wingspan 2nd Edition", 40, null);
            }
            else if (SKU == "D")
            {
                return new Product("D", "Premium Hollow Metal Dice Set", 55, getPromotionByID(2));
            }
            //add error-trapping below
            else
            {
                return null;
            }
        }
    }
}

