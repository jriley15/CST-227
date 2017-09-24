using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Jordan Riley, This is my own work.
 * Milestone 1
 * 
 */ 

namespace Milestone1
{
    class Driver
    {
        static void Main(string[] args)
        {

            //instantiating the grid class with size 10 by 10
            Grid grid = new Grid(10, 10);
            //reveals the grid to the console for the user to see
            grid.reveal();


        }
    }
}
