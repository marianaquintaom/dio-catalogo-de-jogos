using System;

namespace APICatalogJogos.Exceptions
{
    public class JogoCadException : Exception
    {
        public JogoCadException()
           : base("Este já jogo está cadastrado")
        { }
    }
}
