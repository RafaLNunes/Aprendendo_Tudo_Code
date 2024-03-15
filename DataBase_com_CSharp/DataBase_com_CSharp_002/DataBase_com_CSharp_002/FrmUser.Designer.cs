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
            ((System.ComponentModel.ISupportInitialize)dataGriduser).BeginInit();
            SuspendLayout();
            // 
            // Teste
            // 
            Teste.Dock = DockStyle.Left;
            Teste.Location = new Point(0, 0);
            Teste.Name = "Teste";
            Teste.Size = new Size(113, 450);
            Teste.TabIndex = 0;
            Teste.Text = "Testar Conexão";
            Teste.UseVisualStyleBackColor = true;
            Teste.Click += Teste_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Bottom;
            button2.Location = new Point(113, 391);
            button2.Name = "button2";
            button2.Size = new Size(687, 59);
            button2.TabIndex = 1;
            button2.Text = "Enter";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtNome
            // 
            txtNome.Location = new Point(178, 185);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 3;
            // 
            // textIdade
            // 
            textIdade.Location = new Point(178, 342);
            textIdade.Name = "textIdade";
            textIdade.Size = new Size(100, 23);
            textIdade.TabIndex = 4;
            // 
            // textuser
            // 
            textuser.Location = new Point(625, 185);
            textuser.Name = "textuser";
            textuser.Size = new Size(100, 23);
            textuser.TabIndex = 5;
            // 
            // textPassWord
            // 
            textPassWord.Location = new Point(625, 342);
            textPassWord.Name = "textPassWord";
            textPassWord.Size = new Size(100, 23);
            textPassWord.TabIndex = 6;
            // 
            // CBDia
            // 
            CBDia.FormattingEnabled = true;
            CBDia.Location = new Point(357, 277);
            CBDia.Name = "CBDia";
            CBDia.Size = new Size(64, 23);
            CBDia.TabIndex = 7;
            // 
            // CBMes
            // 
            CBMes.FormattingEnabled = true;
            CBMes.Location = new Point(427, 277);
            CBMes.Name = "CBMes";
            CBMes.Size = new Size(64, 23);
            CBMes.TabIndex = 8;
            // 
            // CBAno
            // 
            CBAno.FormattingEnabled = true;
            CBAno.Location = new Point(497, 277);
            CBAno.Name = "CBAno";
            CBAno.Size = new Size(64, 23);
            CBAno.TabIndex = 9;
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Location = new Point(204, 167);
            Nome.Name = "Nome";
            Nome.Size = new Size(40, 15);
            Nome.TabIndex = 10;
            Nome.Text = "Nome";
            // 
            // Idade
            // 
            Idade.AutoSize = true;
            Idade.Location = new Point(208, 324);
            Idade.Name = "Idade";
            Idade.Size = new Size(36, 15);
            Idade.TabIndex = 11;
            Idade.Text = "Idade";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(644, 167);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 12;
            label1.Text = "userName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(644, 324);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 13;
            label2.Text = "PassWord";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(402, 240);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 14;
            label3.Text = "Data de Nascimento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(383, 260);
            label4.Name = "label4";
            label4.Size = new Size(158, 15);
            label4.TabIndex = 15;
            label4.Text = "Dia        |      Mês      |        Ano";
            // 
            // dataGriduser
            // 
            dataGriduser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGriduser.Location = new Point(335, 90);
            dataGriduser.Name = "dataGriduser";
            dataGriduser.RowTemplate.Height = 25;
            dataGriduser.Size = new Size(240, 150);
            dataGriduser.TabIndex = 16;
            dataGriduser.CellContentClick += dataGriduser_CellContentClick;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Location = new Point(113, 0);
            button1.Name = "button1";
            button1.Size = new Size(687, 84);
            button1.TabIndex = 17;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // resut
            // 
            resut.AutoSize = true;
            resut.Location = new Point(208, 110);
            resut.Name = "resut";
            resut.Size = new Size(38, 15);
            resut.TabIndex = 18;
            resut.Text = "label5";
            // 
            // Frmuser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "Frmuser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Frmuser_Load;
            ((System.ComponentModel.ISupportInitialize)dataGriduser).EndInit();
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
    }
}
