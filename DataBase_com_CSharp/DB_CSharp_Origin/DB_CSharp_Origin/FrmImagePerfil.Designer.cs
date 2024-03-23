namespace DB_CSharp_Origin
{
    partial class FrmImagePerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImagePerfil));
            panel1 = new Panel();
            PBrouder_perfil = new clRouderPB();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            Test_Connection = new LinkLabel();
            PBvisible = new PictureBox();
            button2 = new Button();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            textpassword = new TextBox();
            label1 = new Label();
            textUser = new TextBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            listImage_Visible_password = new ImageList(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBrouder_perfil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBvisible).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 255, 171);
            panel1.Controls.Add(PBrouder_perfil);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(387, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(547, 533);
            panel1.TabIndex = 0;
            // 
            // PBrouder_perfil
            // 
            PBrouder_perfil.Image = Properties.Resources.atenção__1_;
            PBrouder_perfil.Location = new Point(200, 113);
            PBrouder_perfil.Name = "PBrouder_perfil";
            PBrouder_perfil.Size = new Size(159, 159);
            PBrouder_perfil.SizeMode = PictureBoxSizeMode.Zoom;
            PBrouder_perfil.TabIndex = 1;
            PBrouder_perfil.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.image_removebg_preview__4_;
            pictureBox1.Location = new Point(-141, -119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(843, 758);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.aaa__1_;
            panel2.Controls.Add(Test_Connection);
            panel2.Controls.Add(PBvisible);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textpassword);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textUser);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(387, 533);
            panel2.TabIndex = 1;
            // 
            // Test_Connection
            // 
            Test_Connection.ActiveLinkColor = Color.Red;
            Test_Connection.AutoSize = true;
            Test_Connection.BackColor = Color.Transparent;
            Test_Connection.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Test_Connection.Location = new Point(2, 0);
            Test_Connection.Name = "Test_Connection";
            Test_Connection.Size = new Size(176, 31);
            Test_Connection.TabIndex = 20;
            Test_Connection.TabStop = true;
            Test_Connection.Text = "Testar Conexão";
            Test_Connection.LinkClicked += Test_Connection_LinkClicked;
            // 
            // PBvisible
            // 
            PBvisible.BackColor = Color.Transparent;
            PBvisible.Image = Properties.Resources.visivel;
            PBvisible.Location = new Point(328, 300);
            PBvisible.Name = "PBvisible";
            PBvisible.Size = new Size(43, 43);
            PBvisible.SizeMode = PictureBoxSizeMode.Zoom;
            PBvisible.TabIndex = 19;
            PBvisible.TabStop = false;
            PBvisible.Click += pictureBox4_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(90, 255, 201);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(74, 371);
            button2.Name = "button2";
            button2.Size = new Size(248, 73);
            button2.TabIndex = 18;
            button2.Text = "Salvar Como Imagem de Perfil";
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.senha_imageperfil;
            pictureBox3.Location = new Point(16, 291);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(52, 52);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(74, 273);
            label2.Name = "label2";
            label2.Size = new Size(104, 28);
            label2.TabIndex = 14;
            label2.Text = "PassWord";
            // 
            // textpassword
            // 
            textpassword.Anchor = AnchorStyles.None;
            textpassword.Location = new Point(74, 307);
            textpassword.Name = "textpassword";
            textpassword.PasswordChar = '•';
            textpassword.Size = new Size(248, 27);
            textpassword.TabIndex = 13;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(74, 190);
            label1.Name = "label1";
            label1.Size = new Size(116, 28);
            label1.TabIndex = 12;
            label1.Text = "User Name";
            // 
            // textUser
            // 
            textUser.Anchor = AnchorStyles.None;
            textUser.Location = new Point(74, 224);
            textUser.Name = "textUser";
            textUser.Size = new Size(248, 27);
            textUser.TabIndex = 11;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.user_imageperfil;
            pictureBox2.Location = new Point(16, 210);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(90, 255, 201);
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(74, 66);
            button1.Name = "button1";
            button1.Size = new Size(248, 81);
            button1.TabIndex = 0;
            button1.Text = "Buscar Imagem";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listImage_Visible_password
            // 
            listImage_Visible_password.ColorDepth = ColorDepth.Depth8Bit;
            listImage_Visible_password.ImageStream = (ImageListStreamer)resources.GetObject("listImage_Visible_password.ImageStream");
            listImage_Visible_password.TransparentColor = Color.Transparent;
            listImage_Visible_password.Images.SetKeyName(0, "visivel.png");
            listImage_Visible_password.Images.SetKeyName(1, "olho.png");
            // 
            // FrmImagePerfil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 533);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmImagePerfil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmImage";
            FormClosed += FrmImagePerfil_FormClosed;
            Load += FrmImage_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PBrouder_perfil).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PBvisible).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox3;
        private Label label2;
        private TextBox textpassword;
        private Label label1;
        private TextBox textUser;
        private PictureBox pictureBox2;
        private PictureBox PBvisible;
        private ImageList listImage_Visible_password;
        private clRouderPB PBrouder_perfil;
        private LinkLabel Test_Connection;
    }
}