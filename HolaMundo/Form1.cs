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
            //en esta variable vamos a almacenar el texto del textfield de la contraseña 1
            string password = txtContraseña1.Text;
            //en esta variable vamos a almacenar el texto del textfield de la contraseña 2
            string confirmPassword = txtContraseña2.Text;

            //con esta expresion regular estamos definiendo que valide que la contraseña al menos cuente con una letra minuscula, una mayuscula,un digito y un caracter no alfanumerico 
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).+$";

            //con este bool obtenemos un true o false de la comparación de la contraseña con el patron designado en la expresion regular
            bool isValid = Regex.IsMatch(password, pattern);


            if (!isValid)
            {
                //con este messageBox le informamos al usuario que su contraseña no cumple con los criterios de la expresion regular
                MessageBox.Show("La contraseña no cumple con los requisitos:\n- Una mayúscula\n- Una minúscula\n- Un número\n- Un símbolo");
                return;
            }

            if (password != confirmPassword)
            {
                //con este messageBox le informamos al usuario ambas contraseñas no coinciden
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            //con este messageBox le informamos al usuario que su contraseña si cumple con los criterios de la expresion regular y que ambas contraseñas coinciden
            MessageBox.Show("La contraseña ha sido validada");
        }
    }
}
