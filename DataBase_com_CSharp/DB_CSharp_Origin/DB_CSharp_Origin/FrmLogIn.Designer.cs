namespace DB_CSharp_Origin
{
    partial class FrmLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogIn));
            panel1 = new Panel();
            PBvisiblePassword = new PictureBox();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            button1 = new Button();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            textpassword = new TextBox();
            label1 = new Label();
            textUser = new TextBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            listImage_Visible_password = new ImageList(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBvisiblePassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Design_sem_nome;
            panel1.Controls.Add(PBvisiblePassword);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textpassword);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textUser);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(537, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(397, 533);
            panel1.TabIndex = 0;
            // 
            // PBvisiblePassword
            // 
            PBvisiblePassword.Anchor = AnchorStyles.None;
            PBvisiblePassword.BackColor = Color.Transparent;
            PBvisiblePassword.Image = Properties.Resources.visivel;
            PBvisiblePassword.Location = new Point(344, 277);
            PBvisiblePassword.Name = "PBvisiblePassword";
            PBvisiblePassword.Size = new Size(43, 43);
            PBvisiblePassword.SizeMode = PictureBoxSizeMode.Zoom;
            PBvisiblePassword.TabIndex = 10;
            PBvisiblePassword.TabStop = false;
            PBvisiblePassword.Click += PBvisiblePassword_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.None;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Location = new Point(232, 458);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(84, 20);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Clique aqui";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(87, 458);
            label3.Name = "label3";
            label3.Size = new Size(149, 20);
            label3.TabIndex = 7;
            label3.Text = "Você não tem log in?";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(192, 192, 0);
            button1.FlatAppearance.BorderSize = 0;
            button1.Location = new Point(119, 367);
            button1.Name = "button1";
            button1.Size = new Size(174, 55);
            button1.TabIndex = 6;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.BackgroundImage = Properties.Resources.Design_sem_nome1;
            pictureBox3.Image = Properties.Resources.icons8_senha_96;
            pictureBox3.Location = new Point(32, 271);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(52, 52);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(90, 253);
            label2.Name = "label2";
            label2.Size = new Size(104, 28);
            label2.TabIndex = 3;
            label2.Text = "PassWord";
            // 
            // textpassword
            // 
            textpassword.Anchor = AnchorStyles.None;
            textpassword.Location = new Point(90, 287);
            textpassword.Name = "textpassword";
            textpassword.PasswordChar = '•';
            textpassword.Size = new Size(248, 27);
            textpassword.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(90, 170);
            label1.Name = "label1";
            label1.Size = new Size(116, 28);
            label1.TabIndex = 1;
            label1.Text = "User Name";
            // 
            // textUser
            // 
            textUser.Anchor = AnchorStyles.None;
            textUser.Location = new Point(90, 204);
            textUser.Name = "textUser";
            textUser.Size = new Size(248, 27);
            textUser.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackgroundImage = Properties.Resources.Design_sem_nome2;
            pictureBox2.Image = Properties.Resources.icons8_usuário_96;
            pictureBox2.Location = new Point(32, 190);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 192, 0);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(537, 533);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.image_removebg_preview;
            pictureBox1.Location = new Point(26, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(455, 509);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Location = new Point(560, 61);
            panel3.Name = "panel3";
            panel3.Size = new Size(367, 106);
            panel3.TabIndex = 1;
            // 
            // listImage_Visible_password
            // 
            listImage_Visible_password.ColorDepth = ColorDepth.Depth8Bit;
            listImage_Visible_password.ImageStream = (ImageListStreamer)resources.GetObject("listImage_Visible_password.ImageStream");
            listImage_Visible_password.TransparentColor = Color.Transparent;
            listImage_Visible_password.Images.SetKeyName(0, "visivel.png");
            listImage_Visible_password.Images.SetKeyName(1, "olho.png");
            // 
            // FrmLogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 533);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogIn";
            FormClosed += FrmLogIn_FormClosed;
            Load += FrmLogIn_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PBvisiblePassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textUser;
        private Label label2;
        private TextBox textpassword;
        private Button button1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private LinkLabel linkLabel1;
        private Label label3;
        private PictureBox PBvisiblePassword;
        private ImageList listImage_Visible_password;
        private Panel panel3;
    }
}