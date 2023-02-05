using System;

namespace Aula08_1 {
    class Program{
        static void Main(){
            float v1, v2;
            int op;
            int res=1;

            Console.Write("Digite o Primeiro Valor: ");
            v1 = float.Parse(Console.ReadLine());
            Console.Write("Digite o Segundo Valor: ");
            v2 = float.Parse(Console.ReadLine());
            while (res == 1) {
                Console.WriteLine("--=--=--=--=--=--=--");
                Console.WriteLine("[ 1 ] Adição");
                Console.WriteLine("[ 2 ] Subtração");
                Console.WriteLine("[ 3 ] Multiplicação");
                Console.WriteLine("[ 4 ] Divisão");
                Console.WriteLine("--=--=--=--=--=--=--");
                Console.Write("Sua opção: ");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op) {
                    case (1):
                        Console.WriteLine("A Adição entre os números {0} e {1} é {2}",v1,v2, v1+v2);
                        break;
                    case (2):
                        Console.WriteLine("A Subtração entre os números {0} e {1} é {2}",v1,v2, v1-v2);
                        break;
                    case (3):
                        Console.WriteLine("A Multiplicação entre os números {0} e {1} é {2}",v1,v2, v1*v2);
                        break;
                    case (4):
                        Console.WriteLine("A divisão entre os números {0} e {1} é {2}",v1,v2, v1/v2);
                        break;
                    default:
                        Console.WriteLine("Refaça o Processo");
                        break;
                }
                Console.WriteLine("Deseja continuar? ");
                Console.WriteLine("[Sim] = 1 | [Não] = 0");
                res = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Obrigado! Volte Sempre!");
        }
    }
}