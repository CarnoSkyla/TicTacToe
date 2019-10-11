using System;
using System.Collections.Generic;
using System.Text;
using TicTacToeRendererLib.Renderer;

namespace Self_Practice
{
    public class TicTacToe
    {
       
         
            private TicTacToeConsoleRenderer _boardRenderer;

            public TicTacToe()
            {
                _boardRenderer = new TicTacToeConsoleRenderer(10, 6);
                _boardRenderer.Render();
            }


        public static void TTT()
        {

        
            //Board


        }
    }

}

