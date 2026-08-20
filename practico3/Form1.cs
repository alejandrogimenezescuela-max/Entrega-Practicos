namespace practico3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CargarImagenesIniciales();
        }

        // Carga los iconos de los botones desde Recursos (se copian al bin al compilar)
        private void CargarImagenesIniciales()
        {
            btnGuardar.Image = CargarImagen("guardar.png");
            btnEliminar.Image = CargarImagen("eliminar.png");
            btnSalir.Image = CargarImagen("salir.png");
            // picGenero queda vacio a proposito hasta elegir Varon/Mujer (punto 2 de la consigna)
        }

        private static Image? CargarImagen(string nombreArchivo)
        {
            string ruta = Path.Combine(AppContext.BaseDirectory, "Recursos", nombreArchivo);
            return File.Exists(ruta) ? Image.FromFile(ruta) : null;
        }

        // Validaciones heredadas del Practico 2
        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        // Punto 7: cambia la imagen del PictureBox segun el genero elegido
        private void RBVaron_CheckedChanged(object sender, EventArgs e)
        {
            if (RBVaron.Checked)
                picGenero.BackgroundImage = CargarImagen("varon.png");
        }

        private void RBMujer_CheckedChanged(object sender, EventArgs e)
        {
            if (RBMujer.Checked)
                picGenero.BackgroundImage = CargarImagen("mujer.png");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TDni.Text) ||
                string.IsNullOrWhiteSpace(TApellido.Text) ||
                string.IsNullOrWhiteSpace(TNombre.Text))
            {
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblModificar.Text = $"{TNombre.Text} {TApellido.Text}";

            DialogResult ask = MessageBox.Show(
                "¿Seguro que desea insertar un nuevo Cliente?",
                "Confirmar Insercion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if (ask == DialogResult.Yes)
            {
                MessageBox.Show(
                    $"El Cliente: {lblModificar.Text} se inserto Correctamente",
                    "Guardar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show(
                $"Esta apunto de eliminar el Cliente: {lblModificar.Text}",
                "Confirmar Eliminacion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (ask == DialogResult.Yes)
            {
                MessageBox.Show(
                    $"El Cliente: {lblModificar.Text} se elimino correctamente",
                    "Eliminar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                TDni.Clear();
                TApellido.Clear();
                TNombre.Clear();
                txtTelefono.Clear();
                chkNaranja.Checked = false;
                chkVisa.Checked = false;
                chkMastercard.Checked = false;
                lblModificar.Text = "modificar";
                TDni.Focus();
            }
        }

        // Punto 6: el boton salir cierra la aplicacion
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
