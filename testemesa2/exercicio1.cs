using System;

public class Exercicio1
{
    public void Calcular()
    {
        // Entradas
        Console.Write("Digite o valor presente (R$): ");
        double valorPresente = double.Parse(Console.ReadLine());

        Console.Write("Digite a taxa de juros mensal (%): ");
        double taxaJurosPercentual = double.Parse(Console.ReadLine());
        double taxaJuros = taxaJurosPercentual / 100;

        Console.Write("Digite o período em meses: ");
        int periodoMeses = int.Parse(Console.ReadLine());

        // Cálculo do valor futuro
        double valorFuturo = valorPresente * Math.Pow(1 + taxaJuros, periodoMeses);

        // Saída
        Console.WriteLine($"\nValor Futuro após {periodoMeses} meses: R$ {valorFuturo:F2}");
    }
}
