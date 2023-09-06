   let greeting = `Welcome to ES2015`;
    console.log(greeting);

    let name = 'JavaScript';
    console.log(`${name} is awesome!`);

    let num1 = 20;
    let num2 = 15;

    console.log(`Sum of ${num1} and ${num2} is ${num1 + num2}`);

    function doublemessage(number)
        {
            return (`Your number doubled is : ${number *2}`);
        }
   console.log(doublemessage(5));



function CreateProductStore(inv) {
        return {
          inv,
          invValue() {
            return this.inv.reduce(
              (total, product) => total + product.price,0);
          },
          getPrice(productId) {
            return this.inv.find((product) => product.id === productId).price;
          },
        };
      }


      const inv = [
        { id: 1, name: 'Bahubali', price: 399 },
        { id: 2, name: 'Timex watch', price: 1249 },
      ];



      const myProductStore = CreateProductStore(inv);

      console.log(myProductStore.getPrice(2));


/*=====================================================================*/

const calculateArea = function (l, w)
{
   return l * w;
}

let l = 8;
let w = 4;
console.log(`Area of rectangle is ${calculateArea(l, w)}`);

/*=================display multiple lines =========================================*/

var multiLineMessage = `Template literal 
                       example with 
                       multiple lines`;

console.log(multiLineMessage);

















      console.log(myProductStore.invValue());