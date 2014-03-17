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
using System.Net.Sockets;
using System.IO;
using System.Net;
using Utilitys;
using UserHandler;
namespace CIP
{
    public partial class Connection : Form
    {


        // Create our first Client
        Client client = new Client();
        
        public Connection()
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

        private void btnContinue_Click(object sender, EventArgs e)
        {
            //client.ClientServerPort = int.Parse(numPort.Value.ToString());
            //client.ClientServerIP = tbIPAddress.Text; // IP Address name / IP
            //client.PythonCode = " "; // So we dont execute nothing each time the client is updated
            //client.ClientID = client.GetLocalIPAddress();
           // int serverPort = portNum;

            bool ConnectionOK= true;
            // Need much better validation on this !
            if(checkBox1.Checked)
            {
                UserHandler.User.UseLocalHost = true;
                UserHandler.User.ServerIP = "127.0.0.1";
                NetworkHandler.ServerHandler localServer = new NetworkHandler.ServerHandler();

            }
            if (string.IsNullOrEmpty(tbIPAddress.Text) && checkBox1.Checked == false)
            {
                ConnectionOK = false;
            }
            else if (checkBox1.Checked == true && !string.IsNullOrEmpty(tbIPAddress.Text))
            {
                MessageBox.Show("Please select a server, you cant use a local and remote server at the same time \n");
            }
            UserHandler.User.ServerIP = tbIPAddress.Text;
            UserHandler.User.ServerPort = int.Parse(numPort.Value.ToString());
           
            try
            {
                
                //client.SendOnNetwork(client.GetIPV4(client.ClientServerIP), client.ClientServerPort, client);
                //AsyncSocks.AsynchronousClient.Echo(UserHandler.User.ServerIP, UserHandler.User.ServerPort);
               //ConnectionOK =  Utilitys.Utils.SendEcho(UserHandler.User.ServerIP,UserHandler.User.ServerPort, "Echo");
                ConnectionOK = NetworkHandler.ClientHandler.SendEcho(UserHandler.User.ServerIP, UserHandler.User.ServerPort, "Echo");
               
            } catch (Exception err)
            {
              //  MessageBox.Show(this, err.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Socket Error" + err.Message);
                ConnectionOK = false;
            }
            finally
            {
                //socket.Close();
            }
          
            if (ConnectionOK == true)
            {
                
                MessageBox.Show(this, "Connected to server : " + UserHandler.User.ServerIP + " on Port : " +  UserHandler.User.ServerPort ,"Connected !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Prequery pq = new Prequery();

                EnableDoubleBuffering();
                this.Hide();

                // First save to the temp (this will be the start of the persistent file 
                //client.WriteSeralizeFile();


                pq.Show();
            }
            else
            {
                MessageBox.Show(this, "Could not connect to server : " + UserHandler.User.ServerIP + " on Port : " + UserHandler.User.ServerPort + "\nPlease try again!", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
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


        private void Connection_Load(object sender, EventArgs e)
        {
            //this.DoubleBuffered = true;
        }

        public void EnableDoubleBuffering()
        {
             

            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);

            this.DoubleBuffered = true;
            this.UpdateStyles();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // If we are checked
            if (checkBox1.Checked)
            {
                // If the ip address is empty or the use local host is empty, then set it
                if (tbIPAddress != null || UserHandler.User.UseLocalHost == true)
                {
                    UserHandler.User.UseLocalHost = true;
                    UserHandler.User.ServerIP = "127.0.0.1";
                    MessageBox.Show("You are now offline !\n Using this computer only.\n");
                } 
            
            }
     
           

            
        }

    }
}
