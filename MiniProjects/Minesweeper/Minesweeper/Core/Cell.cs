using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper.Core
{
    public enum CellType
    {
        Regular, Mine, Flagged, FlaggedMine
    }

    public enum CellState
    {
        Opened, Closed
    }

    public class Cell : Button
    {
        public int XLoc { get; set; }
        public int YLoc { get; set; }
        public int CellSize { get; set; }
        public CellState CellState { get; set; }
        public CellType CellType { get; set; }
        public int NumMines { get; set; }
        public Board Board { get; set; }
        public bool FirstPick { get; set; }
        public bool FirstBomb { get; set; }

        public void SetupDesign()
        {
            this.BackColor = SystemColors.ButtonFace;
            this.BackColor = Color.DarkGray;
            this.Location = new Point(XLoc * CellSize, YLoc * CellSize);
            this.Size = new Size(CellSize, CellSize);
            this.UseVisualStyleBackColor = false;
            this.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
        }

        public void OnFlag()
        {
            if (CellType == CellType.Regular)
            {
                CellType = CellType.Flagged;
            }
            else if (CellType == CellType.Mine)
            {
                CellType = CellType.FlaggedMine;
            }
            else if (CellType == CellType.Flagged)
            {
                CellType = CellType.Regular;
            }
            else if (CellType == CellType.FlaggedMine)
            {
                CellType = CellType.Mine;
            }

            if (CellType == CellType.Flagged || CellType == CellType.FlaggedMine)
            {
                this.Font = new Font("Webdings", 30F, FontStyle.Bold);
                this.Text = "w";
            }
            else
            {
                this.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
                this.Text = "";
            }
        }

        public void OnClick(bool recursiveCall = false)
        {
            if (CellType == CellType.Regular)
            {
                CellState = CellState.Opened;
                this.BackColor = Color.GhostWhite;
                if (this.NumMines > 0)
                {
                    this.Text = this.NumMines.ToString();
                    this.ForeColor = GetCellColour();
                }
            }
            else
            {
                this.Font = new Font("Wingdings", 20F, FontStyle.Bold);
                this.Text = "M";
                this.BackColor = Color.GhostWhite;
                if (CellType == CellType.Mine && FirstBomb)
                {
                    this.BackColor = Color.Red;
                }else if (CellType == CellType.Flagged)
                {
                    this.Text = "";
                    this.BackColor = Color.Red;
                }
            }

        }

        /// <summary>
        /// Return the colour code associated with the number of surrounding mines
        /// </summary>
        /// <returns></returns>
        private Color GetCellColour()
        {
            switch (this.NumMines)
            {
                case 1:
                    return ColorTranslator.FromHtml("0x0000FE"); // 1
                case 2:
                    return ColorTranslator.FromHtml("0x186900"); // 2
                case 3:
                    return ColorTranslator.FromHtml("0xAE0107"); // 3
                case 4:
                    return ColorTranslator.FromHtml("0x000177"); // 4
                case 5:
                    return ColorTranslator.FromHtml("0x8D0107"); // 5
                case 6:
                    return ColorTranslator.FromHtml("0x007A7C"); // 6
                case 7:
                    return ColorTranslator.FromHtml("0x902E90"); // 7
                case 8:
                    return ColorTranslator.FromHtml("0x000000"); // 8
                default:
                    return ColorTranslator.FromHtml("0xffffff");
            }
        }
    }
}
