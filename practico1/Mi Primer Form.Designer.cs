namespace practico1
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
            apellido = new Label();
            nombreLabel = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            textBox1 = new TextBox();
            btnGuardar = new Button();
            btnEliminar = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // apellido
            // 
            apellido.AutoSize = true;
            apellido.Location = new Point(27, 49);
            apellido.Name = "apellido";
            apellido.Size = new Size(51, 15);
            apellido.TabIndex = 0;
            apellido.Text = "Apellido";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new Point(27, 95);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(51, 15);
            nombreLabel.TabIndex = 1;
            nombreLabel.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(84, 95);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 2;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(84, 46);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 3;
            txtApellido.TextChanged += txtApellido_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(235, 29);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 220);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(27, 141);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(109, 141);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(64, 226);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 261);
            Controls.Add(button1);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(textBox1);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(nombreLabel);
            Controls.Add(apellido);
            Name = "Form1";
            Text = "Mi Primer Forms";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label apellido;
        private Label nombreLabel;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox textBox1;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button button1;
    }
}
