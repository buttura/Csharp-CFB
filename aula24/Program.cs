using System;

namespace Aula24 {
    class Program {
        static void Main() {
            int v1, v2, res;
            Console.Write("Número 1: ");
            v1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Número 2: ");
            v2 = Convert.ToInt32(Console.ReadLine());
            res = soma(ref v1, ref v2);
            Console.WriteLine("A soma de {0} e {1} é {2}",v1, v2, res);
        }

        static int soma(ref int n1, ref int n2){
            int res = n1+n2;
            return res;
        }
    }
}
