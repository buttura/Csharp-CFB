using System;

namespace Aula03
{
    class Program
    {
        static void Main()
        {
            int num1, num2, res;
            num1=10;
            num2=2;

            byte n1=10; // 0 a 255
            string nome="Bruno";
            char sexo='M';
            int numero=7;
            float decimais=5.3f;
            var aux=nome;

            Console.Write(aux);
            Console.WriteLine("Valor da variável: "+aux+"...");
            Console.WriteLine("A soma de "+ num1 + " x " + num2 +" = " + num1*num2);
        }
    }
}
