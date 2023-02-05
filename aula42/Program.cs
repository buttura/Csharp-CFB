using System;

class Carro {
    private int[] velMax = new int[5]{80, 120, 160, 240, 300};

    public int this[int i]{
        get {
            return velMax[i];
        }
        set {
            if(value < 0) {
                velMax[i] = 0;
            } else if (value > 300) {
                velMax[i] = 300;
            } else {
                velMax[i] = value;
            }
        }
    }
    public Carro() {
    }
}

class Program {
    static void Main() {
        Carro carro = new Carro();
        Console.WriteLine("Velocidade: {0} km/h", carro[0]);
    }
}