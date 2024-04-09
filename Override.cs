public class Personagem {
    private string nome;
    private string elemento;
    private int nivel;
    //Construtor da classe Personagem
    public Personagem (String nome, string elemento, int nivel){
     Nome = nome;
     Elemento = elemento;
     Nivel = nivel;
    }
    //Propriedades da classe Personagem que permite acesso controlado a um campo privado
    public string Nome {
        get { return nome; }
        set { nome = value; }
    }
    public string Elemento {
        get { return elemento; }
        set {elemento = value; }
    }
    public int Nivel {
        get { return nivel; }
        set { nivel = value; }
    }
    public class Personagem {
        public virtual void Atacar() {
            Console.WriteLine("Ataque primário!");
        }
    }
}
public class Gladiador : Personagem {
    private string furia;

    //Construtor da classe Gladiador
    public Gladiador(string nome, string elemento, int nivel, ) : base(nome, elemento, nivel){
        Furia = furia;
    }    

    //Propriedades da classe Gladiador que permite acesso controlada a um campo privado
    public string furia{
        get { return furia; }
        set {furia = value; }
    }
    public virtual void Atacar(){
        Console.WriteLine("Gladiador ativa a furia!");
    }
}
public class Bruxo : Personagem {
    private string Invocacao;

    //Construtor da classe Bruxo
    public Bruxo(string nome, string elemento, int nivel) : base(nome, elemento, nivel){
        Invocacao = invocacao;
    }    

    //Propriedades da classe Bruxo que permite acesso controlada a um campo privado
    public string invocacao{
        get { return invocacao; }
        set {invocacao = value; }
    }
    public virtual void Atacar(){
        Console.WriteLine("Bruxo faz uma invocacao de um golem de pedra")
    }
}
public class Anjo : Personagem {
    private string Ressuscitar;

    //Construtor da classe Anjo
    public Anjo(string nome, string elemento, int nivel) : base(nome, elemento, nivel){
        Ressuscitar = ressuscitar;
    }    

    //Propriedades da classe Anjo que permite acesso controlada a um campo privado
    public string ressuscitar{
        get { return ressuscitar; }
        set {ressuscitar = value; }
    }
    public virtual void Atacar(){
        Console.WriteLine("Anjo ressuscita npc")
    }
}

    public class Program {
        public static void main (string[] args) {

            Personagem personagem;
            Gladiador gladiador = new Gladiador("Guts", "Fogo", 1000);

            Bruxo bruxo = new Bruxo("Androxus", "Escuridao" , 10000000);

            Anjo anjo = new Anjo("Thomas", "Luz", 500)

        }
    }