using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata_Assessment.Classes
{
    internal class Basket
    {
        public List<BasketItem> basketItems { get; set; }

        public Basket()
        {
            this.basketItems = new List<BasketItem> ();
        }

        public static void addItemToBasket(Basket basket, Product product, int quantityToAdd)
        {
            //if item already in basket, adjust its quantity
            var basketItem = basket.basketItems.FindAll(x => x.product.SKU == product.SKU).FirstOrDefault();
            if (basketItem != null)
            {
                var itemIndex = basket.basketItems.FindIndex(x => x.product.SKU == product.SKU);
                var currentQuantity = basket.basketItems[itemIndex].quantity;
                //allow the basketItem constructor to handle the logic, treating new basket additions and edits as the same - KH
                basket.basketItems.RemoveAt(itemIndex);

                //allow quantityToAdd to be negative to remove items. Below if statement ensures non-negative basket quantity - KH
                if (Math.Max(0, currentQuantity + quantityToAdd) > 0)
                {
                    basketItem = new BasketItem(product, currentQuantity + quantityToAdd);
                    basket.basketItems.Add(basketItem);

                    var addedRemovedString = quantityToAdd < 0 ? "removed from" : "added to";
                    Console.WriteLine(quantityToAdd + "x " + product.displayName + " successfully " + addedRemovedString + " your basket!");
                    Console.WriteLine("\n");
                }
                else 
                {
                    Console.WriteLine(currentQuantity + "x " + product.displayName + " successfully removed from your basket!");
                }
            }
            //else, add it
            else
            {
                if (Math.Max(0, quantityToAdd) > 0)
                {
                    basketItem = new BasketItem(product, quantityToAdd);
                    basket.basketItems.Add(basketItem);
                    Console.WriteLine(quantityToAdd + "x " + product.displayName + " successfully added to your basket!");
                    Console.WriteLine("\n");
                }
            }
        }

        public static void viewBasketContents(Basket basket)
        {
            Console.WriteLine("Hello customer, your basket currently contains: ");
            for (int i = 0; i < basket.basketItems.Count; i++)
            {
                var quantity = basket.basketItems[i].quantity;
                var product = basket.basketItems[i].product.displayName;
                var itemTotal = basket.basketItems[i].itemTotal;

                Console.WriteLine(quantity + "x " + product + " at £" + itemTotal);
            }
            Console.WriteLine("\n");
        }

        public static void getBasketTotal(Basket basket)
        {
            decimal total = 0;
            Console.WriteLine("Hello customer, the total for your basked (including promotions!) is: ");
            for (int i = 0; i < basket.basketItems.Count; i++)
            {
                var quantity = basket.basketItems[i].quantity;
                var product = basket.basketItems[i].product.displayName;
                var itemTotal = basket.basketItems[i].itemTotal;

                total += itemTotal;

                Console.WriteLine(quantity + "x " + product + " at £" + itemTotal);
            }
            Console.WriteLine("£" + total);
        }
    }
}
