﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Xadrez.GameBoardContainer
{
    class Position
    {
        public int Line { get; set; }
        public int Column { get; set; }

        public Position() { }

        public Position(int line, int column)
        {
            Line = line;
            Column = column;
        }

        public void DefineValues(int line, int column)
        {
            Line = line;
            Column = column;

        }

        public override string ToString()
        {
            return $"{Line}, {Column}";
        }
    }
}
