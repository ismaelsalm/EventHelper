using EventHelper.Items;
using EventHelper.Janelas;
using SQLite;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EventHelper
{
    public partial class Form1 : Form
    {
        SQLiteConnection conn = new SQLiteConnection(Program.filePath);
        List<SalaComum> salas = new List<SalaComum>();
        List<SalaCafe> cafes = new List<SalaCafe>();
        int cafeMax;
        int salasMax;
        int totalParticipantes;
        int faltas;

        public Form1()
        {
            InitializeComponent();
            AtualizarListas();
        }

        private void UIRefresh()
        {
            lst_Participantes.Items.Clear();
            foreach (var item in conn.Table<Participante>().ToList())
            {
                var row = new string[] { item.Nome, item.Sobrenome, item.Sala1, item.Sala2, item.SalaCafe };
                var b = new ListViewItem(row);
                b.Tag = item;
                lst_Participantes.Items.Add(b);
            }

            lst_SalasComuns.Items.Clear();
            foreach (var item in salas)
            {
               lst_SalasComuns.Items.Add(item.salaref.nome);
            }

            lst_Cafes.Items.Clear();
            foreach (var item in cafes)
            {
                lst_Cafes.Items.Add(item.salaref.nome);
            }

            totalParticipantes = conn.Table<Participante>().ToList().Count;
            lbl_TotalParticipantes.Text = totalParticipantes.ToString();
            lbl_vagasSalasC.Text = salasMax.ToString();
            lbl_cafesVagas.Text = cafeMax.ToString();

            if (faltas > 0)
            {
                lbl_Falta.Text = "Existem: " + faltas + " pessoas que não tiveram todas suas salas preenchidas";
            }
            else lbl_Falta.Text = "";

        }

        public void AtualizarListas()
        {
            RecarregarSalasComuns();
            RecarregarCafes();
            Sort();
            UIRefresh();
        }
        void RecarregarCafes()
        {
            cafeMax = 0;
            conn.CreateTable<Cafe>();
            cafes.Clear();
            foreach (var item in conn.Table<Cafe>().ToList())
            {
                SalaCafe s = new SalaCafe
                {
                    salaref = item,
                    participantes = new List<Participante>(),
                };
                cafeMax += item.lotacao;
                cafes.Add(s);
            }
        }
        void RecarregarSalasComuns()
        {
            salasMax = 0;
            conn.CreateTable<Sala>();
            salas.Clear();
            foreach (var item in conn.Table<Sala>().ToList())
            {
                SalaComum s = new SalaComum
                {
                    salaref = item,
                    participantes = new List<Participante>(),
                };
                salasMax += item.lotacao;
                salas.Add(s);
            }
        }





        void Sort()
        {
            faltas = 0;
            // 1º Limpa todos os participantes das salas;
            foreach (var sala in salas)
            {
                sala.participantes.Clear();
            }
            //2º Verifica cada participante cadastrado
            foreach (var p in conn.Table<Participante>().ToList())
            {
                bool s1 = false;
                bool s2 = false;
                bool sc = false;
                Participante pn = new Participante();
                pn = p;

                //3º Procura entre as salas pela primeira com vaga.
                foreach (var s in salas)
                {
                    if (s.participantes.Count < s.salaref.lotacao)
                    {
                        //4º Adiciona o participante na sala, referencia a sala para o participante e avisa que conseguiu encontrar uma sala disponível
                        pn.Sala1 = s.salaref.nome;
                        s.participantes.Add(pn);
                        s1 = true;
                        break;
                    }
                }
                //5º Repete a 3º e 4º ação para a segunda sala verificando se o participante não ficará na mesma sala.
                foreach (var s in salas)
                {
                    if (s.participantes.Count < s.salaref.lotacao && s.salaref.nome != p.Sala1)
                    {
                        pn.Sala2 = s.salaref.nome;
                        s.participantes.Add(pn);
                        Console.WriteLine(s.salaref.nome + ": " + s.participantes.Count.ToString() + " / " + s.salaref.lotacao.ToString());
                        s2 = true;
                        break;
                    }
                }
                //6º adiciona o local de café.
                foreach (var c in cafes)
                {
                    if (c.participantes.Count < c.salaref.lotacao)
                    {
                        pn.SalaCafe = c.salaref.nome;
                        c.participantes.Add(pn);
                        sc = true;
                        break;
                    }
                }

                //7º verifica se todas as salas foram preenchidas.
                if (!s1)
                {
                    pn.Sala1 = "";
                }
                if (!s2)
                {
                    pn.Sala2 = "";
                }
                if (!sc)
                {
                    pn.SalaCafe = "";
                }
                if (!s1 || !s2)
                {
                    faltas++;
                }

                //8º atualiza o cadastro no banco de dados
                conn.Delete(p);
                conn.Insert(pn);
            }
        }



        #region UIControl
        private void btt_atualizar_Click(object sender, EventArgs e)
        {
            AtualizarListas();
        }

        private void btt_DelPart_Click(object sender, EventArgs e)
        {
            conn.DeleteAll<Participante>();
            AtualizarListas();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }


            #endregion





        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btt_CadastroCafe_Click_1(object sender, EventArgs e)
        {
            CadastroCafe cc = new CadastroCafe();
            cc.ShowDialog();
        }

        private void btt_CadastroParticipante_Click_1(object sender, EventArgs e)
        {
            CadastroParticipante cp = new CadastroParticipante();
            cp.ShowDialog();
        }

        private void btt_CadastroSala_Click(object sender, EventArgs e)
        {
            CadastroSala cs = new CadastroSala();
            cs.ShowDialog();
        }

        private void lst_SalasComuns_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SalaInfo si = new SalaInfo(salas[lst_SalasComuns.SelectedIndex]);
            si.ShowDialog();
        }

        private void lst_Cafes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Info ci = new Info(cafes[lst_Cafes.SelectedIndex]);
            ci.ShowDialog();
        }

        private void btt_DeleteSalas_Click_1(object sender, EventArgs e)
        {
            conn.DeleteAll<Sala>();
            conn.DeleteAll<Cafe>();
            AtualizarListas();
        }
    }

    public class SalaComum
        {
            public Sala salaref { get; set; }
            public List<Participante> participantes { get; set; }
        }
        public class SalaCafe
        {
            public Cafe salaref { get; set; }
            public List<Participante> participantes { get; set; }
        }
    
}
