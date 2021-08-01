using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_Xadrez.GameBoardContainer.GameBoardContainerExceptions
{
    class GameBoardException : ApplicationException
    {
        public GameBoardException(string message) : base(message) { }


    }
}
