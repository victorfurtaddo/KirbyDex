using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class telaLogin : Form
    {
        public telaLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtLogin.Text) || string.IsNullOrWhiteSpace(txtSenha.Text))
            {

                MessageBox.Show("Por favor, preencha o usuário e a senha.",
                                "Campos Vazios",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else
            {
                home formHome = new home();
                formHome.Show();
                this.Hide();
            }
        }
    }
}
