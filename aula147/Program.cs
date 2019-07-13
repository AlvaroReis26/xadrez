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
           // PosicaoXadrez px = new PosicaoXadrez('c', 4);
           // Console.WriteLine( px );
          //  Console.WriteLine(px.ToPosicao());

            try
            {
                tab.ColocarPeca(new Torre(Cor.Preta), new Posicao(0, 7));
                tab.ColocarPeca(new Torre(Cor.Preta), new Posicao(0, 0));
                tab.ColocarPeca(new Rei(Cor.Preta), new Posicao(0, 4));
                tab.ColocarPeca(new Torre(Cor.Branca), new Posicao(7, 0));
                tab.ColocarPeca(new Torre(Cor.Branca), new Posicao(7, 7));
                tab.ColocarPeca(new Rei(Cor.Branca), new Posicao(7, 3));
                Tela.ImprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
