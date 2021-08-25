/**
 * @param {number} x
 * @return {number}
 */
var reverse = function(x) {
    x = x.toString();
    let result = x.split("").reverse().join("");
    result = parseInt(result);
    if (result > 2 ** 31 - 1) return 0;
    return x < 0 ? -result : result;
};
let test1 = 123;
let test2 = -123;
let test3 = 120;
let test4 = 0;
console.log(reverse(test1));
console.log(reverse(test2));
console.log(reverse(test3));
console.log(reverse(test4));