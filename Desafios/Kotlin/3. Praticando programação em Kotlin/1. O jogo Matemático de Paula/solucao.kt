fun main(args: Array<String>) {  
    val N = readLine()!!.toInt()
    
    for (i in 1..N) {
        val range1 = 'A'..'Z'
        val range2 = 'a'..'z'
        
        val line = readLine()!!
        
        for (letter in range1) {
            if (line.contains(letter)) {
                val list = line.split(letter).map { it.toInt() }
                
                val N1 = list[0]
                val N2 = list[1]
                
                if (N1 == N2) {
                    println(N2 * N1)
                } else {
                    println(N2 - N1)
                }
            }
        }
        
        for (letter in range2) {
            if (line.contains(letter)) {
                val list = line.split(letter).map { it.toInt() }
                
                val N1 = list[0]
                val N2 = list[1]

                if (N1 == N2) {
                    println(N2 * N1)
                } else {
                    println(N2 + N1)
                }
            }
        }
    }
}