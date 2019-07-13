using System;
using System.Collections.Generic;
using System.Text;

namespace aula147.Tabuleiros
{
    class Posicao // tenter deixa como struct para testar o resultado
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }

        public Posicao(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
        }

        public override string ToString()
        {
            return $"Posição {Linha} , {Coluna}";
        }
    }
}
