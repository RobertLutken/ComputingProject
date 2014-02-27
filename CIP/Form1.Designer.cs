namespace CIP
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbNetBios = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbLessonTitle = new System.Windows.Forms.Label();
            this.lbLessonDescription = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnContinue
            // 
            this.btnContinue.AutoSize = true;
            this.btnContinue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnContinue.BackColor = System.Drawing.Color.Transparent;
            this.btnContinue.BackgroundImage = global::CIP.Properties.Resources.ArrowRight;
            this.btnContinue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnContinue.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnContinue.FlatAppearance.BorderSize = 0;
            this.btnContinue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnContinue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.ForeColor = System.Drawing.Color.Transparent;
            this.btnContinue.Image = global::CIP.Properties.Resources.ArrowRight;
            this.btnContinue.Location = new System.Drawing.Point(956, 0);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnContinue.Size = new System.Drawing.Size(156, 829);
            this.btnContinue.TabIndex = 0;
            this.btnContinue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnContinue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.button1_Click);
            this.btnContinue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            this.btnContinue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.btnContinue.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.btnContinue.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.btnContinue.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // btnPrevious
            // 
            this.btnPrevious.AutoSize = true;
            this.btnPrevious.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.BackgroundImage = global::CIP.Properties.Resources.gradient_background_wallpaper_u___ibackgroundz_com;
            this.btnPrevious.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.Transparent;
            this.btnPrevious.Image = global::CIP.Properties.Resources.ArrowLeft;
            this.btnPrevious.Location = new System.Drawing.Point(0, 0);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPrevious.Size = new System.Drawing.Size(156, 829);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrevious.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.button2_Click);
            this.btnPrevious.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick);
            this.btnPrevious.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            this.btnPrevious.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.btnPrevious.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.btnPrevious.MouseHover += new System.EventHandler(this.button2_MouseHover);
            this.btnPrevious.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button2_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lbNetBios);
            this.panel1.Controls.Add(this.lbTime);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(728, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 829);
            this.panel1.TabIndex = 2;
            // 
            // lbNetBios
            // 
            this.lbNetBios.AutoEllipsis = true;
            this.lbNetBios.AutoSize = true;
            this.lbNetBios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNetBios.Location = new System.Drawing.Point(76, 56);
            this.lbNetBios.Name = "lbNetBios";
            this.lbNetBios.Size = new System.Drawing.Size(57, 21);
            this.lbNetBios.TabIndex = 1;
            this.lbNetBios.Text = "label1";
            this.lbNetBios.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(110, 9);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(57, 21);
            this.lbTime.TabIndex = 0;
            this.lbTime.Text = "label1";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // richTextBox1
            // 
            this.richTextBox1.AcceptsTab = true;
            this.richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.EnableAutoDragDrop = true;
            this.richTextBox1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(171, 268);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(779, 435);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.ZoomFactor = 0.5F;
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // lbLessonTitle
            // 
            this.lbLessonTitle.AutoSize = true;
            this.lbLessonTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbLessonTitle.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLessonTitle.ForeColor = System.Drawing.Color.White;
            this.lbLessonTitle.Location = new System.Drawing.Point(146, 9);
            this.lbLessonTitle.Name = "lbLessonTitle";
            this.lbLessonTitle.Size = new System.Drawing.Size(217, 42);
            this.lbLessonTitle.TabIndex = 4;
            this.lbLessonTitle.Text = "Objective 1";
            // 
            // lbLessonDescription
            // 
            this.lbLessonDescription.AutoSize = true;
            this.lbLessonDescription.BackColor = System.Drawing.Color.Transparent;
            this.lbLessonDescription.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLessonDescription.ForeColor = System.Drawing.Color.White;
            this.lbLessonDescription.Location = new System.Drawing.Point(148, 69);
            this.lbLessonDescription.Name = "lbLessonDescription";
            this.lbLessonDescription.Size = new System.Drawing.Size(559, 180);
            this.lbLessonDescription.TabIndex = 5;
            this.lbLessonDescription.Text = "Welcome to your first tutorial ! \r\nBelow is a big box where you write your code.\r" +
    "\nType the words :\r\nprint \"hello world\"\r\n\r\nThen press the continue arrow ! ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::CIP.Properties.Resources.gradient_background_wallpaper_u___ibackgroundz_com;
            this.ClientSize = new System.Drawing.Size(1112, 829);
            this.Controls.Add(this.lbLessonDescription);
            this.Controls.Add(this.lbLessonTitle);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnContinue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbNetBios;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lbLessonTitle;
        private System.Windows.Forms.Label lbLessonDescription;
    }
}

