fun main(args: Array<String>) 
{
    val lista = mutableListOf<Int>()
    
    for (i in 1..readLine()!!.toInt()) {
        val input = readLine()!!.split(" ").map { it.toInt() }
        
        input.forEach { number ->
            lista.add(number)
        }

        println(mdc(lista[0], lista[1]))
        
        lista.clear()
    }
}

fun mdc(n1: Int, n2: Int): Int 
{
    return if (n2 == 0) {
        n1
    } else {
        mdc(n2, (n1 % n2))
    }
}