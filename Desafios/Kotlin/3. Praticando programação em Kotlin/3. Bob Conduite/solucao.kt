import java.util.Scanner

fun main() {
    for (i in 1..readLine()!!.toInt()) {
        val canos = readLine()!!.split(" ").map { 
            it.toInt() 
        }
        
        val r1 = canos[0]
        val r2 = canos[1]
        
        println(r1 + r2)
    }
}