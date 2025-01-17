/*
Ex.06 -Classificação de notas

 
Objetivo: Aprenda a usar várias condições em uma estrutura de decisão. 
Descrição: Crie um programa que solicite a nota de um aluno e classifique a nota em categorias: "Excelente" (nota >= 9), "Bom" (7 <= nota < 9), "Regular" (5 <= nota < 7) e "Baixo" (nota < 5). Exiba a classificação na tela. 
Saída de amostra: "Excelente", "Bom", "Razoável" ou "Baixo".
   */

using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a nota do aluno: ");
        double nota = double.Parse(Console.ReadLine());

        if (nota >= 9)
        {
            Console.WriteLine("Excelente");
        }
        else if (nota >= 7)
        {
            Console.WriteLine("Bom");
        }
        else if (nota >= 5)
        {
            Console.WriteLine("Regular");
        }
        else
        {
            Console.WriteLine("Baixo");
        }
    }
}
