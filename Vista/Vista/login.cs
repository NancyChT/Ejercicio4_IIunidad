using Datos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;

namespace Vista
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private async void Aceptarbutton_Click(object sender, EventArgs e)
        {
            if (CorreotextBox.Text == String.Empty)
            {
                errorProvider1.SetError(CorreotextBox, "Ingrese un correo de usuario");
                CorreotextBox.Focus();
                return;
            }
            errorProvider1.Clear();
            if (ContrasenatextBox.Text == String.Empty)
            {
                errorProvider1.SetError(ContrasenatextBox, "Ingrese una contrasena");
                ContrasenatextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            UsuarioDatos userDatos = new UsuarioDatos();


            bool valido = await userDatos.LoginAsync(CorreotextBox.Text, ContrasenatextBox.Text);

            if (valido)
            {
                Menu Formulario = new Menu();
                Hide();
                Formulario.Show();

            }
            else
            {
                MessageBox.Show("Datos de usuario incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}