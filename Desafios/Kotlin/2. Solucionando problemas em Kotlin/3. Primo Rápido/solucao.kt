import kotlin.math.sqrt

fun main() 
{
    val n = readLine()!!.toInt()
    
    for (i in 0 until n) {
        var x = readLine()!!.toDouble()
        val prime = isPrime(x)
        
        print(prime)
    }
}

fun print(prime: Boolean) 
{
    if (prime) {
        print("Prime\n")
    } else print("Not Prime\n")
}

fun isPrime(num: Double): Boolean 
{
    if (num < 2) return false
    if (num % 2 == 0.0) return num == 2.0
    
    val root = sqrt(num).toInt()
    var i = 3
    
    while (i <= root) {
        if (num % i == 0.0) return false
        i += 2
    }
    
    return true
}