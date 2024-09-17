using System;
using System.Threading;
internal class Program
{
    private static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("S = Segundos (10s = 10 segundos)");
        Console.WriteLine("M = Minuto (1m = 1 minuto)");
        Console.WriteLine("0 = Sair");
        Console.WriteLine("Quanto tempo deseja contar?");

        string data = Console.ReadLine().ToLower();
        if (data == "0")
        {
            Console.WriteLine("Encerrando o programa...");
            Thread.Sleep(1000);
            System.Environment.Exit(0);
        }
        char tipo = char.Parse(data.Substring(data.Length - 1, 1));
        int tempoTipo = int.Parse(data.Substring(0, data.Length - 1));
        int multiplicador = 1;

        if (tipo == 'm')
        {
            multiplicador = 60;
        }
        PreInicio(tempoTipo * multiplicador);


    }

    static void PreInicio(int time)
    {
        Console.Clear();
        Console.WriteLine("Preparar. . .");
        Thread.Sleep(1000);
        Console.WriteLine("Apontar. . .");
        Thread.Sleep(1000);
        Console.WriteLine("VAI! ! !");
        Thread.Sleep(1500);

        Iniciar(time);

    }

    static void Iniciar(int tempo)
    {
        int tempoCorrido = 0;

        while (tempoCorrido != tempo)
        {
            Console.Clear();
            tempoCorrido++;
            Console.WriteLine(tempoCorrido);
            Thread.Sleep(1000);
        }

        Console.Clear();
        Console.WriteLine("Cronometro Finalizado.");
        Thread.Sleep(4500);
        Menu();
    }

}
