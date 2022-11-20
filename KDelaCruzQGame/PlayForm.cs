using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace KDelaCruzQGame
{
    public partial class PlayForm : Form
    {
        //global variables
        Board newBoard = new Board();
        private const string INITIAL_VALUE_NUMBER_OF_MOVES = "0";
        private const string INITIAL_VALUE_NUMBER_OF_REMAINING_BOXES = "0";
        public const int SIZE = 80;
        private int totalCountOfBoxes = 0;
        private int totalNumberOfMoves = 0;
        private int totalCountOfMoves = 0;
        public const string ERROR_MESSAGE = "Only boxes are movable. Please select a box from the grid to make a move.";
        public PlayForm()
        {
            InitializeComponent();
            txtBoxNumOfMoves.Text = INITIAL_VALUE_NUMBER_OF_MOVES;
            txtBoxNumRemainingBoxes.Text = INITIAL_VALUE_NUMBER_OF_REMAINING_BOXES;
        }

        private void loadGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkForBoardClearance();

            dlgOpen.Filter = "Text File|*.txt|all files|*.*|game file|*.game";

            DialogResult result = dlgOpen.ShowDialog();

            switch (result)
            {
                case DialogResult.OK:

                    newBoard.LoadGameFileToBoard(dlgOpen.FileName, pnlBoard, SIZE,out totalCountOfBoxes);
                    btnDown.Enabled = true;
                    btnUp.Enabled = true;
                    btnLeft.Enabled = true;
                    btnRight.Enabled = true;

                    txtBoxNumOfMoves.Text = totalNumberOfMoves.ToString();
                    txtBoxNumRemainingBoxes.Text = totalCountOfBoxes.ToString();
                    break;
                default:
                    break;
            }
        }

        private void checkForBoardClearance()
        {
            var isBoardOccupied = newBoard.IsBoardGameOccupied();

            if(isBoardOccupied == true)
            {
                newBoard.ClearTheGamesTilesInTheBoard();
            }
            
        }

        private void btnUp_Click(object sender, EventArgs e)
        {

            var activeGameTile = Board.SELECTED_MOVABLE_GAMETILE;

            if(activeGameTile.CurrentSelectToolBox == DesignForm.GREEN_BOX_VALUE || activeGameTile.CurrentSelectToolBox == DesignForm.RED_BOX_VALUE)
            {
                //move the game tile going up and assess the move based on the checking grid if its occupied or not for the active game tile to move
              var isBoxMovedUpward= newBoard.MoveTileUpward(activeGameTile);

             if(isBoxMovedUpward == true)
                {
                    totalCountOfMoves++;
                    txtBoxNumOfMoves.Text = totalCountOfMoves.ToString();
                }
            }
            else
            {
                //show message to user that only boxes should be movable.
                MessageBox.Show(ERROR_MESSAGE, "Qgame", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
