class Pessoa
{
  private string nome;
  private int idade;


    public Pessoa(string nome, int idade)
    {
      
        this.nome = nome;
        this.idade = idade;
        
    }

    public string GetNome()
    {
        return nome;
    }

    public int GetIdade()
    {
        return idade;
    }
}

class Program
{
    static void Main()
    {
      
      string nome = Console.ReadLine();
      int idade = int.Parse(Console.ReadLine());
      
      Pessoa pessoa = new Pessoa(nome, idade);
         
      Console.WriteLine("Nome: {0}, Idade: {1}", pessoa.GetNome(), pessoa.GetIdade());
    }
}