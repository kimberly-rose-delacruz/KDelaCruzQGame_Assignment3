/*ToolBoxImageService.cs
 * This class is for returning the image from the resources folder depending on which kind of tool box does the user selected from the design form.
 * 
 * Revision History:
 *      Kimberly Dela Cruz, 2022.10.15: Created
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDelaCruzQGame
{
    public class ToolBoxImageService
    {
        //global variables to set the image from the resources for Toolbox selection.
        Image wallImage = KDelaCruzQGame.Properties.Resources.wall;
        Image redDoorImage = KDelaCruzQGame.Properties.Resources.red_door;
        Image greenDoorImage = KDelaCruzQGame.Properties.Resources.green_door;
        Image redBoxImage = KDelaCruzQGame.Properties.Resources.red_box;
        Image greenBoxImage = KDelaCruzQGame.Properties.Resources.green_box;

        //service to get the image according to the selected tooldbox.
        public Image GetImage(int selectedToolBox)
        {
            if (selectedToolBox == DesignForm.NONE_VALUE)
            {
                return null;
            }   
            else if (selectedToolBox == DesignForm.WALL_VALUE)
            {
                return wallImage;
            }
            else if(selectedToolBox == DesignForm.RED_DOOR_VALUE)
            {
                return redDoorImage;
            }
            else if(selectedToolBox == DesignForm.GREEN_DOOR_VALUE)
            {
                return greenDoorImage;
            }
            else if(selectedToolBox == DesignForm.RED_BOX_VALUE)
            {
                return redBoxImage;
            }
            else
            {
                return greenBoxImage;
            }
        }
    }
}
