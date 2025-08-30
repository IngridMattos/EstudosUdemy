// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;

namespace EstudosUdemy {
    class Program {
        static void Main(string[] args) {
            //String produto1 = "Computador";
            //String produto2 = "Mesa de escritório";
            //byte idade = 30;
            //int cadigo = 5290;
            //char genero = 'M';
            //double preco1 = 2100.0;
            //double preco2 = 650.50;
            //double medida = 53.234567;

            //Console.WriteLine("Produtos:");
            //Console.WriteLine($"{produto1}, cuso preço é $ {preco1}");
            //Console.WriteLine($"{produto2}, cuso preço é $ {preco2}");
            //Console.WriteLine($"Registro: {idade} anos de idade, código {cadigo} e genero: {genero}");
            //Console.WriteLine($"Medida com oito casas decimais: {medida}");
            //Console.WriteLine($"Arredondado (trÊs casas decimais) {medida.ToString("F3")}");
            //Console.WriteLine($"Arredondado (trÊs casas decimais) {medida.ToString("F3", CultureInfo.InvariantCulture)}");

            //int a = 10;
            //Console.WriteLine(a);
            //a += 2;
            //Console.WriteLine(a);
            //a *= 3;
            //Console.WriteLine(a);
            //a /= 2;
            //Console.WriteLine(a);
            //string s = "ABC";
            //Console.WriteLine(s);
            //s += "DEF";
            //Console.WriteLine(s);

            //int b = 10;
            //b++;
            //Console.WriteLine(b);
            //b--;
            //Console.WriteLine(b);

            //String nome = Console.ReadLine();
            //int quartos = int.Parse(Console.ReadLine());
            //double produto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //string[] infos = Console.ReadLine().Split(' ');

            //Console.WriteLine(nome);
            //Console.WriteLine(quartos);
            //Console.WriteLine(produto.ToString("F2", CultureInfo.InvariantCulture));

            //Console.WriteLine(infos[0]);
            //Console.WriteLine(int.Parse(infos[1]));
            //Console.WriteLine(double.Parse(infos[2], CultureInfo.InvariantCulture).ToString("F2", CultureInfo.InvariantCulture));

            //1
            //int numero1, numero2, soma;
            //numero1 = int.Parse(Console.ReadLine());
            //numero2 = int.Parse(Console.ReadLine());
            //soma = numero1 + numero2;

            //Console.WriteLine($"A SOMA É: {soma}");

            //2
            //double R, A, pi = 3.14159;
            //R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //A = pi * R * R;
            //Console.WriteLine("A=" + A.ToString("F2", CultureInfo.InvariantCulture));

            //3
            //int a, b, c, d, DIFERENÇA;
            //a = int.Parse(Console.ReadLine());
            //b = int.Parse(Console.ReadLine());
            //c = int.Parse(Console.ReadLine());
            //d = int.Parse(Console.ReadLine());

            //DIFERENÇA = a * b - c * d;

            //Console.WriteLine("DIFERENÇA" + DIFERENÇA);

            //4 
            //double numeroDoFuncionario, horasTrabalhadas, valorPorHora, salario;

            //numeroDoFuncionario = double.Parse(Console.ReadLine());
            //horasTrabalhadas = double.Parse(Console.ReadLine());
            //valorPorHora = double.Parse(Console.ReadLine());

            //salario = (horasTrabalhadas * valorPorHora);

            //Console.WriteLine("NUMBER = " + numeroDoFuncionario);
            //Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));

            //5 

            //int codigoPeça1, quantidadePeça1, codigoPeça2, quantidadePeça2;
            //double valorPeça1, valorPeça2;

            //codigoPeça1 = int.Parse(Console.ReadLine());
            //quantidadePeça1 = int.Parse(Console.ReadLine());
            //valorPeça1 = double.Parse(Console.ReadLine());
            //codigoPeça2 = int.Parse(Console.ReadLine());
            //quantidadePeça2 = int.Parse(Console.ReadLine());
            //valorPeça2 = double.Parse(Console.ReadLine());

            //double c1 = quantidadePeça1 * valorPeça1;

            //double c2 = quantidadePeça2 * valorPeça2;

            //Console.WriteLine($"VALOR A PAGAR: R$ {c1 + c2}");

            // exercicios de estruturas condicionais

            //int numero = int.Parse(Console.ReadLine());

            //if( numero % 2 == 0) {
            //    Console.WriteLine("par");
            //} else {
            //    Console.WriteLine("impar");
            //}


            // 3 
            //int numero1 = int.Parse(Console.ReadLine());
            //int numero2 = int.Parse(Console.ReadLine());


            //if (numero1 % numero2 == 0 || numero2 % numero1 == 0) {
            //    Console.WriteLine("são multiplos");
            //}
            //else {
            //    Console.WriteLine("Não são multiplos");
            //}


            //4
            //double codigo = int.Parse(Console.ReadLine());
            //int quantidade = int.Parse(Console.ReadLine());
            //double valor;


            //if (codigo == 1) {
            //    valor = quantidade * 4.00;
            //} else if (codigo == 2) {
            //    valor = quantidade * 4.50;
            //}
            //else if (codigo == 3) {
            //    valor = quantidade * 5.00;
            //}
            //else if (codigo == 4) {
            //    valor = quantidade * 2.00;
            //} else {
            //    valor = quantidade * 1.50;
            //}
            //Console.WriteLine("TOTAL: R$ "+ valor.ToString("F2", CultureInfo.InvariantCulture));

            //5

            //double intervaloRecebido = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //string intervaloDeSaida;
            //if(intervaloRecebido <= 0 || intervaloRecebido > 100) {
            //    intervaloDeSaida = "FORA DO INTERVALO";

            //} else if (intervaloRecebido >= 0 && intervaloRecebido <= 25) {
            //    intervaloDeSaida = "Intervalo [0,25]";
            //}
            //else if (intervaloRecebido <= 50) {
            //    intervaloDeSaida = "Intervalo [25,50]";
            //}
            //else if (intervaloRecebido <= 75) {
            //    intervaloDeSaida = "Intervalo [50,75]";
            //}
            //else {
            //    intervaloDeSaida = "Intervalo [75,100]";
            //}
            //Console.WriteLine(intervaloDeSaida);

            // while 
            //1 

            //int valorDigitado = int.Parse(Console.ReadLine());
            //int senha = 2002;

            //while(valorDigitado != senha) {
            //    Console.WriteLine("senha invalida");
            //    Console.Write("digite a senha novamente: ");
            //    valorDigitado = int.Parse(Console.ReadLine());
            //}
            //    Console.WriteLine("Acesso Permitido");

            //2
            //int codigo = int.Parse(Console.ReadLine());

            //int alcool = 0, gasolina = 0, diesel = 0;

            //while (codigo != 4) {
            //    switch (codigo) {
            //        case 1: alcool++; break;
            //        case 2: gasolina++; break;
            //        case 3: diesel++; break;
            //    }
            //    codigo = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("MUITO OBRIGADO");
            //Console.WriteLine("Alcool: " + alcool);
            //Console.WriteLine("Gasolina: " + gasolina);
            //Console.WriteLine("Diesel: " + diesel);

            // exercicio de for
            //1

            //int entrada = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= entrada; i++) {
            //    if (i % 2 != 0) {
            //        Console.WriteLine(i);
            //    }
            //}

            //2
            //Pessoas p = new Pessoas();
            //p.Nome = Console.ReadLine();
            //p.Idade = int.Parse(Console.ReadLine());

            //Pessoas p2 = new Pessoas();
            //p2.Nome = Console.ReadLine();
            //p2.Idade = int.Parse(Console.ReadLine());


            //if (p.Idade > p2.Idade) {
            //    Console.WriteLine($"Pessoa mais velha: {p.Nome}");
            //}
            //else {
            //    Console.WriteLine($"Pessoa mais velha: {p2.Nome}");
            //}

            // 3

            //Pessoas p = new() {
            //    Nome = Console.ReadLine(),
            //    Salario = double.Parse(Console.ReadLine())
            //};

            //Pessoas p2 = new() {
            //    Nome = Console.ReadLine(),
            //    Salario = double.Parse(Console.ReadLine())
            //};

            //double media = (p.Salario + p2.Salario) / 2;
            //Console.WriteLine($"Média do salário é: {media}");

            // exercicio programação orientada a objetos
            //1
            //Retangulo retangulo = new Retangulo();
            //Console.WriteLine("Digite a altura do retangulo: ");
            //retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("Digite a largura do retangulo: ");
            //retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.WriteLine(retangulo);

            //2
            //Nome: Joao Silva
            //Salário bruto: 6000.00
            //Imposto: 1000.00
            //Funcionarios funcionario = new Funcionarios();
            //Console.Write("Digite o Nome: ");
            //funcionario.Nome = Console.ReadLine();
            //Console.Write("Salário bruto: ");
            //funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Imposto: ");
            //funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.WriteLine($"Funcionário: {funcionario}");
            //Console.Write($"Digite a porcentagem para aumentar o salário: ");
            //double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //funcionario.AumentarSalario(porcentagem);
            //Console.WriteLine($"Dados atualizados: {funcionario}");
            //3

            
            Console.WriteLine("Entre o número da conta: ");
            int numeroDaConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre o titular da conta: ");
            string nomeDoTitular = Console.ReadLine();

            Console.WriteLine("Haverá depósito inicial (s/n)? ");
            char valorInicial = Console.ReadKey().KeyChar;
            Console.WriteLine(" ");
            ContaBanco novaContaNoBanco ;
            double deposito;
            if (valorInicial == 's' || valorInicial == 'S') {
                Console.WriteLine("Entre o valor de depósito inicial: ");
                deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                novaContaNoBanco = new ContaBanco(numeroDaConta, nomeDoTitular, deposito);
            } else {
                novaContaNoBanco = new ContaBanco(numeroDaConta, nomeDoTitular);
            }

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(novaContaNoBanco);
            Console.WriteLine();
            Console.WriteLine("Entre um valor para depósito: ");
            deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            novaContaNoBanco.Deposito(deposito);
            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(novaContaNoBanco);
            
            Console.WriteLine();
            Console.WriteLine("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            novaContaNoBanco.Saque(saque);
            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(novaContaNoBanco);



        }
    }
}