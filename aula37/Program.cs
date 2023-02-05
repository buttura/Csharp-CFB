using System;

class Num {
    protected int v1;
    protected int v2;
    public Num(int v1, int v2) {
        this.v1 = v1;
        this.v2 = v2;
    }

    public int getv1() {
        return v1;
    }
    public int getv2() {
        return v2;
    }
}
class Soma:Num{
    public Soma(int v1, int v2):base(v1, v2) {
        this.v1 = v1;
        this.v2 = v2;
    }
    public int getSoma() {
        return v1 + v2;
    }
}
class Subtracao:Num {
    public Subtracao(int v1, int v2):base(v1, v2) {
        this.v1 = v1;
        this.v2 = v2;
    }
    public int getSub() {
        return v1 - v2;
    }
}
class Multiplicacao:Num {
    public Multiplicacao(int v1, int v2):base(v1, v2) {
        this.v1 = v1;
        this.v2 = v2;
    }

    public int getMul() {
        return v1 * v2;
    }
}

class Divisao:Num {
    public Divisao(int v1, int v2):base(v1, v2) {
        this.v1 = v1;
        this.v2 = v2;
    }
    public int getDiv() {
        return v1 / v2;
    }
}
class Program {
    static void Main() {
        Console.Write("Digite o primeiro valor: ");
        int v1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o segundo valor: ");
        int v2 = Convert.ToInt32(Console.ReadLine());

        Num valores = new Num(v1, v2);
        Soma soma = new Soma(v1, v2);
        Subtracao subtrair = new Subtracao(v1, v2);
        Multiplicacao multiplicar = new Multiplicacao(v1, v2);
        Divisao dividir = new Divisao(v1, v2);

        Console.WriteLine("{0} + {1} = {2}", valores.getv1(), valores.getv2(), soma.getSoma());
        Console.WriteLine("{0} - {1} = {2}", valores.getv1(), valores.getv2(), subtrair.getSub());
        Console.WriteLine("{0} x {1} = {2}", valores.getv1(), valores.getv2(), multiplicar.getMul());
        Console.WriteLine("{0} / {1} = {2}", valores.getv1(), valores.getv2(), dividir.getDiv());
    }
}