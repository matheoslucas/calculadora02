using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        double valor1, valor2;
        string op;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "")
            {
                txtPantalla.Text = "1";



            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "1";

            }
               
              
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "")
            {
                txtPantalla.Text = "2";



            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "2";

            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "")
            {
                txtPantalla.Text = "3";



            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "3";

            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "")
            {
                txtPantalla.Text = "4";



            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "4";

            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "")
            {
                txtPantalla.Text = "5";



            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "5";

            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "")
            {
                txtPantalla.Text = "6";



            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "6";

            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "")
            {
                txtPantalla.Text = "7";



            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "7";

            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "")
            {
                txtPantalla.Text = "8";



            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "8";

            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "")
            {
                txtPantalla.Text = "9";



            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "9";
            }

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            valor1 = 0;
            valor2 = 0;
            txtPantalla.Clear();
            txtPantalla.Focus();

        }

        private void btn_divisão_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(txtPantalla.Text);
            op = "/";
            txtPantalla.Clear();
            txtPantalla.Focus();



        }

        private void btn_multiplicação_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(txtPantalla.Text);
            op = "*";
            txtPantalla.Clear();
            txtPantalla.Focus();

        }

        private void btn_adição_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(txtPantalla.Text);
            op = "+";
            txtPantalla.Clear();
            txtPantalla.Focus();

        }

        private void btn_subtração_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(txtPantalla.Text);
            op = "-";
            txtPantalla.Clear();
            txtPantalla.Focus();

        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            valor2 = Convert.ToDouble(txtPantalla.Text);
            switch(op)
            {
                case "+": txtPantalla.Text = Convert.ToString(valor1 + valor2); break;
                case "-": txtPantalla.Text = Convert.ToString(valor1 - valor2); break;
                case "*": txtPantalla.Text = Convert.ToString(valor1 * valor2); break;
                case "/": txtPantalla.Text = Convert.ToString(valor1 / valor2); break;
            }
        }

        private void txtPantalla_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPantalla_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "")
            {
                txtPantalla.Text = "0";



            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "0";

            }
        }
    }
    }

