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

        private void NumberOnClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                pantalla.Text += btn.Text;
                nums.Add(btn.Text);

            }
        }
        private void OperatorOnClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && pantalla.Text.Length > 0)
            {
                string operador = btn.Text;

                string ultimo = pantalla.Text[pantalla.Text.Length - 1].ToString();
                if (ultimo == "+" || ultimo == "-" || ultimo == "*" || ultimo == "/")
                {

                    pantalla.Text = pantalla.Text.Substring(0, pantalla.Text.Length - 1) + operador;
                    nums.RemoveAt(nums.Count - 1); 
                }
                else
                {

                    pantalla.Text += operador;
                    nums.Add(operador);
                }
            }
        }

        private void Calcular()
        {
            Pila<string> calculadora = new Pila<string>(nums);
            Pila<int> aux = new Pila<int>();
            int final = 0;
            int resultado = 0;
            int a = 0; int b = 0;

            string contenidoCalculadora = string.Join(", ", calculadora.ToArray());

            while (!calculadora.IsEmpty)
            {
                string caracter = calculadora.Pop();

                a = int.Parse(calculadora.Pop());
                b = int.Parse(calculadora.Pop());
                switch (caracter)
                {
                    case "+":
                        resultado = a + b;
                        break;
                    case "-":
                        resultado = a - b;
                        break;
                    case "*":
                        resultado = a * b;
                        break;
                    case "/":
                        if (b == 0)
                        {
                            MessageBox.Show("Error: División por cero.");
                            return;
                        }
                        resultado = a / b;
                        break;
                    default:
                        MessageBox.Show("Operador no válido.");
                        return;
                }
                calculadora.Push(resultado.ToString());
                
            }
            pantalla.Text = resultado.ToString();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pantalla_TextChanged(object sender, EventArgs e)
        {

        }

        private void rentar_Click(object sender, EventArgs e)
        {
            pantalla.Text = "";
            nums.Clear();
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            if (pantalla.Text.Length > 0)
            {
                pantalla.Text = pantalla.Text.Substring(0, pantalla.Text.Length - 1);

                if (nums.Count > 0)
                {
                    nums.RemoveAt(nums.Count - 1);
                }
            }
        }

        private void total_Click(object sender, EventArgs e)
        {
            Calcular();
        }
    }
}
