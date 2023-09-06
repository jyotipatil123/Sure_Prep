function sum(...params) {
   return params.reduce((previous, current) => {
      return previous + current;
   });
}
console.log(sum(1, 2, 3));
console.log(sum(1, 2, 3, 4));
