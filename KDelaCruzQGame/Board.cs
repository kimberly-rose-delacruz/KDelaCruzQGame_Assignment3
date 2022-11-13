/*GameTile.cs
 * This class is for each generated tile using Picturebox by inheriting it as a representation of each tile to the Design Form
 * 
 * Revision History:
 *      Kimberly Dela Cruz, 2022.11.01: Modify code with messagebox for total count of wall, boxes, and doors when design has been finalized to be saved in a file.
 *      Kimberly Dela Cruz, 2022.10.15: Created
 */
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDelaCruzQGame
{
    public class Board
    {
        //global variables
        public const int ROW_INDEX = 0;
        public const int COL_INDEX = 1;

        //this method will save the design to the text file according to the selected tool box image with getting out the statistics count of walls, doors, or boxes if added as part of the design.
        public void SaveDesignToTextFile(string fileName, GameTile[,] gameTiles, out int totalCountWall, out int totalCountDoor, out int totalCountBox)
        {
            int countOfWall = 0;
            int countOfBox = 0;
            int countOfDoor = 0;

            StreamWriter writer = new StreamWriter(fileName);

            //this is the number of rows and columns inserted by the user from the design form before generating the tiles in the board.
            writer.WriteLine(gameTiles.GetLength(ROW_INDEX));
            writer.WriteLine(gameTiles.GetLength(COL_INDEX));


            for (int row = 0; row < gameTiles.GetLength(ROW_INDEX); row++)
            {
                for (int column = 0; column < gameTiles.GetLength(COL_INDEX); column++)
                {
                    var currentGameTile = gameTiles[row, column];
                    //this code will write all the values inside the text file the coordinates with selected toolboox
                    writer.WriteLine(row);
                    writer.WriteLine(column);
                    writer.WriteLine(currentGameTile.currentSelectedToolBoxImage);


                    //this code below will count each current selected tool box image according to the selected design from the toolbox.
                    if (currentGameTile.currentSelectedToolBoxImage == DesignForm.WALL_VALUE)
                    {
                        countOfWall++;
                    }

                    if (currentGameTile.currentSelectedToolBoxImage == DesignForm.RED_BOX_VALUE || currentGameTile.currentSelectedToolBoxImage == DesignForm.GREEN_BOX_VALUE)
                    {
                        countOfBox++;
                    }

                    if (currentGameTile.currentSelectedToolBoxImage == DesignForm.RED_DOOR_VALUE || currentGameTile.currentSelectedToolBoxImage == DesignForm.GREEN_DOOR_VALUE)
                    {
                        countOfDoor++;
                    }
                }
            }

            //storing all the counts for each image accordingly as an out integer parameter.
            totalCountWall = countOfWall;
            totalCountDoor = countOfDoor;
            totalCountBox = countOfBox;

            writer.Close();
        }

        public void LoadGameFileToBoard(string fileName, Panel pnlBoard, int size)
        {
            StreamReader reader = new StreamReader(fileName);
            int rowNumFromFile = int.Parse(reader.ReadLine()); //readline
            int colNumFromFile = int.Parse(reader.ReadLine());

            //empty array storage for the gameTiles
            GameTile[,] gameTiles = new GameTile[rowNumFromFile, colNumFromFile];

            var toolboxImageValueFromFile = 0;
            int currentRowValue = 0;
            int currentColValue = 0;
            int count = 0;
            string line;

            while ((line = reader.ReadLine())!= null)
            {
                if (count == 0)
                {
                    currentRowValue = int.Parse(line);
                    count++;
                }
                else if (count == 1)
                {
                    currentColValue = int.Parse(line);
                    count++;
                }
                else if (count == 2)
                {

                    toolboxImageValueFromFile = int.Parse(line);

                    //create a new gametile storage for each tile
                    GameTile newTile = new GameTile(toolboxImageValueFromFile);// send the coordinates (row, col) num of the selected gameTile from the board.
                    //store the new game tile into the array with coordinate

                    newTile.Location = new Point(currentColValue * size + size, currentRowValue * size + size);
                    newTile.Width = size;
                    newTile.Height = size;
                    newTile.Visible = true;
                    newTile.BorderStyle = BorderStyle.Fixed3D;
                    newTile.BringToFront();
                    pnlBoard.Controls.Add(newTile);

                    //
                    gameTiles[currentRowValue, currentColValue] = newTile;

                    count = 0;
                }

            }

        }

    }
}
