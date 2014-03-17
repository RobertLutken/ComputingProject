namespace CIP
{
    partial class AppMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppMain));
            this.btnPrevious = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbNetBios = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbLessonTitle = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbLevelValue = new System.Windows.Forms.Label();
            this.lbScoreValue = new System.Windows.Forms.Label();
            this.lbLevel = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrevious
            // 
            this.btnPrevious.AutoSize = true;
            this.btnPrevious.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.BackgroundImage = global::CIP.Properties.Resources.Background;
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
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lbNetBios);
            this.panel1.Controls.Add(this.lbTime);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(725, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 120);
            this.panel1.TabIndex = 2;
            // 
            // lbNetBios
            // 
            this.lbNetBios.AutoEllipsis = true;
            this.lbNetBios.AutoSize = true;
            this.lbNetBios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNetBios.Location = new System.Drawing.Point(61, 57);
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
            // lbLessonTitle
            // 
            this.lbLessonTitle.AutoSize = true;
            this.lbLessonTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbLessonTitle.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLessonTitle.ForeColor = System.Drawing.Color.White;
            this.lbLessonTitle.Location = new System.Drawing.Point(162, 5);
            this.lbLessonTitle.Name = "lbLessonTitle";
            this.lbLessonTitle.Size = new System.Drawing.Size(166, 42);
            this.lbLessonTitle.TabIndex = 4;
            this.lbLessonTitle.Text = "Tutorial 1";
            this.lbLessonTitle.Click += new System.EventHandler(this.lbLessonTitle_Click);
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
            this.btnContinue.MouseHover += new System.EventHandler(this.button1_MouseEnter);
            this.btnContinue.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // richTextBox1
            // 
            this.richTextBox1.AcceptsTab = true;
            this.richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.EnableAutoDragDrop = true;
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 20F);
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.richTextBox1.Location = new System.Drawing.Point(159, 368);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBox1.Size = new System.Drawing.Size(791, 449);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "Delete mee! ";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // lbLevelValue
            // 
            this.lbLevelValue.AutoSize = true;
            this.lbLevelValue.BackColor = System.Drawing.Color.Transparent;
            this.lbLevelValue.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLevelValue.ForeColor = System.Drawing.Color.White;
            this.lbLevelValue.Location = new System.Drawing.Point(496, 9);
            this.lbLevelValue.Name = "lbLevelValue";
            this.lbLevelValue.Size = new System.Drawing.Size(31, 36);
            this.lbLevelValue.TabIndex = 13;
            this.lbLevelValue.Text = "0";
            // 
            // lbScoreValue
            // 
            this.lbScoreValue.AutoSize = true;
            this.lbScoreValue.BackColor = System.Drawing.Color.Transparent;
            this.lbScoreValue.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScoreValue.ForeColor = System.Drawing.Color.White;
            this.lbScoreValue.Location = new System.Drawing.Point(680, 9);
            this.lbScoreValue.Name = "lbScoreValue";
            this.lbScoreValue.Size = new System.Drawing.Size(31, 36);
            this.lbScoreValue.TabIndex = 12;
            this.lbScoreValue.Text = "0";
            // 
            // lbLevel
            // 
            this.lbLevel.AutoSize = true;
            this.lbLevel.BackColor = System.Drawing.Color.Transparent;
            this.lbLevel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLevel.ForeColor = System.Drawing.Color.White;
            this.lbLevel.Location = new System.Drawing.Point(369, 9);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(104, 36);
            this.lbLevel.TabIndex = 11;
            this.lbLevel.Text = "Level :";
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.BackColor = System.Drawing.Color.Transparent;
            this.lbScore.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.ForeColor = System.Drawing.Color.White;
            this.lbScore.Location = new System.Drawing.Point(549, 9);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(110, 36);
            this.lbScore.TabIndex = 10;
            this.lbScore.Text = "Score :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(152, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 42);
            this.label1.TabIndex = 15;
            this.label1.Text = "Enter your code here : ";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.White;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox2.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.ForeColor = System.Drawing.Color.DarkRed;
            this.richTextBox2.Location = new System.Drawing.Point(159, 81);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.ShowSelectionMargin = true;
            this.richTextBox2.Size = new System.Drawing.Size(791, 239);
            this.richTextBox2.TabIndex = 16;
            this.richTextBox2.Text = "";
            // 
            // AppMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::CIP.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1112, 829);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbLevelValue);
            this.Controls.Add(this.lbScoreValue);
            this.Controls.Add(this.lbLevel);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.lbLessonTitle);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnContinue);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AppMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LocationChanged += new System.EventHandler(this.AppMain_LocationChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbNetBios;
        private System.Windows.Forms.Label lbLessonTitle;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lbLevelValue;
        private System.Windows.Forms.Label lbScoreValue;
        private System.Windows.Forms.Label lbLevel;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}

