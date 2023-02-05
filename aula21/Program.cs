using System;

namespace Aula21 {
    class Program {
        static void Main(){
             /* int num = 5;

             string senha="123";
             string senhauser;
             int t = 0;

             while (num < 5) {
                 Console.WriteLine("CFB Cursos");
             }

             do {
                Console.Write("Digite a senha: ");
                senhauser = Console.ReadLine();
                Console.Clear();
                t++;
                if (t >= 1) {
                    Console.WriteLine("Senha incorreta. ({0})", t);
                }
             } while (senha != senhauser);
             Console.Clear();
             Console.WriteLine("Senha Correta, tentativas: {0}", t);
             */

             string s = "9090", su;
             int t = 0;
             Console.Clear();
             do {
                 Console.Write("SENHA: ");
                 su = Convert.ToString(Console.ReadLine());
                 t++;
                 Console.Clear();
                 if (su != s) {
                     Console.WriteLine("Senha Incorreta! ({0})", t);
                 }
             } while (su != s);
             Console.Clear();
             Console.WriteLine("Senha Correta. Tentativas: {0}", t);
        }
    }
}