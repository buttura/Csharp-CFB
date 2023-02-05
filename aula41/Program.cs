using System;

class Carro {
    private int velMax;

    public int vm {
        get {
            return velMax;
        }
        set {
            if(value < 0) {
                velMax = 0;
            } else if (value > 300) {
                velMax = 300;
            } else {
                velMax = value;
            }
        }
    }
    public Carro() {
        velMax = 300;
    }
}

class Program {
    static void Main() {
        Carro carro = new Carro();
        Console.Write("Digite a velocidade: ");
        carro.vm = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Velocidade: {0} km/h", carro.vm);
    }
}