
using CIP.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace CIP
{
    public partial class AppMain : Form
    {
        SyntaxHighlighter syHighlight = new SyntaxHighlighter();
        public AppMain()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            timer1.Start();
            lbNetBios.Text = Environment.UserName.ToString() + "@" + Utils.GetLocalIPAddress();
          

        }
        public void EnableDoubleBuffering()
        {
            // Set the value of the double-buffering style bits to true. 
            this.SetStyle(ControlStyles.DoubleBuffer |
               ControlStyles.UserPaint |
               ControlStyles.AllPaintingInWmPaint,
               true);
            this.DoubleBuffered = true;
            this.UpdateStyles();
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
            btnContinue.Image = Resources.ArrowRightClick; // btnContinue.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowRightClick.png");
      
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            btnContinue.Image = Resources.ArrowRightClick;// btnContinue.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowRightClick.png");
          
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btnContinue.Image = Resources.ArrowRight; btnContinue.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowRight.png");
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            btnContinue.Image = Resources.ArrowRightHover; //btnContinue.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowRightHover.png");
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            btnContinue.Image = Resources.ArrowRightHover;   //btnContinue.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowRightHover.png");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Go to previous tutorial 

            // if tutorial == beigning 
            //      display Splash
            Splash splash = new Splash();
            EnableDoubleBuffering();
            splash.Show();
            this.Hide();

        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            btnContinue.Image = Resources.ArrowLeftClick; // btnPrevious.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowLeftClick.png");
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            btnContinue.Image = Resources.ArrowLeftHover; //  btnPrevious.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowLeftHover.png");
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            btnContinue.Image = Resources.ArrowLeftHover; // btnPrevious.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowLeftHover.png");
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            // Reset to Hover 
            btnContinue.Image = Resources.ArrowLeftHover; //  btnPrevious.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowLeftHover.png");
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            // Reset to default state
            btnContinue.Image = Resources.ArrowLeft; // btnPrevious.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowLeft.png");
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            btnContinue.Image = Resources.ArrowLeftClick; //  btnPrevious.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowLeftClick.png");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           this.lbTime.Text = Utils.GetTOD();
       
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

 

        public class SyntaxHighlighter
        {

            // Take foucs hack to prevent re-selection
            public void Highlight(RichTextBox tb, Label takeFocus)
            {

                string keywords = @"\b(and|as|assert|break|class|continue|def|del|elif|else|exept|exec|finally|for|from|global|if|import|in|is|lambda|not|or|pass|raise|return|try|while|with|yeild|print|global)\b";
                MatchCollection keywordMatches = Regex.Matches(tb.Text, keywords);

                string types = @"\b(bool|int|float|complex|list|tuple|range|str|byte|bytes|NULL|class)\b";
                MatchCollection typeMatches = Regex.Matches(tb.Text, types);

                string comments = "(\\#.+?$|\"\"\".+?\"\"\")";
                MatchCollection commentsMatches = Regex.Matches(tb.Text, comments);

                string strings = "\".+?\"";
                MatchCollection stringsMatches = Regex.Matches(tb.Text, strings);

                int originalPosition = tb.SelectionStart;
                int originalLength = tb.SelectionLength;
                Color originalColour = Color.Black;
                takeFocus.Focus();

                tb.SelectionStart = 0;
                tb.SelectionLength = tb.Text.Length;
                tb.SelectionColor = originalColour;

                foreach (Match m in keywordMatches)
                {
                    tb.SelectionStart = m.Index;
                    tb.SelectionLength = m.Length;
                    tb.SelectionColor = Color.CornflowerBlue;

                }

                foreach (Match m in typeMatches)
                {
                    tb.SelectionStart = m.Index;
                    tb.SelectionLength = m.Length;
                    tb.SelectionColor = Color.DarkCyan;
                }

                foreach (Match m in commentsMatches)
                {
                    tb.SelectionStart = m.Index;
                    tb.SelectionLength = m.Length;
                    tb.SelectionColor = Color.Orange;
                }

                foreach (Match m in stringsMatches)
                {
                    tb.SelectionStart = m.Index;
                    tb.SelectionLength = m.Length;
                    tb.SelectionColor = Color.Brown;

                }
                tb.SelectionStart = originalPosition;
                tb.SelectionLength = originalLength;
                tb.SelectionColor = originalColour;

                tb.Focus();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            syHighlight.Highlight(richTextBox1, lbTime);
        }

        private void lbLessonDescription_Click(object sender, EventArgs e)
        {

        }



    }
}
