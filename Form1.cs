using MySqlConnector;
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
            // Asumiendo que tienes TextBox para usuario y contraseña
            string usuario = textBoxUsuario.Text;
            string password = textBoxPassword.Text;

            // Validar que no estén vacíos
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, complete todos");
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
                    command.Parameters.AddWithValue("@password", password); // En producción, usa hash!

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        // Aquí abres el siguiente formulario
                        //home formPrincipal = new home();
                        //formPrincipal.Show();      // Muestra el nuevo formulario
                        //this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
