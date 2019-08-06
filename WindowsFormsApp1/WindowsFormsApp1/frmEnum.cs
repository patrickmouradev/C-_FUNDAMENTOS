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
    public partial class frmEnum : Form
    {
        public frmEnum()
        {
            InitializeComponent();
        }
        enum TimeEnum
        {
            São_Paulino,
            Gayvotas_da_Fiel,
            Palmeiras,
            Santos,
            Portuguesa


        }
        private void BtnOK_Click(object sender, EventArgs e)
        {
            var nome = txtNome.Text.ToLower().Trim();
            TimeEnum time;

            if (nome == "fabio" || nome == "kleber" || nome == "rossi" || nome == "vivian")
            {
                time = TimeEnum.Gayvotas_da_Fiel;
            }
            else if (nome == "patrick" || nome == "erik")
            {
                time = TimeEnum.Palmeiras;
            }
            else if (nome == "victor" || nome == "genna")
            {
                time = TimeEnum.São_Paulino;
            }
            else if (nome == "rogerio")
            {
                time = TimeEnum.Santos;
            }
            else
            {
                time = TimeEnum.Portuguesa;
            }

            switch (time)
            {
                case TimeEnum.São_Paulino:
                    txtNome.Text = $"{nome} seu time é de Baitola";
                    break;
                case TimeEnum.Gayvotas_da_Fiel:
                    txtNome.Text = $"{nome} seu time tem a maior torcida Gay";
                    break;
                case TimeEnum.Palmeiras:
                    txtNome.Text = $"{nome} Seu time Massacra";
                    break;
                case TimeEnum.Santos:
                    txtNome.Text = $"{nome} Once up an time Pelé";
                    break;
                case TimeEnum.Portuguesa:
                    txtNome.Text = $"{nome} seu time existe?";
                    break;
                default:
                    txtNome.Text = $"{nome} vai ver Show do Sandy e Junior";
                    break;
            }
            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
        }
    }
}

