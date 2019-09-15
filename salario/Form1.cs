using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double hT, vH;
            hT = double.Parse(txthorastrabajadas.Text);
            vH = double.Parse(txtvalorhora.Text);
           
            double resultado, salarioFinal;
            resultado = vH * hT;
            if (resultado < 700000)
            {
                salarioFinal = resultado-(resultado * 0.10);
                txtsalariofinal.Text = salarioFinal.ToString();
                lbldescuento.Text = "incremento del 10%";
            }
            else if (resultado < 1000000)
            {
                salarioFinal = resultado-(resultado*0.2);
                txtsalariofinal.Text = salarioFinal.ToString();
                lbldescuento.Text = "descuento del 2%";
            }
            else
            {
                salarioFinal = resultado-(resultado*0.3);
                txtsalariofinal.Text = salarioFinal.ToString();
                lbldescuento.Text = "descuento de 5%  //  incremento de 2%";
            }
        }
    }
}
