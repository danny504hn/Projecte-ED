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
    public partial class calculadora : Form
    {
        TaulaLlista<string> nums = new TaulaLlista<string>();
        public calculadora()
        {
            InitializeComponent();
            pantalla.TextAlign = HorizontalAlignment.Right;
            pantalla.Enabled = false;
        }

        private void NumberOnClick(object sender,EventArgs e)
        {
            Button btn = sender as Button;
            if(btn != null)
            {
                pantalla.Text += btn.Text;
                nums.Add(btn.Text);
            }
        }
        private void Calcular()
        {
            Pila<string> calculadora = new Pila<string>(nums);

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numZero_Click(object sender, EventArgs e)
        {
        }
        
        private void pantalla_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
