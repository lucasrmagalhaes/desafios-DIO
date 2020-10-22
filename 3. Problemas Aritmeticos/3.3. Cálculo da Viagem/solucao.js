let line = gets().split(" ");

let H = parseInt(line[0]);
let P = parseInt(line[1]);

let media = (H*P)/12;

let mediaFinal = media.toFixed(3);

console.log(" " + mediaFinal);