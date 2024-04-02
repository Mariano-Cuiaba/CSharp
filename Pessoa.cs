public class Pessoa {
    private String nome;
    private int idade;
    private String cpf;
    //Construtor da classe Pessoa
    public Pessoa(string nome, int idade, string cpf){
        Nome = nome;
        Idade = idade;
        CPF = cpf;
    }
    //Propriedades da classe Pessoa que permite acesso controlado a um campo privado
    public string Nome {
        get { return nome; }
        set { nome = value; }
    }
    public int Idade {
        get { return Idade; }
        set {idade = value; }
    }
    public string CPF {
        get { return cpf; }
        set { cpf = value; }
    }
}
public class Estudante : Pessoa {
    private String curso;

    //Construtor da classe Estudante
    public Estudante(string nome, int idade, string cpf, string curso) : base(nome, idade, cpf){
        Curso = curso;
    }    

    //Propriedades da classe Estudante que permite acesso controlada a um campo privado
    public string Curso{
        get { return curso; }
        set {curso = value; }
    }
}
public class funcionario : Pessoa {
    private double salario;

    //Metodo para celular o bônus
    public double Bonus() {
        return salario * 0.1; //10% de bônus padrão sobre o salário
    }

    //Construtor da classe Estudante
    public funcionario(string nome, int idade, string cpf, double salario) : base(nome, idade, cpf){
        salario = salario;
        }

        //Propriedades da classe Estudante que permite acesso controlado a um campo privado
        public string Salario {
            get { return salario; }
            set { salario = value; }
            }
        }
public class Diretor : Funcionario {

    //Construtor da classe Gerente
    public Diretor(string nome, int idade, string cpf, double salario) : base(nome, idade, cpf, salario) {
        //
    }

     //Sobrescrevendo o método Bônus para adicionar 100 ao bônus
    public override double Bonus {
         return base.Bonus() + 1000; //Bônus padrão do Funcionario de 10% sobre o salario + 1000
     }
}