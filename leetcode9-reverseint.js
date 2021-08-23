/**
 * @param {number} x
 * @return {boolean}
 */
const isPalindrome = function(x) {
    var tempStr = x.toString();
    for (let i = 0; i < tempStr.length / 2; i++) {
        if (tempStr[i] != tempStr[tempStr.length - 1 - i]) {
            return false;
        }

    }
    return true;
};
console.log(isPalindrome(121));
console.log(isPalindrome(-121));
console.log(isPalindrome(10));
console.log(isPalindrome(-101));
console.log(isPalindrome(1000021));