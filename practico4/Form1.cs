namespace practico4
{
    public partial class Form1 : Form
    {
        private readonly string carpetaFotos = Path.Combine(AppContext.BaseDirectory, "Fotos");
        private string RutaFotoPorDefecto => Path.Combine(carpetaFotos, "avatar.jpg");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConfigurarGrilla();
            CargarImagenesIniciales();

            Directory.CreateDirectory(carpetaFotos);
            string origenAvatar = Path.Combine(AppContext.BaseDirectory, "Recursos", "avatar.jpg");
            if (File.Exists(origenAvatar) && !File.Exists(RutaFotoPorDefecto))
                File.Copy(origenAvatar, RutaFotoPorDefecto);

            if (File.Exists(RutaFotoPorDefecto))
                picFoto.BackgroundImage = Image.FromFile(RutaFotoPorDefecto);
        }

        private void CargarImagenesIniciales()
        {
            string carpetaRecursos = Path.Combine(AppContext.BaseDirectory, "Recursos");

            string imgPanel = Path.Combine(carpetaRecursos, "images.jpg");
            if (File.Exists(imgPanel))
                pnlDatos.BackgroundImage = Image.FromFile(imgPanel);

            string imgFondo = Path.Combine(carpetaRecursos, "cuadros negros-734708.png");
            if (File.Exists(imgFondo))
            {
                this.BackgroundImage = Image.FromFile(imgFondo);
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }

            string imgBoton = Path.Combine(carpetaRecursos, "floppy.png");
            if (File.Exists(imgBoton))
                btnFoto.Image = Image.FromFile(imgBoton);
        }

        // Punto 6: fuente distinta para columnas Nombre y Apellido
        private void ConfigurarGrilla()
        {
            var colNombre = new DataGridViewTextBoxColumn { Name = "colNombre", HeaderText = "Nombre" };
            var colApellido = new DataGridViewTextBoxColumn { Name = "colApellido", HeaderText = "Apellido" };
            var colDni = new DataGridViewTextBoxColumn { Name = "colDni", HeaderText = "DNI" };
            var colSexo = new DataGridViewTextBoxColumn { Name = "colSexo", HeaderText = "Sexo" };
            var colFecha = new DataGridViewTextBoxColumn { Name = "colFecha", HeaderText = "Fecha" };
            var colSaldo = new DataGridViewTextBoxColumn { Name = "colSaldo", HeaderText = "Saldo" };
            var colFoto = new DataGridViewTextBoxColumn { Name = "colFoto", HeaderText = "Foto", Visible = false };
            var colEliminar = new DataGridViewButtonColumn
            {
                Name = "colEliminar",
                HeaderText = "",
                Text = "Eliminar",
                UseColumnTextForButtonValue = true
            };

            colNombre.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            colApellido.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

            dgvDatos.Columns.AddRange(colNombre, colApellido, colDni, colSexo, colFecha, colSaldo, colFoto, colEliminar);
        }

        // Punto 5: primera letra mayuscula, resto minuscula, sin perder la posicion del cursor
        private void txtNombre_TextChanged(object sender, EventArgs e) => FormatearTitulo(txtNombre);
        private void txtApellido_TextChanged(object sender, EventArgs e) => FormatearTitulo(txtApellido);

        private static void FormatearTitulo(TextBox txt)
        {
            if (string.IsNullOrEmpty(txt.Text)) return;

            int posicionCursor = txt.SelectionStart;
            string nuevoTexto = char.ToUpper(txt.Text[0]) + txt.Text.Substring(1).ToLower();
            if (nuevoTexto != txt.Text)
            {
                txt.Text = nuevoTexto;
                txt.SelectionStart = posicionCursor;
            }
        }

        // Puntos 2, 3 y 4: elegir imagen, copiarla a la carpeta Fotos del proyecto y mostrarla
        private void btnFoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

            string origen = openFileDialog1.FileName;
            Directory.CreateDirectory(carpetaFotos);
            string destino = Path.Combine(carpetaFotos, Path.GetFileName(origen));
            File.Copy(origen, destino, overwrite: true);

            picFoto.BackgroundImage = Image.FromFile(destino);
            txtFoto.Text = destino;
        }

        // Puntos 7, 8, 10 y 11: guardar el registro en el grid
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Debe Completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sexo = rbVaron.Checked ? rbVaron.Text : rbMujer.Text;
            decimal saldo = decimal.TryParse(txtSaldo.Text, out var valor) ? valor : 0;
            string rutaFoto = string.IsNullOrEmpty(txtFoto.Text) ? RutaFotoPorDefecto : txtFoto.Text;

            int indiceFila = dgvDatos.Rows.Add(
                txtNombre.Text,
                txtApellido.Text,
                txtDni.Text,
                sexo,
                dtpFecha.Value.ToShortDateString(),
                saldo,
                rutaFoto,
                "Eliminar");

            // Punto 8: fila roja si el saldo es menor a $50
            if (saldo < 50)
                dgvDatos.Rows[indiceFila].DefaultCellStyle.BackColor = Color.Red;

            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            txtSaldo.Clear();
            txtFoto.Clear();
            rbVaron.Checked = true;
            dtpFecha.Value = DateTime.Now;

            // Punto 11: la foto por defecto se recarga automaticamente para el proximo registro
            if (File.Exists(RutaFotoPorDefecto))
                picFoto.BackgroundImage = Image.FromFile(RutaFotoPorDefecto);
        }

        // Punto 9: pide confirmacion antes de eliminar
        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvDatos.Columns[e.ColumnIndex].Name != "colEliminar") return;

            var respuesta = MessageBox.Show(
                "¿Desea eliminar este registro?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
                dgvDatos.Rows.RemoveAt(e.RowIndex);
        }

        // Punto 10: al seleccionar una fila, marca el RadioButton correspondiente y muestra su foto
        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var fila = dgvDatos.Rows[e.RowIndex];

            string sexo = fila.Cells["colSexo"].Value?.ToString() ?? "";
            rbVaron.Checked = sexo == rbVaron.Text;
            rbMujer.Checked = sexo == rbMujer.Text;

            string ruta = fila.Cells["colFoto"].Value?.ToString() ?? "";
            if (!string.IsNullOrEmpty(ruta) && File.Exists(ruta))
                picFoto.BackgroundImage = Image.FromFile(ruta);
        }
    }
}
