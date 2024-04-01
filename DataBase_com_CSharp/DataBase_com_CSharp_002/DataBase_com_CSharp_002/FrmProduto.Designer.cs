namespace DataBase_com_CSharp_002
{
    partial class FrmProduto
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
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textpreco = new TextBox();
            textqtd = new TextBox();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            textprod = new TextBox();
            textfornc = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(148, 320);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "Produto";
            // 
            // button1
            // 
            button1.Location = new Point(526, 446);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Sumir";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 370);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 4;
            label2.Text = "Preço";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(148, 421);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 5;
            label3.Text = "Estoque";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(148, 465);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 6;
            label4.Text = "Fornecedor";
            // 
            // textpreco
            // 
            textpreco.Location = new Point(285, 367);
            textpreco.Name = "textpreco";
            textpreco.Size = new Size(125, 27);
            textpreco.TabIndex = 7;
            // 
            // textqtd
            // 
            textqtd.Location = new Point(285, 418);
            textqtd.Name = "textqtd";
            textqtd.Size = new Size(125, 27);
            textqtd.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(526, 379);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 10;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(526, 322);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 11;
            button3.Text = "Cadastrar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(192, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(358, 214);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textprod
            // 
            textprod.Location = new Point(285, 317);
            textprod.Name = "textprod";
            textprod.Size = new Size(125, 27);
            textprod.TabIndex = 13;
            // 
            // textfornc
            // 
            textfornc.Location = new Point(285, 462);
            textfornc.Name = "textfornc";
            textfornc.Size = new Size(125, 27);
            textfornc.TabIndex = 14;
            // 
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            ClientSize = new Size(742, 600);
            Controls.Add(textfornc);
            Controls.Add(textprod);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textqtd);
            Controls.Add(textpreco);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmProduto";
            Load += FrmProduto_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textpreco;
        private TextBox textqtd;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private TextBox textprod;
        private TextBox textfornc;
    }
}