using MySqlConnector;
using System;
using System.Windows.Forms;

namespace PetitPlannerIntegrador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsuario.Text;
            string password = textBoxPassword.Text;

            // Validar que no estén vacíos
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            string connectionString = "Server=localhost;Database=petitplanner;Uid=root;Pwd=root;";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta para verificar credenciales
                    string query = "SELECT COUNT(*) FROM usuarios WHERE user = @usuario AND password = @password";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@password", password);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        // ¡Login exitoso!
                        MessageBox.Show("¡Bienvenido!");

                        // Aquí abres el siguiente formulario (descomenta estas líneas cuando lo tengas)
                        // home formPrincipal = new home();
                        // formPrincipal.Show();
                        // this.Hide(); // Oculta el formulario de login
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}");
            }
        }

        // Este método mantiene el panel de login centrado
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (Panel_azul != null)
            {
                Panel_azul.Left = (this.ClientSize.Width - Panel_azul.Width) / 2;
                Panel_azul.Top = (this.ClientSize.Height - Panel_azul.Height) / 2;
            }
        }


        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

       
    }
}