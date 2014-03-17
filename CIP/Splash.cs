using CIP.Properties;
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
    public partial class Splash : Form
    {
        
        public Splash()
        {
            InitializeComponent();
        }

          private void btnContinue_MouseClick(object sender, MouseEventArgs e)
        {
            btnContinue.Image = Resources.ArrowRightClick;// btnContinue.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowRightClick.png");
        }

        private void btnContinue_MouseDown(object sender, MouseEventArgs e)
        {
            btnContinue.Image = Resources.ArrowRightClick;  //btnContinue.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowRightClick.png");
        }

        private void btnContinue_MouseEnter(object sender, EventArgs e)
        {
            btnContinue.Image = Resources.ArrowRightHover;  //btnContinue.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowRightHover.png");
        }

        private void btnContinue_MouseLeave(object sender, EventArgs e)
        {
            btnContinue.Image = Resources.ArrowRight;  //btnContinue.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowRight.png");
        }

        private void btnContinue_MouseUp(object sender, MouseEventArgs e)
        {
            btnContinue.Image = Resources.ArrowRight; //btnContinue.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowRight.png");
        }
       public void btnContinue_Click(object sender, EventArgs e)
        {
            if (UserHandler.User.Age  > 0 && !string.IsNullOrEmpty(UserHandler.User.Forname) && !string.IsNullOrEmpty(UserHandler.User.Surname))
            {
                AppMain appMain = new AppMain();
                appMain.Show();
                this.Hide();
            }
            else
            {
                Connection connectionWindow = new Connection();
                EnableDoubleBuffering();
                connectionWindow.Show();
                this.Hide();
            }
        }
               
        private void Splash_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
        }
        public void EnableDoubleBuffering()
        {

            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);

            this.DoubleBuffered = true;
            this.UpdateStyles();
        }
      
    }
}
