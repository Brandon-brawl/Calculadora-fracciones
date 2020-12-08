using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_fracciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LblCalcularResultado_Click(object sender, EventArgs e)
        {
            fraccion f1 = new fraccion((int)NumEntero1.Value, (int)NumNumerador1.Value, (int)NumDenominador1.Value);
            fraccion f2 = new fraccion((int)NumEntero2.Value, (int)NumNumerador2.Value, (int)NumDenominador2.Value);
            fraccion resultado = null;
            switch (cboOperaccione.Text)
            {
                case "+":
                     resultado = f1.Sumar(f2);
                    break;
                case "-":
                     resultado = f1.Restar(f2);
                    break;
                case "x":
                     resultado = f1.Multiplicar(f2);
                    break;
                case "/":
                     resultado = f1.Dividir(f2);
                    break;
                default:
                    MessageBox.Show("falta seleccionar la operacion", " error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;


            }
            LblLinea.Text = "___________";
            if (resultado.Entero == 0)
            {
                LblEnteroRe.Text = "";
            }
            else
            {
                LblEnteroRe.Text = resultado.Entero + "";
            }
            if (resultado.Numerador == 0)
            {
                LblNumeradorRe.Text = "";
                LblDenominadorRe.Text = "";
                LblLinea.Text = "";
            }
            else
            {
                LblNumeradorRe.Text = resultado.Numerador + "";
                LblDenominadorRe.Text = resultado.Denominador + "";
            }


            //LblNumeradorRe.Text = resultado.ToString();

        }
    }
}
