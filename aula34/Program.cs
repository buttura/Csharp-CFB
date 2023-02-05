using System;

namespace Aula34 {
    class Veiculo { // Classe Base
        private int rodas;
        public int velMax;
        private bool ligado;
        public int getRodas(int rodas) {
            this.rodas = rodas;
            return rodas;
        }
        public int getVelMax(int velMax) {
            this.velMax = velMax;
            return velMax;
        }
        public void ligar() {
            ligado = true;
        }
        public void desligar() {
            ligado = false;
        }
        public string getLigar() {
            if (ligado) {
                return "Sim";
            } else {
                return "Não";
            }
        }
    }
    
    class Carro:Veiculo { //Classe Derivada
        public string nome;
        public string cor;
        public Carro(string nome, string cor){
            ligar();
            getRodas(4);
            getVelMax(120);

            this.nome = nome;
            this.cor = cor;
        }
    }

    class Program {
        static void Main() {
            Console.Clear();
            Carro c1 = new Carro("Ford", "Vermelho");
            Console.WriteLine("Cor: {0}\nNome: {1}\nRodas: {2}\nVelMax: {3}\nLigado: {4}",c1.cor, c1.nome, c1.getRodas(5), c1.getVelMax(130), c1.getLigar());
       }
    }
}