/*
Ex.03 -Aprovação do aluno

 
Objetivo: Compreender a aplicação das condições para a tomada de decisão. 
Descrição: Escreva um programa que solicite a nota de um aluno. Se a nota for maior ou igual a 6, o aluno é considerado "Aprovado". Caso contrário, ele está "falhando". Exiba a situação do aluno na tela. 
Exemplo de saída: "Aluno aprovado." ou "Aluno reprovado".
   */

using System;

class Program
{
    static void Main()
    {
        // Solicita a nota do aluno
        Console.Write("Digite a nota do aluno: ");
        double nota = double.Parse(Console.ReadLine());

        // Verifica se a nota é maior ou igual a 6
        if (nota >= 6)
        {
            Console.WriteLine("Aluno aprovado.");
        }
        else
        {
            Console.WriteLine("Aluno reprovado.");
        }
    }
}
