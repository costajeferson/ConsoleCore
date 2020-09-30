using System;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new jogofoda(
                new Jogador1("ronaldo"),
                new Jogador2());
            jogo.iniciarJogo();

        }
    }

                        
    
}
