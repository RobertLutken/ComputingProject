using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using CIP.Properties;
using Utilitys;
using UserHandler;
namespace CIP
{
    public partial class Prequery : Form
    {
      
       
        public Prequery()
        {
            InitializeComponent();
        }
        private void btnPrevious_MouseClick(object sender, MouseEventArgs e)
        {
            btnPrevious.Image = Resources.ArrowLeftClick;//.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowLeftClick.png");
        }

        private void btnPrevious_MouseEnter(object sender, EventArgs e)
        {
            btnPrevious.Image = Resources.ArrowLeftHover; //btnPrevious.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowLeftHover.png");
        }

        private void btnPrevious_MouseHover(object sender, EventArgs e)
        {
            btnPrevious.Image = Resources.ArrowLeftHover; //btnPrevious.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowLeftHover.png");
        }

        private void btnPrevious_MouseUp(object sender, MouseEventArgs e)
        {
            // Reset to Hover 
            btnPrevious.Image = Resources.ArrowLeftHover; //btnPrevious.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowLeftHover.png");
            //btnPrevious.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowLeftHover.png");
        }

        private void btnPrevious_MouseLeave(object sender, EventArgs e)
        {
            // Reset to default state
            btnPrevious.Image = Resources.ArrowLeft;  // btnPrevious.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowLeft.png");
        }

        private void btnPrevious_MouseDown(object sender, MouseEventArgs e)
        {
            btnPrevious.Image = Resources.ArrowLeftClick;  // btnPrevious.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowLeftClick.png");
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
           // btnPrevious.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowLeftClick.png");

            this.Hide();
            Splash splash = new Splash();
            EnableDoubleBuffering();
            splash.Show();
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

        private void btnContinue_Click(object sender, EventArgs e)
        {
            
            
           if( Utils.TextCheck(tbFirstName,tbSurname,tbAge))
            {
                User.Forname = tbFirstName.Text;
                User.Surname = tbSurname.Text;
                User.HasProgrammedBefore = ProgrammedBefore;
                User.HasPorgrammedPythonBefore = ProgrammedPython;
                User.Age = int.Parse(tbAge.Text);

                if (Utilitys.Utils.debugging)
                {
                    MessageBox.Show(this, "You entered: \nForname : " +
                        UserHandler.User.Forname.ToString() +
                        "\nSurname : " + UserHandler.User.Surname.ToString() +
                        "\nAge : " + UserHandler.User.Age.ToString() +
                        "\nHas Programmed Python : " + UserHandler.User.HasPorgrammedPythonBefore.ToString() +
                        "\nHas Programmed before : " + UserHandler.User.HasProgrammedBefore.ToString(),
                        "Debugging !", MessageBoxButtons.OK);
                }
                AppMain app = new AppMain();
                EnableDoubleBuffering();
                app.Show();
                this.Hide();
           }
        }
        public void EnableDoubleBuffering()
        {
            // Set the value of the double-buffering style bits to true. 
       
             this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);

            this.DoubleBuffered = true;
            this.UpdateStyles();
        }

        private void Prequery_Load(object sender, EventArgs e)
        {

        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdoProgY_CheckedChanged(object sender, EventArgs e)
        {
            ProgrammedBefore = true;

        }

        private void rdoProgN_CheckedChanged(object sender, EventArgs e)
        {
            ProgrammedBefore = false;
        }

        private void rdoPythonY_CheckedChanged(object sender, EventArgs e)
        {
            ProgrammedPython = true;
        }

        private void rdoPythonN_CheckedChanged(object sender, EventArgs e)
        {
            ProgrammedPython = false;
        }



        public bool ProgrammedPython { get; set; }

        public bool ProgrammedBefore { get; set; }
    }
}
