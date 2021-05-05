fun main(args: Array<String>) {
    var s: String
    var n: Int
    val r = "0x"
    
    while (true) {
        val s = readLine()!!
        
        try {
            val value = s.toInt()
            
            if (value == -1) {
                break
            }
        } catch (e: Exception) {}
        
        if (s.contains(r)) {
            hexaToDecimal(s)
        } else {
            decimalToHexa(s)
        }
    }
}

fun decimalToHexa(s: String) {
    val n = s.toInt()
    
    print("0x${Integer.toHexString(n).toUpperCase()}\n")
}

fun hexaToDecimal(s: String) {
    val hex = s.subSequence(2, s.length).toString()
    val n = Integer.parseInt(hex, 16)
    
    print("$n\n")
}