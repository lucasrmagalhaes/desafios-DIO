/**
 * Quantidade de Números Positivos
 * 
 * Desafio:
 * - Crie um programa que leia 6 valores. Você poderá receber valores negativos 
 * e/ou positivos como entrada, devendo desconsiderar os valores nulos. Em seguida, 
 * apresente a quantidade de valores positivos digitados.
 * 
 * Entrada:
 * - Você receberá seis valores, negativos e/ou positivos.
 * 
 * Saída:
 * - Exiba uma mensagem dizendo quantos valores positivos foram lidos assim como é 
 * exibido abaixo no exemplo de saída. Não esqueça da mensagem "valores positivos" ao final.
 */

numero = Array(6);

numero[0] = gets();
numero[1] = gets();
numero[2] = gets();
numero[3] = gets();
numero[4] = gets();
numero[5] = gets();

positivos = numero.filter(value => value > 0);

console.log(positivos.length + " valores positivos");