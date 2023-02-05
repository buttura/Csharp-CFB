using System;

namespace aula17 {
    class Program {
        static void Main(){
            //int[] num = new int[3]{55, 77, 99};
            //string[] veiculos = {"Caminhão", "Carro", "Moto"};
            int[,] n = new int[3, 5];
            int[,] num = new int[2,2]{{10, 20}, {40, 30}};

            /*
            10 20 30 40 50
            60 70 80 90 15
            25 35 45 55 65
            */

            // Primeira Linha com todos os valores da coluna.
            n[0,0] = 10;
            n[0,1] = 20;
            n[0,2] = 30;
            n[0,3] = 40;
            n[0,4] = 50;

            // Segunda Linha com todos os valores da coluna.
            n[1,0] = 60;
            n[1,1] = 70;
            n[1,2] = 80;
            n[1,3] = 90;
            n[1,4] = 16;

            // Terceira Linha com todos os valores da coluna.
            n[2,0] = 25;
            n[2,1] = 35;
            n[2,2] = 45;
            n[2,3] = 55;
            n[2,4] = 65;

            Console.Clear();
            //Console.WriteLine(n[0]);
            Console.WriteLine(n[1,3]);
            Console.WriteLine(n[2,1]);
        }
    }
}