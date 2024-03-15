namespace DataBase_com_CSharp_002
{
    partial class FrmLogIn
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
            label2 = new Label();
            enter = new Button();
            label1 = new Label();
            textuser = new TextBox();
            textpass = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 81);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 9;
            label2.Text = "UserName";
            // 
            // enter
            // 
            enter.Location = new Point(129, 259);
            enter.Name = "enter";
            enter.Size = new Size(75, 23);
            enter.TabIndex = 8;
            enter.Text = "Enter";
            enter.UseVisualStyleBackColor = true;
            enter.Click += enter_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(183, 158);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 7;
            label1.Text = "PassWord";
            // 
            // textuser
            // 
            textuser.Location = new Point(158, 99);
            textuser.Name = "textuser";
            textuser.Size = new Size(100, 23);
            textuser.TabIndex = 6;
            // 
            // textpass
            // 
            textpass.ImeMode = ImeMode.NoControl;
            textpass.Location = new Point(158, 176);
            textpass.Name = "textpass";
            textpass.Size = new Size(100, 23);
            textpass.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(210, 259);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Left;
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(75, 361);
            button2.TabIndex = 11;
            button2.Text = "Teste conexão";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FrmLogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 361);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(enter);
            Controls.Add(label1);
            Controls.Add(textuser);
            Controls.Add(textpass);
            Name = "FrmLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogIn";
            FormClosed += FrmLogIn_FormClosed;
            Load += FrmLogIn_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button enter;
        private Label label1;
        private TextBox textuser;
        private TextBox textpass;
        private Button button1;
        private Button button2;
    }
}