namespace DB_CSharp_Origin
{
    partial class FrmAlter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlter));
            button1 = new Button();
            dataGridViewuser = new DataGridView();
            pictureBox6 = new PictureBox();
            Nome = new Label();
            textBox2 = new TextBox();
            pictureBox5 = new PictureBox();
            CBperfil = new ComboBox();
            Cargo = new Label();
            label1 = new Label();
            textuser = new TextBox();
            pictureBox2 = new PictureBox();
            PBvisiblePassword = new PictureBox();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            textpassword = new TextBox();
            listImage_Visible_password = new ImageList(components);
            Test_Connection = new LinkLabel();
            linkLabel1 = new LinkLabel();
            panel1 = new Panel();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewuser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBvisiblePassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 126, 169);
            button1.Dock = DockStyle.Bottom;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(0, 498);
            button1.Name = "button1";
            button1.Size = new Size(934, 35);
            button1.TabIndex = 0;
            button1.Text = "AlterTable";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridViewuser
            // 
            dataGridViewuser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewuser.Dock = DockStyle.Top;
            dataGridViewuser.Location = new Point(0, 0);
            dataGridViewuser.Name = "dataGridViewuser";
            dataGridViewuser.RowHeadersWidth = 51;
            dataGridViewuser.RowTemplate.Height = 29;
            dataGridViewuser.Size = new Size(934, 258);
            dataGridViewuser.TabIndex = 1;
            dataGridViewuser.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.None;
            pictureBox6.BackgroundImage = Properties.Resources.Design_sem_nome2;
            pictureBox6.Image = Properties.Resources.Name_altertable;
            pictureBox6.Location = new Point(52, 302);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(52, 52);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 24;
            pictureBox6.TabStop = false;
            // 
            // Nome
            // 
            Nome.Anchor = AnchorStyles.None;
            Nome.AutoSize = true;
            Nome.BackColor = Color.Transparent;
            Nome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Nome.Location = new Point(119, 292);
            Nome.Name = "Nome";
            Nome.Size = new Size(166, 28);
            Nome.TabIndex = 23;
            Nome.Text = "Nome Completo";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(110, 327);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(290, 27);
            textBox2.TabIndex = 22;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.None;
            pictureBox5.BackgroundImage = Properties.Resources.Design_sem_nome2;
            pictureBox5.Image = Properties.Resources.funcao_altertable;
            pictureBox5.Location = new Point(52, 381);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(52, 52);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 27;
            pictureBox5.TabStop = false;
            // 
            // CBperfil
            // 
            CBperfil.Anchor = AnchorStyles.None;
            CBperfil.FormattingEnabled = true;
            CBperfil.Location = new Point(110, 405);
            CBperfil.Name = "CBperfil";
            CBperfil.Size = new Size(290, 28);
            CBperfil.TabIndex = 26;
            // 
            // Cargo
            // 
            Cargo.Anchor = AnchorStyles.None;
            Cargo.AutoSize = true;
            Cargo.BackColor = Color.Transparent;
            Cargo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Cargo.Location = new Point(119, 374);
            Cargo.Name = "Cargo";
            Cargo.Size = new Size(67, 28);
            Cargo.TabIndex = 25;
            Cargo.Text = "Cargo";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(553, 289);
            label1.Name = "label1";
            label1.Size = new Size(116, 28);
            label1.TabIndex = 34;
            label1.Text = "User Name";
            // 
            // textuser
            // 
            textuser.Anchor = AnchorStyles.None;
            textuser.Location = new Point(543, 323);
            textuser.Name = "textuser";
            textuser.Size = new Size(290, 27);
            textuser.TabIndex = 33;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackgroundImage = Properties.Resources.Design_sem_nome2;
            pictureBox2.Image = Properties.Resources.user_altertable;
            pictureBox2.Location = new Point(485, 298);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 35;
            pictureBox2.TabStop = false;
            // 
            // PBvisiblePassword
            // 
            PBvisiblePassword.Anchor = AnchorStyles.None;
            PBvisiblePassword.BackColor = Color.Transparent;
            PBvisiblePassword.Image = Properties.Resources.visivel;
            PBvisiblePassword.Location = new Point(849, 397);
            PBvisiblePassword.Name = "PBvisiblePassword";
            PBvisiblePassword.Size = new Size(43, 43);
            PBvisiblePassword.SizeMode = PictureBoxSizeMode.Zoom;
            PBvisiblePassword.TabIndex = 39;
            PBvisiblePassword.TabStop = false;
            PBvisiblePassword.Click += PBvisiblePassword_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = Properties.Resources.Design_sem_nome1;
            pictureBox3.Image = Properties.Resources.senha_altertable;
            pictureBox3.Location = new Point(484, 388);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(52, 52);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 38;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(553, 371);
            label2.Name = "label2";
            label2.Size = new Size(104, 28);
            label2.TabIndex = 37;
            label2.Text = "PassWord";
            // 
            // textpassword
            // 
            textpassword.Anchor = AnchorStyles.None;
            textpassword.Location = new Point(542, 405);
            textpassword.Name = "textpassword";
            textpassword.PasswordChar = '•';
            textpassword.Size = new Size(290, 27);
            textpassword.TabIndex = 36;
            // 
            // listImage_Visible_password
            // 
            listImage_Visible_password.ColorDepth = ColorDepth.Depth8Bit;
            listImage_Visible_password.ImageStream = (ImageListStreamer)resources.GetObject("listImage_Visible_password.ImageStream");
            listImage_Visible_password.TransparentColor = Color.Transparent;
            listImage_Visible_password.Images.SetKeyName(0, "visivel.png");
            listImage_Visible_password.Images.SetKeyName(1, "olho.png");
            // 
            // Test_Connection
            // 
            Test_Connection.ActiveLinkColor = Color.Red;
            Test_Connection.AutoSize = true;
            Test_Connection.BackColor = Color.Transparent;
            Test_Connection.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Test_Connection.Location = new Point(758, 252);
            Test_Connection.Name = "Test_Connection";
            Test_Connection.Size = new Size(176, 31);
            Test_Connection.TabIndex = 40;
            Test_Connection.TabStop = true;
            Test_Connection.Text = "Testar Conexão";
            Test_Connection.LinkClicked += Test_Connection_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.Location = new Point(0, 253);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(210, 31);
            linkLabel1.TabIndex = 41;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Atualizar Conexão";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 0, 0);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 481);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 17);
            panel1.TabIndex = 42;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 126, 169);
            button2.Dock = DockStyle.Bottom;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(0, 452);
            button2.Name = "button2";
            button2.Size = new Size(934, 29);
            button2.TabIndex = 43;
            button2.Text = "Excluir";
            button2.UseVisualStyleBackColor = false;
            // 
            // FrmAlter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Design_sem_nome;
            ClientSize = new Size(934, 533);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(dataGridViewuser);
            Controls.Add(linkLabel1);
            Controls.Add(Test_Connection);
            Controls.Add(PBvisiblePassword);
            Controls.Add(pictureBox3);
            Controls.Add(label2);
            Controls.Add(textpassword);
            Controls.Add(label1);
            Controls.Add(textuser);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox5);
            Controls.Add(CBperfil);
            Controls.Add(Cargo);
            Controls.Add(pictureBox6);
            Controls.Add(Nome);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Name = "FrmAlter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAlter";
            FormClosed += FrmAlterar_FormClosed;
            Load += FrmAlterar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewuser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBvisiblePassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridViewuser;
        private PictureBox pictureBox6;
        private Label Nome;
        private TextBox textBox2;
        private PictureBox pictureBox5;
        private ComboBox CBperfil;
        private Label Cargo;
        private Label label1;
        private TextBox textuser;
        private PictureBox pictureBox2;
        private PictureBox PBvisiblePassword;
        private PictureBox pictureBox3;
        private Label label2;
        private TextBox textpassword;
        private ImageList listImage_Visible_password;
        private LinkLabel Test_Connection;
        private LinkLabel linkLabel1;
        private Panel panel1;
        private Button button2;
    }
}