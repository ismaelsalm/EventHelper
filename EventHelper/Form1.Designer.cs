
namespace EventHelper
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lst_Participantes = new System.Windows.Forms.ListView();
            this.chNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSobrenome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSala1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSala2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCafe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lst_Cafes = new System.Windows.Forms.ListBox();
            this.lst_SalasComuns = new System.Windows.Forms.ListBox();
            this.lbl_Falta = new System.Windows.Forms.Label();
            this.lbl_cafesVagas = new System.Windows.Forms.Label();
            this.lbl_vagasSalasC = new System.Windows.Forms.Label();
            this.lbl_TotalParticipantes = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btt_DelPart = new System.Windows.Forms.Button();
            this.btt_DeleteSalas = new System.Windows.Forms.Button();
            this.btt_CadastroCafe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btt_CadastroParticipante = new System.Windows.Forms.Button();
            this.btt_CadastroSala = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lst_Participantes
            // 
            this.lst_Participantes.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lst_Participantes.BackgroundImageTiled = true;
            this.lst_Participantes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lst_Participantes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNome,
            this.chSobrenome,
            this.chSala1,
            this.chSala2,
            this.chCafe});
            this.lst_Participantes.Cursor = System.Windows.Forms.Cursors.Default;
            this.lst_Participantes.Enabled = false;
            this.lst_Participantes.GridLines = true;
            this.lst_Participantes.HideSelection = false;
            this.lst_Participantes.Location = new System.Drawing.Point(159, 12);
            this.lst_Participantes.MultiSelect = false;
            this.lst_Participantes.Name = "lst_Participantes";
            this.lst_Participantes.Size = new System.Drawing.Size(540, 332);
            this.lst_Participantes.TabIndex = 39;
            this.lst_Participantes.TileSize = new System.Drawing.Size(5, 2);
            this.lst_Participantes.UseCompatibleStateImageBehavior = false;
            this.lst_Participantes.View = System.Windows.Forms.View.Details;
            // 
            // chNome
            // 
            this.chNome.Text = "Nome";
            this.chNome.Width = 150;
            // 
            // chSobrenome
            // 
            this.chSobrenome.Text = "Sobrenome";
            this.chSobrenome.Width = 150;
            // 
            // chSala1
            // 
            this.chSala1.Text = "Sala 1";
            this.chSala1.Width = 75;
            // 
            // chSala2
            // 
            this.chSala2.Text = "Sala 2";
            this.chSala2.Width = 75;
            // 
            // chCafe
            // 
            this.chCafe.Text = "Cafe";
            this.chCafe.Width = 75;
            // 
            // lst_Cafes
            // 
            this.lst_Cafes.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lst_Cafes.FormattingEnabled = true;
            this.lst_Cafes.Location = new System.Drawing.Point(7, 275);
            this.lst_Cafes.Name = "lst_Cafes";
            this.lst_Cafes.Size = new System.Drawing.Size(136, 95);
            this.lst_Cafes.TabIndex = 38;
            this.lst_Cafes.SelectedIndexChanged += new System.EventHandler(this.lst_Cafes_SelectedIndexChanged);
            // 
            // lst_SalasComuns
            // 
            this.lst_SalasComuns.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lst_SalasComuns.FormattingEnabled = true;
            this.lst_SalasComuns.Location = new System.Drawing.Point(7, 148);
            this.lst_SalasComuns.Name = "lst_SalasComuns";
            this.lst_SalasComuns.Size = new System.Drawing.Size(136, 95);
            this.lst_SalasComuns.TabIndex = 37;
            this.lst_SalasComuns.SelectedIndexChanged += new System.EventHandler(this.lst_SalasComuns_SelectedIndexChanged_1);
            // 
            // lbl_Falta
            // 
            this.lbl_Falta.AutoSize = true;
            this.lbl_Falta.ForeColor = System.Drawing.Color.Red;
            this.lbl_Falta.Location = new System.Drawing.Point(159, 371);
            this.lbl_Falta.Name = "lbl_Falta";
            this.lbl_Falta.Size = new System.Drawing.Size(41, 13);
            this.lbl_Falta.TabIndex = 36;
            this.lbl_Falta.Text = "label10";
            // 
            // lbl_cafesVagas
            // 
            this.lbl_cafesVagas.AutoSize = true;
            this.lbl_cafesVagas.Location = new System.Drawing.Point(626, 347);
            this.lbl_cafesVagas.Name = "lbl_cafesVagas";
            this.lbl_cafesVagas.Size = new System.Drawing.Size(41, 13);
            this.lbl_cafesVagas.TabIndex = 35;
            this.lbl_cafesVagas.Text = "label10";
            // 
            // lbl_vagasSalasC
            // 
            this.lbl_vagasSalasC.AutoSize = true;
            this.lbl_vagasSalasC.Location = new System.Drawing.Point(434, 347);
            this.lbl_vagasSalasC.Name = "lbl_vagasSalasC";
            this.lbl_vagasSalasC.Size = new System.Drawing.Size(41, 13);
            this.lbl_vagasSalasC.TabIndex = 34;
            this.lbl_vagasSalasC.Text = "label10";
            // 
            // lbl_TotalParticipantes
            // 
            this.lbl_TotalParticipantes.AutoSize = true;
            this.lbl_TotalParticipantes.Location = new System.Drawing.Point(236, 347);
            this.lbl_TotalParticipantes.Name = "lbl_TotalParticipantes";
            this.lbl_TotalParticipantes.Size = new System.Drawing.Size(25, 13);
            this.lbl_TotalParticipantes.TabIndex = 33;
            this.lbl_TotalParticipantes.Text = "nop";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(159, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Participantes:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(555, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Vagas Café:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(372, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Vagas:";
            // 
            // btt_DelPart
            // 
            this.btt_DelPart.Location = new System.Drawing.Point(543, 415);
            this.btt_DelPart.Name = "btt_DelPart";
            this.btt_DelPart.Size = new System.Drawing.Size(75, 23);
            this.btt_DelPart.TabIndex = 29;
            this.btt_DelPart.Text = "Del Part";
            this.btt_DelPart.UseVisualStyleBackColor = true;
            this.btt_DelPart.Click += new System.EventHandler(this.btt_DelPart_Click);
            // 
            // btt_DeleteSalas
            // 
            this.btt_DeleteSalas.Location = new System.Drawing.Point(624, 415);
            this.btt_DeleteSalas.Name = "btt_DeleteSalas";
            this.btt_DeleteSalas.Size = new System.Drawing.Size(75, 23);
            this.btt_DeleteSalas.TabIndex = 28;
            this.btt_DeleteSalas.Text = "Del Salas";
            this.btt_DeleteSalas.UseVisualStyleBackColor = true;
            this.btt_DeleteSalas.Click += new System.EventHandler(this.btt_DeleteSalas_Click_1);
            // 
            // btt_CadastroCafe
            // 
            this.btt_CadastroCafe.BackColor = System.Drawing.SystemColors.GrayText;
            this.btt_CadastroCafe.Location = new System.Drawing.Point(7, 84);
            this.btt_CadastroCafe.Name = "btt_CadastroCafe";
            this.btt_CadastroCafe.Size = new System.Drawing.Size(77, 23);
            this.btt_CadastroCafe.TabIndex = 27;
            this.btt_CadastroCafe.Text = "Café";
            this.btt_CadastroCafe.UseVisualStyleBackColor = false;
            this.btt_CadastroCafe.Click += new System.EventHandler(this.btt_CadastroCafe_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Cadastrar:";
            // 
            // btt_CadastroParticipante
            // 
            this.btt_CadastroParticipante.BackColor = System.Drawing.SystemColors.GrayText;
            this.btt_CadastroParticipante.Location = new System.Drawing.Point(7, 26);
            this.btt_CadastroParticipante.Name = "btt_CadastroParticipante";
            this.btt_CadastroParticipante.Size = new System.Drawing.Size(77, 23);
            this.btt_CadastroParticipante.TabIndex = 25;
            this.btt_CadastroParticipante.Text = "Participante";
            this.btt_CadastroParticipante.UseVisualStyleBackColor = false;
            this.btt_CadastroParticipante.Click += new System.EventHandler(this.btt_CadastroParticipante_Click_1);
            // 
            // btt_CadastroSala
            // 
            this.btt_CadastroSala.BackColor = System.Drawing.SystemColors.GrayText;
            this.btt_CadastroSala.Location = new System.Drawing.Point(7, 55);
            this.btt_CadastroSala.Name = "btt_CadastroSala";
            this.btt_CadastroSala.Size = new System.Drawing.Size(77, 23);
            this.btt_CadastroSala.TabIndex = 24;
            this.btt_CadastroSala.Text = "Sala";
            this.btt_CadastroSala.UseVisualStyleBackColor = false;
            this.btt_CadastroSala.Click += new System.EventHandler(this.btt_CadastroSala_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Salas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Cafés:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(712, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lst_Participantes);
            this.Controls.Add(this.lst_Cafes);
            this.Controls.Add(this.lst_SalasComuns);
            this.Controls.Add(this.lbl_Falta);
            this.Controls.Add(this.lbl_cafesVagas);
            this.Controls.Add(this.lbl_vagasSalasC);
            this.Controls.Add(this.lbl_TotalParticipantes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btt_DelPart);
            this.Controls.Add(this.btt_DeleteSalas);
            this.Controls.Add(this.btt_CadastroCafe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btt_CadastroParticipante);
            this.Controls.Add(this.btt_CadastroSala);
            this.Name = "Form1";
            this.Text = "Evento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lst_Participantes;
        private System.Windows.Forms.ColumnHeader chNome;
        private System.Windows.Forms.ColumnHeader chSobrenome;
        private System.Windows.Forms.ColumnHeader chSala1;
        private System.Windows.Forms.ColumnHeader chSala2;
        private System.Windows.Forms.ColumnHeader chCafe;
        private System.Windows.Forms.ListBox lst_Cafes;
        private System.Windows.Forms.ListBox lst_SalasComuns;
        private System.Windows.Forms.Label lbl_Falta;
        private System.Windows.Forms.Label lbl_cafesVagas;
        private System.Windows.Forms.Label lbl_vagasSalasC;
        private System.Windows.Forms.Label lbl_TotalParticipantes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btt_DelPart;
        private System.Windows.Forms.Button btt_DeleteSalas;
        private System.Windows.Forms.Button btt_CadastroCafe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btt_CadastroParticipante;
        private System.Windows.Forms.Button btt_CadastroSala;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

