/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
const twoSum = function(nums, target) {
    let result = {};
    for (let [index, num] of nums.entries()) {
        if (result[num] !== undefined) return [result[num], index];
        result[target - num] = index;
    }
};
let test1 = [3, 4, 22, 35];
let test2 = [1, 5, 6, 11, 13];
console.log(twoSum(test1, 7));
console.log(twoSum(test2, 17));