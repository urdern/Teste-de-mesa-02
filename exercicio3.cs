using System;

public class Exercicio3
{
    public void Calcular()
    {
        Console.Write("Digite o Valor Presente: R$ ");
        double valorPresente = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a Taxa de Juros (% a.m.): ");
        double taxaJuros = Convert.ToDouble(Console.ReadLine()) / 100;

        Console.Write("Digite o Período (em anos): ");
        int periodoAnos = Convert.ToInt32(Console.ReadLine());

        int totalMeses = periodoAnos * 12;

        double valorFuturo = valorPresente * Math.Pow(1 + taxaJuros, totalMeses);
        double rendimento = valorFuturo - valorPresente;

        Console.WriteLine($"\nValor Futuro: R$ {valorFuturo:F2}");
        Console.WriteLine($"Rendimento: R$ {rendimento:F2}");
    }
}
