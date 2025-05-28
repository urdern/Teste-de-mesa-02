using System;

public class Exercicio4
{
    public void Calcular()
    {
        double valorPresente = 2000.00;
        double taxaJuros = 2.0 / 100;
        int totalMeses = 8;
        double rendaAcumulada = 0;
        double saldo = valorPresente;
        double resgate = 1000.00;

        Console.WriteLine("Mês\tRendimento\tRenda Líquida\tRenda Acumulada\tSaldo");

        for (int mes = 1; mes <= totalMeses; mes++)
        {
            double valorFuturo = saldo * (1 + taxaJuros);
            double rendimento = valorFuturo - saldo;
            rendaAcumulada += rendimento;

            if (mes == 5)
            {
                saldo = valorFuturo - resgate;
            }
            else
            {
                saldo = valorFuturo;
            }

            Console.WriteLine($"{mes}\tR$ {rendimento:F2}\t\tR$ {rendimento:F2}\t\tR$ {rendaAcumulada:F2}\t\tR$ {saldo:F2}");
        }
    }
}
