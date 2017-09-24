using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/*
 * 
 * Jordan Riley, This is my own work.
 * CLC Milestone 2
 * 
 */

namespace Milestone1
{
    class Driver
    {
        static void Main(string[] args)
        {

            /*
             * creates instance of MinesweeperGame class, which is an extension of the 
             * Grid class and also implements the iPlayable interface.
             */
            MinesweeperGame game = new MinesweeperGame(10, 10);

            //calls the playGame function
            game.playGame();


        }
    }
}
