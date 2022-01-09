using System;

namespace APICatalogJogos.Exceptions
{
    public class JogoNaoCadException : Exception
    {
        public JogoNaoCadException()
            : base("Este jogo não está cadastrado")
        { }
    }
}
