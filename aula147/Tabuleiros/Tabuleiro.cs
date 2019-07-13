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

        public void ColocarPeca(Peca p, Posicao pos)// instanciar peça
        {
            Pecas[pos.Linha, pos.Coluna] = p;// o tabuleiro recebe onde a peça vai ficar
            p.Posicao = pos;// peça recebe a posição
        }
    }
}
