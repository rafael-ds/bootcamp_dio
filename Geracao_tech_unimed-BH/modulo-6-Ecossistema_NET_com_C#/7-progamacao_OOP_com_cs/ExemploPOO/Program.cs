using ExemploPOO.Interfaces;
using ExemploPOO.Models;

// Pessoa p1 = new Pessoa();
// Pessoa p2 = new Pessoa();

// p1.Nome = "Rafael";
// p1.Idade = 38;

// p2.Nome = "Manu";
// p2.Idade = 4;

// p1.Apresentar();
// p2.Apresentar();

// Retangulo r = new Retangulo();

// r.DefinirMedidas(30, 30);
// r.DefinirMedidas(-2, 30);
// System.Console.WriteLine($"Area: {r.ObterArea()}");


// Herança e Polimorfismo em tempo de execução*****************

// Aluno aluno = new Aluno();
// Professor professor = new Professor();

// aluno.Nome = "Rafael";
// aluno.Idade = 15;
// aluno.Nota = 8;
// aluno.Apresentar();

// professor.Nome = "Manu";
// professor.Idade = 28;
// professor.Salario = 3000;
// professor.Apresentar();

//Polimorfismo em tempo de compilação*****************

// Calculadora calc = new Calculadora();

// System.Console.WriteLine($"Resultado da primeira soma: {calc.Somar(2, 5)}");
// System.Console.WriteLine($"Resultado da segunda soma: {calc.Somar(2, 5, 8)}");



//Classes abstratas  *****************


// Conta conta = new Conta();
// Corrente conta = new Corrente();
// conta.Creditar(10000);
// conta.ExibirSaldo();


// //Classes object  *****************
// Computador comp = new Computador();


// System.Console.WriteLine(comp.ToString());

ICalculadora calc = new Calculadora();

System.Console.WriteLine(calc.Dividir(4, 2));
System.Console.WriteLine(calc.Somar(4, 2));