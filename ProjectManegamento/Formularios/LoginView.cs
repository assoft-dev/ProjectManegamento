using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManegamento.Formularios
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            this.Hide();

            var menu = new MenuPrincipal();

            menu.StartPosition = FormStartPosition.CenterParent;
            menu.Show();
            menu.FormClosing += Menu_FormClosing;
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtEmail.Text = string.Empty;
            txtSenha.Text = string.Empty;
            txtEmail.Focus();
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar_Click(null, null);
            }
        }
    }
}
