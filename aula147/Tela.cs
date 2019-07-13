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
                for (int c = 0; c < tab.Colunas; c++)
                {
                    if (tab.MovePeca(l,c) == null)
                    {
                        Console.Write("_ ");
                    }
                    else
                    {
                        Console.Write(tab.MovePeca(l, c) + " ");
                    }                    
                }
                Console.WriteLine();
            }
        }
    }
}
