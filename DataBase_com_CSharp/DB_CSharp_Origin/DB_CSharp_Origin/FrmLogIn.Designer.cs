namespace DB_CSharp_Origin
{
    partial class FrmLogIn
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
            textpass = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textuser
            // 
            textuser.Anchor = AnchorStyles.None;
            textuser.Location = new Point(496, 138);
            textuser.Name = "textuser";
            textuser.Size = new Size(218, 23);
            textuser.TabIndex = 0;
            // 
            // textpass
            // 
            textpass.Anchor = AnchorStyles.None;
            textpass.BackColor = SystemColors.Window;
            textpass.Location = new Point(496, 294);
            textpass.Name = "textpass";
            textpass.Size = new Size(218, 23);
            textpass.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(101, 153, 151);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(546, 409);
            button1.Name = "button1";
            button1.Size = new Size(136, 48);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave_1;
            // 
            // FrmLogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.DB_CSharp_Origin__3_;
            ClientSize = new Size(780, 489);
            Controls.Add(button1);
            Controls.Add(textpass);
            Controls.Add(textuser);
            MaximumSize = new Size(796, 528);
            MinimumSize = new Size(796, 528);
            Name = "FrmLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FrmLogIn_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textuser;
        private TextBox textpass;
        private Button button1;
    }
}
