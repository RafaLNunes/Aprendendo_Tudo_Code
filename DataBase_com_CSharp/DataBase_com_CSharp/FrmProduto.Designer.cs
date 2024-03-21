namespace DataBase_com_CSharp
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
            label6 = new Label();
            textBox5 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            btnConection = new Button();
            Enter_dados = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(639, 94);
            label6.Name = "label6";
            label6.Size = new Size(100, 15);
            label6.TabIndex = 24;
            label6.Text = "Preço do Produto";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(638, 112);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(259, 94);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 22;
            label3.Text = "Nome Produto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(431, 224);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 21;
            label4.Text = "Qtd do produto";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(425, 242);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 20;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(249, 112);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 19;
            // 
            // btnConection
            // 
            btnConection.BackColor = Color.RosyBrown;
            btnConection.Dock = DockStyle.Left;
            btnConection.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnConection.ForeColor = Color.Black;
            btnConection.Location = new Point(0, 0);
            btnConection.Name = "btnConection";
            btnConection.Size = new Size(186, 354);
            btnConection.TabIndex = 18;
            btnConection.Text = "Testar";
            btnConection.UseVisualStyleBackColor = false;
            btnConection.Click += btnConection_Click;
            // 
            // Enter_dados
            // 
            Enter_dados.BackColor = Color.FromArgb(255, 224, 192);
            Enter_dados.Dock = DockStyle.Bottom;
            Enter_dados.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            Enter_dados.Location = new Point(0, 354);
            Enter_dados.Name = "Enter_dados";
            Enter_dados.Size = new Size(800, 96);
            Enter_dados.TabIndex = 14;
            Enter_dados.Text = "Enter";
            Enter_dados.UseVisualStyleBackColor = false;
            Enter_dados.Click += Enter_dados_Click;
            // 
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(btnConection);
            Controls.Add(Enter_dados);
            Name = "FrmProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmProduto";
            FormClosed += FrmProduto_FormClosed;
            Load += FrmProduto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private TextBox textBox5;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button btnConection;
        private Button Enter_dados;
    }
}