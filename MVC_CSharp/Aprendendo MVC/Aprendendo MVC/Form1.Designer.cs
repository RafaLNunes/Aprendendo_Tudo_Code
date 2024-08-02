namespace Aprendendo_MVC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtID = new TextBox();
            txtNome = new TextBox();
            txtUserName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            CbAno = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            CbCargo = new ComboBox();
            CbUnidade = new ComboBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label7 = new Label();
            txtPassWord = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Location = new Point(141, 125);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 0;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(141, 158);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 27);
            txtNome.TabIndex = 1;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(141, 191);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(125, 27);
            txtUserName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 128);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 6;
            label1.Text = "ID Aluno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 161);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 7;
            label2.Text = "Nome completo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 194);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 8;
            label3.Text = "Name User";
            // 
            // CbAno
            // 
            CbAno.FormattingEnabled = true;
            CbAno.Location = new Point(141, 257);
            CbAno.Name = "CbAno";
            CbAno.Size = new Size(125, 28);
            CbAno.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 260);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 10;
            label4.Text = "Ano Escolar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(86, 295);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 11;
            label5.Text = "Cargo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(70, 328);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 12;
            label6.Text = "Unidade";
            // 
            // CbCargo
            // 
            CbCargo.FormattingEnabled = true;
            CbCargo.Location = new Point(141, 291);
            CbCargo.Name = "CbCargo";
            CbCargo.Size = new Size(125, 28);
            CbCargo.TabIndex = 13;
            // 
            // CbUnidade
            // 
            CbUnidade.FormattingEnabled = true;
            CbUnidade.Location = new Point(141, 325);
            CbUnidade.Name = "CbUnidade";
            CbUnidade.Size = new Size(125, 28);
            CbUnidade.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(303, 125);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 204);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Dock = DockStyle.Right;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(706, 0);
            button1.Name = "button1";
            button1.Size = new Size(94, 450);
            button1.TabIndex = 16;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.Dock = DockStyle.Right;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(612, 0);
            button2.Name = "button2";
            button2.Size = new Size(94, 450);
            button2.TabIndex = 17;
            button2.Text = "Escolher Imagem";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Silver;
            button3.Dock = DockStyle.Right;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(518, 0);
            button3.Name = "button3";
            button3.Size = new Size(94, 450);
            button3.TabIndex = 18;
            button3.Text = "Alterar";
            button3.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(53, 227);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 20;
            label7.Text = "PassWord";
            // 
            // txtPassWord
            // 
            txtPassWord.Location = new Point(141, 224);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.Size = new Size(125, 27);
            txtPassWord.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(txtPassWord);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(CbUnidade);
            Controls.Add(CbCargo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(CbAno);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUserName);
            Controls.Add(txtNome);
            Controls.Add(txtID);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtID;
        private TextBox txtNome;
        private TextBox txtUserName;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox CbAno;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox CbCargo;
        private ComboBox CbUnidade;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label7;
        private TextBox txtPassWord;
    }
}
