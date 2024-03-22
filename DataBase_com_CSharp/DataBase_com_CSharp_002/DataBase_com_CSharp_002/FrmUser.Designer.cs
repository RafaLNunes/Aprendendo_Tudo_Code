namespace DataBase_com_CSharp_002
{
    partial class Frmuser
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
            components = new System.ComponentModel.Container();
            Teste = new Button();
            button2 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtNome = new TextBox();
            textIdade = new TextBox();
            textuser = new TextBox();
            textPassWord = new TextBox();
            CBDia = new ComboBox();
            CBMes = new ComboBox();
            CBAno = new ComboBox();
            Nome = new Label();
            Idade = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dataGriduser = new DataGridView();
            button1 = new Button();
            resut = new Label();
            button3 = new Button();
            button4 = new Button();
            CBperfil = new ComboBox();
            label5 = new Label();
            button5 = new Button();
            LAno = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGriduser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Teste
            // 
            Teste.Dock = DockStyle.Left;
            Teste.Location = new Point(0, 0);
            Teste.Margin = new Padding(3, 4, 3, 4);
            Teste.Name = "Teste";
            Teste.Size = new Size(129, 600);
            Teste.TabIndex = 0;
            Teste.Text = "Testar Conexão";
            Teste.UseVisualStyleBackColor = true;
            Teste.Click += Teste_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Bottom;
            button2.Location = new Point(129, 521);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(1105, 79);
            button2.TabIndex = 1;
            button2.Text = "Enter";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtNome
            // 
            txtNome.Location = new Point(203, 247);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(114, 27);
            txtNome.TabIndex = 3;
            // 
            // textIdade
            // 
            textIdade.Location = new Point(203, 456);
            textIdade.Margin = new Padding(3, 4, 3, 4);
            textIdade.Name = "textIdade";
            textIdade.Size = new Size(114, 27);
            textIdade.TabIndex = 4;
            // 
            // textuser
            // 
            textuser.Location = new Point(714, 247);
            textuser.Margin = new Padding(3, 4, 3, 4);
            textuser.Name = "textuser";
            textuser.Size = new Size(114, 27);
            textuser.TabIndex = 5;
            // 
            // textPassWord
            // 
            textPassWord.Location = new Point(714, 456);
            textPassWord.Margin = new Padding(3, 4, 3, 4);
            textPassWord.Name = "textPassWord";
            textPassWord.Size = new Size(114, 27);
            textPassWord.TabIndex = 6;
            // 
            // CBDia
            // 
            CBDia.FormattingEnabled = true;
            CBDia.Location = new Point(408, 369);
            CBDia.Margin = new Padding(3, 4, 3, 4);
            CBDia.Name = "CBDia";
            CBDia.Size = new Size(73, 28);
            CBDia.TabIndex = 7;
            // 
            // CBMes
            // 
            CBMes.FormattingEnabled = true;
            CBMes.Location = new Point(488, 369);
            CBMes.Margin = new Padding(3, 4, 3, 4);
            CBMes.Name = "CBMes";
            CBMes.Size = new Size(73, 28);
            CBMes.TabIndex = 8;
            // 
            // CBAno
            // 
            CBAno.FormattingEnabled = true;
            CBAno.Location = new Point(568, 369);
            CBAno.Margin = new Padding(3, 4, 3, 4);
            CBAno.Name = "CBAno";
            CBAno.Size = new Size(73, 28);
            CBAno.TabIndex = 9;
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Location = new Point(233, 223);
            Nome.Name = "Nome";
            Nome.Size = new Size(50, 20);
            Nome.TabIndex = 10;
            Nome.Text = "Nome";
            // 
            // Idade
            // 
            Idade.AutoSize = true;
            Idade.Location = new Point(238, 432);
            Idade.Name = "Idade";
            Idade.Size = new Size(47, 20);
            Idade.TabIndex = 11;
            Idade.Text = "Idade";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(736, 223);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 12;
            label1.Text = "userName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(736, 432);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 13;
            label2.Text = "PassWord";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(459, 320);
            label3.Name = "label3";
            label3.Size = new Size(145, 20);
            label3.TabIndex = 14;
            label3.Text = "Data de Nascimento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(438, 347);
            label4.Name = "label4";
            label4.Size = new Size(206, 20);
            label4.TabIndex = 15;
            label4.Text = "Dia        |      Mês      |        Ano";
            // 
            // dataGriduser
            // 
            dataGriduser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGriduser.Location = new Point(383, 120);
            dataGriduser.Margin = new Padding(3, 4, 3, 4);
            dataGriduser.Name = "dataGriduser";
            dataGriduser.RowHeadersWidth = 51;
            dataGriduser.RowTemplate.Height = 25;
            dataGriduser.Size = new Size(274, 200);
            dataGriduser.TabIndex = 16;
            dataGriduser.CellContentClick += dataGriduser_CellContentClick;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Location = new Point(129, 0);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(1105, 112);
            button1.TabIndex = 17;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // resut
            // 
            resut.AutoSize = true;
            resut.Location = new Point(238, 147);
            resut.Name = "resut";
            resut.Size = new Size(50, 20);
            resut.TabIndex = 18;
            resut.Text = "label5";
            // 
            // button3
            // 
            button3.Dock = DockStyle.Bottom;
            button3.Location = new Point(129, 490);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(1105, 31);
            button3.TabIndex = 19;
            button3.Text = "Alter Table";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.Location = new Point(475, 435);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(86, 31);
            button4.TabIndex = 20;
            button4.Text = "Excluir";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // CBperfil
            // 
            CBperfil.FormattingEnabled = true;
            CBperfil.Location = new Point(735, 353);
            CBperfil.Margin = new Padding(3, 4, 3, 4);
            CBperfil.Name = "CBperfil";
            CBperfil.Size = new Size(122, 28);
            CBperfil.TabIndex = 21;
            CBperfil.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(770, 320);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 22;
            label5.Text = "Perfil";
            // 
            // button5
            // 
            button5.Dock = DockStyle.Left;
            button5.Location = new Point(129, 112);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(67, 378);
            button5.TabIndex = 23;
            button5.Text = "Atuaizar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // LAno
            // 
            LAno.AutoSize = true;
            LAno.Location = new Point(500, 411);
            LAno.Name = "LAno";
            LAno.Size = new Size(0, 20);
            LAno.TabIndex = 24;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(927, 176);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(255, 234);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Frmuser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 600);
            Controls.Add(pictureBox1);
            Controls.Add(LAno);
            Controls.Add(button5);
            Controls.Add(label5);
            Controls.Add(CBperfil);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(resut);
            Controls.Add(button1);
            Controls.Add(dataGriduser);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Idade);
            Controls.Add(Nome);
            Controls.Add(CBAno);
            Controls.Add(CBMes);
            Controls.Add(CBDia);
            Controls.Add(textPassWord);
            Controls.Add(textuser);
            Controls.Add(textIdade);
            Controls.Add(txtNome);
            Controls.Add(button2);
            Controls.Add(Teste);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Frmuser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Frmuser_Load;
            ((System.ComponentModel.ISupportInitialize)dataGriduser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Teste;
        private Button button2;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtNome;
        private TextBox textIdade;
        private TextBox textuser;
        private TextBox textPassWord;
        private ComboBox CBDia;
        private ComboBox CBMes;
        private ComboBox CBAno;
        private Label Nome;
        private Label Idade;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGriduser;
        private Button button1;
        private Label resut;
        private Button button3;
        private Button button4;
        private ComboBox CBperfil;
        private Label label5;
        private Button button5;
        private Label LAno;
        private PictureBox pictureBox1;
    }
}
