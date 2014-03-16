
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
using Utilitys;
using System.Net.Sockets;
using System.Net;
using UserHandler;
using System.Threading;
namespace CIP
{
    public partial class AppMain : Form
    {
        SyntaxHighlighter syHighlight = new SyntaxHighlighter();
        Client client = new Client();
 
        Results resultsWND;
       
        public AppMain()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            timer1.Start();
            lbNetBios.Text = Environment.UserName.ToString() + "@" + Utils.GetLocalIPAddress();
            client = client.ReadSeralizedFile();
            UserHandler.User.CurrentScore = 0;
            UserHandler.User.CurrentLevel = 1;
            
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
        public void StartConnection()
        {
            

            AsyncSocks.AsynchronousClient.StartClient("192.168.0.9");
           
            /*var thread = new Thread(() =>
           
            {
                result = GetResults();
            }

                );
            thread.Start();
            thread.Join();

            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnContinue.Image = Resources.ArrowRightClick;

            User.Code = richTextBox1.Text.ToString();
           
            if (User.UseLocalHost)
            {
              User.Results =  Utilitys.Utils.ExecutePython(User.Code);
            }
            //StartConnection();
          
            if(User.CodeOK)
            {

                if (!Utils.CheckOpenForm(resultsWND))// Check results window is not running
                {
                    resultsWND = new Results();

                    resultsWND.Start();

                }
                else
                {
                    resultsWND.Start();
                }

                UserHandler.User.CurrentScore += 1;
                UserHandler.User.CurrentLevel += 1;
                lbLevelValue.Text = UserHandler.User.CurrentLevel.ToString();
                lbScoreValue.Text= UserHandler.User.CurrentScore.ToString();

            }
            else if(!User.CodeOK)
            {
                // show error
                    MessageBox.Show("An error occured in your python code"+ User.Results);
                    
                    
            }
            
            EnableDoubleBuffering();
            }
        
       
        private void PositionResults()
        {
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;

            Point parentPoint = this.Location;

            int parentHeight = this.Height;
            int parentWidth = this.Width;

            if (Utils.CheckOpenForm(resultsWND))
            {
                // set our child form to the new position
                resultsWND.Location = new Point(this.Right, parentPoint.Y);
            }
        }
        
        
        private void button1_OnMouseEnter(object sender, EventArgs e)
        {
            btnContinue.Image = Resources.ArrowRightHover; //  button1.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowLeftHover.png");
            
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
            btnContinue.Image = Resources.ArrowRight; //btnContinue.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowRight.png");
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
            btnPrevious.Image = Resources.ArrowLeftClick; // btnPrevious.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowLeftClick.png");
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            btnPrevious.Image = Resources.ArrowLeftHover; //  btnPrevious.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowLeftHover.png");
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            btnPrevious.Image = Resources.ArrowLeftHover; // btnPrevious.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowLeftHover.png");
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            // Reset to Hover 
            btnPrevious.Image = Resources.ArrowLeftHover; //  btnPrevious.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowLeftHover.png");
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            // Reset to default state
            btnPrevious.Image = Resources.ArrowLeft; // btnPrevious.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowLeft.png");
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            btnPrevious.Image = Resources.ArrowLeftClick; //  btnPrevious.Image = Image.FromFile(@"U:\Computing Individual Project\Code Base\ComputingProject\CIP\Resources\ArrowLeftClick.png");
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

        private void lbLessonDescription_LocationChanged(object sender, EventArgs e)
        {

        }

        private void AppMain_LocationChanged(object sender, EventArgs e)
        {
           // Results.UpdatePosition();
            PositionResults();
        }

  


    }
}
