numero = Array(6);
numero[0] = gets();
numero[1] = gets();
numero[2] = gets();
numero[3] = gets();
numero[4] = gets();
numero[5] = gets();
positivos = numero.filter(value => value > 0);
console.log(positivos.length + " valores positivos");