
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
using System.Reflection;
namespace CIP
{
    public partial class AppMain : Form
    {
       // SyntaxHighlighter syHighlight = new SyntaxHighlighter();
        //Client client = new Client();
 
        Results resultsWND;
        public List<Tutorial> tuts = new List<Tutorial>();
        public AppMain()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            SetupTutorials();
            timer1.Start();
            lbNetBios.Text = Environment.UserName.ToString() + "@" + Utils.GetLocalIPAddress();
           
            //client = client.ReadSeralizedFile();
            UserHandler.User.CurrentScore = 0;
            UserHandler.User.CurrentLevel = 0;
            

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

               
               
             
                //Set Next Level
                if (UserHandler.User.CurrentLevel == 0)
                {
                    MessageBox.Show(this,"CONGATS!\nAs you can see on your right is the first programm you have written.\nYou are now a programmer ! \nIt's not that difficult is it?\nWelcome to relm of programmers.....","Success!",MessageBoxButtons.OK,MessageBoxIcon.Information);

                }
                // Set score
                 if (richTextBox1.Text.EndsWith("\n"))
                {
                    //lbScoreValue.Text = richTextBox1.GetLineFromCharIndex(richTextBox1.TextLength + 1).ToString();
                    UserHandler.User.CurrentScore = richTextBox1.GetLineFromCharIndex(richTextBox1.TextLength + 1);
                    lbScoreValue.Text = UserHandler.User.CurrentScore.ToString();
                }
                else
                richTextBox1.AppendText("\n");
               // lbScoreValue.Text = richTextBox1.GetLineFromCharIndex(richTextBox1.TextLength).ToString();

                UserHandler.User.CurrentScore +=  richTextBox1.GetLineFromCharIndex
                    (richTextBox1.TextLength);
                lbScoreValue.Text = UserHandler.User.CurrentScore.ToString();

                // Set Next Level
                if (UserHandler.User.CurrentLevel == tuts.Count)
                {
                    SetNextTutorial(tuts.ElementAt(tuts.Count - 1));
                }
                else if (UserHandler.User.CurrentLevel <= 4)
                {   
                   
                    SetNextTutorial(tuts.ElementAt(UserHandler.User.CurrentLevel));
                     UserHandler.User.CurrentLevel += 1;
                } 
                
                //Clear textbox 
                richTextBox1.Clear();

            }
            else if(!User.CodeOK)
            {
                // show error
                MessageBox.Show("An error occured in your python code : \n\n"+ User.Results);
                    
                    
            }

           
               
            
           // SetNextTutorial(GetCurrentTutorial(UserHandler.User.CurrentLevel));
            //lbLevelValue.Text = UserHandler.User.CurrentLevel.ToString();
           
            
          
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
        
        public void SetupTutorials()
        {

          
            
           
            tuts.Add(new Tutorial()
            {
                TutorialLesson = GetTutorial("Tutorial1"),
                TutorialTitle = "Hello world",
                TutorialNumber = 1
            }
                );

            tuts.Add(new Tutorial()
                {
                    TutorialTitle = @"Comments",
                    TutorialNumber  = 2,
                    TutorialLesson = GetTutorial("Tutorial2")
                });

            tuts.Add(new Tutorial()
                {

                    TutorialTitle = "Variables",
                    TutorialNumber= 3,
                    TutorialLesson = GetTutorial("Tutorial3")
                });
             tuts.Add(new Tutorial()
            {
               TutorialNumber = 4,
               TutorialTitle = "Operators",
               TutorialLesson = GetTutorial("Tutorial4")
            });

             
                
                 //  Load up  first tutorial straigt away
             lbLevelValue.Text = tuts.ElementAt(0).TutorialNumber.ToString();
             lbLessonTitle.Text = tuts.ElementAt(0).TutorialTitle.ToString();
             richTextBox2.Text = tuts.ElementAt(0).TutorialLesson.ToString();

             //TextCheck.Highlight(richTextBox2, lbTime);
             
        }
        public void SetNextTutorial(Tutorial currentLesson)
        {
            foreach (Tutorial nextTutorial in tuts)
            { 


                if(nextTutorial.TutorialNumber <= currentLesson.TutorialNumber)
                {
                    
                    lbLevelValue.Text = nextTutorial.TutorialNumber.ToString();
                    lbLessonTitle.Text = nextTutorial.TutorialTitle.ToString();
                    richTextBox2.Text = nextTutorial.TutorialLesson.ToString();
                }
                //this.lbLevel = tut numb
                //this.lbTitle = tut title
                // this.lbHE = tut
            }
        }
        public void SetPreviousTutorial(Tutorial currentLesson)
        {

        foreach(Tutorial currenttut in tuts)
        {
            if(currenttut.TutorialNumber == currentLesson.TutorialNumber)
            {
                lbLevelValue.Text = currenttut.TutorialNumber.ToString();
                lbLessonTitle.Text = currenttut.TutorialTitle.ToString();
                richTextBox2.Text = currenttut.TutorialLesson.ToString();
            }
        }
              
                //this.lbLevel = tut numb
                //this.lbTitle = tut title
                // this.lbHE = tut
            
        }
        public Tutorial GetCurrentTutorial(int current)
        {
            foreach(Tutorial thistut in tuts)
            {
                if (thistut.TutorialNumber == current)
                {
                    return thistut;
                }
                else
                    return null; // Should not get here !
            }
            return null; // or here
        }
        public int GetTutorialByNum(int numtofind)
        {

            foreach (Tutorial tutorials in tuts)
            {
                if (tutorials.TutorialNumber == numtofind)
                    return tuts.IndexOf(tutorials);
            }
            return 0;
        }
        public void SetTutorial(int num)
        {

        }
        public string GetTutorial (string filename)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "CIP." + filename + ".txt";
            string result;
            
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                 result = reader.ReadToEnd();
            }
            return result;
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
            //if(UserHandler.User.CurrentLevel == 1)
            //{
            //    Splash splash = new Splash();
            //    EnableDoubleBuffering();
            //    splash.Show(); 
            //    this.Hide();

            //}
            if (UserHandler.User.CurrentLevel == 0)
            {
                SetNextTutorial(tuts.ElementAt(0));
            }
            if (UserHandler.User.CurrentLevel >= 1)
            {
                UserHandler.User.CurrentLevel -= 1;
                SetPreviousTutorial(tuts.ElementAt(UserHandler.User.CurrentLevel ));
                
            } 
          
           

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

 

        //public class SyntaxHighlighter
        //{

        //   
        //}

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            TextCheck.Highlight(richTextBox1, lbTime);
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

        private void lbLessonTitle_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

  


    }
    public class Tutorial 
    {
        public string TutorialTitle { get; set; }
        public int TutorialNumber { get; set; }
        public string TutorialLesson { get; set; }

    }
}
