using System;

public class Timoteo {
    //Atributos
    private string nome;
    private string cor;
    private int idade;
    private double altura;
    private char genero;

    //Construtor
    public Timoteo(string nome, string cor, int idade, double altura, char genero){
        this.nome = nome;
        this.cor = cor;
        this.idade = idade;
        this.altura = altura;
        this.genero = genero;
    }
    //Metodos
    public void infoTimoteo() {
        Console.WriteLine($"Nome: {nome}, idade: {idade}, altura: {altura}, genero: {genero}");
    }
    public void correr() {
        Console.WriteLine("Correndo.");
    }
    public void pular() {
        Console.WriteLine("pulando.");
    }
}
 public class Wander : Timoteo {

    public Wander () {
        this.nome = "Wander"
        this.cor = "Branco"
        this.idade = 22;
        this.altura = 1.97;
        this.genero = "M";

        public void Rindo() {
            Console.WriteLine("Wander está rindo")
        }
    }
 }
 public class Son : Timoteo {

    public Son () {
        this.nome = "Son"
        this.cor = "Branco"
        this.idade = 19;
        this.altura = 2.17;
        this.genero = "M";

        public void Comendo() {
            COnsole.WriteLine("Son está comendo")
        }
    }
 }
 class Program {
    static void Main(string[] args) {
        Wander wander = new Wander();
        Son son = new Son ();

        Console.WriteLine($"Nome: {wander.Nome}, Cor: {wander.Cor}, Idade: {wander.Idade}, Altura: {wander.Altura}, Gênero: {wander.Genero}");

        wander.Correr();
        wander.Pular();
        wander.Rindo();

        Console.WriteLine();
        Console.WriteLine($"Nome: {son.Nome}, Cor: {son.Cor}, Idade: {son.Idade}, Altura: {son.Altura}, Gênero: {son.Genero}");

        son.Correr();
        son.Pular();
        son.Comendo();
    }
 }