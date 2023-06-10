using System;
using System.Windows.Forms;

namespace Prova02
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm loginForm = new LoginForm();

            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // O login foi bem-sucedido, então podemos iniciar o Form1
                Application.Run(new Form1());
            }
            else
            {
                // O login falhou ou foi cancelado, então podemos encerrar o aplicativo
                return;
            }
        }

    }
}
