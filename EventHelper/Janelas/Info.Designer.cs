
namespace EventHelper.Janelas
{
    partial class Info
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_lotacao = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lst_participantesSala = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_lotacao
            // 
            this.lbl_lotacao.AutoSize = true;
            this.lbl_lotacao.Location = new System.Drawing.Point(219, 13);
            this.lbl_lotacao.Name = "lbl_lotacao";
            this.lbl_lotacao.Size = new System.Drawing.Size(35, 13);
            this.lbl_lotacao.TabIndex = 14;
            this.lbl_lotacao.Text = "label3";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(47, 13);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 13;
            this.lbl_nome.Text = "label3";
            // 
            // lst_participantesSala
            // 
            this.lst_participantesSala.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lst_participantesSala.FormattingEnabled = true;
            this.lst_participantesSala.Location = new System.Drawing.Point(12, 56);
            this.lst_participantesSala.Name = "lst_participantesSala";
            this.lst_participantesSala.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lst_participantesSala.Size = new System.Drawing.Size(248, 264);
            this.lst_participantesSala.Sorted = true;
            this.lst_participantesSala.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Lotação:";
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(277, 332);
            this.Controls.Add(this.lbl_lotacao);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lst_participantesSala);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Info";
            this.Text = "Info";
            this.Load += new System.EventHandler(this.Info_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_lotacao;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.ListBox lst_participantesSala;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}