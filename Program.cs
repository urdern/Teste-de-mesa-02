
using System;

class Program
{
    static void Main()
    {
        int opcao = 0;

        do
        {
            Console.WriteLine("\n=== Menu de Cálculos Financeiros ===");
            Console.WriteLine("1 - Valor Futuro (Juros Compostos)");
            Console.WriteLine("2 - Tabela de Rendimento Mensal");
            Console.WriteLine("3 - Cálculo com Entradas (Anos -> Meses)");
            Console.WriteLine("4 - Simular Resgate no 5º mês");
            Console.WriteLine("5 - Valor Presente (Dado Valor Futuro)");
            Console.WriteLine("0 - Sair");
            Console.Write("\nEscolha uma opção: ");
            
            string entrada = Console.ReadLine();
            if (!int.TryParse(entrada, out opcao))
            {
                opcao = -1;
            }

            Console.WriteLine();

            switch (opcao)
            {
                case 1:
                    ValorFuturo();
                    break;
                case 2:
                    TabelaRendimento();
                    break;
                case 3:
                    CalculoComEntradas();
                    break;
                case 4:
                    SimularResgate();
                    break;
                case 5:
                    ValorPresente();
                    break;
                case 0:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            if (opcao != 0)
            {
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
                Console.WriteLine();
            }

        } while (opcao != 0);
    }

    static void ValorFuturo()
    {
        Console.WriteLine("=== Valor Futuro (Juros Compostos) ===");

        Console.Write("Digite o valor presente (R$): ");
        double valorPresente = double.Parse(Console.ReadLine());

        Console.Write("Digite a taxa de juros mensal (%): ");
        double taxaJuros = double.Parse(Console.ReadLine()) / 100;

        Console.Write("Digite o período (em meses): ");
        int meses = int.Parse(Console.ReadLine());

        double valorFuturo = valorPresente * Math.Pow(1 + taxaJuros, meses);

        Console.WriteLine($"\nO valor futuro é: R$ {valorFuturo:F2}");
    }

    static void TabelaRendimento()
    {
        Console.WriteLine("=== Tabela de Rendimento Mensal ===");

        double valorInicial = 3800;
        double taxaJuros = 1.25 / 100;
        int meses = 6;
        double saldo = valorInicial;

        for (int i = 1; i <= meses; i++)
        {
            double rendimento = saldo * taxaJuros;
            saldo += rendimento;
            Console.WriteLine($"Mês {i}: Saldo = R$ {saldo:F2} | Rendimento = R$ {rendimento:F2}");
        }
    }

    static void CalculoComEntradas()
    {
        Console.WriteLine("=== Cálculo com Entradas ===");

        Console.Write("Digite o valor presente (R$): ");
        double valorPresente = double.Parse(Console.ReadLine());

        Console.Write("Digite a taxa de juros mensal (%): ");
        double taxaJuros = double.Parse(Console.ReadLine()) / 100;

        Console.Write("Digite o período (em anos): ");
        int anos = int.Parse(Console.ReadLine());
        int meses = anos * 12;

        double valorFuturo = valorPresente * Math.Pow(1 + taxaJuros, meses);

        Console.WriteLine($"\nO valor futuro é: R$ {valorFuturo:F2}");
    }

    static void SimularResgate()
    {
        Console.WriteLine("=== Simulação de Resgate no 5º mês ===");

        double valorInicial = 2000;
        double taxaJuros = 2.00 / 100;
        int meses = 6;
        double saldo = valorInicial;

        for (int i = 1; i <= meses; i++)
        {
            double rendimento = saldo * taxaJuros;
            saldo += rendimento;

            if (i == 5)
            {
                Console.WriteLine(">> Resgate de R$ 1000 no mês 5.");
                saldo -= 1000;
            }

            Console.WriteLine($"Mês {i}: Saldo = R$ {saldo:F2} | Rendimento = R$ {rendimento:F2}");
        }
    }

    static void ValorPresente()
    {
        Console.WriteLine("=== Cálculo do Valor Presente ===");

        Console.Write("Digite o valor futuro desejado (R$): ");
        double valorFuturo = double.Parse(Console.ReadLine());

        Console.Write("Digite a taxa de juros mensal (%): ");
        double taxaJuros = double.Parse(Console.ReadLine()) / 100;

        Console.Write("Digite o período (em meses): ");
        int meses = int.Parse(Console.ReadLine());

        double valorPresente = valorFuturo / Math.Pow(1 + taxaJuros, meses);

        Console.WriteLine($"\nO valor presente necessário é: R$ {valorPresente:F2}");
    }
}
