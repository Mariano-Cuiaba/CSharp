public class Produto {
    private string nome;
    private decimal preco;
    private string descricao;
    private string categoria;
    //Construtor da classe Produto 
    public Produto (String nome, decimal preco, string descricao, string categoria){
     Nome = nome;
     Preco = preco;
     Decricacao = descricacao;
     Categoria = categoria;
    }
    //Propriedades da classe Produto que permite acesso controlado a um campo privado
    public string Nome {
        get { return nome; }
        set { nome = value; }
    }
    public decimal Preco {
        get { return preco; }
        set {preco = value; }
    }
    public string Descricao {
        get { return descricao; }
        set { descricao = value; }
    }
    public string Categiria {
        get { return categoria; }
        set { categoria = value; }
    }
}
public class ConsoleGame : Produto {
    private int capacidadeArmazenamento;

    //Construtor da classe ConsoleGame
    public ConsoleGame(string nome, decimal preco, string descricacao, string categoria) : base(nome, preco, descricacao, categoria){
        capacidadeArmazenamento = capacidadeArmazenamento;
    }    

    //Propriedades da classe ConsoleGame que permite acesso controlada a um campo privado
    public string capacidadeArmazenamento{
        get { return capacidadeArmazenamento; }
        set {capacidadeArmazenamento = value; }
    }
}
public class Jogo : Produto {
    private string genero;

    //Construtor da classe Jogo
    public Jogo(string nome, decimal preco, string descricacao, string categoria) : base(nome, preco, descricacao, categoria){
        Genero = genero;
    }    

    //Propriedades da classe Jogo que permite acesso controlada a um campo privado
    public string genero{
        get { return genero; }
        set {genero = value; }
    }
}
public class Acessorio : Produto {
    private string tipo;

    //Construtor da classe Acessorio
    public Acessorio(string nome, decimal preco, string descricacao, string categoria) : base(nome, preco, descricacao, categoria){
        Tipo = tipo;
    }    

    //Propriedades da classe Acessorio que permite acesso controlada a um campo privado
    public string tipo{
        get { return tipo; }
        set {tipo = value; }
    }
}
public class Colecionavel : Produto {
    private bool edicaoLimitada;

    //Construtor da classe Colecionavel
    public Colecionavel(string nome, decimal preco, string descricacao, string categoria, bool edicaoLimitada) : base(nome, preco, descricacao, categoria){
        edicaoLimitada = edicaoLimitada;
    }    

    //Propriedades da classe Colecionavel que permite acesso controlada a um campo privado
    public bool edicaoLimitada{
        get { return edicaoLimitada; }
        set {edicaoLimitada = value; }
    }
}
public class Colecionavel {

    public class Porgram {
        public static void main (string[] args) {

            Produto produto;
            produto = new ConsoleGame("PlayStation 5", 5.900, "Console de Vídeo Game Playstation 5 Slim com 1 Tera de armazenamento", "Console", 1024000);

            Jogo jogo = new Jogo("Marvel's Spider-Man 2 PREMIUM", 299,9,"Jogo completo Marvel's Spider-Man 2 para PS5." , "Jogo PS5", "Ação e Aventura");

            Acessorio acessorio = new Acessorio("Headset sem fio PULSE 3D", 540,00, "Fone de ouvido sem fio para Playstation 5", "Fone sem fio","Acessorio")

            Colecionavel colecionavel = new Colecionavel("The last of Us part 2", 208,10, "Jogo exclusivo da marca de videogame PlayStation", "Jogo exclusivo", "Colecionavel")
        }
    }
}