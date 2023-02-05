using System;

namespace Aula28 {

    public class Jogador {
        public string nome = "";
        public int energia = 100;
        public bool vivo = true;

    }
    public class Inimigo {
        public string nome = "Corvalius";
        public int energia = 150;
        public bool vivo = true;
    }
    public class Program {
        public static void Main() {
            Console.Clear();
            int on, oe, danger=0, danototal;
            int[] danos = {};
            Random a = new Random();
            Jogador j1 = new Jogador();
            Inimigo ini = new Inimigo();

            Console.Write("Nome do Jogador: ");
            j1.nome = Console.ReadLine();
            do {
                Console.WriteLine("--=--=--=--=-- NOME DA LUTADORA --=--=--=--=--");
                Console.WriteLine("[ 1 ] Corvalius");
                Console.WriteLine("[ 2 ] Sandreas");
                Console.WriteLine("[ 3 ] Manchesterina");
                Console.WriteLine("--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--");
                Console.Write("Sua opção: ");
                on = Convert.ToInt32(Console.ReadLine());
                switch(on) {
                    case 1:
                        break;
                    case 2:
                        ini.nome = "Sandreas";
                        break;
                    case 3:
                        ini.nome = "Manchesterina";
                        break;
                    default:
                        Console.WriteLine("Digite um número válido, tente novamente!");
                        break;
                }
                Console.Clear();
            } while (on < 1 | on > 3);
            while (ini.energia > 1 & j1.energia > 1) {
                do {
                    Console.WriteLine("--=--=--=--=-- MODO DE ATAQUE --=--=--=--=--");
                    Console.WriteLine("[ 1 ] SOCO");
                    Console.WriteLine("[ 2 ] CHUTE");
                    Console.WriteLine("--=--=--=--=--=--=--=--=--=--=--=--=--=--=--");
                    Console.Write("Sua opção: ");
                    oe = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("--=--=--=--=--=--=--=--=--=--=--=--=--=--=--");
                    switch (oe) {
                        case 1:
                            danger = a.Next(40, 80);
                            break;
                        case 2:
                            danger = a.Next(20, 50);
                            break;
                        default:
                            Console.WriteLine("Número inválido, tente novamente!");
                            break;
                    }
                } while (oe < 1 | oe > 2);
                danos = danos.Concat(new int[] {danger}).ToArray();
                int s = 0;
                foreach(int d in danos) {
                    s += d;
                }
                Console.WriteLine("{0} DE DANO!!", danger);
                Console.WriteLine("DANO TOTAL: {0}", somadano(danos));
                ini.energia -= danger;
                if (ini.energia <= 0) {
                    Console.WriteLine("Energia da {0}: 0", ini.nome.ToUpper());
                    } else {
                        Console.WriteLine("Energia da {0}: {1}", ini.nome.ToUpper(), ini.energia);
                        int danoinimigo = a.Next(30, 60);
                        j1.energia -= danoinimigo;
                if (j1.energia <= 0) {
                    Console.WriteLine("Você está com 0 de vida.", j1.energia);
                    } else {
                        Console.WriteLine("Você está com {0} de vida. ATACA!", j1.energia);
                    }
                }
            }
            Console.WriteLine("--=--=--=--=--=--=--=--=--=--=--=--=--=--=--");
            if (ini.energia < 1) {
                Console.WriteLine("Parabéns, você ganhou!");
            } else {
                Console.WriteLine("Você perdeu!");
            }
        }
        static int somadano(params int[]d) {
            Inimigo ini = new Inimigo();
            int danototal = 0;
            for (int i = 0; i < d.Length; i++) {
                danototal += d[i];
            }
            return danototal;
        }

    }
}
