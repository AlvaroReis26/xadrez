using System;
using aula147.Tabuleiros;

namespace aula147
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
           
            for (int l = 0; l < tab.Linhas; l++)
            {
                Console.Write(8 - l + " ");
                for (int c = 0; c < tab.Colunas; c++)
                {
                    if (tab.MovePeca(l,c) == null)
                    {
                        Console.Write("_ ");
                    }
                    else
                    {
                        ImprimirPeca(tab.MovePeca(l, c));
                        Console.Write(" ");
                    }
                    
                }
               
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Write("  A B C D E F G H ");
        }

        public static void ImprimirPeca(Peca peca)
        {
            if (peca.Cor == Cor.Branca)
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
    }
}
