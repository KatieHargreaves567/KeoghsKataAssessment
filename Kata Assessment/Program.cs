using static Kata_Assessment.Classes.Product;
using static Kata_Assessment.Classes.Promotion;
using static Kata_Assessment.Classes.BasketItem;
using static Kata_Assessment.Classes.Basket;
using Kata_Assessment.Classes;

/* Note to user: the below code should demonstrate the exercise works as intended and act as a "how to" for using the application. 
 * See acknowledgements at the bottom of this file for any further info  */

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

/*
    Below code to test the second promotion
*/
product = getProductBySKU("D");
addItemToBasket(basket, getProductBySKU("D"), 2);
viewBasketContents(basket);
addItemToBasket(basket, getProductBySKU("D"), 1);
viewBasketContents(basket);
addItemToBasket(basket, getProductBySKU("D"), 1);
viewBasketContents(basket);

getBasketTotal(basket);

//note: Additional code could be easily added to give user feedback on when discounts have been applied, the name of the discount
//Acknowledgements

//known bug: basket.basketItems.clear(); does not behave as expected - This could accrue technical debt if not resolved
//Dirty fix would be a "clear basket" method which calls "addItemToBasket" for all items to remove
//More competent fix would require deeper understanding as to why the call causes problems

//line 21 in Basket.cs is potentially inefficient (there should only ever be one instance of an individual product in the basket)

//active flag can be tweaked in Promotion.cs, but may be beyond the scope of the exercise
//that said, if a promotion expires at midnight and the basket is filled at 11:59, even if checkout occurs after midnight, the discount will be honoured
//not sure if this is behaviour as intended (in my experience, it isn't)

//foreach could have been used instead of for i < item.count loops for improved readability

//and as a final acknowledgement, this project was enjoyable to put together (frustrations with VS/Github notwithstanding)






