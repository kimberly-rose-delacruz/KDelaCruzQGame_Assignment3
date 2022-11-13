namespace KDelaCruzQGame
{
    partial class DesignForm
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
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBoxNumColumns = new System.Windows.Forms.TextBox();
            this.txtBoxNumRows = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblColumns = new System.Windows.Forms.Label();
            this.lblRows = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlGreenBox = new System.Windows.Forms.Panel();
            this.pnlRedBox = new System.Windows.Forms.Panel();
            this.btnGreenBox = new System.Windows.Forms.Button();
            this.pnlGreenDoor = new System.Windows.Forms.Panel();
            this.btnRedBox = new System.Windows.Forms.Button();
            this.btnGreenDoor = new System.Windows.Forms.Button();
            this.pnlRedDoor = new System.Windows.Forms.Panel();
            this.btnRedDoor = new System.Windows.Forms.Button();
            this.pnlWall = new System.Windows.Forms.Panel();
            this.btnWall = new System.Windows.Forms.Button();
            this.pnlNone = new System.Windows.Forms.Panel();
            this.btnNone = new System.Windows.Forms.Button();
            this.lblToolBox = new System.Windows.Forms.Label();
            this.pnlParentBoard = new System.Windows.Forms.Panel();
            this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1219, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem1,
            this.closeToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "&File";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.saveToolStripMenuItem1.Text = "&Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.closeToolStripMenuItem1.Text = "&Close";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtBoxNumColumns);
            this.panel1.Controls.Add(this.txtBoxNumRows);
            this.panel1.Controls.Add(this.btnGenerate);
            this.panel1.Controls.Add(this.lblColumns);
            this.panel1.Controls.Add(this.lblRows);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1207, 90);
            this.panel1.TabIndex = 1;
            // 
            // txtBoxNumColumns
            // 
            this.txtBoxNumColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBoxNumColumns.Location = new System.Drawing.Point(294, 25);
            this.txtBoxNumColumns.Name = "txtBoxNumColumns";
            this.txtBoxNumColumns.Size = new System.Drawing.Size(97, 26);
            this.txtBoxNumColumns.TabIndex = 4;
            this.txtBoxNumColumns.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBoxNumRows
            // 
            this.txtBoxNumRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBoxNumRows.Location = new System.Drawing.Point(93, 22);
            this.txtBoxNumRows.Name = "txtBoxNumRows";
            this.txtBoxNumRows.Size = new System.Drawing.Size(99, 26);
            this.txtBoxNumRows.TabIndex = 3;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnGenerate.Location = new System.Drawing.Point(431, 11);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(138, 49);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblColumns
            // 
            this.lblColumns.AutoSize = true;
            this.lblColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblColumns.Location = new System.Drawing.Point(213, 30);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(75, 20);
            this.lblColumns.TabIndex = 1;
            this.lblColumns.Text = "Columns:";
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRows.Location = new System.Drawing.Point(34, 25);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(53, 20);
            this.lblRows.TabIndex = 0;
            this.lblRows.Text = "Rows:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.pnlGreenBox);
            this.panel2.Controls.Add(this.pnlRedBox);
            this.panel2.Controls.Add(this.btnGreenBox);
            this.panel2.Controls.Add(this.pnlGreenDoor);
            this.panel2.Controls.Add(this.btnRedBox);
            this.panel2.Controls.Add(this.btnGreenDoor);
            this.panel2.Controls.Add(this.pnlRedDoor);
            this.panel2.Controls.Add(this.btnRedDoor);
            this.panel2.Controls.Add(this.pnlWall);
            this.panel2.Controls.Add(this.btnWall);
            this.panel2.Controls.Add(this.pnlNone);
            this.panel2.Controls.Add(this.btnNone);
            this.panel2.Controls.Add(this.lblToolBox);
            this.panel2.Location = new System.Drawing.Point(0, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 871);
            this.panel2.TabIndex = 2;
            // 
            // pnlGreenBox
            // 
            this.pnlGreenBox.BackgroundImage = global::KDelaCruzQGame.Properties.Resources.green_box;
            this.pnlGreenBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlGreenBox.Location = new System.Drawing.Point(26, 586);
            this.pnlGreenBox.Name = "pnlGreenBox";
            this.pnlGreenBox.Size = new System.Drawing.Size(60, 74);
            this.pnlGreenBox.TabIndex = 11;
            // 
            // pnlRedBox
            // 
            this.pnlRedBox.BackgroundImage = global::KDelaCruzQGame.Properties.Resources.red_box;
            this.pnlRedBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlRedBox.Location = new System.Drawing.Point(26, 483);
            this.pnlRedBox.Name = "pnlRedBox";
            this.pnlRedBox.Size = new System.Drawing.Size(60, 74);
            this.pnlRedBox.TabIndex = 9;
            // 
            // btnGreenBox
            // 
            this.btnGreenBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnGreenBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnGreenBox.Location = new System.Drawing.Point(20, 574);
            this.btnGreenBox.Name = "btnGreenBox";
            this.btnGreenBox.Size = new System.Drawing.Size(171, 97);
            this.btnGreenBox.TabIndex = 10;
            this.btnGreenBox.Text = "Green Box";
            this.btnGreenBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGreenBox.UseVisualStyleBackColor = false;
            this.btnGreenBox.Click += new System.EventHandler(this.btnGreenBox_Click);
            // 
            // pnlGreenDoor
            // 
            this.pnlGreenDoor.BackgroundImage = global::KDelaCruzQGame.Properties.Resources.green_door;
            this.pnlGreenDoor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlGreenDoor.Location = new System.Drawing.Point(26, 380);
            this.pnlGreenDoor.Name = "pnlGreenDoor";
            this.pnlGreenDoor.Size = new System.Drawing.Size(60, 74);
            this.pnlGreenDoor.TabIndex = 7;
            // 
            // btnRedBox
            // 
            this.btnRedBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRedBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRedBox.Location = new System.Drawing.Point(20, 471);
            this.btnRedBox.Name = "btnRedBox";
            this.btnRedBox.Size = new System.Drawing.Size(171, 97);
            this.btnRedBox.TabIndex = 8;
            this.btnRedBox.Text = "Red Box";
            this.btnRedBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRedBox.UseVisualStyleBackColor = false;
            this.btnRedBox.Click += new System.EventHandler(this.btnRedBox_Click);
            // 
            // btnGreenDoor
            // 
            this.btnGreenDoor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnGreenDoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnGreenDoor.Location = new System.Drawing.Point(20, 368);
            this.btnGreenDoor.Name = "btnGreenDoor";
            this.btnGreenDoor.Size = new System.Drawing.Size(171, 97);
            this.btnGreenDoor.TabIndex = 6;
            this.btnGreenDoor.Text = "Green Door";
            this.btnGreenDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGreenDoor.UseVisualStyleBackColor = false;
            this.btnGreenDoor.Click += new System.EventHandler(this.btnGreenDoor_Click);
            // 
            // pnlRedDoor
            // 
            this.pnlRedDoor.BackgroundImage = global::KDelaCruzQGame.Properties.Resources.red_door;
            this.pnlRedDoor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlRedDoor.Location = new System.Drawing.Point(26, 272);
            this.pnlRedDoor.Name = "pnlRedDoor";
            this.pnlRedDoor.Size = new System.Drawing.Size(60, 67);
            this.pnlRedDoor.TabIndex = 5;
            // 
            // btnRedDoor
            // 
            this.btnRedDoor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRedDoor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRedDoor.Location = new System.Drawing.Point(20, 256);
            this.btnRedDoor.Name = "btnRedDoor";
            this.btnRedDoor.Size = new System.Drawing.Size(171, 97);
            this.btnRedDoor.TabIndex = 4;
            this.btnRedDoor.Text = "Red Door";
            this.btnRedDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRedDoor.UseVisualStyleBackColor = false;
            this.btnRedDoor.Click += new System.EventHandler(this.btnRedDoor_Click);
            // 
            // pnlWall
            // 
            this.pnlWall.BackgroundImage = global::KDelaCruzQGame.Properties.Resources.wall;
            this.pnlWall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlWall.Location = new System.Drawing.Point(26, 167);
            this.pnlWall.Name = "pnlWall";
            this.pnlWall.Size = new System.Drawing.Size(60, 69);
            this.pnlWall.TabIndex = 3;
            // 
            // btnWall
            // 
            this.btnWall.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnWall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnWall.Location = new System.Drawing.Point(20, 152);
            this.btnWall.Name = "btnWall";
            this.btnWall.Size = new System.Drawing.Size(171, 98);
            this.btnWall.TabIndex = 3;
            this.btnWall.Text = "Wall";
            this.btnWall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWall.UseVisualStyleBackColor = false;
            this.btnWall.Click += new System.EventHandler(this.btnWall_Click);
            // 
            // pnlNone
            // 
            this.pnlNone.BackgroundImage = global::KDelaCruzQGame.Properties.Resources.none;
            this.pnlNone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlNone.Location = new System.Drawing.Point(26, 71);
            this.pnlNone.Name = "pnlNone";
            this.pnlNone.Size = new System.Drawing.Size(60, 61);
            this.pnlNone.TabIndex = 2;
            // 
            // btnNone
            // 
            this.btnNone.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnNone.Location = new System.Drawing.Point(20, 56);
            this.btnNone.Name = "btnNone";
            this.btnNone.Size = new System.Drawing.Size(171, 90);
            this.btnNone.TabIndex = 1;
            this.btnNone.Text = "None";
            this.btnNone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNone.UseVisualStyleBackColor = false;
            this.btnNone.Click += new System.EventHandler(this.btnNone_Click);
            // 
            // lblToolBox
            // 
            this.lblToolBox.AutoSize = true;
            this.lblToolBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblToolBox.Location = new System.Drawing.Point(69, 12);
            this.lblToolBox.Name = "lblToolBox";
            this.lblToolBox.Size = new System.Drawing.Size(80, 24);
            this.lblToolBox.TabIndex = 0;
            this.lblToolBox.Text = "Toolbox";
            // 
            // pnlParentBoard
            // 
            this.pnlParentBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlParentBoard.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlParentBoard.Location = new System.Drawing.Point(234, 130);
            this.pnlParentBoard.Name = "pnlParentBoard";
            this.pnlParentBoard.Size = new System.Drawing.Size(973, 703);
            this.pnlParentBoard.TabIndex = 3;
            // 
            // dlgSaveFile
            // 
            this.dlgSaveFile.DefaultExt = "qgame";
            this.dlgSaveFile.FileName = "Savegame.qgame";
            // 
            // DesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 990);
            this.Controls.Add(this.pnlParentBoard);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DesignForm";
            this.Text = "Design Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblColumns;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblToolBox;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtBoxNumRows;
        private System.Windows.Forms.TextBox txtBoxNumColumns;
        private System.Windows.Forms.Panel pnlNone;
        private System.Windows.Forms.Button btnNone;
        private System.Windows.Forms.Button btnWall;
        private System.Windows.Forms.Panel pnlWall;
        private System.Windows.Forms.Panel pnlRedDoor;
        private System.Windows.Forms.Button btnRedDoor;
        private System.Windows.Forms.Panel pnlGreenDoor;
        private System.Windows.Forms.Button btnGreenDoor;
        private System.Windows.Forms.Panel pnlRedBox;
        private System.Windows.Forms.Button btnRedBox;
        private System.Windows.Forms.Panel pnlGreenBox;
        private System.Windows.Forms.Button btnGreenBox;
        private System.Windows.Forms.Panel pnlParentBoard;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
        private System.Windows.Forms.SaveFileDialog dlgSaveFile;
    }
}