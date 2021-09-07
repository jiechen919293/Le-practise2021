/**
 * Definition for singly-linked list.*/
function ListNode(val, next) {
    this.val = (val === undefined ? 0 : val)
    this.next = (next === undefined ? null : next)
}

/**
 * @param {ListNode} l1
 * @param {ListNode} l2
 * @return {ListNode}
 */
var mergeTwoLists = function(l1, l2) {
    let result = new ListNode();
    let tempNode = result;
    while (l1 !== null && l2 !== null) {
        if (l1.val <= l2.val) {
            tempNode.next = l1;
            l1 = l1.next;
        } else {
            tempNode.next = l2;
            l2 = l2.next;
        }
        tempNode = tempNode.next;
    }
    tempNode.next = l1 ? l1 : l2;
    return result.next;
};
console.log(mergeTwoLists([1, 2, 4], [1, 3, 4]));