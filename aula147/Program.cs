using System;
using aula147.Tabuleiros;
using aula147.Tabuleiros.Xadrez;

namespace aula147
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);
            {
                /*
                tab.ColocarPeca(new Torre(Cor.Branca, tab), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(Cor.Branca, tab), new Posicao(0, 7));
                tab.ColocarPeca(new Rei(Cor.Branca, tab), new Posicao(0, 4));
                */
            }
            try
            {
                tab.ColocarPeca(new Torre(Cor.Branca), new Posicao(0, 7));
                tab.ColocarPeca(new Torre(Cor.Branca), new Posicao(0, 7));
                tab.ColocarPeca(new Rei(Cor.Branca), new Posicao(0, 4));
                Tela.ImprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
