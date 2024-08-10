int soma = 0;
int numero;
bool condicao = true;

while (condicao == true)
{
    Console.WriteLine("Entre com um número para somar, caso seja 0, o programa para...");
    numero = Convert.ToInt32(Console.ReadLine());
    if (numero == 0)
    {
        break;
    }
    else
    {
        if (numero % 2 == 0)
        {
            soma += numero;
            Console.WriteLine("O somatório atual é:" + soma);
        }
        else
        {
            soma -= numero;
            Console.WriteLine("O somatório atual é:" + soma);
        }
    }
}
Console.WriteLine("O somatório Final é:" + soma);