using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adefinir
{
    public partial class InterfaceCalculadora : Form
    {
        string Operador;
        int a = 0;
        bool Validar = false;
        public InterfaceCalculadora()
        {
            InitializeComponent();
        }

        private void btnNumerador_Click(object sender, EventArgs e)
        {
            Button BT = (Button)sender;
            txtResultado.Text = txtResultado.Text + BT.Text;
         

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            label1.Text = "";
            a = 0;
            Validar = false;
            label1.Text = "0";
           
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            if(Validar == true)
            {

                a = a - Convert.ToInt32(txtResultado.Text);
                label1.Text = Convert.ToString(a) + "+";
                txtResultado.Text = "";
                Operador = "+";
            }
            else
            {
                label1.Text = txtResultado.Text + btnSomar.Text;
                a = Convert.ToInt32(txtResultado.Text);
                txtResultado.Text = "";
                Operador = "+";
                Validar = true;
            }
        }

        private void btnDiminuir_Click(object sender, EventArgs e)
        {
            if (Validar == true)
            {
                a = a - Convert.ToInt32(txtResultado.Text);
                label1.Text = Convert.ToString(a) + "-";
                txtResultado.Text = "";
                Operador = "-";

            }
            else
            {
                label1.Text = txtResultado.Text + btnDiminuir.Text;
                a = Convert.ToInt32(txtResultado.Text);
                txtResultado.Text = "";
                Operador = "-";
                Validar = true;
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (Validar == true)
            {
                a = a * Convert.ToInt32(txtResultado.Text);
                label1.Text = Convert.ToString(a) + "*";
                txtResultado.Text = "";
                Operador = "*";

            }
            else
            {
                label1.Text = txtResultado.Text + btnMultiplicar.Text;
                a = Convert.ToInt32(txtResultado.Text);
                txtResultado.Text = "";
                Operador = "*";
                Validar = true;
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (Validar == true)
            {
                a = a / Convert.ToInt32(txtResultado.Text);
                label1.Text = Convert.ToString(a) + "/";
                txtResultado.Text = "";
                Operador = "/";

            }
            else
            {
                label1.Text = txtResultado.Text + btnDividir.Text;
                a = Convert.ToInt32(txtResultado.Text);
                txtResultado.Text = "";
                Operador = "/";
                Validar = true;
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            
           if (Operador == "-" )
            {
                label1.Text = label1.Text + txtResultado.Text + "=";
                txtResultado.Text = Convert.ToString(a - Convert.ToInt32(txtResultado.Text));

            }
           else if(Operador == "+")
            {
                label1.Text = label1.Text + txtResultado.Text + "=";
                txtResultado.Text = Convert.ToString(a + Convert.ToInt32(txtResultado.Text));

            }
            else if(Operador == "*")
            {
                label1.Text = label1.Text + txtResultado.Text + "=";
                txtResultado.Text = Convert.ToString(a * Convert.ToInt32(txtResultado.Text));

            }
           else if(Operador == "/")
            {
                label1.Text = label1.Text + txtResultado.Text + "=";
                txtResultado.Text = Convert.ToString(a / Convert.ToInt32(txtResultado.Text));
                


            }
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
