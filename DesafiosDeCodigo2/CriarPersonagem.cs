/*
>Desafio
No mundo dos RPGs, a criação do personagem é um momento importante e emocionante para os jogadores! Durante esse processo, o jogador deve escolher o nome, a raça, a classe e outras características importantes para o personagem.

Crie uma classe chamada "Personagem" que tenha os seguintes atributos: nome (string), raça (string), classe (string), nível (inteiro), vida (inteiro) e mana (inteiro). A classe deve ter um construtor que recebe como parâmetros o nome, a raça e a classe do personagem. O nível e a vida devem ser iniciados com valores padrão (1 e 10 , respectivamente). Além disso, crie um método chamado "exibir_status" que exibe na tela o nome, a raça, a classe, o nível, a vida e a mana do personagem.

>Entrada:
A entrada deve conter as informações necessárias para a criação do personagem, como nome, raça e classe.

>Saída:
A saída deve conter a frase "Status:" seguida das informações do método "exibir_status", ou seja, deve exibir na tela o nome, a raça, a classe, o nível e a vida do personagem. Conforme exemplos abaixo.
*/

class Personagem
{
    public string Nome { get; set; }
    public string Raca { get; set; }
    public string Classe { get; set; }
    public int Nivel { get; set; } = 1;
    public int Vida { get; set; } = 10;

    public Personagem(string nome, string raca, string classe)
    {
        this.Nome = nome;
        this.Raca = raca;
        this.Classe = classe;
    }

    public void ExibirStatus()
    {
        Console.WriteLine($"Status: \nNome:{Nome} \nRaça:{Raca} \nClasse:{Classe} \nNível:1 \nVida:10");
    }
}

class Program
{
    static void Main()
    {
        string nome = Console.ReadLine();
        string raca = Console.ReadLine();
        string classe = Console.ReadLine();
        
        Personagem personagem = new Personagem(nome, raca, classe);
        
        personagem.ExibirStatus();
        
    }
}