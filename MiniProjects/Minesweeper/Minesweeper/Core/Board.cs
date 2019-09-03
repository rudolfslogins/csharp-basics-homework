using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper.Core
{
    public class Board
    {
        public Minesweeper Minesweeper { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int NumMines { get; set; }
        public Cell[,] Cells { get; set; }

        private bool _gameEnd = false;

        private bool _firstClick = true;
        
        private Random random = new Random();

        public Board(Minesweeper minesweeper, int width, int height, int mines)
        {
            this.Minesweeper = minesweeper;
            this.Width = width;
            this.Height = height;
            this.NumMines = mines;
            this.Cells = new Cell[width, height];
        }

        public void SetupBoard()
        {
            for (var i = 0; i < Width; i++)
            {
                for (var j = 0; j < Height; j++)
                {
                    var c = new Cell
                    {
                        XLoc = i,
                        YLoc = j,
                        CellState = CellState.Closed,
                        CellType = CellType.Regular,
                        CellSize = 50,
                        Board = this
                    };
                    c.SetupDesign();
                    c.MouseDown += Cell_MouseClick;

                    this.Cells[i, j] = c;
                    this.Minesweeper.Controls.Add(c);
                }
            }
        }

        private void Cell_MouseClick(object sender, MouseEventArgs e)
        {
            var cell = (Cell) sender;

            if (cell.CellState == CellState.Opened || _gameEnd)
                return;

            switch (e.Button)
            {
                case MouseButtons.Left:
                    if (cell.CellType == CellType.Mine)
                    {
                        BombClickAction(cell);
                        return;
                    }
                    else if (cell.CellType == CellType.Flagged || cell.CellType == CellType.FlaggedMine)
                    {
                        return;
                    }
                    cell.OnClick();
                    break;

                case MouseButtons.Right:
                    cell.OnFlag();
                    return;

                default:
                    return;
            }

            if (_firstClick)
            {
                FirstClickAction(cell);
            }

            if (cell.NumMines == 0)
            {
                FloodFill(cell.XLoc, cell.YLoc);
            }
            CheckGameWin();
        }

        private void CheckGameWin()
        {
            int openCellCount = 0;

            foreach (var itemCell in Cells)
            {
                if (itemCell.CellState == CellState.Opened)
                {
                    openCellCount++;
                }
            }

            if (openCellCount == Cells.Length - NumMines)
            {
                _gameEnd = true;
                foreach (var bombs in Cells)
                {
                    if (bombs.CellType == CellType.Mine)
                    {
                        bombs.OnFlag();
                    }
                }
                MessageBox.Show("You opened all cells!\nYou Won!", "CONGRATULATIONS");
            }
        }

        private void BombClickAction(Cell input)
        {
            input.FirstBomb = true;
            foreach (var item in Cells)
            {
                if (item.CellType == CellType.Mine || item.CellType == CellType.Flagged)
                {
                    item.OnClick();
                }
            }
            MessageBox.Show("You found a BOMB!\nYou Lost!", "GAME OVER");
            _gameEnd = true;
        }
        private void FirstClickAction(Cell input)
        {
            _firstClick = false;
            var firstClickNeighbors = GetNeighborCell.GetCells(Cells, input.XLoc, input.YLoc, Width, Height);
            for (var i = 0; i < firstClickNeighbors.Count; i++)
            {
                firstClickNeighbors[i].FirstPick = true;
            }
            PasteBombs();
        }
        private void FloodFill(int x, int y)
        {
            var neighborCells = GetNeighborCell.GetCells(Cells, x, y, Width, Height);
            foreach (var neighbor in neighborCells)
            {
                if (neighbor.CellState == CellState.Closed && neighbor.CellType == CellType.Regular)
                {
                    neighbor.OnClick();
                    if (neighbor.NumMines == 0)
                    {
                        FloodFill(neighbor.XLoc, neighbor.YLoc);
                    }
                }
            }
        }

        private void PasteBombs()
        {
            
            for (var bombsPasted = 0; bombsPasted < NumMines;)
            {
                var randX = random.Next(Width);
                var randY = random.Next(Height);
                if (Cells[randX, randY].CellState == CellState.Closed 
                    && Cells[randX, randY].FirstPick == false 
                    && Cells[randX, randY].CellType != CellType.Mine)
                {
                    Cells[randX, randY].CellType = CellType.Mine;
                    //Cells[randX, randY].Text = "M";
                    bombsPasted++;
                }
            }
            foreach (var item in Cells)
            {
                foreach (var itemCell in GetNeighborCell.GetCells(Cells, item.XLoc, item.YLoc, Width, Height))
                {
                    if (itemCell.CellType == CellType.Mine && item.CellType != CellType.Mine)
                    {
                        item.NumMines++;
                    }
                }
            }
        }
    }
}
