namespace DB_CSharp_Origin
{
    partial class FrmAlterar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlterar));
            button1 = new Button();
            dataGridView1 = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            button1.Location = new Point(0, 464);
            button1.Name = "button1";
            button1.Size = new Size(934, 69);
            button1.TabIndex = 0;
            button1.Text = "AlterTable";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(934, 145);
            dataGridView1.TabIndex = 1;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.None;
            pictureBox6.BackgroundImage = Properties.Resources.Design_sem_nome2;
            pictureBox6.Image = Properties.Resources.nome_altertable;
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
            pictureBox5.Image = Properties.Resources.cargo_signup;
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
            pictureBox2.Image = Properties.Resources.user_signup;
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
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = Properties.Resources.Design_sem_nome1;
            pictureBox3.Image = Properties.Resources.Senha_signup;
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
            // FrmAlterar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Design_sem_nome;
            ClientSize = new Size(934, 533);
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
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "FrmAlterar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCadastro";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
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
    }
}