namespace KDelaCruzQGame
{
    partial class PlayForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.lblNumOfMoves = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxNumOfMoves = new System.Windows.Forms.TextBox();
            this.txtBoxNumRemainingBoxes = new System.Windows.Forms.TextBox();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1262, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadGameToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadGameToolStripMenuItem
            // 
            this.loadGameToolStripMenuItem.Name = "loadGameToolStripMenuItem";
            this.loadGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadGameToolStripMenuItem.Text = "Load Game";
            this.loadGameToolStripMenuItem.Click += new System.EventHandler(this.loadGameToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // pnlBoard
            // 
            this.pnlBoard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBoard.Location = new System.Drawing.Point(7, 27);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(861, 864);
            this.pnlBoard.TabIndex = 1;
            // 
            // btnUp
            // 
            this.btnUp.Enabled = false;
            this.btnUp.Location = new System.Drawing.Point(1025, 652);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 83);
            this.btnUp.TabIndex = 2;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Enabled = false;
            this.btnLeft.Location = new System.Drawing.Point(944, 741);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 83);
            this.btnLeft.TabIndex = 3;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Enabled = false;
            this.btnRight.Location = new System.Drawing.Point(1106, 741);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 83);
            this.btnRight.TabIndex = 4;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnDown
            // 
            this.btnDown.Enabled = false;
            this.btnDown.Location = new System.Drawing.Point(1025, 741);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 83);
            this.btnDown.TabIndex = 5;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // lblNumOfMoves
            // 
            this.lblNumOfMoves.AutoSize = true;
            this.lblNumOfMoves.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNumOfMoves.Location = new System.Drawing.Point(893, 50);
            this.lblNumOfMoves.Name = "lblNumOfMoves";
            this.lblNumOfMoves.Size = new System.Drawing.Size(140, 20);
            this.lblNumOfMoves.TabIndex = 6;
            this.lblNumOfMoves.Text = "Number Of Moves:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(893, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Number of Remaining Boxes:";
            // 
            // txtBoxNumOfMoves
            // 
            this.txtBoxNumOfMoves.Enabled = false;
            this.txtBoxNumOfMoves.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBoxNumOfMoves.Location = new System.Drawing.Point(897, 73);
            this.txtBoxNumOfMoves.Name = "txtBoxNumOfMoves";
            this.txtBoxNumOfMoves.Size = new System.Drawing.Size(259, 26);
            this.txtBoxNumOfMoves.TabIndex = 8;
            // 
            // txtBoxNumRemainingBoxes
            // 
            this.txtBoxNumRemainingBoxes.Enabled = false;
            this.txtBoxNumRemainingBoxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBoxNumRemainingBoxes.Location = new System.Drawing.Point(897, 178);
            this.txtBoxNumRemainingBoxes.Name = "txtBoxNumRemainingBoxes";
            this.txtBoxNumRemainingBoxes.Size = new System.Drawing.Size(259, 26);
            this.txtBoxNumRemainingBoxes.TabIndex = 9;
            // 
            // dlgOpen
            // 
            this.dlgOpen.FileName = "openFileDialog1";
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 903);
            this.Controls.Add(this.txtBoxNumRemainingBoxes);
            this.Controls.Add(this.txtBoxNumOfMoves);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNumOfMoves);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.pnlBoard);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PlayForm";
            this.Text = "PlayForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Label lblNumOfMoves;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxNumOfMoves;
        private System.Windows.Forms.TextBox txtBoxNumRemainingBoxes;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
    }
}