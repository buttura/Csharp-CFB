using System;
public interface Veiculo {
    void info();

}



public interface Combate {
    void disparar();
}
class Carro:Veiculo, Combate {
    private int municao;
    private string nome;
    public string res;
    public Carro() {
        setMunicao(280);
        setNome("Ford");
        setLigado('S');
    }

    public string n {
        get {
            return nome;
        }
    }

    public void setNome(string nome) {
        this.nome = nome;
    }

    public void setMunicao(int municao) {
        this.municao = municao;
    }
    public int mun {
        get {
            return municao;
        }
        set {
            if (value > 300) {
                municao = 300;
            } else if (value < 0) {
                municao = 0;
            } else {
                municao = value;
            }
        }
    }

    public string sn {
        get {
            return res;
        }
    }

    public void setLigado(char res) {
        switch(res) {
            case 'n':
            case 'N':
                this.res = "Desligado";
                break;
            case 'S':
            case 's':
                this.res = "Ligado";
                break;
        }
    }
    public void Linha() {
        Console.WriteLine("\n--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=--=\n");
    }

    public void info(){}
    public void disparar() {}
}



class Program {
    static void Main() {
        Console.Clear();
        Carro c1 = new Carro();
        Console.Write("Digite o nome do Carro: ");
        string cn = Convert.ToString(Console.ReadLine());
        c1.setNome(cn);
        Console.WriteLine("Carro: {0}", c1.n);
        c1.Linha();
        Console.Write("Digite quantas munições deseja: [0/300] ");
        int m = Convert.ToInt32(Console.ReadLine());
        c1.setMunicao(m);
        Console.WriteLine("Munição: {0}", c1.mun);
        c1.Linha();
        Console.Write("O Carro está ligado: [S/N] ");
        char sn = Convert.ToChar(Console.ReadLine());
        c1.setLigado(sn);
        Console.WriteLine("O carro está {0}", c1.sn);
    }
}