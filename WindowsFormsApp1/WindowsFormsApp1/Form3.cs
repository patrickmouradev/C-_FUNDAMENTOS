using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            int valorInteiro;
            decimal valorDecimal;
            DateTime data;

            valorInteiro = Convert.ToInt32(txtValorInteiro.Text);
            valorDecimal = Convert.ToDecimal(txtValorDecimais.Text);
            data = Convert.ToDateTime(txtData.Text);


        }

        private void BtnSomar_Click(object sender, EventArgs e)
        {
            int valorInteiro;
            decimal valorDecimal, resultado;

            valorInteiro = Convert.ToInt32(txtValorInteiro.Text);
            valorDecimal = Convert.ToDecimal(txtValorDecimais.Text);

            resultado = valorDecimal + valorInteiro;

            MessageBox.Show($"O Resultado da Soma é:{resultado}");
        }

        private void BtnSubtrair_Click(object sender, EventArgs e)
        {
            int valorInteiro;
            decimal valorDecimal, resultado;

            valorInteiro = Convert.ToInt32(txtValorInteiro.Text);
            valorDecimal = Convert.ToDecimal(txtValorDecimais.Text);

            resultado = valorInteiro -valorDecimal;

            MessageBox.Show($"O Resultado da Subtração é:{resultado}");
        }

        private void BtnFormula_Click(object sender, EventArgs e)
        {
            int valorInteiro;
            decimal valorDecimal, resultado,multiplicador;

            valorInteiro = Convert.ToInt32(txtValorInteiro.Text);
            valorDecimal = Convert.ToDecimal(txtValorDecimais.Text);

            multiplicador = 1.5M;
            resultado = valorInteiro / valorDecimal * multiplicador;

            MessageBox.Show($"O Resultado é: {resultado}","Resultado",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}
