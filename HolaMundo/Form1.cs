using System.Text.RegularExpressions;

namespace HolaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string password = txtContraseña1.Text;
            string confirmPassword = txtContraseña2.Text;

            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).+$";

            bool isValid = Regex.IsMatch(password, pattern);


            if (!isValid)
            {
                MessageBox.Show("La contraseña no cumple con los requisitos:\n- Una mayúscula\n- Una minúscula\n- Un número\n- Un símbolo");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            MessageBox.Show("La contraseña ha sido validada");
        }
    }
}
