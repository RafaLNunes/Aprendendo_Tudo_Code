namespace DB_CSharp_Origin
{
    partial class FrmSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSignUp));
            panel1 = new Panel();
            Test_Connection = new LinkLabel();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            CBperfil = new ComboBox();
            Nome = new Label();
            Cargo = new Label();
            textName = new TextBox();
            label4 = new Label();
            CBdia = new ComboBox();
            CBmes = new ComboBox();
            CBano = new ComboBox();
            PBvisiblePassword = new PictureBox();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            signup = new Button();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            textpassword = new TextBox();
            label1 = new Label();
            textuser = new TextBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            listImage_Visible_password = new ImageList(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBvisiblePassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Design_sem_nome__1_;
            panel1.Controls.Add(Test_Connection);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(CBperfil);
            panel1.Controls.Add(Nome);
            panel1.Controls.Add(Cargo);
            panel1.Controls.Add(textName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(CBdia);
            panel1.Controls.Add(CBmes);
            panel1.Controls.Add(CBano);
            panel1.Controls.Add(PBvisiblePassword);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(signup);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textpassword);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textuser);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(488, 533);
            panel1.TabIndex = 1;
            // 
            // Test_Connection
            // 
            Test_Connection.ActiveLinkColor = Color.Red;
            Test_Connection.AutoSize = true;
            Test_Connection.BackColor = Color.Transparent;
            Test_Connection.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Test_Connection.Location = new Point(312, 0);
            Test_Connection.Name = "Test_Connection";
            Test_Connection.Size = new Size(176, 31);
            Test_Connection.TabIndex = 21;
            Test_Connection.TabStop = true;
            Test_Connection.Text = "Testar Conexão";
            Test_Connection.LinkClicked += Test_Connection_LinkClicked;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.None;
            pictureBox6.BackgroundImage = Properties.Resources.Design_sem_nome2;
            pictureBox6.Image = Properties.Resources.name_signup;
            pictureBox6.Location = new Point(20, 20);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(52, 52);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 21;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.None;
            pictureBox5.BackgroundImage = Properties.Resources.Design_sem_nome2;
            pictureBox5.Image = Properties.Resources.cargo_signup;
            pictureBox5.Location = new Point(20, 101);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(52, 52);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 20;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.None;
            pictureBox4.BackgroundImage = Properties.Resources.Design_sem_nome2;
            pictureBox4.Image = Properties.Resources.nascimento_signup;
            pictureBox4.Location = new Point(20, 187);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(52, 52);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 19;
            pictureBox4.TabStop = false;
            // 
            // CBperfil
            // 
            CBperfil.Anchor = AnchorStyles.None;
            CBperfil.FormattingEnabled = true;
            CBperfil.Location = new Point(78, 125);
            CBperfil.Name = "CBperfil";
            CBperfil.Size = new Size(290, 28);
            CBperfil.TabIndex = 18;
            // 
            // Nome
            // 
            Nome.Anchor = AnchorStyles.None;
            Nome.AutoSize = true;
            Nome.BackColor = Color.Transparent;
            Nome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Nome.Location = new Point(87, 10);
            Nome.Name = "Nome";
            Nome.Size = new Size(166, 28);
            Nome.TabIndex = 17;
            Nome.Text = "Nome Completo";
            // 
            // Cargo
            // 
            Cargo.Anchor = AnchorStyles.None;
            Cargo.AutoSize = true;
            Cargo.BackColor = Color.Transparent;
            Cargo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Cargo.Location = new Point(87, 94);
            Cargo.Name = "Cargo";
            Cargo.Size = new Size(67, 28);
            Cargo.TabIndex = 16;
            Cargo.Text = "Cargo";
            // 
            // textName
            // 
            textName.Anchor = AnchorStyles.None;
            textName.Location = new Point(78, 45);
            textName.Name = "textName";
            textName.Size = new Size(290, 27);
            textName.TabIndex = 15;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(86, 173);
            label4.Name = "label4";
            label4.Size = new Size(205, 28);
            label4.TabIndex = 13;
            label4.Text = "Data de Nascimento";
            // 
            // CBdia
            // 
            CBdia.Anchor = AnchorStyles.None;
            CBdia.FormattingEnabled = true;
            CBdia.Location = new Point(78, 211);
            CBdia.Name = "CBdia";
            CBdia.Size = new Size(96, 28);
            CBdia.TabIndex = 12;
            // 
            // CBmes
            // 
            CBmes.Anchor = AnchorStyles.None;
            CBmes.FormattingEnabled = true;
            CBmes.Location = new Point(180, 211);
            CBmes.Name = "CBmes";
            CBmes.Size = new Size(96, 28);
            CBmes.TabIndex = 11;
            // 
            // CBano
            // 
            CBano.Anchor = AnchorStyles.None;
            CBano.FormattingEnabled = true;
            CBano.Location = new Point(282, 211);
            CBano.Name = "CBano";
            CBano.Size = new Size(96, 28);
            CBano.TabIndex = 10;
            // 
            // PBvisiblePassword
            // 
            PBvisiblePassword.Anchor = AnchorStyles.None;
            PBvisiblePassword.BackColor = Color.Transparent;
            PBvisiblePassword.Image = Properties.Resources.visivel;
            PBvisiblePassword.Location = new Point(385, 367);
            PBvisiblePassword.Name = "PBvisiblePassword";
            PBvisiblePassword.Size = new Size(43, 43);
            PBvisiblePassword.SizeMode = PictureBoxSizeMode.Zoom;
            PBvisiblePassword.TabIndex = 9;
            PBvisiblePassword.TabStop = false;
            PBvisiblePassword.Click += PBvisiblePassword_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.None;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Location = new Point(233, 478);
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
            label3.Location = new Point(120, 478);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 7;
            label3.Text = "Você tem log in?";
            // 
            // signup
            // 
            signup.Anchor = AnchorStyles.None;
            signup.BackColor = Color.FromArgb(0, 189, 255);
            signup.FlatAppearance.BorderSize = 0;
            signup.FlatStyle = FlatStyle.Flat;
            signup.Location = new Point(133, 411);
            signup.Name = "signup";
            signup.Size = new Size(174, 55);
            signup.TabIndex = 6;
            signup.Text = "Sign Up";
            signup.UseVisualStyleBackColor = false;
            signup.Click += signup_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = Properties.Resources.Design_sem_nome1;
            pictureBox3.Image = Properties.Resources.Senha_signup;
            pictureBox3.Location = new Point(20, 358);
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
            label2.Location = new Point(89, 341);
            label2.Name = "label2";
            label2.Size = new Size(104, 28);
            label2.TabIndex = 3;
            label2.Text = "PassWord";
            // 
            // textpassword
            // 
            textpassword.Anchor = AnchorStyles.None;
            textpassword.Location = new Point(78, 375);
            textpassword.Name = "textpassword";
            textpassword.PasswordChar = '•';
            textpassword.Size = new Size(290, 27);
            textpassword.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(88, 258);
            label1.Name = "label1";
            label1.Size = new Size(116, 28);
            label1.TabIndex = 1;
            label1.Text = "User Name";
            // 
            // textuser
            // 
            textuser.Anchor = AnchorStyles.None;
            textuser.Location = new Point(78, 292);
            textuser.Name = "textuser";
            textuser.Size = new Size(290, 27);
            textuser.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackgroundImage = Properties.Resources.Design_sem_nome2;
            pictureBox2.Image = Properties.Resources.user_signup;
            pictureBox2.Location = new Point(20, 267);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 189, 255);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(488, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(446, 533);
            panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.image_removebg_preview__2_;
            pictureBox1.Location = new Point(-23, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(515, 583);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // listImage_Visible_password
            // 
            listImage_Visible_password.ColorDepth = ColorDepth.Depth8Bit;
            listImage_Visible_password.ImageStream = (ImageListStreamer)resources.GetObject("listImage_Visible_password.ImageStream");
            listImage_Visible_password.TransparentColor = Color.Transparent;
            listImage_Visible_password.Images.SetKeyName(0, "visivel.png");
            listImage_Visible_password.Images.SetKeyName(1, "olho.png");
            // 
            // FrmSignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 533);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmSignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmSignUp";
            FormClosed += FrmSignUp_FormClosed;
            Load += FrmSignUp_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBvisiblePassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private LinkLabel linkLabel1;
        private Label label3;
        private Button signup;
        private PictureBox pictureBox3;
        private Label label2;
        private TextBox textpassword;
        private Label label1;
        private TextBox textuser;
        private PictureBox pictureBox2;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox PBvisiblePassword;
        private ImageList listImage_Visible_password;
        private ComboBox CBperfil;
        private Label Nome;
        private Label Cargo;
        private TextBox textName;
        private Label label4;
        private ComboBox CBdia;
        private ComboBox CBmes;
        private ComboBox CBano;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private LinkLabel Test_Connection;
    }
}