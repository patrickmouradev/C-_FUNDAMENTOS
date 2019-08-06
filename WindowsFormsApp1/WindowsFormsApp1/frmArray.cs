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
    public partial class frmArray : Form
    {
        public frmArray()
        {
            InitializeComponent();
        }
        string[] alunos = new string[8];
        private void BtnOK_Click(object sender, EventArgs e)
        {

            //     alunos[0] = "Rossi";
            //     alunos[1] = "Patrick";
            //     alunos[2] = "Erik";
            //     alunos[3] = "Genna";
            //     alunos[4] = "Victor";
            //     alunos[5] = "Vivian";
            //     alunos[6] = "Fabio";
            //     alunos[7] = "Rogerio";
            //
            //     lblTamanhoArray.Text = alunos.Length.ToString();


            for (int i = 0; i < alunos.Length; i++)
            {
                if (alunos[1] == null)
                {
                    alunos[i] = txtNome.Text;
                    lblTamanhoArray.Text += $"{txtNome.Text} \r\n";
                    txtNome.Text = string.Empty;
                    break;
                }

            }
        }
    }
}
