using System.Collections.Generic;
using System.Text;
using aula147.Tabuleiros;

namespace aula147.Tabuleiros.Xadrez
{
    class Torre : Peca
    {
        /*
        public Torre(Cor cor, Tabuleiro tab) : base(cor, tab)
        {
        }*/

        public Torre(Cor cor) : base(cor)
        {
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
