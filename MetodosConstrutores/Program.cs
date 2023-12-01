using MetodosConstrutores.Models;

Pessoa p1 = new Pessoa(nome: "Cássia", sobrenome: "Carvalho");

Pessoa p2 = new Pessoa(nome: "Danilo", sobrenome: "Acioly");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();



// Pessoa p1 = new Pessoa();
// p1.Nome = "Cássia";
// p1.Sobrenome = "Carvalho";
// p1.Idade = 29;
// p1.Apresentar();
