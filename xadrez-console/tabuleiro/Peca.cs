﻿using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; } // Quando protected é acessivel pela class e a subclass
        public int QteMovimentos { get; protected set; }
        public Tabuleiro Tab  { get; protected set; }

        public Peca(Posicao posicao, Tabuleiro tab, Cor cor)
        {
            Posicao = posicao;
            Cor = cor;
            Tab = tab;
            QteMovimentos = 0;
        }
    }
}
