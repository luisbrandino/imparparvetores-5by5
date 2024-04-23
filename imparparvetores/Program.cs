/*
2 - Faça um programa que leia dez numeros inteiros e faça os seguintes itens:
A) Imprima o vetor lido;
B) Imprima o vetor de tras pra frente;
C) Imprima até a metadae do vetor;
D) Guarde os valores impares/pares em um novo vetor sem os valores 0 e imprima;
*/

int[] numbers = new int[10];

for (int i = 0; i < 10; i++)
{
    Console.Write($"Informe o {i + 1}º número: ");
    numbers[i] = int.Parse(Console.ReadLine());
}

int[] evenNumbers = new int[10];
int[] oddNumbers = new int[10];

int quantityOfEvenNumbers = 0;
for (int i = 0; i < 10; i++)
{
    if (numbers[i] == 0)
        continue;

    if (numbers[i] % 2 == 0)
        evenNumbers[quantityOfEvenNumbers++] = numbers[i];
}

int quantityOfOddNumbers = 0;
for (int i = 0; i < 10; i++)
{
    if (numbers[i] % 2 != 0)
        oddNumbers[quantityOfOddNumbers++] = numbers[i];
}

Console.WriteLine("\nVetor: ");

for (int i = 0; i < 10; i++)
    Console.Write($"{numbers[i]} ");

Console.WriteLine("\nVetor de trás pra frente: ");

for (int i = 9; i >= 0; i--)
    Console.Write($"{numbers[i]} ");

Console.WriteLine("\nMetade do vetor: ");

for (int i = 0; i < 5; i++)
    Console.Write($"{numbers[i]} ");

Console.WriteLine("\nNúmeros pares: ");

for (int i = 0; i < quantityOfEvenNumbers; i++)
    Console.Write($"{evenNumbers[i]} ");

Console.WriteLine("\nNúmeros ímpares: ");

for (int i = 0; i < quantityOfOddNumbers; i++)
    Console.Write($"{oddNumbers[i]} ");