using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DB_CSharp_Origin
{
    internal class Home
    {
        ClConnection conn = new ClConnection();
        public TextBox textUser;
        public TextBox textpassword;
        public MenuStrip GetMenu()
        {

            MenuStrip Menu = new MenuStrip();
            ToolStripMenuItem image = new ToolStripMenuItem("Add Image");
            Menu.Items.Add(image);
            ToolStripMenuItem alertable = new ToolStripMenuItem("Alter Table");
            Menu.Items.Add(alertable);
            ToolStripMenuItem signup = new ToolStripMenuItem("New Acount");
            Menu.Items.Add(signup);


            signup.Click += signup_Click;
            alertable.Click += alertable_Click;
            image.Click += Image_Click;


            return Menu;
        }

        private void signup_Click(object sender, EventArgs e)
        {
            FrmSignUp up = new FrmSignUp();
            //this.Hide();
            up.ShowDialog();
        }
       

        private void alertable_Click(object sender, EventArgs e)
        {
            FrmAlter alt = new FrmAlter();
            //this.Hide();
            alt.ShowDialog();
        }
        private void Image_Click(object sender, EventArgs e)
        {
            FrmImagePerfil ima = new FrmImagePerfil();
            //this.Hide();
            ima.ShowDialog();

        }


    }
}
