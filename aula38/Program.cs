using System;

class Base {
    public Base() {
        Console.WriteLine("Construtor da classe Base");
    }

    virtual public void info() {
        Console.WriteLine("Base");
    }
}
class Derivada1:Base {
    public Derivada1() {
        Console.WriteLine("Construtor da classe Derivada1");
    }
    override public void info(){
        Console.WriteLine("Derivada 1");
    }
}
class Derivada2:Derivada1 {
    public Derivada2() {
        Console.WriteLine("Construtor da classe Derivada2");
    }
    override public void info(){
        Console.WriteLine("Derivada 2");
    }
}
class Program{
    static void Main() {
        Base Ref;
        Derivada1 derivada1 = new Derivada1();
        derivada1.info();
    }
}