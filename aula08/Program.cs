using System;

namespace Aula08 {
    class Program {
        static void Main(){
            int v1, v2;
            Console.Write("Digite o primeiro valor: ");
            v1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            v2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A soma entre os números {0} e {1} é {2}",v1,v2,v1+v2);
        }
    }
}