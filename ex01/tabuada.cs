// Solicita ao usuário que insira um número
Console.Write("Digite um número: ");
int numero = int.Parse(Console.ReadLine());

// Imprime a tabuada de 1 a 10 do número fornecido
Console.WriteLine($"Tabuada do {numero}:");
for (int i = 1; i <= 10; i++)
{
    int resultado = numero * i;
    Console.WriteLine($"{numero} x {i} = {resultado}");
}

Console.ReadKey();