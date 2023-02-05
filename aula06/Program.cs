using System;

namespace Aula06 {
    class Program {
        static void Main(){
            // int n1, n2, n3;
            // n1 = 10; n2=20; n3=30;
            // Console.Write("\nn1={0} \nn2={1} \nn3={2}",n1,n2,n3);

            double valorCompra=5.50;
            double valorVenda;
            double lucro=0.1;
            string produto="Pastel";

            valorVenda = valorCompra + (valorCompra*lucro);

            Console.WriteLine("Produto.......: {0,15:c}",produto);
            Console.WriteLine("Val.Compra....: {0,15:c}",valorCompra);
            Console.WriteLine("Lucro.........: {0,15:p}",lucro);
            Console.WriteLine("Val. Venda....: {0,15:c}",valorVenda);
        }
    }
}
