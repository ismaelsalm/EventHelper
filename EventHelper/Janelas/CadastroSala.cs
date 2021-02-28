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
    public partial class CadastroSala : Form
    {
        public CadastroSala()
        {
            InitializeComponent();
        }
        bool CadastrarSala()
        {
            if (txtentry_nome.Text != null)
            {
                Sala sala = new Sala
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

        private void btt_cadastrar_Click(object sender, EventArgs e)
        {
            if (CadastrarSala())
            {
                Program.form1.AtualizarListas();
                this.Close();
            }
        }
    }
}
