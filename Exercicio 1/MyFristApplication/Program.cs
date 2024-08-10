using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<List<List<string>>> geladeira = new List<List<List<string>>>();

        //Estrutura da Geladeira
        for (int i=0; i<3; i++)
        {
            geladeira.Add(new List<List<string>>());
            for (int j = 0; j < 2; j++)
            {
                geladeira[i].Add(new List<string>());
                for (int k = 0; k < 4; k++)
                {
                    geladeira[i][j].Add(null);
                }
            }
        }

        // Alguns itens da Geladeira
        geladeira[0][0][0] = "Maçã";
        geladeira[0][1][1] = "Cenoura";
        geladeira[1][1][2] = "Leite";
        geladeira[1][0][3] = "Queijo";
        geladeira[2][1][2] = "Presunto";
        geladeira[2][0][0] = "Ovos";


        //Mostrar itens
        for (int andar = 0; andar < 3; andar++)
        {
            for (int container = 0; container < 2; container++)
            {
                for (int posicao = 0; posicao < 4; posicao++)
                {
                    string item = geladeira[andar][container][posicao];
                    if (item != null)
                    {
                        Console.WriteLine($"Andar {andar}, Container {container}, Posição {posicao}: {item}");
                    }
                }
            }
        }

        Console.ReadLine();
    }
}