using System;

namespace Aula43 {
    public interface Veiculo {
        void info();
    }
    public interface Combate {
        void disparar();
    }
    class Carro:Veiculo, Combate {
        private string ligado;
        private string nome;
        private int velMax;
        // VelMax
        public int vm {
            get {
                return velMax;
            }
            set {
                if (value > 300) {
                    velMax = 300;
                } else if (value < 0) {
                    velMax = 0;
                } else {
                    velMax = value;
                }
            }
        }
        
        public void setVelMax(int velMax) {
            this.velMax = velMax;
        }


        public Carro() {
            ligado = "Sim";
            nome = "Carro do Zoio";
            velMax = 120;
        }
        // Ligado
        public void setLigado(char ligado) {
            switch(ligado) {
                case 'N':
                case 'n':
                    this.ligado = "Não";
                    break;
                case 'S':
                case 's':
                    this.ligado = "Sim";
                    break;
                default:
                    break;
            }
        }
        public string getLigado() {
            return this.ligado;
        }
        // Nome

        public void SetNome(string nome) {
            this.nome = nome;
        }

        public string GetNome() {
            return this.nome;
        }
        public void info(){}
        public void disparar(){}
        public void Linha() {
            Console.WriteLine("--=--=--=--=--=--=--=--=--=--=--=--=--");
        }
    }

    class Program {
        static void Main() {
            Console.Clear();
            Carro c1 = new Carro();
            Console.Write("Seu carro está ligado? [N/S] ");
            char sn = char.Parse(Console.ReadLine());
            c1.setLigado(sn);
            Console.Write("Digite o nome do Veículo: ");
            string nome = Console.ReadLine().ToString();
            c1.SetNome(nome);
            Console.Write("Digite a velocidade máxima: ");
            int velmax = Convert.ToInt32(Console.ReadLine());
            c1.setVelMax(velmax);
            c1.Linha();
            Console.WriteLine("Nome: {0}", c1.GetNome());
            Console.WriteLine("Ligado: {0}", c1.getLigado());
            Console.WriteLine("Velocidade Máxima: {0}", c1.vm);
        }
    }
}