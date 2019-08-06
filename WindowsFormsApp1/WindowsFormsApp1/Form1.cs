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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teste Botão 1");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string nome = "Patrick", sobrenome = "Moura", nomeCompleto;

            nomeCompleto = $"Nome:{nome} Sobrenome:{sobrenome}";

            MessageBox.Show(nomeCompleto);
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int numerosInteiros;
            string tipoTexto;
            decimal numeroDecimal;
            double numedoDecimalMenor;
            short numeroInteiroMenor;
            byte numeroInteiromenor;
            DateTime dataHora;
            bool verdadeiroouFalso;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void BtnChamarForm3_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }

        private void BtnChamaForm4_Click(object sender, EventArgs e)
        {
            new FrmPoupanca().Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            new FormCalculaIdade().Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            new frmDatas().Show();
        }

        private void BtnChamafrmArray_Click(object sender, EventArgs e)
        {
            new frmArray().Show();
        }
    }
}
