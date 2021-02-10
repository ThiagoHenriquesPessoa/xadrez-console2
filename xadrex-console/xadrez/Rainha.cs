using tabuleiro;

namespace xadrez
{
    class Rainha : Peca
    {
        public Rainha(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }
        public override string ToString()
        {
            return "S";
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];
            Posicao pos = new Posicao(0, 0);
            return mat;
        }
    }
}
