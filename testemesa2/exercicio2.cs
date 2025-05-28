using System;

public class Exercicio2
{
    public void Calcular()
    {
        double valorPresente = 3800.00;
        double taxaJuros = 1.25 / 100;
        int meses = 6;

        Console.WriteLine("Mês\tValor Futuro\tRendimento\tRenda Líquida\tRenda Acumulada");

        double rendaAcumulada = 0;

        for (int mes = 1; mes <= meses; mes++)
        {
            double valorFuturo = valorPresente * Math.Pow(1 + taxaJuros, mes);
            double rendimento = valorFuturo - valorPresente;
            rendaAcumulada += rendimento;

            Console.WriteLine($"{mes}\tR$ {valorFuturo:F2}\tR$ {rendimento:F2}\tR$ {(valorFuturo - valorPresente):F2}\tR$ {rendaAcumulada:F2}");
        }
    }
}
