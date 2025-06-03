using tabuleiro;

namespace JXadrez
{
    class Torre : Peca
    {

        public Torre(Tabuleiro tabu, Cor cor) : base(tabu, cor)
        {

        }

        public override string ToString()
        {
            return "T";
        }

    }
}
