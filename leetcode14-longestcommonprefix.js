/**
 * @param {string[]} strs
 * @return {string}
 */
var longestCommonPrefix = function(strs) {
    if (strs.length === 0) {
        return "";
    };
    strs.sort();
    let result = strs[0];
    if (strs[strs.length - 1].startsWith(result)) {
        return result;
    }
    for (let i = 0; i < result.length; i++) {
        if (result[i] !== strs[strs.length - 1][i]) {
            return result.substr(0, i);
        }
    }
};