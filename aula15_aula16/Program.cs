using System;

namespace Aula15 {
    class Program {
        static void Main(){

            float tempo = 0;
            char escolha;

            inicio: 

            Console.Clear();

            Console.WriteLine("Belo Horizonete/MG a Vitória/ES");
                Console.WriteLine("Escolha o transporte: ");
                Console.WriteLine("--==--==--==--");
                Console.WriteLine("[ A ] Avião");
                Console.WriteLine("[ C ] Carro");
                Console.WriteLine("[ O ] Ônibus");
                Console.WriteLine("--==--==--==--");
                Console.Write("Sua opção: ");
                escolha = char.Parse(Console.ReadLine());
                switch (escolha) {
                    case 'a':
                    case 'A':
                        tempo = 50;
                        break;
                    case 'c':
                    case 'C':
                        tempo = 480;
                        break;
                    case 'o':
                    case 'O':
                        tempo = 660;
                        break;
                    default:
                        break;
                }
                if (tempo == 0) {
                    Console.WriteLine("Transporte Indisponível.");
                } else {
                    Console.WriteLine("Para o transporte escolhido, o tempo é: {0} horas.", tempo/60);
                }
            novamente:

            Console.Write("Calcular outro transporte [S/N]: ");
            escolha = char.Parse(Console.ReadLine());
            if (escolha == 'S' || escolha == 's') {
                goto inicio;
            } else if (escolha == 'N' || escolha == 'n') {
                Console.Clear();
                Console.WriteLine("Obrigado!");
            } else {
                Console.WriteLine("Tente Novamente");
                goto novamente;
            }
        } 
    }
}