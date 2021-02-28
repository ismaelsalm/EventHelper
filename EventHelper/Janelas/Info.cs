using EventHelper.Items;
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
    public partial class Info : Form
    {
        public Info(SalaCafe sc)
        {
            InitializeComponent();
            lst_participantesSala.Items.Clear();
            foreach (var item in sc.participantes)
            {
                lst_participantesSala.Items.Add(String.Format("{0,-10}{0,-10}", item.Nome, item.Sobrenome));
            }
            lbl_nome.Text = sc.salaref.nome;
            lbl_lotacao.Text = sc.salaref.lotacao.ToString();
        }

        private void Info_Load(object sender, EventArgs e)
        {

        }
    }
}
