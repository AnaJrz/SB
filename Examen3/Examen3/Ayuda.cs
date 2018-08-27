using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Examen3
{
    public partial class Ayuda : Form
    {
        private PictureBox pb = new PictureBox();
        Graphics g;
        Image Imagen = Image.FromFile("Ayuda.png");
        public Ayuda()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            g.DrawImage(Imagen, 0,0,pictureBox1.Width, pictureBox1.Height);
        }

        private void Ayuda_Load(object sender, EventArgs e)
        {
            pb.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.Controls.Add(pb);
        }
    }
}
