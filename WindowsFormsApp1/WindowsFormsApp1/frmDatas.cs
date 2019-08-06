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
    public partial class frmDatas : Form
    {
        public frmDatas()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            txtData.Text = string.Empty;
            txtDias.Text = string.Empty;
            txtMeses.Text = string.Empty;
            lblQtDias.Text = string.Empty;
            lblQtdMeses.Text = string.Empty;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            var datadias = Convert.ToDateTime(txtData.Text);
            datadias = datadias.AddDays(Convert.ToInt32(txtDias.Text));
            lblQtDias.Text = datadias.ToString("dd-MM-yy");

            var datameses = Convert.ToDateTime(txtData.Text);
            datameses = datameses.AddMonths(Convert.ToInt32(txtMeses.Text));
            lblQtdMeses.Text = datameses.ToString("dd-MM-yy");
            
        }
    }
}
