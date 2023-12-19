using ExemploPOO.Models;
using Interfaces;

// Em interfaces, metodos que não tem corpo são obrigatorios para a implementação, e metodos que tem corpo são opcionais para a implementação.

ICalculadora calc = new Calculadora();
Console.WriteLine(calc.Multiplicar(3, 2));

// interface implementam os métodos;



// Todas as classes derivam direta ou indiretamente da classe object.

// Computador c = new Computador();
// Console.WriteLine(c.ToString());






// Pessoa p1 = new Pessoa("Cássia");
// Aluno a1 = new Aluno("Maria");
// a1.Apresentar();

// Corrente c = new Corrente();
// c.Creditar(500);
// c.ExibirSaldo();


// Aluno a1 = new Aluno();
// a1.Nome = "Cássia";
// a1.Idade = 15;
// a1.Nota = 7.5;

// a1.Apresentar();

// Professor p1 = new Professor();
// p1.Nome = "Danilo";
// p1.Idade = 30;
// p1.Salario = 1250;

// p1.Apresentar();

// ContaCorrente c1 = new ContaCorrente(123, 1300);

// c1.ExibirSaldo();
// c1.Sacar(2000);
// c1.ExibirSaldo();
