﻿using System;
using tabuleiro;
using Xadrez_console;

namespace Xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);
            Tela.imprimirTabuleiro(tab);
            Console.ReadLine();
        }
    }
}
