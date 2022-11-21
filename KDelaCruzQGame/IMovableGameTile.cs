/*IMovableGametile.cs
 * This class is for each generated tile using Picturebox by inheriting it as a representation of each tile to the Design Form
 * 
 * Revision History:
 *      Kimberly Dela Cruz, 2022.11.20: Add the functions for controllers and clearing of the game tiles when user attempts to upload a new level for Qgame.
 *      Kimberly Dela Cruz, 2022.11.01: Modify code with messagebox for total count of wall, boxes, and doors when design has been finalized to be saved in a file.
 *      Kimberly Dela Cruz, 2022.10.15: Created
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDelaCruzQGame
{
    public interface IMovableGameTile
    {
        int CurrentSelectToolBox { get; }
        int XCoordinateOfTile { get; set; }
        int YCoordinateOfTile { get; set; }
        void ChangeGameTile(int gameTileType);
    }
}
