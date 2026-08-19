namespace practico1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            // Validar que no estén vacíos los campos
            if (string.IsNullOrWhiteSpace(txtApellido.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor, ingrese tanto el Apellido como el Nombre.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Agrega el apellido y nombre al TextBox grande (textBox1) con salto de línea
            textBox1.AppendText($"{txtApellido.Text}, {txtNombre.Text}{Environment.NewLine}");

            // Limpia los campos de entrada y pone el foco en Apellido
            txtApellido.Clear();
            txtNombre.Clear();
            txtApellido.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Limpia todos los cuadros de texto
            txtApellido.Clear();
            txtNombre.Clear();
            textBox1.Clear();

            // Devuelve el cursor a la primera casilla
            txtApellido.Focus();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}