using System;

namespace Aula34 {
    class Veiculo { // Classe Base
        private int rodas;
        public int velMax;
        private bool ligado;
        public Veiculo(int rodas) {
            this.rodas = rodas;
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
            return (ligado?"sim":"não"); 
            //if (ligado) {
            //    return "Sim";
            //} else {
            //    return "Não";
            //}
        }
        public int getRodas() {
            return rodas;
        }
        public void setRodas(int rodas) {
            if(rodas < 0) {
                this.rodas = 0;
            } else if (rodas > 40) {
                this.rodas = 40;
            } else {
                this.rodas = rodas;
            }
        }
    }
    
    class Carro:Veiculo { //Classe Derivada
        public string nome;
        public string cor;
        public Carro(string nome, string cor):base(6){
            ligar();
            getRodas();
            getVelMax(120);

            this.nome = nome;
            this.cor = cor;
        }
    }

    class CarroCombate:Carro {
        public int municao;
        public CarroCombate():base("Carro de Combate", "Verde") {
            municao = 100;
            setRodas(6);
        }
    }

    class Program {
        static void Main() {
            Console.Clear();
            Carro c1 = new Carro("Ford", "Vermelho");
            CarroCombate cc1 = new CarroCombate();
            Console.WriteLine("Cor: {0}\nNome: {1}\nRodas: {2}\nVelMax: {3}\nLigado: {4}\n--=--=--=--=--=--=--=--=--=--=--=--=--=--",c1.cor, c1.nome, c1.getRodas(), c1.getVelMax(130), c1.getLigar());
            Console.WriteLine("Cor: {0}\nNome: {1}\nRodas: {2}\nVelMax: {3}\nLigado: {4}\nMunição: {5}",cc1.cor, cc1.nome, cc1.getRodas(), cc1.getVelMax(120), cc1.getLigar(), cc1.municao);
       }
    }
}