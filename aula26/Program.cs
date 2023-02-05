using System;

namespace Aula26 {
    class Program {
        static void Main() {
            int pn, sn, subtrair, multiplicar, soma, quociente, resto;
            Console.Write("Digite o primeiro valor: ");
            pn = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            sn = Convert.ToInt32(Console.ReadLine());
            soma = ASMD(ref pn, ref sn, out subtrair, out multiplicar, out quociente, out resto);
            Console.WriteLine("{0} + {1} = {2}\n{0} - {1} = {3}\n{0} x {1} = {4}\n{0} / {1} = {5} e resta {6}", pn, sn, soma, subtrair, multiplicar, quociente, resto);
        }

        static int ASMD(ref int valor1, ref int valor2, out int subtrair, out int multiplicar, out int quociente, out int resto) {
            int soma = valor1 + valor2;
            subtrair = valor1 - valor2;
            multiplicar = valor1 * valor2;
            quociente = valor1 / valor2;
            resto = valor1%valor2;
            return soma;
        }
    }
}