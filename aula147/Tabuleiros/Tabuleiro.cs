using System;
using System.Collections.Generic;
using System.Text;

namespace aula147.Tabuleiros
{
    class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] Pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[linhas, colunas];
        }

        public Peca MovePeca(int linha, int coluna)// nome original peca()
        {
            return Pecas[linha, coluna];
        }

        public Peca MovePeca(Posicao pos)// nome original peca()
        {
            return Pecas[pos.Linha, pos.Coluna];
        }

        public bool ExistePeca(Posicao pos)
        {
            ValidarPosicao(pos);
            return MovePeca(pos) != null;
        }

        public void ColocarPeca(Peca p, Posicao pos)// instanciar peça
        {
            if (ExistePeca(pos))
            {
                throw new TabuleiroException("ERRO já existe peça nesta posição!!!");
            }
            Pecas[pos.Linha, pos.Coluna] = p;// o tabuleiro recebe onde a peça vai ficar
            p.Posicao = pos;// peça recebe a posição
        }

        public bool PosicaoValida(Posicao pos)
        {
            if (pos.Linha < 0 || pos.Linha > Linhas || pos.Coluna < 0 || pos.Coluna > Colunas)
            {
                return false;
            }
            else
                return true;
        }

        public void ValidarPosicao(Posicao pos)
        {
            if (!PosicaoValida(pos))
            {
                throw new TabuleiroException("ERRO Posicão inválida");
            }
        }
    }
}
