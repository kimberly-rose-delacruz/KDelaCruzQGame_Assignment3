/*Playform.cs
 * This is the form for the actual playing of the Qgame where loading of the text file according to its level shall be processed, controllers, and it's game result are part of this solution.
 * 
 * Revision History:
 *      Kimberly Dela Cruz, 2022.11.20: Add the functions for controllers and clearing of the game tiles when user attempts to upload a new level for Qgame.
 *      Kimberly Dela Cruz, 2022.11.01: Modify code with messagebox for total count of wall, boxes, and doors when design has been finalized to be saved in a file.
 *      Kimberly Dela Cruz, 2022.10.15: Created
 */
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
        private int countOfExitedBoxes = 0;

        public const string SUCCESS_MESSAGE = "Congratulations!\nGame ended";
        public const string ERROR_MESSAGE = "Only boxes are movable. Please select a box from the grid to make a move.";
        public const string ERROR_MESSAGE_2 = "Unexpected error happened. Kindly contact the administrator.";
        public PlayForm()
        {
            InitializeComponent();
            txtBoxNumOfMoves.Text = INITIAL_VALUE_NUMBER_OF_MOVES;
            txtBoxNumRemainingBoxes.Text = INITIAL_VALUE_NUMBER_OF_REMAINING_BOXES;
        }

        private void loadGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                checkForBoardClearance();

                dlgOpen.Filter = "Text File|*.txt|all files|*.*|game file|*.game";

                DialogResult result = dlgOpen.ShowDialog();

                switch (result)
                {
                    case DialogResult.OK:

                        newBoard.LoadGameFileToBoard(dlgOpen.FileName, pnlBoard, SIZE, out totalCountOfBoxes);
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
            catch (Exception ex)
            {

                MessageBox.Show(ERROR_MESSAGE_2 + ex.Message, "Qgame", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //this is going to check the board if its occupied with the level. If its occupied then clear the boxes prior to loading it.
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
            try
            {
                var activeGameTile = Board.SELECTED_MOVABLE_GAMETILE;
                int totalRemainingBoxes = int.Parse(txtBoxNumRemainingBoxes.Text);
                if (activeGameTile.CurrentSelectToolBox == DesignForm.GREEN_BOX_VALUE || activeGameTile.CurrentSelectToolBox == DesignForm.RED_BOX_VALUE)
                {
                    //move the game tile going up and assess the move based on the checking grid if its occupied or not for the active game tile to move
                    var isBoxMovedUpward = newBoard.MoveTileUpward(activeGameTile, out countOfExitedBoxes);

                    if (isBoxMovedUpward == true)
                    {
                        totalCountOfMoves++;
                        txtBoxNumOfMoves.Text = totalCountOfMoves.ToString();
                        txtBoxNumRemainingBoxes.Text = (totalRemainingBoxes - countOfExitedBoxes).ToString();
                    }
                }
                else
                {
                    //show message to user that only boxes should be movable.
                    MessageBox.Show(ERROR_MESSAGE, "Qgame", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //this will determine if the game has ended if the totalremaining boxes is 0.
                if (int.Parse(txtBoxNumRemainingBoxes.Text) == 0)
                {
                    MessageBox.Show(SUCCESS_MESSAGE, "Qgame", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //clearing all grid and game board when game ended.
                    checkForBoardClearance();
                    //set the totalCountOfMoves to 0 since the game has ended.
                    totalCountOfMoves = 0;
                    txtBoxNumOfMoves.Text = totalCountOfMoves.ToString();
                }
            }
            catch (Exception ex)
            {
                //showing error message via messagebox when unexpected error occur when using the Qgame.

                MessageBox.Show(ERROR_MESSAGE_2 + ex.Message, "Qgame", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            try
            {
                var activeGameTile = Board.SELECTED_MOVABLE_GAMETILE;
                int totalRemainingBoxes = int.Parse(txtBoxNumRemainingBoxes.Text);


                if (activeGameTile.CurrentSelectToolBox == DesignForm.GREEN_BOX_VALUE || activeGameTile.CurrentSelectToolBox == DesignForm.RED_BOX_VALUE)
                {
                    //move the game tile going left and assess the move based on the checking grid if its occupied or not for the active game tile to move
                    var isBoxMovedLeft = newBoard.MoveTileGoingLeft(activeGameTile, out countOfExitedBoxes);

                    if (isBoxMovedLeft == true)
                    {
                        totalCountOfMoves++;
                        txtBoxNumOfMoves.Text = totalCountOfMoves.ToString();
                        txtBoxNumRemainingBoxes.Text = (totalRemainingBoxes - countOfExitedBoxes).ToString();
                    }
                }
                else
                {
                    //show message to user that only boxes should be movable.
                    MessageBox.Show(ERROR_MESSAGE, "Qgame", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //this will determine if the game has ended if the totalremaining boxes is 0.
                if (int.Parse(txtBoxNumRemainingBoxes.Text) == 0)
                {
                    MessageBox.Show(SUCCESS_MESSAGE, "Qgame", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //clearing all grid and game board when game ended.
                    checkForBoardClearance();
                    //set the totalCountOfMoves to 0 since the game has ended.
                    totalCountOfMoves = 0;
                    txtBoxNumOfMoves.Text = totalCountOfMoves.ToString();

                }
            }
            catch (Exception ex)
            {
                //showing error message via messagebox when unexpected error occur when using the Qgame.

                MessageBox.Show(ERROR_MESSAGE_2 + ex.Message, "Qgame", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            try
            {
                var activeGameTile = Board.SELECTED_MOVABLE_GAMETILE;
                int totalRemainingBoxes = int.Parse(txtBoxNumRemainingBoxes.Text);


                if (activeGameTile.CurrentSelectToolBox == DesignForm.GREEN_BOX_VALUE || activeGameTile.CurrentSelectToolBox == DesignForm.RED_BOX_VALUE)
                {
                    //move the game tile going down and assess the move based on the checking grid if its occupied or not for the active game tile to move
                    var isBoxMovedDownward = newBoard.MoveTileDownward(activeGameTile, out countOfExitedBoxes);

                    if (isBoxMovedDownward == true)
                    {
                        totalCountOfMoves++;
                        txtBoxNumOfMoves.Text = totalCountOfMoves.ToString();
                        txtBoxNumRemainingBoxes.Text = (totalRemainingBoxes - countOfExitedBoxes).ToString();
                    }
                }
                else
                {
                    //show message to user that only boxes should be movable.
                    MessageBox.Show(ERROR_MESSAGE, "Qgame", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //this will determine if the game has ended if the totalremaining boxes is 0.
                if (int.Parse(txtBoxNumRemainingBoxes.Text) == 0)
                {
                    MessageBox.Show(SUCCESS_MESSAGE, "Qgame", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //clearing all grid and game board when game ended.
                    checkForBoardClearance();
                    //set the totalCountOfMoves to 0 since the game has ended.
                    totalCountOfMoves = 0;
                    txtBoxNumOfMoves.Text = totalCountOfMoves.ToString();
                }
            }
            catch (Exception ex)
            {
                //showing error message via messagebox when unexpected error occur when using the Qgame.

                MessageBox.Show(ERROR_MESSAGE_2 + ex.Message, "Qgame", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            try
            {
                var activeGameTile = Board.SELECTED_MOVABLE_GAMETILE;
                int totalRemainingBoxes = int.Parse(txtBoxNumRemainingBoxes.Text);


                if (activeGameTile.CurrentSelectToolBox == DesignForm.GREEN_BOX_VALUE || activeGameTile.CurrentSelectToolBox == DesignForm.RED_BOX_VALUE)
                {
                    //move the game tile going down and assess the move based on the checking grid if its occupied or not for the active game tile to move
                    var isBoxMovedGoingRight = newBoard.MoveTileGoingRight(activeGameTile, out countOfExitedBoxes);

                    if (isBoxMovedGoingRight == true)
                    {
                        totalCountOfMoves++;
                        txtBoxNumOfMoves.Text = totalCountOfMoves.ToString();
                        txtBoxNumRemainingBoxes.Text = (totalRemainingBoxes - countOfExitedBoxes).ToString();
                    }
                }
                else
                {
                    //show message to user that only boxes should be movable.
                    MessageBox.Show(ERROR_MESSAGE, "Qgame", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                //this will determine if the game has ended if the totalremaining boxes is 0.
                if (int.Parse(txtBoxNumRemainingBoxes.Text) == 0)
                {
                    MessageBox.Show(SUCCESS_MESSAGE, "Qgame", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //clearing all grid and game board when game ended.
                    checkForBoardClearance();
                    //set the totalCountOfMoves to 0 since the game has ended.
                    totalCountOfMoves = 0;
                    txtBoxNumOfMoves.Text = totalCountOfMoves.ToString();
                }
            }
            catch (Exception ex)
            {
                //showing error message via messagebox when unexpected error occur when using the Qgame.
                MessageBox.Show(ERROR_MESSAGE_2 + ex.Message, "Qgame", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //closing the form.
            this.Close();
        }
    }
}
