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
