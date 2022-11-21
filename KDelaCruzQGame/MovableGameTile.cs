using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDelaCruzQGame
{
    public class MovableGameTile : GameTile, IMovableGameTile
    {

        public MovableGameTile(int gameTileType) : base(gameTileType)
        {
            InitializeComponent();
        }

        public int CurrentSelectToolBox => this.currentSelectedToolBoxImage;

        public int ColumnCoordinateOfTile { get; set; }
        public int RowCoordinateOfTile { get; set; }

        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // MovableGameTile
            // 
            this.Click += new System.EventHandler(this.MovableGameTile_Click);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        private void MovableGameTile_Click(object sender, EventArgs e)
        {
            Board.SELECTED_MOVABLE_GAMETILE = this;
        }
    }
}
