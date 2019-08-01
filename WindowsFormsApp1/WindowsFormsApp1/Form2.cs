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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            bool valido = true;
            if (txtNome.Text == string.Empty)
            {
                MessageBox.Show("Preencer o Nome", "erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                valido = false;
            }
            if (txtSobrenome.Text == string.Empty)
            {
                MessageBox.Show("Preencer o Sobre Nome", "erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                valido = false;
            }
            if (txtDtNascimento.Text == string.Empty)
            {
                MessageBox.Show("Preencer a data de Nascimento", "erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                valido = false;
            }

            if (valido == false)
            {
                return;
            }
            
            string nome, sobrenome;
            DateTime dataNascimento;

            nome = txtNome.Text;
            sobrenome = txtSobrenome.Text;
            dataNascimento = Convert.ToDateTime(txtDtNascimento.Text);



            

            MessageBox.Show($"Nome: {nome} Sobrenome: {sobrenome} Data de Nascimento: {dataNascimento}");
        }

        private void TxtDtNascimento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
//