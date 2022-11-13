/*GameTile.cs
 * This class is for each generated tile using Picturebox by inheriting it as a representation of each tile to the Design Form
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
using System.Windows.Forms;

namespace KDelaCruzQGame
{
    public class GameTile : PictureBox
    {
        //global variables
        ToolBoxImageService toolBoxImageService = new ToolBoxImageService();
        public int currentSelectedToolBoxImage = DesignForm.NONE_VALUE;
        public GameTile()
        {
            InitializeComponent();
        }

        //properties to store the currentRowSelectFromtheBoard, currentColSelectedFromTheBoard
        public GameTile(int gameTileType)
        {
            //feed all the code when gameTileType has been stored from the read text file
            this.Image = toolBoxImageService.GetImage(gameTileType);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.currentSelectedToolBoxImage = gameTileType;
        }

        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTile
            // 
            this.Click += new System.EventHandler(this.GameTile_Click);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        //this created through event handler by clicking in the panelBoard it will trigger this class as a gameTile (to add the image according to the position where the user tries to select in the grid.
        //this is also going to be used in the board where it will indicate the current selected toolbox image and store it so it can be referenced whenever needed to be mapped for saving files or counting the toolbox image as being used as a design within the Board class.
        private void GameTile_Click(object sender, EventArgs e)
        {
            this.Image = toolBoxImageService.GetImage(DesignForm.selectedToolBox);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.currentSelectedToolBoxImage = DesignForm.selectedToolBox;
        }
    }
}
