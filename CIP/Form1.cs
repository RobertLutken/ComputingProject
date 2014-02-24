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
            button1.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowLeftClick.png");
         
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            button1.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowLeftClick.png");
      
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowLeftClick.png");
          
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowLeft.png");
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowLeftEnter.png");
        }


    }
}
