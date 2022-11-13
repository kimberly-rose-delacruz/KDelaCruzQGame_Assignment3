/*DesignForm.cs
 * This program is a windows form in .net framework that will be shown when Design button for Qgame is clicked from the control panel form main form. All logic and backend program will be indicated in here.
 * 
 * Revision History:
 *      Kimberly Dela Cruz, 2022.10.15: Created
 */
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KDelaCruzQGame
{
    public partial class DesignForm : Form
    {

        //Declaration of global variables for the Qgame board.
        Board newBoard = new Board();
        public int rowNumber = 0;
        public int columnNumber = 0;
        public const string ERROR_MESSAGE = "Please provide valid data for rows and columns (Both must be integers)";
        public const int SIZE = 100;
        public const int NONE_VALUE = 1;
        public const int WALL_VALUE = 2;
        public const int RED_DOOR_VALUE = 3;
        public const int GREEN_DOOR_VALUE = 4; 
        public const int RED_BOX_VALUE = 5;
        public const int GREEN_BOX_VALUE = 6;
        public static int selectedToolBox = 0;
        public int totalCountOfWall = 0;
        public int totalCountOfDoor = 0;
        public int totalCountOfBox = 0;
        public const string SUCCESS_MESSAGE = "File saved successfully.:";
        public const string ERROR_MESSAGE_FOR_DESIGN = "Please provide atleast 1 maching colored door for same colored boxes added in the board.\n e.g. 1 or more green boxes should have 1 green door";

        GameTile[,] gameTiles;

        public DesignForm()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //get row and column number from user input in the form by clicking the generate button
            string rowValue = txtBoxNumRows.Text;
            string columnValue = txtBoxNumColumns.Text;

            bool isRowValueValid = int.TryParse(rowValue, out rowNumber);
            bool isColumnValueValid = int.TryParse(columnValue, out columnNumber);

            //if the given Row Value or Column Value is invalid
            if (!isRowValueValid || !isColumnValueValid)
            {
                MessageBox.Show(ERROR_MESSAGE, "Qgame", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                gameTiles = new GameTile[rowNumber, columnNumber];

                //this will loop in the board according to the specified row and column number that is being manipulated in the board. I use the GameTile Class to create grid with specific widt, heigh and its location.
                for (int row = 0; row < rowNumber; row++)
                {
                    for (int column = 0; column < columnNumber; column++)
                    {
                        gameTiles[row, column] = new GameTile();
                        gameTiles[row, column].Location = new Point(column * SIZE + SIZE, row * SIZE + SIZE);
                        gameTiles[row, column].Width = SIZE;
                        gameTiles[row, column].Height = SIZE;
                        gameTiles[row, column].Visible = true;
                        gameTiles[row, column].BorderStyle = BorderStyle.Fixed3D;
                        gameTiles[row, column].BringToFront();
                        pnlParentBoard.Controls.Add(gameTiles[row, column]);
                    }
                }
            }
        }

        private void btnNone_Click(object sender, EventArgs e)
        {
            selectedToolBox = NONE_VALUE;
        }

        private void btnWall_Click(object sender, EventArgs e)
        {
            selectedToolBox = WALL_VALUE;
        }

        private void btnRedDoor_Click(object sender, EventArgs e)
        {
            selectedToolBox = RED_DOOR_VALUE;
        }

        private void btnGreenDoor_Click(object sender, EventArgs e)
        {
            selectedToolBox = GREEN_DOOR_VALUE;
        }

        private void btnRedBox_Click(object sender, EventArgs e)
        {
            selectedToolBox = RED_BOX_VALUE;
        }

        private void btnGreenBox_Click(object sender, EventArgs e)
        {
            selectedToolBox = GREEN_BOX_VALUE;
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dlgSaveFile.Filter = "Text File|*.txt|all files|*.*|game file|*.qgame";
            dlgSaveFile.DefaultExt = "qgame";

            DialogResult result = dlgSaveFile.ShowDialog();

            switch (result)
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    try
                    {
                        //this is to call the service method from the board class to save all values and coordinates with the selected image from toolbox based from the design that the user insert in the tile.
                        newBoard.SaveDesignToTextFile(dlgSaveFile.FileName, gameTiles, out totalCountOfWall, out totalCountOfDoor, out totalCountOfBox);
                        
                        //show the success message together with the total coun to designed wall, box, and door.
                        MessageBox.Show(SUCCESS_MESSAGE + "\n"
                            + $"Total number of walls: {totalCountOfWall}\n" + $"Total number of doors: {totalCountOfDoor}\n"
                            + $"Total number of boxes: {totalCountOfBox}\n"
                            , "Qgame", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception exception)
                    {
                        //show error message when there is something goes wrong when saving the file.
                        MessageBox.Show("Error in files save:" + exception.Message);
                    }
                    break;
                default:
                    break;
            }

        }
    }
}
