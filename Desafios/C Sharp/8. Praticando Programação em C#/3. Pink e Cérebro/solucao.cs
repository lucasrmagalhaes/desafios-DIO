using System;

namespace Pink_E_Cerebro
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()),
                num, 
                cont2 = 0, 
                cont3 = 0, 
                cont4 = 0, 
                cont5 = 0;
      
            string[] numString = Console.ReadLine().Split();
      
            for (int i = 0; i < n; i++) {
                num = int.Parse(numString[i]);
          
                if (num % 2 == 0) {
                    cont2++;
                }
                
                if (num % 3 == 0) {
                    cont3++;
                }
                
                if (num % 4 == 0) {
                    cont4++;
                }
                
                if (num % 5 == 0) {
                    cont5++;
                }
            }
      
            Console.WriteLine($"{cont2} Multiplo(s) de 2\n" +
                                $"{cont3} Multiplo(s) de 3\n" +
                                $"{cont4} Multiplo(s) de 4\n" +
                                $"{cont5} Multiplo(s) de 5");
        }
    }
}