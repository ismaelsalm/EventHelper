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
    public partial class CadastroParticipante : Form
    {
        public CadastroParticipante()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btt_cadastrar_Click(object sender, EventArgs e)
        {
            if (Cadastrar())
            {
                Program.form1.AtualizarListas();
                this.Close();
            }
        }

        bool Cadastrar()
        {
            if (txtb_nome.Text != "" && txtb_sobrenome.Text != "")
            {
                Participante participante = new Participante
                {
                    Nome = txtb_nome.Text,
                    Sobrenome = txtb_sobrenome.Text,
                    Sala1 = "",
                    Sala2 = "",
                    SalaCafe = "",
                };


                using (SQLiteConnection conn = new SQLiteConnection(Program.filePath))
                {
                    conn.CreateTable<Participante>();
                    conn.Insert(participante);
                }
                return true;
            }
            return false;
        }
    }
}
