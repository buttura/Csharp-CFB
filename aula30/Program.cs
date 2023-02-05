using System;

namespace Aula30 {
    public class Jogador {
        public int energia;
        public bool vivo;
        public string nome;
        public Jogador() {
            nome = "Jogador";
            vivo = true;
            energia = 100;
        }
        public Jogador(string n) {
            nome = n;
            vivo = true;
            energia = 100;
        }
        public Jogador(string n, int e) {
            nome = n;
            vivo = true;
            energia = e;
        }

        public Jogador(string n, int e, bool v) {
            nome = n;
            vivo = v;
            energia = e;
        }

        public void info() {
            Console.WriteLine("Nome do Jogador: {0}\nEnergia do Jogador: {1}\nStatus: {2}\n",nome, energia, vivo);
        }
    }
    public class Program {
        static void Main(){
            Jogador j1 = new Jogador();
            Jogador j2 = new Jogador("Théo");
            Jogador j3 = new Jogador("Bruno", 150);
            Jogador j4 = new Jogador("Murilo", 100, true);

            j1.info();
            j2.info();
            j3.info();
            j4.info();
        }
    }
}