using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjecteED
{
    public partial class frmPrincipal1 : Form
    {
        public frmPrincipal1()
        {
            InitializeComponent();
        }

        private void btnPolaca_Click(object sender, EventArgs e)
        {
            calculadora dlg = new calculadora();
            dlg.ShowDialog();
        }
        private void btnValidacio_Click(object sender, EventArgs e)
        {
            Form1 dlg = new Form1();
            dlg.ShowDialog();
        }
    }
}
