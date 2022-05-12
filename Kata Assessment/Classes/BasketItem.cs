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
            this.itemTotal = getDiscountedPrice(product, quantity);
        }

        public static decimal getDiscountedPrice(Product product, int quantity)
        {
            if (product.applicablePromotion == null)
            {
                return product.unitPrice * quantity;
            }
            if (product.applicablePromotion.promotionDisplayName == "3 for £40" && product.applicablePromotion.promotionActive)
            {
                //discountFrequency added for similar promotions (e.g. 2 for £20) for code re-use
                int discountFrequency = 3;
                int quantityNotDiscounted = quantity % discountFrequency;
                int numberOfSatisfiedPromotions = (quantity - (quantity % discountFrequency))/discountFrequency;
                decimal promotionPrice = 40;

                return (numberOfSatisfiedPromotions * promotionPrice) + (quantityNotDiscounted * product.unitPrice);  
            }
            else if (product.applicablePromotion.promotionDisplayName == "25% off for every 2 purchased together" && product.applicablePromotion.promotionActive)
            {
                int discountFrequency = 2;
                int quantityNotDiscounted = quantity % discountFrequency;
                int quantityDiscounted = (quantity - (quantity % discountFrequency));
                //NB: confirm with relevant people which way to round in case of fractions of pence
                decimal discountPercentage = 25;

                return (quantityDiscounted * product.unitPrice) * ((100-discountPercentage) / 100) + (quantityNotDiscounted * product.unitPrice);

            }
            else
            {
                return product.unitPrice * quantity;
            }
        }
    }
}
