/**
 * @param {number[]} nums1
 * @param {number} m
 * @param {number[]} nums2
 * @param {number} n
 * @return {void} Do not return anything, modify nums1 in-place instead.
 */
const merge = function(nums1, m, nums2, n) {
    if (m === 0) {
        nums1 = nums2;
    } else {
        for (let i = m + n - 1; i > 0; i--) {
            if (nums1[m - 1] > nums2[n - 1] && m > 0) {
                nums1[i] = nums1[m - 1];
                --m;
            } else if (n > 0) {
                nums1[i] = nums2[n - 1];
                --n;
            };
        };
    };
    console.log(nums1);
};
merge([1, 2, 3, 0, 0, 0], 3, [2, 5, 6], 3);
merge([1], 1, [], 0);
merge([], 0, [1], 1);