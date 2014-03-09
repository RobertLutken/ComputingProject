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

            int portNum = int.Parse(numPort.Value.ToString());
            String server = tbIPAddress.Text.ToString(); // IP Address name / IP


            string initClient = "Helloworld";// String to send 

            byte[] byteBuffer = Encoding.ASCII.GetBytes(initClient);// Get number of bytes

            int serverPort = portNum;

            Socket socket = null;

            bool ConnectionAlive = false;
            try
            {

                // Create a new Socket
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                //Create an end point (to get where the connection is supposed to end)

                IPEndPoint serverEndPoint = new IPEndPoint(Dns.GetHostEntry(server).AddressList[0], serverPort);

                // Attempt to  connect to end point
                socket.Connect(serverEndPoint);

                lbState.Text = "Connecting To server\nSending hellooo!";

                socket.Send(byteBuffer, 0, byteBuffer.Length, SocketFlags.None);
                lbState.Text += "\nSuccessfully Sent {0} bytes to server..."+ byteBuffer.Length.ToString();

                int totalBytesRCVD = 0; // Total number of bytes received 
                int bytesRCVD = 0; // bytes in current read

                while (totalBytesRCVD < byteBuffer.Length)
                {

                    if((bytesRCVD = socket.Receive(byteBuffer, totalBytesRCVD, byteBuffer.Length - totalBytesRCVD, SocketFlags.None)) == 0)
                    {
                        lbState.Text += "Connection Closed too soon!";
                        ConnectionAlive = false;
                        break;
                        
                    }
                    totalBytesRCVD += bytesRCVD;
                }
                ConnectionAlive = true;
                lbState.Text += "Receved bytes from server" + totalBytesRCVD.ToString() + Encoding.ASCII.GetString(byteBuffer, 0, totalBytesRCVD);

            } catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ConnectionAlive = false;
            }
            finally
            {
                socket.Close();
            }
          
            if (ConnectionAlive == true)
            {
                MessageBox.Show(this, "Connected to server : " + server + " on Port : " + portNum,"Connected !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Prequery pq = new Prequery();
                EnableDoubleBuffering();
                this.Hide();
                pq.Show();
            }
            else
            {
                MessageBox.Show(this, "Could not connect to server : " + server + " on Port : " + portNum + "\nPlease try again!", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

    }
}
