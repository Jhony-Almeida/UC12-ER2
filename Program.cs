// See https://aka.ms/new-console-template for more information

//Console.Clear();
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Turma13");

using ProgBackEnd.Classes;

PessoaFisica novaPf = new PessoaFisica();

novaPf.nome = "Jhony Almeida da Silva";
novaPf.cpf = "1547846565";

Console.WriteLine(novaPf.nome);
Console.WriteLine(novaPf.cpf);
Console.WriteLine($"---------------------------");


Console.WriteLine($"Bem-vindo {novaPf.nome} seu cpf é:{novaPf.cpf}");
