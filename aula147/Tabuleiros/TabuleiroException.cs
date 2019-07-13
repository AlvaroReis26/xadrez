using System;
using System.Collections.Generic;
using System.Text;

namespace aula147.Tabuleiros
{
    class TabuleiroException : Exception
    {
        public TabuleiroException(string message) : base(message)
        {
        }
    }
}
