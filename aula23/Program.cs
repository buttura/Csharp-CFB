 using System;

 namespace Aula23 {
     class Program {
         static void Main(){
             int[] vetor1 = new int[5];
             int[] vetor2 = new int[5];
             int[] vetor3 = new int[5];
             int[,] matriz = new int[2,5]{{11, 22, 33, 44, 55},{66, 77, 88, 99, 00}};
             Random a = new Random();

             for (int i = 0; i < vetor1.Length; i++) {
                 vetor1[i] = a.Next(50, 100);
             }

             Console.WriteLine("Elementos do Vetor");
             foreach(int valores in vetor1) {
                 Console.WriteLine(valores);
             }

             //public static int BinarySearch(array, valor);
             Console.WriteLine("BinarySearch");
             int procurado=33;
             int pos = Array.BinarySearch(vetor1, procurado);
             Console.WriteLine("O valor {0} está na posição {1}", procurado, pos);
             Console.WriteLine("--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--");

             //public static void Copy(Array de Origem, Array de Destino, Quantidade de Elementos)
             Console.WriteLine("Copy");
             Array.Copy(vetor1, vetor2, vetor1.Length);
             foreach (int n in vetor2) {
                 Console.WriteLine(n);
             }
             Console.WriteLine("--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--");

             //public void CopyTo()
             Console.Write("CopyTo");
             vetor1.CopyTo(vetor3, 0);
             foreach(int n in vetor3) {
                 Console.WriteLine(n);
             }
             Console.WriteLine("--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--");

             //public long GetLongLength(Dimensão)
             Console.WriteLine("GetLongLength");
             long QuantidadeDeElementosDeUmArray = vetor1.GetLongLength(0);
             Console.WriteLine("Quantidade de Elementos do VETOR1: {0}", QuantidadeDeElementosDeUmArray);
             Console.WriteLine("--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--");

             //public int GetLowerBound(Dimensão)
             Console.WriteLine("GetLowerBound");
             int MenorIndiceVetor = vetor1.GetLowerBound(0);
             int MenorIndiceMatriz = matriz.GetLowerBound(1);
             Console.WriteLine("Menor índice do vetor1: {0}", MenorIndiceVetor);
             Console.WriteLine("--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--");

             //public int GetUpperBound(Dimensão)
             Console.WriteLine("GetUpperBound");
             int MaiorIndiceVetor = vetor1.GetUpperBound(0);
             int MaiorIndiceMatriz = matriz.GetUpperBound(1);
             Console.WriteLine("O Maior Índice do VETOR1 é {0}", MaiorIndiceVetor);
             Console.WriteLine("--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--");

             //public object GetValue(long índice)
             Console.WriteLine("GetValue");
             int Vetor1Indice3 = Convert.ToInt32(vetor1.GetValue(3));
             int MatrizIndice1e2 = Convert.ToInt32(matriz.GetValue(1,2));
             Console.WriteLine("Valor do Indice 3 no Vetor1: {0}", Vetor1Indice3);
             Console.WriteLine("--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--");

             //public static int IndexOf(array, Valor) e LastIndexOf(Array, Valor)
             Console.WriteLine("IndexOf");
             int IndiceDoPrimeiroValor33 = Array.IndexOf(vetor1, 33);
             Console.WriteLine("A posição da primeira vez que o Índice do Valor 33 é encontrado: {0}",IndiceDoPrimeiroValor33);
             int IndiceDoUltimoValor33 = Array.LastIndexOf(vetor1, 33);
             Console.WriteLine("A posição da última vez que o índice do Valor 33 é encontrado: {0}", IndiceDoUltimoValor33);

             //public static void Reverse(array)
             Array.Reverse(vetor1);
             foreach(int valores in vetor1) {
                 Console.WriteLine(valores);
             }

             //public void SetValue(object valor, long pos)
             vetor2.SetValue(99, 0);
             for (int i = 0; i < vetor2.Length; i++) {
                 vetor2.SetValue(65, i);
             }

             //public static void Sort(array)
             Array.Sort(vetor1);
             Array.Sort(vetor2);
             Array.Sort(vetor3);
             Console.WriteLine("Vetor 1");
             foreach (int v in vetor1) {
                 Console.WriteLine(v);
             }
             Console.WriteLine("\nVetor 2");
             foreach (int v in vetor2) {
                 Console.WriteLine(v);
             }
             Console.WriteLine("\nVetor 3");
             foreach (int v in vetor3) {
                 Console.WriteLine(v);
             }

        }
    }
}
