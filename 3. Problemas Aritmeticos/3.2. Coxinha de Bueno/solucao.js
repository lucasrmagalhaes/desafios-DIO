let line = gets().split(" ");

let H = parseInt(line[0]);
let P = parseInt(line[1]);

let media = (H/P).toFixed(2);

console.log(" " + media);