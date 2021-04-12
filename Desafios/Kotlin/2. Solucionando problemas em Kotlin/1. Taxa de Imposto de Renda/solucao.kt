fun main(args: Array<String>) 
{
  fun Double.format(digits: Int) = "%.${digits}f".format(this).replace(',', '.')

  val valor = readLine()!!.toDouble()
  var imposto = 0.0
  var diferenca: Double

  if (valor > 4500) {
    imposto = 1000 * 0.08 + 1500 * 0.18
    diferenca = valor - 4500
    imposto += diferenca * 0.28
  } else if (valor > 3000) {
    imposto = 1000 * 0.08
    diferenca = valor - 3000
    imposto += diferenca * 0.18
  } else if (valor > 2000) {
    diferenca = valor - 2000
    imposto = diferenca * 0.08
  }
  
  if (imposto == 0.0) println("Isento") else println("R$ ${imposto.format(2)}")
}