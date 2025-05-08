namespace WinFormsApp1
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnComenzar = new Button();
            lblPelea = new Label();
            lblCountdown = new Label();
            timerCountdown = new System.Windows.Forms.Timer(components);
            lifebarDeadpool = new ProgressBar();
            lifebarWolverine = new ProgressBar();
            label1 = new Label();
            lblDeadpul = new Label();
            lblWolverin = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btnPelea = new Button();
            lblDaño = new Label();
            lblVidaD = new Label();
            lblVidaW = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.stand3;
            pictureBox1.Location = new Point(362, 403);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(478, 524);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.stand2;
            pictureBox2.Location = new Point(1162, 478);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(424, 512);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // btnComenzar
            // 
            btnComenzar.BackColor = Color.MistyRose;
            btnComenzar.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btnComenzar.FlatAppearance.BorderSize = 3;
            btnComenzar.FlatStyle = FlatStyle.Flat;
            btnComenzar.Location = new Point(846, 811);
            btnComenzar.Name = "btnComenzar";
            btnComenzar.RightToLeft = RightToLeft.Yes;
            btnComenzar.Size = new Size(278, 76);
            btnComenzar.TabIndex = 2;
            btnComenzar.Text = "Comenzar";
            btnComenzar.UseVisualStyleBackColor = false;
            btnComenzar.Click += btnComenzar_Click;
            // 
            // lblPelea
            // 
            lblPelea.AutoSize = true;
            lblPelea.BackColor = Color.Transparent;
            lblPelea.Font = new Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPelea.ForeColor = Color.White;
            lblPelea.Location = new Point(768, 251);
            lblPelea.Name = "lblPelea";
            lblPelea.Size = new Size(72, 101);
            lblPelea.TabIndex = 3;
            lblPelea.Text = " ";
            lblPelea.Click += label1_Click;
            // 
            // lblCountdown
            // 
            lblCountdown.AutoSize = true;
            lblCountdown.BackColor = Color.Transparent;
            lblCountdown.Font = new Font("Leelawadee UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCountdown.ForeColor = Color.White;
            lblCountdown.Location = new Point(945, 528);
            lblCountdown.Name = "lblCountdown";
            lblCountdown.Size = new Size(0, 112);
            lblCountdown.TabIndex = 4;
            lblCountdown.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timerCountdown
            // 
            timerCountdown.Interval = 1000;
            timerCountdown.Tick += timerCountdown_Tick;
            // 
            // lifebarDeadpool
            // 
            lifebarDeadpool.Location = new Point(181, 155);
            lifebarDeadpool.Maximum = 1000;
            lifebarDeadpool.Name = "lifebarDeadpool";
            lifebarDeadpool.Size = new Size(546, 62);
            lifebarDeadpool.TabIndex = 5;
            // 
            // lifebarWolverine
            // 
            lifebarWolverine.Location = new Point(1162, 155);
            lifebarWolverine.Maximum = 1000;
            lifebarWolverine.Name = "lifebarWolverine";
            lifebarWolverine.Size = new Size(546, 62);
            lifebarWolverine.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(186, 76);
            label1.Name = "label1";
            label1.Size = new Size(0, 30);
            label1.TabIndex = 7;
            // 
            // lblDeadpul
            // 
            lblDeadpul.AutoEllipsis = true;
            lblDeadpul.AutoSize = true;
            lblDeadpul.BackColor = Color.Transparent;
            lblDeadpul.Font = new Font("Verdana", 25F, FontStyle.Bold);
            lblDeadpul.ForeColor = Color.White;
            lblDeadpul.Location = new Point(257, 76);
            lblDeadpul.Name = "lblDeadpul";
            lblDeadpul.Size = new Size(341, 72);
            lblDeadpul.TabIndex = 8;
            lblDeadpul.Text = "Deadpool";
            // 
            // lblWolverin
            // 
            lblWolverin.AutoEllipsis = true;
            lblWolverin.AutoSize = true;
            lblWolverin.BackColor = Color.Transparent;
            lblWolverin.Font = new Font("Verdana", 25F, FontStyle.Bold);
            lblWolverin.ForeColor = Color.White;
            lblWolverin.Location = new Point(1264, 66);
            lblWolverin.Name = "lblWolverin";
            lblWolverin.Size = new Size(356, 72);
            lblWolverin.TabIndex = 9;
            lblWolverin.Text = "wolverine";
            // 
            // btnPelea
            // 
            btnPelea.BackColor = Color.MistyRose;
            btnPelea.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btnPelea.FlatAppearance.BorderSize = 3;
            btnPelea.FlatStyle = FlatStyle.Flat;
            btnPelea.Location = new Point(846, 811);
            btnPelea.Name = "btnPelea";
            btnPelea.RightToLeft = RightToLeft.Yes;
            btnPelea.Size = new Size(278, 76);
            btnPelea.TabIndex = 10;
            btnPelea.Text = "Pelea";
            btnPelea.UseVisualStyleBackColor = false;
            btnPelea.Click += btnPelea_Click;
            // 
            // lblDaño
            // 
            lblDaño.AutoSize = true;
            lblDaño.BackColor = Color.Transparent;
            lblDaño.Font = new Font("Verdana", 19F, FontStyle.Bold);
            lblDaño.ForeColor = Color.White;
            lblDaño.Location = new Point(412, 279);
            lblDaño.Name = "lblDaño";
            lblDaño.Size = new Size(38, 54);
            lblDaño.TabIndex = 11;
            lblDaño.Text = " ";
            // 
            // lblVidaD
            // 
            lblVidaD.AutoSize = true;
            lblVidaD.BackColor = Color.Transparent;
            lblVidaD.Font = new Font("Segoe UI Black", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVidaD.ForeColor = Color.White;
            lblVidaD.Location = new Point(622, 107);
            lblVidaD.Name = "lblVidaD";
            lblVidaD.Size = new Size(96, 45);
            lblVidaD.TabIndex = 12;
            lblVidaD.Text = "1000";
            // 
            // lblVidaW
            // 
            lblVidaW.AutoSize = true;
            lblVidaW.BackColor = Color.Transparent;
            lblVidaW.Font = new Font("Segoe UI Black", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVidaW.ForeColor = Color.White;
            lblVidaW.Location = new Point(1162, 107);
            lblVidaW.Name = "lblVidaW";
            lblVidaW.Size = new Size(96, 45);
            lblVidaW.TabIndex = 13;
            lblVidaW.Text = "1000";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._48372ce5cb6d866817dc4e9c3a2c5f0e;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1894, 1017);
            Controls.Add(lblVidaW);
            Controls.Add(lblVidaD);
            Controls.Add(lblDaño);
            Controls.Add(btnPelea);
            Controls.Add(lblWolverin);
            Controls.Add(lblDeadpul);
            Controls.Add(label1);
            Controls.Add(lifebarWolverine);
            Controls.Add(lifebarDeadpool);
            Controls.Add(lblCountdown);
            Controls.Add(lblPelea);
            Controls.Add(btnComenzar);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlLEFT;
        private Panel pnlRIGHT;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnComenzar;
        private Label lblPelea;
        private Label lblCountdown;
        private System.Windows.Forms.Timer timerCountdown;
        private ProgressBar lifebarDeadpool;
        private ProgressBar lifebarWolverine;
        private Label label1;
        private Label lblDeadpul;
        private Label lblWolverin;
        private System.Windows.Forms.Timer timer1;
        private Button btnPelea;
        private Label lblDaño;
        private Label lblVidaD;
        private Label lblVidaW;
    }
}