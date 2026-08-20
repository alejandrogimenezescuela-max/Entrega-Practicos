namespace practico2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 1. Validaciones para permitir solo Números en DNI
        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla ingresada
            }
        }

        // 2. Validaciones para permitir solo Letras y Espacios en Apellido y Nombre
        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // 3. Botón GUARDAR
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Verificación con operador OR
            if (string.IsNullOrWhiteSpace(TDni.Text) ||
                string.IsNullOrWhiteSpace(TApellido.Text) ||
                string.IsNullOrWhiteSpace(TNombre.Text))
            {
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Actualiza el label con el Nombre y Apellido
            lblModificar.Text = $"{TNombre.Text} {TApellido.Text}";

            // Mensaje de consulta con foco por defecto en "Sí" (Button1)
            DialogResult ask = MessageBox.Show(
                "¿Seguro que desea insertar un nuevo Cliente?",
                "Confirmar Insercion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1
            );

            if (ask == DialogResult.Yes)
            {
                MessageBox.Show(
                    $"El Cliente: {lblModificar.Text} se inserto Correctamente",
                    "Guardar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        // 4. Botón ELIMINAR (o button2)
        private void button2_Click(object sender, EventArgs e)
        {
            // Mensaje de advertencia con foco por defecto en "NO" (Button2)
            DialogResult ask = MessageBox.Show(
                $"Esta apunto de eliminar el Cliente: {lblModificar.Text}",
                "Confirmar Eliminacion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2
            );

            if (ask == DialogResult.Yes)
            {
                MessageBox.Show(
                    $"El Cliente: {lblModificar.Text} se elimino correctamente",
                    "Eliminar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Limpieza de campos y label
                TDni.Clear();
                TApellido.Clear();
                TNombre.Clear();
                lblModificar.Text = "modificar";
                TDni.Focus();
            }
        }
    }
}