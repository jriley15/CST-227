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
    class Grid
    {
        //class member vars
        private int rows;
        private int collumns;
        private Cell[,] cells;


        //default constructors
        public Grid(int rows, int collumns)
        {
            this.rows = rows;
            this.collumns = collumns;
            cells = new Cell[collumns, rows];
            generateCells();
            activateCells();
        }

        //fills up the 2d cell array
        private void generateCells()
        {      
            for (int x = 0; x < collumns; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    cells[x, y] = new Cell();
                    cells[x, y].setCollumn(x);
                    cells[x, y].setRow(y);
                }
            }
        }

        //loops through every cell and randomly sets
        //20 percent of them to 'live' and increments
        //the live cells neighbors to know how many 
        //live cells there are in the surrounding area
        private void activateCells()
        {
            Random rand = new Random();
            for (int x = 0; x < collumns; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    
                    if (rand.Next(0, 100) <= 20)
                    {
                        cells[x, y].setLive(true);
                        cells[x, y].setLiveNeighbors(9);
                        for (int neighborX = -1; neighborX <= 1; neighborX++)
                        {
                            for (int neighborY = -1; neighborY <= 1; neighborY++)
                            {
                                if (neighborX == 0 && neighborY == 0)
                                {

                                }
                                else if (x + neighborX >= 0 && x + neighborX < collumns && y + neighborY >= 0 && y + neighborY < rows)
                                {
                                    cells[x + neighborX, y + neighborY].incerementLiveNeighbors();
                                }

                            }
                        }
                    }
                }
            }
        }

        //reveals the whole grid to the user
        //in the console

        public void reveal()
        {

            for (int x = 0; x < collumns; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    if (cells[x, y].isVisited())
                    {
                        if (cells[x, y].isLive())
                        {
                            Console.Write("| * ");
                        }
                        else
                        {
                            Console.Write("| " + cells[x, y].getLiveNeighbors() + " ");
                        }
                    }
                    else
                    {
                        //not visited
                        if (cells[x, y].isLive())
                        {
                            Console.Write("| * ");
                        }
                        else
                        {
                            Console.Write("| " + cells[x, y].getLiveNeighbors() + " ");
                        }
                    }


                   

                }
                Console.WriteLine("|");
            }

        }
    }
}
