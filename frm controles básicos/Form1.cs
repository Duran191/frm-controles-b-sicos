using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm_controles_básicos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblVarlorUno_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textvalor1.Clear();
            textValor2.Clear();
            textSuma.Clear();
            textResta.Clear();
            textMultiplicacion.Clear();
            textDivision.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Declaración de variables 
            double v1, v2, suma, resta, multiplicacion, divide;
            //entrada de datos
            v1 = Convert.ToDouble(textvalor1.Text);
            v2 = Convert.ToDouble(textValor2.Text);

            //Proceso
            suma = v1 + v2;
            resta = v1 - v2;
            multiplicacion = v1 * v2;
            divide = v1 / v2;
            //Salida de la informacion 
            textSuma.Text = suma.ToString();
            textResta.Text = resta.ToString();
            textMultiplicacion.Text = multiplicacion.ToString();
            textDivision.Text = divide.ToString();

        }

        private void lblSuma_Click(object sender, EventArgs e)
        {

        }

        private void textResta_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textMultiplicacion_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textDivision_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
