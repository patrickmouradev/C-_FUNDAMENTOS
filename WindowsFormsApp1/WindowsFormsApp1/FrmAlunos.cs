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
    public partial class FrmAlunos : Form
    {
        string[] alunos = new string[8];
        public FrmAlunos()
        {
            InitializeComponent();

            
            alunos[0] = "Rossi";
            alunos[1] = "Patrick";
            alunos[2] = "Erik";
            alunos[3] = "Genna";
            alunos[4] = "Victor";
            alunos[5] = "Vivian";
            alunos[6] = "Fabio";
            alunos[7] = "Rogerio";

            lstAluno.DataSource = alunos;

            

        }

    

        private void FrmAlunos_Load(object sender, EventArgs e)
        {

        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            string[] listaFiltrada = new string[0];
            int i = 0;
            foreach (var aluno in alunos)
            {
                if (aluno.ToLower().Contains(txtFiltroNome.Text.ToLower()))
                {

                    Array.Resize(ref listaFiltrada, listaFiltrada.Length + 1);
                    listaFiltrada[i] = aluno;
                    i++;

                }
            }

            
            lstAluno.DataSource = listaFiltrada;
        }
    }
}
