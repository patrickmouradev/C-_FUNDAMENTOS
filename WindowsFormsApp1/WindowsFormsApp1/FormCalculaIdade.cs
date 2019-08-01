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
    public partial class FormCalculaIdade : Form
    {
        public FormCalculaIdade()
        {
            InitializeComponent();
        }

        private void BtCalcula_Click(object sender, EventArgs e)
        {
            DateTime dataNascimento = DateTime.Parse(txtDtNascimento.Text);

            int idade = DateTime.Today.Year - dataNascimento.Year;

            if (DateTime.Today.Month < dataNascimento.Month)
            {
                idade--;
            }

            MessageBox.Show(idade.ToString());
        }

    }
}
