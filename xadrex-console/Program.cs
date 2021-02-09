using System;
using tabuleiro;
using xadrez;

namespace xadrex_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Tabuleiro tab = new Tabuleiro(8, 8);
                tab.colocarPeca(new Torre(tab, Cor.Preto), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preto), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preto), new Posicao(2, 4));
                tab.colocarPeca(new Torre(tab, Cor.Branco), new Posicao(3, 5));
                tab.colocarPeca(new Torre(tab, Cor.Branco), new Posicao(7, 6));
                tab.colocarPeca(new Rei(tab, Cor.Branco), new Posicao(6, 6));


                Tela.imprimindoTabuleiro(tab);
            }
            catch(TabuleitoException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
