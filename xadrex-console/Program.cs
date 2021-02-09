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

                PartidaDeXadrez partida = new PartidaDeXadrez();
                Tela.imprimindoTabuleiro(partida.tab);

            }
            catch (TabuleitoException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
