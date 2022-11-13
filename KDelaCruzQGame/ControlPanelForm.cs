/*ControlPanelForm.cs
 * This program is a windows form in .net framework that only controls the Qgame menu to design and play games by loading the file and saving the file
 * 
 * Revision History:
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

namespace KDelaCruzQGame
{
    public partial class ControlPanelForm : Form
    {

        public ControlPanelForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //When the Exit button is click this will exit the control form for QGame.
            Application.Exit();
        }

        private void btnDesign_Click(object sender, EventArgs e)
        {
            //When the design button from the control form for QGame has been clicked, this will create an instance of the Design Form in a new window.
            DesignForm designForm = new DesignForm();
            designForm.Show();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            PlayForm playForm = new PlayForm();
            playForm.Show();
        }
    }
}
