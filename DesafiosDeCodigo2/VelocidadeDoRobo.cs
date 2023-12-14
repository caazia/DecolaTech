class Robo
{
  public int velocidadeAtual { get; set; } = 0;
  public int velocidadeMaxima { get; }
  public int velocidadeMinima { get; }

  public Robo(int velocidadeMinima, int velocidadeMaxima)
  {
    this.velocidadeMinima = velocidadeMinima;
    this.velocidadeMaxima = velocidadeMaxima;
    this.velocidadeAtual = velocidadeMinima;
  }

  public void Acelerar()
  {
    if (velocidadeAtual < velocidadeMaxima)
    {
      this.velocidadeAtual++;
    }
  }

  public void Desacelerar()
  {
    if (velocidadeAtual > velocidadeMinima)
    {
      this.velocidadeAtual--;
    }
  }

  public void Comandos(string comandos)
  {
    foreach (var palavra in comandos)
    {
      if (palavra == 'A')
      {
        Acelerar();
      }
      else
      {
        Desacelerar();
      }
    }
  }
}

class Program
{
  static void Main()
  {
    int Vmin, Vmax;

    string velocidade = Console.ReadLine();
    string comandos = Console.ReadLine();
    string[] velocidades = velocidade.Split(" ");
    Vmin = int.Parse(velocidades[0]);
    Vmax = int.Parse(velocidades[1]);



    Robo robo = new Robo(Vmin, Vmax);
    robo.Comandos(comandos);

    Console.WriteLine(robo.velocidadeAtual);
  }
}