/**
 * @param {number[]} nums
 * @return {number}
 */
const rob = function(nums) {
    if (nums.length == 0) return 0;
    let temperArr = new Array(0,0);
    temperArr[1] = nums[0];
    for (let i = 2; i <= nums.length; ++i) {
        temperArr[i] = temperArr[i - 1] > nums[i - 1] + temperArr[i - 2] ? temperArr[i - 1] : nums[i - 1] + temperArr[i - 2];
        console.log(temperArr[i]);
    };
    return temperArr[nums.length];
};
let numstest = [2, 7, 9, 3, 1];
let numstest1 = [1, 2, 3, 1];
console.log(rob(numstest));
console.log("_________________")
console.log(rob(numstest1));
