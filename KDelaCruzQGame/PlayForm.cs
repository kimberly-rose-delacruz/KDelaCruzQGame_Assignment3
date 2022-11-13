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
        public const int SIZE = 100;
        public PlayForm()
        {
            InitializeComponent();
            txtBoxNumOfMoves.Text = INITIAL_VALUE_NUMBER_OF_MOVES;
            txtBoxNumRemainingBoxes.Text = INITIAL_VALUE_NUMBER_OF_REMAINING_BOXES;
        }

        private void loadGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
                                                            
            dlgOpen.Filter = "Text File|*.txt|all files|*.*|game file|*.game";

            DialogResult result = dlgOpen.ShowDialog();

            switch (result)
            {
                case DialogResult.OK:
                    newBoard.LoadGameFileToBoard(dlgOpen.FileName, pnlBoard, SIZE);
                    break;
                default:
                    break;
            }
        }
    }
}
