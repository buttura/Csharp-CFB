using System;

namespace Aula25 {
    class Program {
        static void Main(){
            Console.Write("Digite um valor: ");
            int v = Convert.ToInt32(Console.ReadLine());
            Dobrar(ref v);
            Console.WriteLine("O dobro de {0} é {1}", v/2, v);
        }
        static void Dobrar(ref int valor) {
            valor *= 2;
        }
    }
}