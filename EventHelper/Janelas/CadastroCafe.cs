using EventHelper.Items;
using SQLite;
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
    public partial class CadastroCafe : Form
    {
        public CadastroCafe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CadastrarSala())
            {
                Program.form1.AtualizarListas();
                this.Close();
            }
        }
        bool CadastrarSala()
        {
            if (txtentry_nome.Text != null)
            {
                Cafe sala = new Cafe
                {
                    nome = txtentry_nome.Text,
                    lotacao = (int)nud_lotacao.Value
                };


                using (SQLiteConnection conn = new SQLiteConnection(Program.filePath))
                {
                    conn.CreateTable<Sala>();
                    conn.Insert(sala);
                }
                return true;
            }
            return false;
        }
    }
}
