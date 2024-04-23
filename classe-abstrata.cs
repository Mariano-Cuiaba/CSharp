using System;

public abstract class Samurais
{
    //Atributos da classe Samurais
    public string nome;
    public int honra;
    public int forca;

    // Construtor da classe Samurai
    public Samurai(string nome, int honra, int forca)
    {
        this.nome = nome;
        this.honra = honra;
        this.forca = forca;
    }
    // Getter para o nome 
    public string GetNome(){
        return nome;
    }
    // Setter para o nome
    public void SetNome(string nome){
        this.nome = nome;
    }
    // Getter para a honra
    public string GetHonra(){
        return honra;
    }
    // Setter para a honra
    public void SetHonra(string honra){
        this.honra = honra;
    }
    // Getter para o força
    public string GetForca(){
        return forca;
    }
    // Setter para o força
    public void SetForca(string forca){
        this.forca = forca;
    }
using System;
    public abstract class Samurais {
    public string Nome { get; set; }
    public int Honra { get; set; }
    public int Forca { get; set; }
    public Samurais(string nome, int honra, int forca) {
        Nome = nome;
        Honra = honra;
        Forca = forca;
    }
    public abstract void Golpear(); // Metodo abstrato
    public abstract void Defender(); // Metodo abstrato
    public void GanharHonra(int honra) { // Metodo concreto
        Honra -= honra;
        Console.WriteLine($"{Nome} ganhou {honra} honra e agora tem {honra} de honra.");
        if (Honra <= 0) {
            Suicidio();
        }
    }
    public void Suicidio() { // Metodo concreto
        Console.WriteLine($"{Nome} teve que se suicidar por causa da honra baixa!");
    }
}
public class Goshi : Personagem {
    public Goshi(string nome, int honra, int forca) : base(nome, honra, forca) {}
    public override void Golpear() {
        Console.WriteLine($"{Nome} golpeia com sua foice!");
    }
    public override void Defender() {
        Console.WriteLine($"{Nome} defende com seu corpo!");
    }
}
public class Hatamoto : Personagem {
    public Hatamoto(string nome, int honra, int forca) : base(nome, honra, forca) {}

    public override void Golpear() {
        Console.WriteLine($"{Nome} golpeia com a sua katana!");
    }
    public override void Defender() {
        Console.WriteLine($"{Nome} defende com seu corpo!");
    }
}
public class Gonekin : Personagem {
    public Gonekin(string nome, int honra, int forca) : base(nome, honra, forca) {}

    public override void Golpear() {
        Console.WriteLine($"{Nome} golpeia com sua wakizashi!");
    }
    public override void Defender() {
        Console.WriteLine($"{Nome} defende com seu corpo!");
    }
}
public class Sensei : Personagem {
    public Sensei(string nome, int honra, int forca) : base(nome, honra, forca) {}

    public override void Golpear() {
        Console.WriteLine($"{Nome} golpeia com seu bastão!");
    }
    public override void Defender() {
        Console.WriteLine($"{Nome} defende com seu corpo!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Samurais goshi = new Goshi("Mika", 100, 300);
        Samurais hatamoto = new Hatamoto("Tatsumo", 500, 700);
        Samurais gonekin = new Gonekin("Shakrin", 40, 150);
        Samurais sensei = new Sensei("Hanzo", 1000, 1400);

        goshi.Golpear();
        ((Goshi)goshi).Defender(); 
        hatamoto.Golpear();
        ((Hatamoto)hatamoto).Defender();
        gonekin.Golpear();
        ((Gonekin)gonekin).Defender();
        sensei.Golpear();
        ((Sensei)sensei).Defender();
        
    }
}
}