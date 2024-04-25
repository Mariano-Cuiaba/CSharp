using System;

// Interface representando um ataque
interface IAtacante {
    void Atacar();
    void Especial();
}

public abstract class Heroi {
    protected int poder;

    public Heroi(int poder) {
        this.poder = poder;
    }

    // Getter para o Poder
    public int GetPoder() {
        return poder;
    }

    // Setter para o Poder
    public void SetPoder(int poder) {
        this.poder = poder;
    }

    public abstract void Atacar();

    public abstract void Especial();
}

// Classe Combatente implementando a interface IAtacante
class Combatente : Heroi, IAtacante {
    public Combatente(int poder) : base(poder) {}

    public override void Atacar() {
        Console.WriteLine("Combatente ataca com o machado!");
    }

    public override void Especial() {
        Console.WriteLine("Combatente usa furacão cortante!");
    }
}

// Classe Guardião implementando a interface IAtacante
class Guardiao : Heroi, IAtacante {
    public Guardiao(int poder) : base(poder) {}

    public override void Atacar() {
        Console.WriteLine("Guardiao lança um feixe de luz!");
    }

    public override void Especial() {
        Console.WriteLine("Guardião invoca escudo relusente!");
    }
}

// Classe Artilheiro implementando a interface IAtacante
class Artilheiro : Heroi, IAtacante {
    public Artilheiro(int poder) : base(poder) {}

    public override void Atacar() {
        Console.WriteLine("Artilheiro dispara com sua besta!");
    }

    public override void Especial() {
        Console.WriteLine("Artilheiro dispara com canhão de mão!");
    }
}

class Program {
    static void Main(string[] args) {
        // Criando instâncias de diferentes personagens
        IAtacante combatente = new Combatente(400);
        IAtacante guardiao = new Guardiao(1100);
        IAtacante artilheiro = new Artilheiro(650);

        // Chamando o método Atacar de cada personagem
        combatente.Atacar();
        combatente.Especial();
        guardiao.Especial();
        guardiao.Atacar();
        artilheiro.Especial();
        artilheiro.Atacar();
    }
}
