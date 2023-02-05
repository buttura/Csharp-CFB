using System;

class Veiculo { // Base
    public int velAtual;
    private int velMax;
    protected bool ligado;
    public Veiculo(int velMax) {
        velAtual = 0;
        this.velMax = velMax;
    }
    public int getVelMax() {
        return velMax;
    }
    public string getLigado() {
        return(ligado?"Ligado":"Desligado");
    }
}

class Carro:Veiculo { // Derivada de Veículo
    public string nome;
    public Carro(string nome, int vm):base(vm) {
        this.nome = nome;
        ligado = false;
    }
}
class Program {
    static void Main() {
        Carro c1 = new Carro("Bonitão", 120);
        Console.WriteLine("{0} está {2} tem a velocidade máxima de {1}", c1.nome, c1.getVelMax(), c1.getLigado());

    }
}