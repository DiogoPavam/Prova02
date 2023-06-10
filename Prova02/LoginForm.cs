using System;
using System.Windows.Forms;
using Prova02;


namespace Prova02
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void entrarButton_Click(object sender, EventArgs e)
        {
            Global.UsuarioLogado = new UsuariosDAO().Login(loginTextBox.Text, senhaTextBox.Text);
            //não encontrou
            if (Global.UsuarioLogado == null)
            {
                MessageBox.Show("Usuário e senha não encontrados!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                senhaTextBox.Clear();
                loginTextBox.Focus();
            }
            else
            {
                //encontrou e testamos se está ativo
                if (Global.UsuarioLogado.Ativo == false)
                {
                    MessageBox.Show("Usuário desabilitado!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    senhaTextBox.Clear();
                    loginTextBox.Focus();
                }
                else
                {
                    //está tudo certo, exiba uma mensagem antes de fechar o formulário
                    MessageBox.Show("Login bem-sucedido! O Form1 será exibido.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //defina o DialogResult como OK antes de fechar o formulário
                    this.DialogResult = DialogResult.OK;

                    //feche o formulário
                    Close();
                }
            }
        }


        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
