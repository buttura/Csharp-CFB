using System;

namespace Aula29 {
    public class Jogador {
        public int energia;
        public bool vivo;
        public string nome;
        public Jogador(string n) {
            energia = 100;
            vivo = true;
            nome = n;
        }
        ~Jogador() {
            Console.WriteLine("O jogador foi destruido!");
        }
    }
    public class Program {
        static void Main() {
            string[] nomes = {};
            Console.Write("Nome do Jogador 1: ");
            nomes = nomes.Concat(new string[] {Console.ReadLine()}).ToArray();
            Jogador j1 = new Jogador(nomes[0]);
            Console.Write("Nome do Jogador 2: ");
            nomes = nomes.Concat(new string[] {Console.ReadLine()}).ToArray();
            Jogador j2 = new Jogador(nomes[1]);

            j1.energia = 50;
            Console.WriteLine("Energia do Jogador {0}: {1}.", nomes[0], j1.energia);
            Console.WriteLine("Energia do Jogador {0}: {1}.", nomes[1], j2.energia);
            }
        }
    }