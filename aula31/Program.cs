using System;

namespace Aula31 {
    static public class Jogador {
        static public int energia;
        static public bool vivo;
        static public string nome;
        static public void iniciar(string n) {
            nome = n;
            vivo = true;
            energia = 100;
        }
        static public void info() {
            Console.WriteLine("Nome do Jogador: {0}\nEnergia do Jogador: {1}\nStatus: {2}\n",nome, energia, vivo);
        }
    }

    class Inimigo {
        static public bool alerta;
        public string nome;
        public Inimigo(string n) {
            alerta = false;
            nome = n;
        }
        public void info() {
            Console.WriteLine("Nome do Inimigo: {0}\n Alerta: {1}\n---=---=---=---=---=---=---=--- ", nome, alerta);
        }
    }
    public class Program {
        static void Main(){
            Jogador.iniciar("Bruno");
            Jogador.info();

            Inimigo i1 = new Inimigo("Doido");
            Inimigo i2 = new Inimigo("Maluco");
            Inimigo i3 = new Inimigo("Pirado");

            Inimigo.alerta = true;

            i1.info();
            i2.info();
            i3.info();
        }
    }
}