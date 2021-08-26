/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function(nums, target) {
    let left = 0;
    let right = nums.length - 1;
    let sum = 0;
    let result = [0, 0];
    while (left < right) {
        sum = nums[left] + nums[right];
        if (sum == target) break;
        if (sum < target) ++left;
        else --right;
    }
    return result = [left, right];
};
let test1 = [3, 4, 22, 35];
let test2 = [1, 3, 5, 11, 13];
console.log(twoSum(test1, 7));
console.log(twoSum(test2, 14));