namespace practico2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nomYApe = new Label();
            lblModificar = new Label();
            LDni = new Label();
            LApellido = new Label();
            LNombre = new Label();
            TDni = new TextBox();
            TApellido = new TextBox();
            TNombre = new TextBox();
            btnGuardar = new Button();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // nomYApe
            // 
            nomYApe.AutoSize = true;
            nomYApe.Location = new Point(33, 28);
            nomYApe.Name = "nomYApe";
            nomYApe.Size = new Size(110, 15);
            nomYApe.TabIndex = 0;
            nomYApe.Text = "Nombre y Apellido:";
            // 
            // lblModificar
            // 
            lblModificar.AutoSize = true;
            lblModificar.ForeColor = Color.Red;
            lblModificar.Location = new Point(149, 28);
            lblModificar.Name = "lblModificar";
            lblModificar.Size = new Size(58, 15);
            lblModificar.TabIndex = 1;
            lblModificar.Text = "modificar";
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.Location = new Point(33, 86);
            LDni.Name = "LDni";
            LDni.Size = new Size(27, 15);
            LDni.TabIndex = 2;
            LDni.Text = "DNI";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(33, 131);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(51, 15);
            LApellido.TabIndex = 3;
            LApellido.Text = "Apellido";
            LApellido.UseMnemonic = false;
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(33, 175);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(51, 15);
            LNombre.TabIndex = 4;
            LNombre.Text = "Nombre";
            LNombre.UseMnemonic = false;
            // 
            // TDni
            // 
            TDni.Location = new Point(107, 83);
            TDni.Name = "TDni";
            TDni.Size = new Size(100, 23);
            TDni.TabIndex = 5;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(107, 128);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(100, 23);
            TApellido.TabIndex = 6;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(107, 175);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(100, 23);
            TNombre.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(38, 227);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(72, 25);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(135, 227);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(72, 27);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 344);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(TNombre);
            Controls.Add(TApellido);
            Controls.Add(TDni);
            Controls.Add(LNombre);
            Controls.Add(LApellido);
            Controls.Add(LDni);
            Controls.Add(lblModificar);
            Controls.Add(nomYApe);
            Name = "Form1";
            Text = "Pequeño Formulario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nomYApe;
        private Label lblModificar;
        private Label LDni;
        private Label LApellido;
        private Label LNombre;
        private TextBox TDni;
        private TextBox TApellido;
        private TextBox TNombre;
        private Button btnGuardar;
        private Button btnEliminar;
    }
}
