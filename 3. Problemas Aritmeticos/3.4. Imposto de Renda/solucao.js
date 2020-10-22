let calc = gets();
calc = parseFloat(calc);

if (calc<=2000){
  console.log('Isento');
} else if (calc<=3000) {
  segundaFaixa = (calc - 2000)*0.08;
  result = parseFloat(segundaFaixa);
  result = result.toFixed(2);
  console.log('R$ ' + result);
} else if (calc<=4500) {
    aux1 = calc - 2000;
    aux2 = calc - 3000;
    aux2 = aux2>=0 ? aux2 : 0;
    segundaFaixa = ((calc - 2000)-aux2)* 0.08;
    terceiraFaixa = (calc - 3000) * 0.18;
    result = parseFloat(segundaFaixa+terceiraFaixa);
    result = result.toFixed(2);
      console.log('R$ ' + result);
} else {
    aux1 = calc - 2000;
    aux2 = calc - 3000;
    aux3 = calc - 4500;
    aux2 = aux2>=0 ? aux2 : 0;
    aux3 = aux3>=0 ? aux3 : 0;
    segundaFaixa = ((calc - 2000)-aux2)* 0.08;
    terceiraFaixa = ((calc - 3000)-aux3) * 0.18;
    quartaFaixa =  (calc-4500) * 0.28;
    result = parseFloat(segundaFaixa+terceiraFaixa+quartaFaixa);
    result = result.toFixed(2);
   console.log('R$ ' + result);
}