using System;

namespace Aula27 {
    class Program {
        static void Main(){
            string res = "";
            int[] valores = {};
            while(res != "N") {
                Console.WriteLine("Digite um valor: ");
                valores = valores.Concat(new int[] {Convert.ToInt32(Console.ReadLine())}).ToArray();
                Console.Write("Deseja Continuar? [S/N] ");
                res = Console.ReadLine();
            }
            soma(valores);
        }

        static void soma(params int[]n){
            int sv = 0;
            if (n.Length < 1) {
                Console.WriteLine("Valores Insuficientes");
            } else if (n.Length < 2) {
                Console.WriteLine("Você digitou apenas um valor, o número {0}",n[0]);
            } else {
                for(int i = 0; i < n.Length; i++) {
                    sv += n[i];
                }
                Console.WriteLine("A soma dos valores é {0}", sv);
            }

        }
    }
}