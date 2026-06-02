using System.ComponentModel.Design;
using System.Security.Cryptography;

Console.WriteLine("Olá Mundo");


Console.WriteLine("ETAPA 1: FUNDAMENTOS DE SAÍDA DE DADOS: ");
Console.ReadLine();



string nome;
Console.WriteLine("Escreva seu nome: ");
nome = Console.ReadLine() ?? "";
Console.WriteLine("Olá " + nome + ", bem-vindo ao curso de C#");


Console.WriteLine("FIM!");


Console.WriteLine("Digite o ano de seu nacimento? ");
int anoNascimento = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o ano atual ?");
int anoAtual = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Qual é sua idade ?");
int idadeAtual = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("FIM!");


Console.WriteLine("Digite uma nota? ");
double nota1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a segunda nota?");
double nota2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a terceira nota? ");
double nota3 = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("FIM!");


double media = (nota1 + nota2 + nota3) / 5;
Console.WriteLine("Sua média final é: " + media);


Console.WriteLine("FIM!");


double cotacaoDolar = 5.50; 

Console.WriteLine("Digite o valor em reais (R$): ");
double valorReais = Convert.ToDouble(Console.ReadLine());

double valorDolar = valorReais / cotacaoDolar;

Console.WriteLine("O valor em dólar é: (US$): " + valorDolar);


Console.WriteLine("FIM!");


Console.WriteLine("ETAPA 2: ESTRUTURA CONDICIONAIS: ");
Console.ReadLine();


Console.WriteLine("Digite um número: ");
int numero = Convert.ToInt32(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine("O número é par.");
}
else
{
    Console.WriteLine("O número é ímpar.");
}


Console.WriteLine("FIM!");


Console.WriteLine("Digite uma nota: ");
nota1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a segunda nota: ");
nota2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a terceira nota: ");
nota3 = Convert.ToDouble(Console.ReadLine());

media = (nota1 + nota2 + nota3) / 3;


Console.WriteLine("FIM!");


Console.WriteLine("Sua média é: " + media);

if (media >= 7)
{
    Console.WriteLine("Aprovado");
}
else if (media >= 5 && media < 7)
{
    Console.WriteLine("Recuperação");
}
else
{
    Console.WriteLine("Reprovado");
}


Console.WriteLine("FIM!");


double peso, altura, imc;

Console.WriteLine("Digite seu peso (kg): ");
peso = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite sua altura (m): ");
altura = Convert.ToDouble(Console.ReadLine());

imc = peso / (altura * altura);

Console.WriteLine("Seu IMC é: " + imc.ToString("F2"));

if (imc < 18.5)
{
    Console.WriteLine("Classificação: Abaixo do peso");
}
else if (imc >= 18.5 && imc < 25)
{
    Console.WriteLine("Classificação: Peso ideal");
}
else if (imc >= 25 && imc < 30)
{
    Console.WriteLine("Classificação: Sobrepeso");
}
else if (imc >= 30 && imc < 35)
{
    Console.WriteLine("Classificação: Obesidade grau 1");
}
else if (imc >= 35 && imc < 40)
{
    Console.WriteLine("Classificação: Obesidade grau 2");
}
else
{
    Console.WriteLine("Classificação: Obesidade grau 3");
}


Console.WriteLine("FIM!");


int opcao;

Console.WriteLine("MENU DE OPÇÕES");
Console.WriteLine("1 - Soma ");
Console.WriteLine("2 - Subtração ");
Console.WriteLine("3 - Sair ");

Console.WriteLine("Escolha uma opção:"); 
opcao = Convert.ToInt32(Console.ReadLine());

if (opcao == 1)
{
    Console.WriteLine("Você escolheu: Soma");
}
else if (opcao == 2)
{
    Console.WriteLine("Você escolheu: Subtração");
}
else if (opcao == 3)
{
    Console.WriteLine("Você escolheu: Sair");
}
else
{
    Console.WriteLine("Opção inválida");
}


Console.WriteLine("FIM!");

Console.WriteLine("ETAPA 3: LAÇOS DE REPETIÇÃO: ");
Console.ReadLine();


int numeroTabuada;

Console.WriteLine("Digite um número para ver a tabuada: ");
numeroTabuada = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nTabuada do " + numeroTabuada);
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(numeroTabuada + " x " + i + " = " + (numeroTabuada * i));
}


Console.WriteLine("FIM!");


int numeroContagem;

Console.WriteLine("Digite o número para começar a contagem? ");
numeroContagem = Convert.ToInt32(Console.ReadLine());

while (numeroContagem >= 0)
{
    Console.WriteLine(numeroContagem);

    Thread.Sleep(50); // intervalo de 1 segundo

    numeroContagem--;
}


Console.WriteLine("FIM!");


int numeroSair = -1;
int soma = 0;

while (numeroSair!= 0)
{
    Console.Write("Digite um número (0 para sair): ");
    numeroSair = Convert.ToInt32(Console.ReadLine());

    soma += numeroSair;
}

Console.WriteLine("A soma dos números digitados é: " + soma);

string senhaCorreta = "1234";
string senha = "";

while (senha != senhaCorreta)
{
    Console.WriteLine("Digite a senha: ");
    senha = Console.ReadLine();

    if (senha != senhaCorreta)
    {
        Console.WriteLine("Senha incorreta. Tente novamente.");
    }
}

Console.WriteLine("Senha correta! Acesso liberado.");
Console.WriteLine("FIM DA PROGRAMÇÃO!!!!!!!!!!!!!!!!");






