using System;

public class Exercicio5
{
    public void Calcular()
    {
        Console.Write("Digite o Valor Futuro (R$): ");
        double valorFuturo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a Taxa de Juros Anual (%): ");
        double taxaJuros = Convert.ToDouble(Console.ReadLine()) / 100;

        Console.Write("Digite o número de períodos (em anos): ");
        int anos = Convert.ToInt32(Console.ReadLine());

        double valorPresente = valorFuturo / Math.Pow(1 + taxaJuros, anos);

        Console.WriteLine($"\nValor Presente necessário para alcançar R$ {valorFuturo} em {anos} anos com taxa de {taxaJuros * 100}% a.a.:");
        Console.WriteLine($"R$ {valorPresente:F2}");
    }
}
