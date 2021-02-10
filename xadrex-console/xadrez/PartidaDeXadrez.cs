using System;
using tabuleiro;

namespace xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro tab { get; private set; }
        private int turno;
        private Cor jogadorAtual;
        public bool terminada { get; private set; }

        public PartidaDeXadrez()
        {
            this.tab = new Tabuleiro(8,8);
            this.turno = 1;
            this.jogadorAtual = Cor.Branco;
            terminada = false;
            colocarPecas();
        }
        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);
            p.incrementarQteMovimento();
            tab.retirarPeca(destino);
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);
        }

        private void colocarPecas()
        { 
            /*
            tab.colocarPeca(new Peao(tab, Cor.Branco), new PosicaoXadrez('a', 2).toPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Branco), new PosicaoXadrez('b', 2).toPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Branco), new PosicaoXadrez('c', 2).toPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Branco), new PosicaoXadrez('d', 2).toPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Branco), new PosicaoXadrez('e', 2).toPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Branco), new PosicaoXadrez('f', 2).toPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Branco), new PosicaoXadrez('g', 2).toPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Branco), new PosicaoXadrez('h', 2).toPosicao());*/

            tab.colocarPeca(new Torre(tab, Cor.Branco), new PosicaoXadrez('a', 1).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branco), new PosicaoXadrez('h', 1).toPosicao());
            tab.colocarPeca(new Rei(tab, Cor.Branco), new PosicaoXadrez('d', 1).toPosicao());            
            tab.colocarPeca(new Rainha(tab, Cor.Branco), new PosicaoXadrez('e', 1).toPosicao());            
            tab.colocarPeca(new Cavalo(tab, Cor.Branco), new PosicaoXadrez('b', 1).toPosicao());
            tab.colocarPeca(new Cavalo(tab, Cor.Branco), new PosicaoXadrez('g', 1).toPosicao());
            tab.colocarPeca(new Bispo(tab, Cor.Branco), new PosicaoXadrez('c', 1).toPosicao());
            tab.colocarPeca(new Bispo(tab, Cor.Branco), new PosicaoXadrez('f', 1).toPosicao());
/*
            tab.colocarPeca(new Peao(tab, Cor.Preto), new PosicaoXadrez('a', 7).toPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Preto), new PosicaoXadrez('b', 7).toPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Preto), new PosicaoXadrez('c', 7).toPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Preto), new PosicaoXadrez('d', 7).toPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Preto), new PosicaoXadrez('e', 7).toPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Preto), new PosicaoXadrez('f', 7).toPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Preto), new PosicaoXadrez('g', 7).toPosicao());
            tab.colocarPeca(new Peao(tab, Cor.Preto), new PosicaoXadrez('h', 7).toPosicao());*/

            tab.colocarPeca(new Torre(tab, Cor.Preto), new PosicaoXadrez('a', 8).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preto), new PosicaoXadrez('h', 8).toPosicao());
            tab.colocarPeca(new Rei(tab, Cor.Preto), new PosicaoXadrez('d', 8).toPosicao());
            tab.colocarPeca(new Rainha(tab, Cor.Preto), new PosicaoXadrez('e', 8).toPosicao());
            tab.colocarPeca(new Cavalo(tab, Cor.Preto), new PosicaoXadrez('b', 8).toPosicao());
            tab.colocarPeca(new Cavalo(tab, Cor.Preto), new PosicaoXadrez('g', 8).toPosicao());
            tab.colocarPeca(new Bispo(tab, Cor.Preto), new PosicaoXadrez('c', 8).toPosicao());
            tab.colocarPeca(new Bispo(tab, Cor.Preto), new PosicaoXadrez('f', 8).toPosicao());

        }
    }
}
