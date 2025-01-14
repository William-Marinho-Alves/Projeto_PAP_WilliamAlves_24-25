using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_PAP_WilliamAlves_24_25
{
    public partial class registo : Form
    {
        public registo()
        {
            InitializeComponent();
        }

        private void registo_btn_Click(object sender, EventArgs e)
        {




            //se registar
            this.Hide();
            login Login = new login();
            Login.Show();
        }

        private void password_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void link_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login login = new login();


            this.Hide();
            login.Show();
            //está feito
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (VerPasseRegisto.Checked)
            {
                // Exibe a senha no TextBox
                password_txt.UseSystemPasswordChar = false;
            }
            else
            {
                // Oculta a senha no TextBox
                password_txt.UseSystemPasswordChar = true;
            }
        }
    }
}
