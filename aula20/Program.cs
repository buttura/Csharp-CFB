using System;

namespace Aula20 {
    class Program {
        static void Main(){
            int[] num = new int[10];
            int i = num.Length-1;

            while (i > 0) {
                Console.WriteLine(num[i]);
                num[i] = 0;
                i--;
            }

            for(int p = 0; p < num.Length; p++) {
                Console.WriteLine("Valor da {0}o posição: {1}", i, num[i]);
            }
            Console.WriteLine("Fim do Loop");
        }
    }
}
