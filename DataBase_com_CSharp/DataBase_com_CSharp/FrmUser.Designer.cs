namespace DataBase_com_CSharp
{
    partial class FrmUser
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
            textuser = new TextBox();
            Enter_dados = new Button();
            textpassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnConection = new Button();
            label3 = new Label();
            label4 = new Label();
            textidade = new TextBox();
            textname = new TextBox();
            SuspendLayout();
            // 
            // textuser
            // 
            textuser.Location = new Point(633, 244);
            textuser.Name = "textuser";
            textuser.Size = new Size(100, 23);
            textuser.TabIndex = 0;
            // 
            // Enter_dados
            // 
            Enter_dados.BackColor = Color.FromArgb(255, 224, 192);
            Enter_dados.Dock = DockStyle.Bottom;
            Enter_dados.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            Enter_dados.Location = new Point(0, 354);
            Enter_dados.Name = "Enter_dados";
            Enter_dados.Size = new Size(800, 96);
            Enter_dados.TabIndex = 1;
            Enter_dados.Text = "Enter";
            Enter_dados.UseVisualStyleBackColor = false;
            Enter_dados.Click += button1_Click;
            // 
            // textpassword
            // 
            textpassword.Location = new Point(633, 107);
            textpassword.Name = "textpassword";
            textpassword.Size = new Size(100, 23);
            textpassword.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(652, 89);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 3;
            label1.Text = "PassWord";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(652, 226);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 4;
            label2.Text = "NameUser";
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
            btnConection.TabIndex = 5;
            btnConection.Text = "Testar";
            btnConection.UseVisualStyleBackColor = false;
            btnConection.Click += btnConection_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(272, 89);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 9;
            label3.Text = "Nome";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(270, 226);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 8;
            label4.Text = "Idade";
            // 
            // textidade
            // 
            textidade.Location = new Point(244, 244);
            textidade.Name = "textidade";
            textidade.Size = new Size(100, 23);
            textidade.TabIndex = 7;
            // 
            // textname
            // 
            textname.Location = new Point(244, 107);
            textname.Name = "textname";
            textname.Size = new Size(100, 23);
            textname.TabIndex = 6;
            // 
            // FrmUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(textidade);
            Controls.Add(textname);
            Controls.Add(btnConection);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textpassword);
            Controls.Add(Enter_dados);
            Controls.Add(textuser);
            Name = "FrmUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosed += FrmUser_Closed;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textuser;
        private Button Enter_dados;
        private TextBox textpassword;
        private Label label1;
        private Label label2;
        private Button btnConection;
        private Label label3;
        private Label label4;
        private TextBox textidade;
        private TextBox textname;
    }
}
