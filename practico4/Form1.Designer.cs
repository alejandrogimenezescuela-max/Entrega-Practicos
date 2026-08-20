namespace practico4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlDatos = new Panel();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblDni = new Label();
            txtDni = new TextBox();
            lblSaldo = new Label();
            txtSaldo = new TextBox();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            lblSexo = new Label();
            rbVaron = new RadioButton();
            rbMujer = new RadioButton();
            lblFoto = new Label();
            txtFoto = new TextBox();
            btnFoto = new Button();
            picFoto = new PictureBox();
            btnGuardar = new Button();
            dgvDatos = new DataGridView();
            openFileDialog1 = new OpenFileDialog();
            pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            //
            // pnlDatos
            //
            pnlDatos.BackgroundImageLayout = ImageLayout.Stretch;
            pnlDatos.Controls.Add(lblNombre);
            pnlDatos.Controls.Add(txtNombre);
            pnlDatos.Controls.Add(lblApellido);
            pnlDatos.Controls.Add(txtApellido);
            pnlDatos.Controls.Add(lblFecha);
            pnlDatos.Controls.Add(dtpFecha);
            pnlDatos.Controls.Add(lblSexo);
            pnlDatos.Controls.Add(rbVaron);
            pnlDatos.Controls.Add(rbMujer);
            pnlDatos.Controls.Add(lblDni);
            pnlDatos.Controls.Add(txtDni);
            pnlDatos.Controls.Add(lblSaldo);
            pnlDatos.Controls.Add(txtSaldo);
            pnlDatos.Controls.Add(lblFoto);
            pnlDatos.Controls.Add(btnFoto);
            pnlDatos.Controls.Add(txtFoto);
            pnlDatos.Font = new Font("Papyrus", 16F);
            pnlDatos.ForeColor = Color.White;
            pnlDatos.Location = new Point(20, 20);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(620, 300);
            pnlDatos.TabIndex = 0;
            //
            // lblNombre
            //
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Location = new Point(15, 15);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(90, 30);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            //
            // txtNombre
            //
            txtNombre.Font = new Font("Segoe UI", 9F);
            txtNombre.ForeColor = Color.Black;
            txtNombre.Location = new Point(280, 14);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(310, 23);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += txtNombre_TextChanged;
            //
            // lblApellido
            //
            lblApellido.AutoSize = true;
            lblApellido.BackColor = Color.Transparent;
            lblApellido.Location = new Point(15, 57);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(96, 30);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido:";
            //
            // txtApellido
            //
            txtApellido.Font = new Font("Segoe UI", 9F);
            txtApellido.ForeColor = Color.Black;
            txtApellido.Location = new Point(280, 56);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(310, 23);
            txtApellido.TabIndex = 3;
            txtApellido.TextChanged += txtApellido_TextChanged;
            //
            // lblFecha
            //
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.Transparent;
            lblFecha.Location = new Point(15, 99);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(210, 30);
            lblFecha.TabIndex = 4;
            lblFecha.Text = "Fecha Nacimiento:";
            //
            // dtpFecha
            //
            dtpFecha.Font = new Font("Segoe UI", 9F);
            dtpFecha.ForeColor = Color.Black;
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(280, 98);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(180, 23);
            dtpFecha.TabIndex = 5;
            //
            // lblSexo
            //
            lblSexo.AutoSize = true;
            lblSexo.BackColor = Color.Transparent;
            lblSexo.Location = new Point(15, 141);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(64, 30);
            lblSexo.TabIndex = 6;
            lblSexo.Text = "Sexo:";
            //
            // rbVaron
            //
            rbVaron.AutoSize = true;
            rbVaron.BackColor = Color.Transparent;
            rbVaron.Checked = true;
            rbVaron.Font = new Font("Segoe UI", 9F);
            rbVaron.Location = new Point(280, 144);
            rbVaron.Name = "rbVaron";
            rbVaron.Size = new Size(58, 19);
            rbVaron.TabIndex = 7;
            rbVaron.TabStop = true;
            rbVaron.Text = "Varon";
            //
            // rbMujer
            //
            rbMujer.AutoSize = true;
            rbMujer.BackColor = Color.Transparent;
            rbMujer.Font = new Font("Segoe UI", 9F);
            rbMujer.Location = new Point(370, 144);
            rbMujer.Name = "rbMujer";
            rbMujer.Size = new Size(59, 19);
            rbMujer.TabIndex = 8;
            rbMujer.Text = "Mujer";
            //
            // lblDni
            //
            lblDni.AutoSize = true;
            lblDni.BackColor = Color.Transparent;
            lblDni.Location = new Point(15, 183);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(60, 30);
            lblDni.TabIndex = 9;
            lblDni.Text = "DNI:";
            //
            // txtDni
            //
            txtDni.Font = new Font("Segoe UI", 9F);
            txtDni.ForeColor = Color.Black;
            txtDni.Location = new Point(280, 182);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(150, 23);
            txtDni.TabIndex = 10;
            //
            // lblSaldo
            //
            lblSaldo.AutoSize = true;
            lblSaldo.BackColor = Color.Transparent;
            lblSaldo.Location = new Point(15, 225);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(78, 30);
            lblSaldo.TabIndex = 11;
            lblSaldo.Text = "Saldo:";
            //
            // txtSaldo
            //
            txtSaldo.Font = new Font("Segoe UI", 9F);
            txtSaldo.ForeColor = Color.Black;
            txtSaldo.Location = new Point(280, 224);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(150, 23);
            txtSaldo.TabIndex = 12;
            //
            // lblFoto
            //
            lblFoto.AutoSize = true;
            lblFoto.BackColor = Color.Transparent;
            lblFoto.Location = new Point(15, 267);
            lblFoto.Name = "lblFoto";
            lblFoto.Size = new Size(70, 30);
            lblFoto.TabIndex = 13;
            lblFoto.Text = "Foto:";
            //
            // btnFoto
            //
            btnFoto.Font = new Font("Segoe UI", 9F);
            btnFoto.ForeColor = Color.Black;
            btnFoto.ImageAlign = ContentAlignment.MiddleLeft;
            btnFoto.Location = new Point(280, 264);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(90, 28);
            btnFoto.TabIndex = 14;
            btnFoto.Text = "Foto";
            btnFoto.TextAlign = ContentAlignment.MiddleRight;
            btnFoto.UseVisualStyleBackColor = true;
            btnFoto.Click += btnFoto_Click;
            //
            // txtFoto
            //
            txtFoto.Font = new Font("Segoe UI", 9F);
            txtFoto.ForeColor = Color.Black;
            txtFoto.Location = new Point(380, 267);
            txtFoto.Name = "txtFoto";
            txtFoto.ReadOnly = true;
            txtFoto.Size = new Size(220, 23);
            txtFoto.TabIndex = 15;
            //
            // picFoto
            //
            picFoto.BackColor = Color.WhiteSmoke;
            picFoto.BackgroundImageLayout = ImageLayout.Zoom;
            picFoto.BorderStyle = BorderStyle.FixedSingle;
            picFoto.Location = new Point(660, 20);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(220, 300);
            picFoto.TabIndex = 1;
            picFoto.TabStop = false;
            //
            // btnGuardar
            //
            btnGuardar.Location = new Point(400, 335);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(120, 35);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            //
            // dgvDatos
            //
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(20, 390);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowTemplate.Height = 25;
            dgvDatos.Size = new Size(860, 270);
            dgvDatos.TabIndex = 3;
            dgvDatos.CellClick += dgvDatos_CellClick;
            dgvDatos.CellContentClick += dgvDatos_CellContentClick;
            //
            // openFileDialog1
            //
            openFileDialog1.Filter = "Archivos Imagenes|*.jpg|Archivos Imagenes|*.bmp|Archivos Imagenes|*.png";
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 690);
            Controls.Add(dgvDatos);
            Controls.Add(btnGuardar);
            Controls.Add(picFoto);
            Controls.Add(pnlDatos);
            Name = "Form1";
            Text = "Formulario con Grid";
            Load += Form1_Load;
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDatos;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblDni;
        private TextBox txtDni;
        private Label lblSaldo;
        private TextBox txtSaldo;
        private Label lblFecha;
        private DateTimePicker dtpFecha;
        private Label lblSexo;
        private RadioButton rbVaron;
        private RadioButton rbMujer;
        private Label lblFoto;
        private TextBox txtFoto;
        private Button btnFoto;
        private PictureBox picFoto;
        private Button btnGuardar;
        private DataGridView dgvDatos;
        private OpenFileDialog openFileDialog1;
    }
}
