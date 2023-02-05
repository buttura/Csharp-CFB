using System;

namespace Aula33 {
    class Jogador {
        private int energia;
        private string nome;
        public Jogador(string nome) {
            this.nome = nome;
            energia = 100;
        }

        public int getEnergia(){
            return energia;
        }

        public string getNome(){
            return nome;
        }

        public void setEnergia(int energia) {
            if (energia < 0) {
                if (this.energia+energia < 0) {
                    this.energia = 0;
                } else {
                    this.energia+=energia;
                }
            } else if (energia > 0) {
                if (this.energia+energia > 100) {
                    this.energia = 100;
                } else {
                    this.energia += energia;
                }
            }
        }
    }
    class Program {
        static void Main (){
            Console.Write("Digite o seu nome: ");
            Jogador j1 = new Jogador(Console.ReadLine());
            j1.setEnergia(-30);
            Console.WriteLine("Nome {0}\nEnergia: {1}", j1.getNome(), j1.getEnergia());
        }
    }
}
