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
    public partial class FrmPoupanca : Form
    {
        public FrmPoupanca()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            DateTime previsaoSaque = Convert.ToDateTime(txtPrvSaque.Text);
            decimal totalmeses = Convert.ToInt32((previsaoSaque - DateTime.Today).TotalDays / 30);
            decimal taxa = 0.37M /100, saldo;
            string nome = txtNome.Text;
            saldo = Convert.ToDecimal(txtSaldo.Text);
                                  
            for (int i = 0; i < totalmeses; i++)
            {
                saldo += (saldo * taxa);
            }
            MessageBox.Show($"O Saldo será: {(saldo).ToString("C")}");

        }
    }
}
