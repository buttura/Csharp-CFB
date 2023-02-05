using System;

namespace Aula32 {
    class Calculo {
        public int v1;
        public int v2;
        public int mul;
        public int divi;
        public int s = 0;
        public Calculo(int v1, int v2) {
            this.v1 = v1;
            this.v2 = v2;
        }

        public int SMD(){
            mul = v1 * v2;
            divi = v1 / v2;
            return v1 - v2;
        }
    }
    class Program {
        static void Main(){ 
            Console.Clear();
            char res = 'S';
            int i = 1, v1, v2;
            int[] valores = {};
            Console.Write("Digite o primeiro valor (Multiplicação, divisão e Subtração): ");
            v1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o primeiro valor (Multiplicação, divisão e Subtração): ");
            v2 = Convert.ToInt32(Console.ReadLine());
            Calculo val = new Calculo(v1, v2);
            Console.WriteLine("--=--=--=--=--=--=--=--=--=--=--");
            Console.WriteLine("Adição");
            Console.WriteLine("--=--=--=--=--=--=--=--=--=--=--");
            do {
                Console.Write("Digite o {0}o número: ", i);
                valores = valores.Concat(new int[] {Convert.ToInt32(Console.ReadLine())}).ToArray();
                i++;
                Console.Write("Deseja continuar? [S/N] ");
                res = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("--=--=--=--=--=--=--=--=--");
                if (valores.Length < 2) {
                    res = 'S';
                    Console.WriteLine("Digite dois valores ou digite mais um número");
                }
            } while (res != 'N');
            Console.Clear();
            Console.WriteLine("--=--=--=--=--=--=--=--=--");
            for (int p = 0; p < valores.Length; p++) {
                if (p == valores.Length-1) {
                    Console.Write("{0}", valores[p]);
                } else {
                    Console.Write("{0} + ",valores[p]);
                }
            }
            Console.Write(" = {0}\n", Somar(valores)); 
            Console.WriteLine("{0} - {1} = {2}\n{0} x {1} = {3}\n{0} / {1} = {4}", val.v1, val.v2, val.SMD(), val.mul, val.divi);
            Console.WriteLine("--=--=--=--=--=--=--=--=--");
        }
        static int Somar(params int[]v) {
            int s = 0;
            for (int i = 0; i < v.Length; i++) {
                s += v[i];
            }
            return s;
            }
        }
    }