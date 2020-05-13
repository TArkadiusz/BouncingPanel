using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouncingPanel
{
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent();
        }
        int maxX, maxY;

        private void fmBounce_Load(object sender, EventArgs e)
        {
            Form frm = (Form)sender;
            maxX = frm.Size.Width;
            maxY = frm.Size.Height;
        }

        private Random random = new Random((int)DateTime.Now.Ticks);

        private int RandomNumber(int min, int max)
        {

            return random.Next(min, max);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int moveX = RandomNumber(0, maxX-150);
            int moveY = RandomNumber(0, maxY-150);
            int r = RandomNumber(0, 255);
            int g = RandomNumber(0, 255);
            int b = RandomNumber(0, 255);

            pnlBounce.Location = new Point(moveX, moveY);

            pnlBounce.BackColor = new Color();
            pnlBounce.BackColor = Color.FromArgb(r, g, b);
        }
    }
}
