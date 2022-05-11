using static Kata_Assessment.Classes.Product;
using static Kata_Assessment.Classes.Promotion;
using static Kata_Assessment.Classes.BasketItem;
using static Kata_Assessment.Classes.Basket;
using Kata_Assessment.Classes;

//initialise basket
var basket = new Basket();
/* 
 Below code to test if item will add to basket, if quantities can be edited, if items can be removed and if a negative quantity is invalid
*/
var product = getProductBySKU("B");

addItemToBasket(basket, product, 1);
viewBasketContents(basket);

addItemToBasket(basket, product, 1);
viewBasketContents(basket);

addItemToBasket(basket, product, -1);
viewBasketContents(basket);

addItemToBasket(basket, product, -3);
viewBasketContents(basket);


/*
 Below code to test a basket with different types of items
 */
addItemToBasket(basket, product, 5);
viewBasketContents(basket);

product = getProductBySKU("C");
addItemToBasket(basket, product, 3);
viewBasketContents(basket);

/*
    Below code to test the first promotion
*/
addItemToBasket(basket, product, -3);
product = getProductBySKU("B");
addItemToBasket(basket, product, -5);


addItemToBasket(basket, product, 1);
addItemToBasket(basket, product, 1);
viewBasketContents(basket);
addItemToBasket(basket, product, 1);
viewBasketContents(basket);
addItemToBasket(basket, product, 10);
viewBasketContents(basket);