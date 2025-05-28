using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("===== TESTE DE MESA CALCULOS =====");
            Console.WriteLine("1 - Exercício 1");
            Console.WriteLine("2 - Exercício 2");
            Console.WriteLine("3 - Exercício 3");
            Console.WriteLine("4 - Exercício 4");
            Console.WriteLine("5 - Exercício 5");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    var ex1 = new Exercicio1();
                    ex1.Calcular();
                    break;
                case "2":
                    var ex2 = new Exercicio2();
                    ex2.Calcular();
                    break;
                case "3":
                    var ex3 = new Exercicio3();
                    ex3.Calcular();
                    break;
                case "4":
                    var ex4 = new Exercicio4();
                    ex4.Calcular();
                    break;
                case "5":
                    var ex5 = new Exercicio5();
                    ex5.Calcular();
                    break;
                case "0":
                    Console.WriteLine("Encerrando...");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Pressione qualquer tecla para tentar novamente.");
                    break;
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }
    }
}


