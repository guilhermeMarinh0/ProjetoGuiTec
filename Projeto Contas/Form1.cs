using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Contas
{
    public partial class Contas : Form
    {
        public Contas()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtn1.Clear();
            txtn1.Clear();
            lblresultado.Text = "";
            txtn1.Focus();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {

            Double n1=0, n2=0, resultado = 0;
            n1 = double.Parse(txtn1.Text);
            n2= double.Parse(txtn2.Text);

            if (rbtnadicao.Checked == true)
            {
                resultado = n1 + n2;
                lblresultado.Text = "O resultado da Adição é: " + resultado.ToString();
            }
            else if (rbtnsubtracao.Checked == true)
            {
                resultado = n1 - n2;
                lblresultado.Text = "O resultado da Subtração é: " + resultado.ToString();
            }
            else if (rbtndivisao.Checked == true)
            {
                resultado = n1 / n2;
                lblresultado.Text = "O resultado da Divisão é: " + resultado.ToString();
            }
            else if (rbtnmultiplicacao.Checked == true) 
            {
                resultado = n1 * n2;
                lblresultado.Text = "O resultado da Multiplicação é: " + resultado.ToString();
            }
            else 
            {
                lblresultado.Text = "Escolha uma Das Opções";
            }
        }
    }
}
