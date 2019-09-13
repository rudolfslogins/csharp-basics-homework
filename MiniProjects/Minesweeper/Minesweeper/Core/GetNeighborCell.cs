using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

namespace Minesweeper.Core
{
    public class GetNeighborCell
    {
        public static List<Cell> GetCells(Cell[,] input,int x, int y, int width, int height)
        {
            var res = new List<Cell>();

            {
                
                if ((x - 1 >= 0) && (y - 1 >= 0))
                {
                    res.Add(input[x - 1, y - 1]);
                }
                if ((x >= 0) && (y - 1 >= 0))
                {
                    res.Add(input[x, y - 1]);
                }
                if ((x + 1 >= 0) && (x + 1 < width) && (y - 1 >= 0))
                {
                    res.Add(input[x + 1, y - 1]);
                }
                if ((x + 1 < height) && (y >= 0))
                {
                    res.Add(input[x + 1, y]);
                }
                if ((x + 1 >= 0) && (x + 1 < width) && (y + 1 < height))
                {
                    res.Add(input[x + 1, y + 1]);
                }
                if ((x >= 0) && (y + 1 < height))
                {
                    res.Add(input[x, y + 1]);
                }
                if ((x - 1 >= 0) && (y + 1 < height))
                {
                    res.Add(input[x - 1, y + 1]);
                }
                if ((x - 1 >= 0) && (y >= 0))
                {
                    res.Add(input[x - 1, y]);
                }

            }
            return res;
        }
    }
}