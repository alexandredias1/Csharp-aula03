Console.WriteLine("Digite um número inteiro: ");
int numero = Convert.ToInt32(Console.ReadLine());
long fatorial = 1;

for (int i = 1; i <= numero; i++)
{
    fatorial *= i;
}

Console.WriteLine($"O fatorial de {numero} é: {fatorial}");
