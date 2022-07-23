// using System;

// class Program {
//   public static void Main (string[] args) {
//     Console.WriteLine ("Hello World");
//   }
// }


//Designing Daraz


/*
Component
  - iventory
    - items
        id, name, price, quantity, storeId, categoryId
    - category
      id, name, parentCategoryId
    - stores
      name, ownerId
    - sotreItems
      storeId, itemId
  - order
    - cart
      id, userId
    - cartItems
      itemId, quantity, cartId
    - order
      userId, cartId, paymentMethod, status (pending, prcoessing, payment recevied, dispatched, delivered)
    - paymentMethods
      id, name, type, credentails
  - users
    - user
      id, name, email. phonenumber, emailVerified, hasedPassword
    - login
  - promostion
    - sales
    - promo codes
      id, code, validFrom, validUntil, discountPrice
  - adds/compaines/
    id, add description, img, startFrom, endOn


  / POST: /api/processOrder/
{
promoCode: '',
  orderItems: [
{
id, quantity,
}
  ]
}

authenticate user -> verify quantity of items -> successfully place order 

quantity = 1000
item on sale (70%) -> 100,000

s3 => /aws.s3/daraz/adds/1233.png
*/
/*company promo ad

3 x 3
1 x 1

image sizes

ad name:
ad description:
ad image [add image] // s3 url

[save ad]

*/