/*

Ex.10 - Cálculo de desconto

 
Objetivo: Aplicar condições para cálculos. 

Descrição: Escreva um programa que solicite o valor de uma compra e verifique se o valor é maior que 100. Em caso afirmativo, aplique um desconto de 10% sobre o valor e mostre o valor final. Caso contrário, exiba o valor original.
 
Saída de amostra: "Valor descontado: [valor final]." ou "Valor original: [valor]
 
    */

using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o valor da compra: R$ ");
        double valorCompra = double.Parse(Console.ReadLine());

        if (valorCompra > 100)
        {
            double desconto = valorCompra * 0.10;
            double valorFinal = valorCompra - desconto;
            Console.WriteLine($"Valor descontado: R$ {valorFinal:F2}");
        }
        else
        {
            Console.WriteLine($"Valor original: R$ {valorCompra:F2}");
        }
    }
}
