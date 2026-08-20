namespace practico3
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
            lblTitulo = new Label();
            nomYApe = new Label();
            lblModificar = new Label();
            pnlDatos = new Panel();
            LDni = new Label();
            TDni = new TextBox();
            LApellido = new Label();
            TApellido = new TextBox();
            LNombre = new Label();
            TNombre = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblTarjeta = new Label();
            chkNaranja = new CheckBox();
            chkVisa = new CheckBox();
            chkMastercard = new CheckBox();
            picGenero = new PictureBox();
            RBVaron = new RadioButton();
            RBMujer = new RadioButton();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnSalir = new Button();
            pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picGenero).BeginInit();
            SuspendLayout();
            //
            // lblTitulo
            //
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.RoyalBlue;
            lblTitulo.Location = new Point(150, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(200, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Nuevo Cliente";
            //
            // nomYApe
            //
            nomYApe.AutoSize = true;
            nomYApe.Location = new Point(20, 65);
            nomYApe.Name = "nomYApe";
            nomYApe.Size = new Size(110, 15);
            nomYApe.TabIndex = 1;
            nomYApe.Text = "Nombre y Apellido:";
            //
            // lblModificar
            //
            lblModificar.AutoSize = true;
            lblModificar.ForeColor = Color.Red;
            lblModificar.Location = new Point(136, 65);
            lblModificar.Name = "lblModificar";
            lblModificar.Size = new Size(58, 15);
            lblModificar.TabIndex = 2;
            lblModificar.Text = "modificar";
            //
            // pnlDatos
            //
            pnlDatos.BackColor = Color.LightSteelBlue;
            pnlDatos.Controls.Add(LDni);
            pnlDatos.Controls.Add(TDni);
            pnlDatos.Controls.Add(LApellido);
            pnlDatos.Controls.Add(TApellido);
            pnlDatos.Controls.Add(LNombre);
            pnlDatos.Controls.Add(TNombre);
            pnlDatos.Controls.Add(lblTelefono);
            pnlDatos.Controls.Add(txtTelefono);
            pnlDatos.Controls.Add(lblTarjeta);
            pnlDatos.Controls.Add(chkNaranja);
            pnlDatos.Controls.Add(chkVisa);
            pnlDatos.Controls.Add(chkMastercard);
            pnlDatos.Location = new Point(20, 95);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(300, 260);
            pnlDatos.TabIndex = 3;
            //
            // LDni
            //
            LDni.AutoSize = true;
            LDni.Location = new Point(10, 15);
            LDni.Name = "LDni";
            LDni.Size = new Size(37, 15);
            LDni.TabIndex = 0;
            LDni.Text = "* DNI";
            //
            // TDni
            //
            TDni.Location = new Point(90, 12);
            TDni.Name = "TDni";
            TDni.Size = new Size(100, 23);
            TDni.TabIndex = 1;
            TDni.KeyPress += TDni_KeyPress;
            //
            // LApellido
            //
            LApellido.AutoSize = true;
            LApellido.Location = new Point(10, 50);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(61, 15);
            LApellido.TabIndex = 2;
            LApellido.Text = "* Apellido";
            //
            // TApellido
            //
            TApellido.Location = new Point(90, 47);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(100, 23);
            TApellido.TabIndex = 3;
            TApellido.KeyPress += TApellido_KeyPress;
            //
            // LNombre
            //
            LNombre.AutoSize = true;
            LNombre.Location = new Point(10, 85);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(61, 15);
            LNombre.TabIndex = 4;
            LNombre.Text = "* Nombre";
            //
            // TNombre
            //
            TNombre.Location = new Point(90, 82);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(100, 23);
            TNombre.TabIndex = 5;
            TNombre.KeyPress += TNombre_KeyPress;
            //
            // lblTelefono
            //
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(10, 120);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(58, 15);
            lblTelefono.TabIndex = 6;
            lblTelefono.Text = "Telefono";
            //
            // txtTelefono
            //
            txtTelefono.Location = new Point(90, 117);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(180, 23);
            txtTelefono.TabIndex = 7;
            //
            // lblTarjeta
            //
            lblTarjeta.AutoSize = true;
            lblTarjeta.Location = new Point(10, 155);
            lblTarjeta.Name = "lblTarjeta";
            lblTarjeta.Size = new Size(110, 15);
            lblTarjeta.TabIndex = 8;
            lblTarjeta.Text = "Tarjeta de creditos:";
            //
            // chkNaranja
            //
            chkNaranja.AutoSize = true;
            chkNaranja.Location = new Point(25, 180);
            chkNaranja.Name = "chkNaranja";
            chkNaranja.Size = new Size(76, 19);
            chkNaranja.TabIndex = 9;
            chkNaranja.Text = "Naranja";
            //
            // chkVisa
            //
            chkVisa.AutoSize = true;
            chkVisa.Location = new Point(25, 205);
            chkVisa.Name = "chkVisa";
            chkVisa.Size = new Size(50, 19);
            chkVisa.TabIndex = 10;
            chkVisa.Text = "Visa";
            //
            // chkMastercard
            //
            chkMastercard.AutoSize = true;
            chkMastercard.Location = new Point(25, 230);
            chkMastercard.Name = "chkMastercard";
            chkMastercard.Size = new Size(96, 19);
            chkMastercard.TabIndex = 11;
            chkMastercard.Text = "Mastercard";
            //
            // picGenero
            //
            picGenero.BackColor = Color.WhiteSmoke;
            picGenero.BackgroundImageLayout = ImageLayout.Zoom;
            picGenero.BorderStyle = BorderStyle.FixedSingle;
            picGenero.Location = new Point(340, 95);
            picGenero.Name = "picGenero";
            picGenero.Size = new Size(140, 140);
            picGenero.TabIndex = 4;
            picGenero.TabStop = false;
            //
            // RBVaron
            //
            RBVaron.AutoSize = true;
            RBVaron.Checked = true;
            RBVaron.Location = new Point(340, 245);
            RBVaron.Name = "RBVaron";
            RBVaron.Size = new Size(58, 19);
            RBVaron.TabIndex = 5;
            RBVaron.TabStop = true;
            RBVaron.Text = "Varon";
            RBVaron.CheckedChanged += RBVaron_CheckedChanged;
            //
            // RBMujer
            //
            RBMujer.AutoSize = true;
            RBMujer.Location = new Point(410, 245);
            RBMujer.Name = "RBMujer";
            RBMujer.Size = new Size(59, 19);
            RBMujer.TabIndex = 6;
            RBMujer.Text = "Mujer";
            RBMujer.CheckedChanged += RBMujer_CheckedChanged;
            //
            // btnGuardar
            //
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(20, 375);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(110, 32);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            //
            // btnEliminar
            //
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(140, 375);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(110, 32);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            //
            // btnSalir
            //
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(260, 375);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(110, 32);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.TextAlign = ContentAlignment.MiddleRight;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 440);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(RBMujer);
            Controls.Add(RBVaron);
            Controls.Add(picGenero);
            Controls.Add(pnlDatos);
            Controls.Add(lblModificar);
            Controls.Add(nomYApe);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Pequeño Formulario";
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picGenero).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label nomYApe;
        private Label lblModificar;
        private Panel pnlDatos;
        private Label LDni;
        private TextBox TDni;
        private Label LApellido;
        private TextBox TApellido;
        private Label LNombre;
        private TextBox TNombre;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblTarjeta;
        private CheckBox chkNaranja;
        private CheckBox chkVisa;
        private CheckBox chkMastercard;
        private PictureBox picGenero;
        private RadioButton RBVaron;
        private RadioButton RBMujer;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnSalir;
    }
}
