using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Note.Views
{
    public partial class DrawNote : Form
    {
       
        private Draw_Note drawNote;
        private Graphics graphics = null;

        public DrawNote()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            drawNote.isDraw = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            drawNote.isDraw = true;
            drawNote.X = e.X;
            drawNote.Y = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawNote.isDraw)
            {
                if (graphics == null)
                {
                    graphics = pictureBox1.CreateGraphics();
                    Bitmap bmp = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
                    pictureBox1.Image = bmp;
                    graphics = Graphics.FromImage(bmp);
                  //  graphics.Clear(Color.DarkCyan);

                }

                graphics.DrawLine(drawNote.pen, drawNote.X, drawNote.Y, e.X, e.Y);

                graphics.Flush();
                graphics.Save();
                pictureBox1.Refresh();

                drawNote.X = e.X;
                drawNote.Y = e.Y;

            }
        }

        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            if (graphics == null) return;
            graphics.Dispose();
           // this.pictureBox1.CreateGraphics().Clear(Color.DarkCyan);
            Bitmap bmp = new Bitmap(this.pictureBox1.ClientSize.Width, this.pictureBox1.ClientSize.Height, this.pictureBox1.CreateGraphics());
        }

        private void DrawNote_Load(object sender, EventArgs e)
        {
            drawNote = new Draw_Note();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Bitmap bmp = new Bitmap(this.pictureBox1.ClientSize.Width, this.pictureBox1.ClientSize.Height);
            this.pictureBox1.DrawToBitmap(bmp, this.pictureBox1.ClientRectangle);
            // bmp.Save(String.Format("Button.jpg", System.Drawing.Imaging.ImageFormat.Gif));
            bmp.Save(String.Format("{0}.jpg", this.txttitleDraw));
            MessageBox.Show("Saved");
            this.pictureBox1.CreateGraphics().Clear(Color.DarkCyan);
            // this.pictureBox1.CreateGraphics().Clear();
            
            graphics = null;
            this.txttitleDraw.Clear();
            
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.pictureBox1.CreateGraphics().Clear(Color.DarkCyan);
            graphics = null;
         
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenKlyeMethod();
        }
        private void OpenKlyeMethod()
        {
            OpenFileDialog openfiledialog = new OpenFileDialog();
            // openfiledialog.Filter = "Text Files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf|MSWord Files (*.docx)|*.docx|PHP (*.php)|*.php";
            openFileDialog1.Filter = "Windows Bitmap|*.bmp|JPEG Image|*.jpg|All Files|*.*";
            DialogResult result = openfiledialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                Image img = Image.FromFile(openfiledialog.FileName);
                pictureBox1.Image = img;
             //   pictureBox1.BackgroundImageLayout.GetHashCode();
            }

        }

        private void darkGrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.DarkGray;
        }

        private void hotPinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.HotPink;
        }

        private void greenYellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.GreenYellow;
        }

        private void mediumAquamarineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.MediumAquamarine;
        }

        private void rosyBrownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.RosyBrown;
        }
    }
    public class Draw_Note
    {
        public int X { set; get; }
        public int Y { set; get; }
        public Color color { set; get; }
        public Pen pen { set; get; }
        public bool isDraw { set; get; }
        public Draw_Note()
        {
            isDraw = false;
            color = Color.White;
            pen = new Pen(color, 2);
        }

    }
}
