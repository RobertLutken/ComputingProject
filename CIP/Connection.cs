using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIP
{
    public partial class Connection : Form
    {
        public Connection()
        {
            InitializeComponent();
        }

        private void btnPrevious_MouseClick(object sender, MouseEventArgs e)
        {
            btnPrevious.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowLeftClick.png");
        }

        private void btnPrevious_MouseEnter(object sender, EventArgs e)
        {
            btnPrevious.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowLeftHover.png");
        }

        private void btnPrevious_MouseHover(object sender, EventArgs e)
        {
            btnPrevious.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowLeftHover.png");
        }

        private void btnPrevious_MouseUp(object sender, MouseEventArgs e)
        {
            // Reset to Hover 
            btnPrevious.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowLeftHover.png");
        }

        private void btnPrevious_MouseLeave(object sender, EventArgs e)
        {
            // Reset to default state
            btnPrevious.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowLeft.png");
        }

        private void btnPrevious_MouseDown(object sender, MouseEventArgs e)
        {
            btnPrevious.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowLeftClick.png");
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            btnPrevious.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowLeftClick.png");
        }
    }
}
