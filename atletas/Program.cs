using System;

class Program
{
    static void Main()
    {
        string[] nomes = new string[100]; // Array para armazenar os nomes dos atletas
        double[] pesos = new double[100]; // Array para armazenar os pesos levantados
        int contador = 0; // Contador para o número de atletas registrados
        string input;

        while (true)
        {
            Console.Write("Digite o nome do atleta (ou 'calcular' para ver o resultado): ");
            input = Console.ReadLine().ToLower();

            if (input == "calcular")
            {
                break;
            }

            nomes[contador] = input;

            Console.Write("Digite a quantidade de quilos levantados por " + input + ": ");
            pesos[contador] = double.Parse(Console.ReadLine());
            contador++;
        }

        if (contador > 0)
        {
            double maxPeso = 0;
            double segundoMaxPeso = 0;
            double terceiroMaxPeso = 0;

            string vencedor = "";
            string segundoLugar = "";
            string terceiroLugar = "";

            int i = 0;
            while (i < contador)
            {
                if (pesos[i] > maxPeso)
                {
                    // Atualiza posições de prata e bronze
                    terceiroMaxPeso = segundoMaxPeso;
                    terceiroLugar = segundoLugar;

                    segundoMaxPeso = maxPeso;
                    segundoLugar = vencedor;

                    // Atualiza o vencedor (ouro)
                    maxPeso = pesos[i];
                    vencedor = nomes[i];
                }
                else if (pesos[i] > segundoMaxPeso)
                {
                    // Atualiza posição de bronze
                    terceiroMaxPeso = segundoMaxPeso;
                    terceiroLugar = segundoLugar;

                    // Atualiza o segundo lugar (prata)
                    segundoMaxPeso = pesos[i];
                    segundoLugar = nomes[i];
                }
                else if (pesos[i] > terceiroMaxPeso)
                {
                    // Atualiza o terceiro lugar (bronze)
                    terceiroMaxPeso = pesos[i];
                    terceiroLugar = nomes[i];
                }

                i++;
            }

            Console.WriteLine("\nO vencedor da medalha de ouro é " + vencedor + " com " + maxPeso + " quilos levantados.");
            Console.WriteLine("O vencedor da medalha de prata é " + segundoLugar + " com " + segundoMaxPeso + " quilos levantados.");
            Console.WriteLine("O vencedor da medalha de bronze é " + terceiroLugar + " com " + terceiroMaxPeso + " quilos levantados.");
        }
        else
        {
            Console.WriteLine("Nenhum atleta foi registrado.");
        }
    }
}
