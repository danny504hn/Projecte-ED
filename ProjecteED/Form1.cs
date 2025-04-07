using ProjecteED.Interficies;

namespace ProjecteED
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtExpressio_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblExpressio_Click(object sender, EventArgs e)
        {

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (Compilador.Validar(txtExpressio.Text)) MessageBox.Show("VÀLID", "Pestanya validar");
            else MessageBox.Show("NO VÀLID", "Pestanya validar");
        }
    }
}
