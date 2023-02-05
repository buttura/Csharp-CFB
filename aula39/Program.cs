using System;

abstract class Veiculo { // Classe Base Abstrata
    protected int velMax;
    protected int velAtual;
    protected bool Ligado;
    public Veiculo() {
        Ligado = false;
        velAtual = 0;
    }
    public bool setLigado(bool ligado) {
        this.Ligado = ligado;
        return this.Ligado;
    }

    virtual public void Aceleracao(int mult) {}

    public int getVelAtual() {
        return velAtual;
    }

}

class Carro:Veiculo{
    public Carro() {
        velMax = 120;
    }
    override public void Aceleracao(int mult) {
        velAtual += 10*mult;
    }
}
class Program {
    static void Main() {
        Carro carro1 = new Carro();
        carro1.Aceleracao(1);

        Console.WriteLine(carro1.setLigado(true));

    }
}