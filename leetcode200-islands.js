/**
 * @param {character[][]} grid
 * @return {number}
 */
const numjslands = (grid) => {
    let number = 0;
    for (let i = 0; i < grid.length; i++) {
        for (let j = 0; j < grid[0].length; j++) {
            if (grid[i][j] == '1') {
                number++;
                search(i, j, grid);
            }
        }
    }
    return number;
};
const search = (i, j, grid) => {
    if (i < 0 || j < 0 || i >= grid.length || j >= grid[0].length || grid[i][j] != '1') return;
    grid[i][j] = '2';
    search(i + 1, j, grid);
    search(i, j + 1, grid);
    search(i - 1, j, grid);
    search(i, j - 1, grid);

};

let testgrid = [
    ["1", "1", "1", "1", "0"],
    ["1", "1", "0", "1", "0"],
    ["1", "1", "0", "0", "0"],
    ["0", "0", "0", "0", "0"]
];
console.log(numjslands(testgrid));