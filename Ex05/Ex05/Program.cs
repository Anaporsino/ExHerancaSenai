﻿using Ex05;
{ 

Funcionario func1 = new Funcionario { Nome = "Rafael", Idade = 30 };


func1.Envelhecer(10); 
Console.WriteLine($"Nome: {func1.Nome}, Idade: {func1.Idade}");

func1.Rejuvenecer(10);
Console.WriteLine($"Nome: {func1.Nome}, Idade: {func1.Idade}");

Funcionario func2 = new Funcionario { Nome = "Amanda", Idade = 20 };
func2.Envelhecer(14);
Console.WriteLine($"Nome: {func2.Nome}, Idade: {func2.Idade}");

func2.Rejuvenecer(11);
Console.WriteLine($"Nome: {func2.Nome}, Idade: {func2.Idade}");

Funcionario func3 = new Funcionario { Nome = "Livia", Idade = 15 };
func3.Envelhecer(36);
Console.WriteLine($"Nome: {func3.Nome}, Idade: {func3.Idade}");

func2.Rejuvenecer(9;
Console.WriteLine($"Nome: {func3.Nome}, Idade: {func3.Idade}");

//Encerra o programa!
Console.WriteLine("Pressione qualquer tecla para sair");
Console.ReadKey();

}