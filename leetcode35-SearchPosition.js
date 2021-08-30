/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number}
 */
var searchInsert = function(nums, target) {
    let i = 0
    for (i = 0; i < nums.length; i++) {
        if (target <= nums[i]) break;
    }
    return i;
};
// if (nums.indexOf(target) === -1) {
//     let tempArr = nums.push(target);
//     return tempArr.sort().indexOf(target);
// } else {
//     return nums.indexOf(target);
// };
let numstest = [2, 7, 9, 3, 1];
let numstest1 = [1, 3, 5, 6];
console.log(searchInsert(numstest, 9));
console.log("_________________")
console.log(searchInsert(numstest1, 7));