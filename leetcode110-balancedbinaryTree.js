/**
 * Definition for a binary tree node.
 * function TreeNode(val, left, right) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.left = (left===undefined ? null : left)
 *     this.right = (right===undefined ? null : right)
 * }
 */
/**
 * @param {TreeNode} root
 * @return {boolean}
 */
var isBalanced = function(root) {
    return getH(root) >= 0;
};
var getH = function(root) {
    if (root == null) {
        return 0;
    };
    let leftH = getH(root.left);
    let rightH = getH(root.right);
    if (leftH >= 0 && rightH >= 0 && Math.abs(leftH - rightH) <= 1) {
        return Math.max(leftH, rightH) + 1;
    } else {
        return -1;
    }
}