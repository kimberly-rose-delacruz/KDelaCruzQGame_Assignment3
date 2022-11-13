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
using System.IO;
using System.Linq;
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
                    if(currentGameTile.currentSelectedToolBoxImage == DesignForm.WALL_VALUE)
                    {
                        countOfWall++;
                    }

                    if(currentGameTile.currentSelectedToolBoxImage == DesignForm.RED_BOX_VALUE || currentGameTile.currentSelectedToolBoxImage == DesignForm.GREEN_BOX_VALUE)
                    {
                        countOfBox++;
                    }

                    if(currentGameTile.currentSelectedToolBoxImage == DesignForm.RED_DOOR_VALUE || currentGameTile.currentSelectedToolBoxImage == DesignForm.GREEN_DOOR_VALUE)
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

    }
}
