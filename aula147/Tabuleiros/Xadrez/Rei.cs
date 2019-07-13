using System;
using System.Collections.Generic;
using System.Text;
using aula147.Tabuleiros;

namespace aula147.Tabuleiros.Xadrez
{
    class Rei : Peca
    { 
        /*
        public Rei(Cor cor, Tabuleiro tab) : base(cor, tab)
        {
        }*/

        public Rei(Cor cor) : base(cor)
        {
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
