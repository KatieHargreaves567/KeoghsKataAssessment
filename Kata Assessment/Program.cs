using static Kata_Assessment.Classes.Product;
using static Kata_Assessment.Classes.Promotion;
using static Kata_Assessment.Classes.BasketItem;
using static Kata_Assessment.Classes.Basket;

var product = getProductBySKU("B");

Console.WriteLine("Product successfully loaded with: " + product.displayName + " at £" + product.unitPrice); //test

