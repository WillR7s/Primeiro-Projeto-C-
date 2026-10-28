/*
Console.WriteLine("Hello, World!");

Console.Write("Digite seu nome: ");
string? nome = Console.ReadLine();

Console.Write("Digite seu sobrenome: ");
string? sobrenome = Console.ReadLine();

// Concatenação de valores
Console.WriteLine("Meu nome é " + nome + " e o sobre nome é "  + sobrenome);

// Interpolação de valores
Console.WriteLine($"Meu nome é {nome} e o sobrenome é {sobrenome}");
*/

// Formatação de valores
//using System.Net.NetworkInformation;

/*decimal preco = 1250.5m;

Console.WriteLine($"Preço: {preco:F2}");
Console.WriteLine($"Preço: {preco:C}");

preco = 1000.00m;

const double pi = 3.1415;
// pi = 3.14;*/


//Conversão de tipos 
/*
double Valor = 9.8;
int Numero = (int)Valor;

Console.WriteLine(Numero);

string texto ="25";
int Idade = int.Parse(texto);
Console.WriteLine(Idade);
*/

//TryParse : tenta converter um valor sem lançar uma exceção quando a conversão falha

/*string texto ="25W";

if(int.TryParse(texto,out int idade))
{
    Console.WriteLine($"Idade: {idade}");
}

else
{
    Console.WriteLine("Valor Invalido");
}*/

// Estrutura de Decisão

/*int idade = 30;

if (idade >=18 && idade <20)
{
    Console.WriteLine("Jovem.");
}

else if (idade >18 && idade <=60)
{
    Console.WriteLine("Adulto");
}
else if (idade >60)
{
    Console.WriteLine("Idoso");
}*/

//Switch Case

/*Console. WriteLine("""
Selecione uma das opções abaixo:
1 - Cadastrar
2 - Consultar
3 - Excluir
""");

Console.Write("Digite uma opção:");
int opcao = int.Parse(Console.ReadLine()!);

switch (opcao)
{
    case 1:
    Console.WriteLine("Opção Cadastrar foi selecionada.");
    break;

    case 2:
    Console.WriteLine("Opção Consultar foi selecionada.");
    break;

    case 3:
    Console.WriteLine("Opção Excluir foi selecionada.");
    break;

    default: 
    Console.WriteLine("Opção Invalida");
    break;
   
    
}
*/

//Estruturas de repetição 
/*For

for (int i= 5; i<= 1 ; i--)
{
    Console.WriteLine(i);
}
*/

//while
/*
int i = 1;

while (i <=5)
{
    Console.WriteLine(i);
}
*/
//do While

/*string senha;

do
{
    Console.WriteLine("digite sua senha:");
    senha = Console.ReadLine()!;
    
} while (senha != "123");
Console.WriteLine("Acesso Liberado");*/

//Metodos:

// void ExibirMensagem()
// {
//     Console.WriteLine("Hello Word");
// }

// ExibirMensagem();

// void ExibirNome(String nome)
// {
//     Console.WriteLine($"Olá, {nome}!");
// }
// ExibirNome("Willian");

// int Somar (int a,int b)
// {
//     if(a>0)
//     {
//         return a + b;
//     }

//     else
//     {
//         return 0;
//     }
// }

// Console.WriteLine(Somar(5,3));

int [] numeros = {10,20,30,40,50}; // instanciando o array ja definindo seus valores e posições

string [] nomes = new string [3]; // Criando um arreay que ja possui 3 posições sem valores definidos 

nomes[0] = "Ana";
nomes[1] = "Bruno";
nomes[2] = "Carla";

Console.WriteLine(nomes [0]);
Console.WriteLine(nomes [1]);
Console.WriteLine(nomes [2]);