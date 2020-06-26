namespace Note.Views
{
    partial class DrawNote
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawNote));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backGroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkGrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotPinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenYellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumAquamarineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rosyBrownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txttitleDraw = new System.Windows.Forms.ToolStripTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.txttitleDraw});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(379, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1,
            this.openToolStripMenuItem,
            this.backGroundToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(37, 23);
            this.newToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.newToolStripMenuItem1.Text = "New";
            this.newToolStripMenuItem1.Click += new System.EventHandler(this.newToolStripMenuItem1_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // backGroundToolStripMenuItem
            // 
            this.backGroundToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkGrayToolStripMenuItem,
            this.hotPinkToolStripMenuItem,
            this.greenYellowToolStripMenuItem,
            this.mediumAquamarineToolStripMenuItem,
            this.rosyBrownToolStripMenuItem});
            this.backGroundToolStripMenuItem.Name = "backGroundToolStripMenuItem";
            this.backGroundToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.backGroundToolStripMenuItem.Text = "BackGround";
            // 
            // darkGrayToolStripMenuItem
            // 
            this.darkGrayToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray;
            this.darkGrayToolStripMenuItem.Name = "darkGrayToolStripMenuItem";
            this.darkGrayToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.darkGrayToolStripMenuItem.Text = "DarkGray";
            this.darkGrayToolStripMenuItem.Click += new System.EventHandler(this.darkGrayToolStripMenuItem_Click);
            // 
            // hotPinkToolStripMenuItem
            // 
            this.hotPinkToolStripMenuItem.BackColor = System.Drawing.Color.HotPink;
            this.hotPinkToolStripMenuItem.Name = "hotPinkToolStripMenuItem";
            this.hotPinkToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.hotPinkToolStripMenuItem.Text = "HotPink";
            this.hotPinkToolStripMenuItem.Click += new System.EventHandler(this.hotPinkToolStripMenuItem_Click);
            // 
            // greenYellowToolStripMenuItem
            // 
            this.greenYellowToolStripMenuItem.BackColor = System.Drawing.Color.GreenYellow;
            this.greenYellowToolStripMenuItem.Name = "greenYellowToolStripMenuItem";
            this.greenYellowToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.greenYellowToolStripMenuItem.Text = "Green Yellow";
            this.greenYellowToolStripMenuItem.Click += new System.EventHandler(this.greenYellowToolStripMenuItem_Click);
            // 
            // mediumAquamarineToolStripMenuItem
            // 
            this.mediumAquamarineToolStripMenuItem.BackColor = System.Drawing.Color.MediumAquamarine;
            this.mediumAquamarineToolStripMenuItem.Name = "mediumAquamarineToolStripMenuItem";
            this.mediumAquamarineToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.mediumAquamarineToolStripMenuItem.Text = "MediumAquamarine";
            this.mediumAquamarineToolStripMenuItem.Click += new System.EventHandler(this.mediumAquamarineToolStripMenuItem_Click);
            // 
            // rosyBrownToolStripMenuItem
            // 
            this.rosyBrownToolStripMenuItem.BackColor = System.Drawing.Color.RosyBrown;
            this.rosyBrownToolStripMenuItem.Name = "rosyBrownToolStripMenuItem";
            this.rosyBrownToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.rosyBrownToolStripMenuItem.Text = "RosyBrown";
            this.rosyBrownToolStripMenuItem.Click += new System.EventHandler(this.rosyBrownToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 23);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 23);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // txttitleDraw
            // 
            this.txttitleDraw.Name = "txttitleDraw";
            this.txttitleDraw.Size = new System.Drawing.Size(100, 23);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(379, 339);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            this.pictureBox1.Resize += new System.EventHandler(this.pictureBox1_Resize);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DrawNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Note.Properties.Resources.BackgroundBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(379, 366);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DrawNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DrawNote";
            this.Load += new System.EventHandler(this.DrawNote_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txttitleDraw;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backGroundToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem darkGrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotPinkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenYellowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumAquamarineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rosyBrownToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}