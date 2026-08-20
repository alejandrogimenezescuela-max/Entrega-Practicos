namespace practico3
{
    public partial class MDIParent1 : Form
    {
        public MDIParent1()
        {
            InitializeComponent();
        }

        // Punto 10: abre el formulario chico como hijo del MDI
        // Punto 11: al asignar MdiParent, el formulario no puede salir del MDIParent1
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 pequenoFormulario = new Form1();
            pequenoFormulario.MdiParent = this;
            pequenoFormulario.Show();
        }
    }
}
