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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button1_OnMouseEnter(object sender, EventArgs e)
        {
          //  button1.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowLeftHover.png");
            
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            btnContinue.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowLeftClick.png");
      
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
          btnContinue.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowLeftClick.png");
          
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btnContinue.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowLeft.png");
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            btnContinue.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowLeftHover.png");
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            btnContinue.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowLeftHover.png");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            btnPrevious.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowRightClick.png");
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            btnPrevious.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowRightHover.png");
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            btnPrevious.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowRightHover.png");
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            // Reset to Hover 
            btnPrevious.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowRightHover.png");
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            // Reset to default state
            btnPrevious.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowRight.png");
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            btnPrevious.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowRightClick.png");
        }


    }
}
