using System;
using aula147.Tabuleiros;

namespace aula147
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao P;
            P = new Posicao(3, 4);
            Console.WriteLine();
            Tabuleiro t = new Tabuleiro(8,8);

            Tela.ImprimirTabuleiro(t);
        }
    }
}
