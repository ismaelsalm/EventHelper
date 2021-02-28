using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventHelper.Janelas
{
    public partial class SalaInfo : Form
    {
        string stdetails = "{0,-10}{1,10}";
        public SalaInfo(SalaComum sc)
        {

            InitializeComponent();
            lst_participantesSala.Items.Clear();
            foreach (var item in sc.participantes)
            {
                lst_participantesSala.Items.Add(String.Format(stdetails, item.Nome, item.Sobrenome));
            }
            lbl_nome.Text = sc.salaref.nome;
            lbl_lotacao.Text = sc.salaref.lotacao.ToString();

        }
        private void SalaInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
