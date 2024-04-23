using System;

public abstract class Samurais
{
    private string nome;
    private int honra;
    private int forca;

    public Samurais(string nome, int honra, int forca)
    {
        this.nome = nome;
        this.honra = honra;
        this.forca = forca;
    }

    public string GetNome()
    {
        return nome;
    }

    public void SetNome(string nome)
    {
        this.nome = nome;
    }

    public int GetHonra()
    {
        return honra;
    }

    public void SetHonra(int honra)
    {
        this.honra = honra;
    }

    public int GetForca()
    {
        return forca;
    }

    public void SetForca(int forca)
    {
        this.forca = forca;
    }

    public abstract void Golpear();
    public abstract void Defender();

    public void GanharHonra(int honra)
    {
        this.honra += honra;
        Console.WriteLine($"{nome} ganhou {honra} honra e agora tem {this.honra} de honra.");
        if (this.honra <= 0)
        {
            Suicidio();
        }
    }

    public void Suicidio()
    {
        Console.WriteLine($"{nome} teve que se suicidar por causa da honra baixa!");
    }
}

public class Goshi : Samurais
{
    public Goshi(string nome, int honra, int forca) : base(nome, honra, forca) { }

    public override void Golpear()
    {
        Console.WriteLine($"{GetNome()} golpeia com sua foice!");
    }

    public override void Defender()
    {
        Console.WriteLine($"{GetNome()} defende com seu corpo!");
    }
}

public class Hatamoto : Samurais
{
    public Hatamoto(string nome, int honra, int forca) : base(nome, honra, forca) { }

    public override void Golpear()
    {
        Console.WriteLine($"{GetNome()} golpeia com a sua katana!");
    }

    public override void Defender()
    {
        Console.WriteLine($"{GetNome()} defende com seu corpo!");
    }
}

public class Gonekin : Samurais
{
    public Gonekin(string nome, int honra, int forca) : base(nome, honra, forca) { }

    public override void Golpear()
    {
        Console.WriteLine($"{GetNome()} golpeia com sua wakizashi!");
    }

    public override void Defender()
    {
        Console.WriteLine($"{GetNome()} defende com seu corpo!");
    }
}

public class Sensei : Samurais
{
    public Sensei(string nome, int honra, int forca) : base(nome, honra, forca) { }

    public override void Golpear()
    {
        Console.WriteLine($"{GetNome()} golpeia com seu bastão!");
    }

    public override void Defender()
    {
        Console.WriteLine($"{GetNome()} defende com seu corpo!");
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
        goshi.Defender();
        hatamoto.Golpear();
        hatamoto.Defender();
        gonekin.Golpear();
        gonekin.Defender();
        sensei.Golpear();
        sensei.Defender();
    }
}
