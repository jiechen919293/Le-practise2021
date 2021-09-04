// Definition for a binary tree node.
function TreeNode(val, left, right) {
    this.val = (val === undefined ? 0 : val)
    this.left = (left === undefined ? null : left)
    this.right = (right === undefined ? null : right)
}

/**
 * @param {TreeNode} root
 * @return {number[]}
 */
var postorderTraversal = function(root) {
    let number = [];
    if (root === null) {
        return number;
    }
    const order = function(node, result) {
        if (node === null) return;
        order(node.left, result);
        order(node.right, result);
        result.push(node.val);
    }
    order(root, number);
    return number;
};