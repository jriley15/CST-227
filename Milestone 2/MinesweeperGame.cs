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
    class MinesweeperGame : Grid, IPlayable
    {

        private bool play;

        public MinesweeperGame(int rows, int collumns) : base(rows, collumns)
        {
            /*
             * Non default constructor that calls the base class constructor and also sets
             * the play boolean to true;
             */ 
            play = true;
        }

        public override void reveal()
        {
            //function for revealing the minesweeper grid to user
            //overrides the base class reveal function.

            for (int x = 0; x < collumns; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    //nested for loop that iterates through every cell

                    if (cells[x, y].isVisited())
                    {
                        if (cells[x, y].isLive())
                        {
                            Console.Write("| * ");
                        }
                        else
                        {
                            if (cells[x, y].getLiveNeighbors() > 0)
                            {
                                Console.Write("| " + cells[x, y].getLiveNeighbors() + " ");
                            }
                            else
                            {
                                Console.Write("| ~ ");
                            }
                        }
                    }
                    else
                    {
                        Console.Write("| ? ");
                    }
                }
                Console.WriteLine("|");
            }
        }

        public void playGame()
        {
            //calls the reveal grid function and starts game using a while loop

            reveal();

            while (play)
            {
                //prompts user for input
                Console.WriteLine("Enter row "+0+"-"+(rows-1)+": ");
                int rowSelected = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter collumn " + 0 + "-" + (collumns - 1) + ": ");
                int collumnSelected = int.Parse(Console.ReadLine());

                //checks if user input is valid
                if (rowSelected > 0 && rowSelected < rows && collumnSelected > 0 && collumnSelected < collumns)
                {
                    Console.Clear();
                    //checks if sell hasn't been visited
                    if (!cells[collumnSelected, rowSelected].isVisited())
                    {
                        //checks if cell has a bomb or is 'live'
                        if (cells[collumnSelected, rowSelected].isLive())
                        {
                            //nested loop to go through every cell and set it to visited
                            for (int x = 0; x < collumns; x++)
                            {
                                for (int y = 0; y < rows; y++)
                                {
                                    cells[x, y].setVisited(true);
                                }
                            }
                            //revels entire grid and ends game loop
                            reveal();
                            Console.WriteLine("Cell has a mine, game over!");
                            play = false;
                        }
                        else
                        {
                            //sets cell to visited and reveals grid
                            cells[collumnSelected, rowSelected].setVisited(true);
                            reveal();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Cell already visited");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid cell entered");

                }


            }
        }
    }
}
