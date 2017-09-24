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
    class Cell
    {
        //class member vars
        private int collumn;
        private int row;
        private Boolean visited;
        private Boolean live;
        private int liveNeighbors;


        //default constructor
        public Cell()
        {
            collumn = -1;
            row = -1;
            visited = false;
            live = false;
            liveNeighbors = 0;
        }

        //getters and setters
        public int getCollumn()
        {
            return collumn;
        }

        public int getRow()
        {
            return row;
        }

        public Boolean isVisited()
        {
            return visited;
        }

        public Boolean isLive()
        {
            return live;
        }

        public int getLiveNeighbors()
        {
            return liveNeighbors;
        }

        public void setCollumn(int col)
        {
            collumn = col;
        }

        public void setRow(int r)
        {
            row = r;
        }

        public void setVisited(Boolean v)
        {
            visited = v;
        }

        public void setLive(Boolean l)
        {
            live = l;
        }

        public void setLiveNeighbors(int ln)
        {
            liveNeighbors = ln;
        }
        public void incerementLiveNeighbors()
        {
            liveNeighbors++;
        }
    }
}
