
namespace EventHelper.Janelas
{
    partial class CadastroParticipante
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
            this.txtb_sobrenome = new System.Windows.Forms.TextBox();
            this.txtb_nome = new System.Windows.Forms.TextBox();
            this.btt_cadastrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtb_sobrenome
            // 
            this.txtb_sobrenome.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtb_sobrenome.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtb_sobrenome.Location = new System.Drawing.Point(352, 15);
            this.txtb_sobrenome.Name = "txtb_sobrenome";
            this.txtb_sobrenome.Size = new System.Drawing.Size(182, 20);
            this.txtb_sobrenome.TabIndex = 9;
            // 
            // txtb_nome
            // 
            this.txtb_nome.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtb_nome.Location = new System.Drawing.Point(55, 12);
            this.txtb_nome.Name = "txtb_nome";
            this.txtb_nome.Size = new System.Drawing.Size(221, 20);
            this.txtb_nome.TabIndex = 8;
            // 
            // btt_cadastrar
            // 
            this.btt_cadastrar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btt_cadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btt_cadastrar.Location = new System.Drawing.Point(540, 12);
            this.btt_cadastrar.Name = "btt_cadastrar";
            this.btt_cadastrar.Size = new System.Drawing.Size(104, 23);
            this.btt_cadastrar.TabIndex = 7;
            this.btt_cadastrar.Text = "Cadastrar";
            this.btt_cadastrar.UseVisualStyleBackColor = false;
            this.btt_cadastrar.Click += new System.EventHandler(this.btt_cadastrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sobrenome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome:";
            // 
            // CadastroParticipantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(648, 49);
            this.Controls.Add(this.txtb_sobrenome);
            this.Controls.Add(this.txtb_nome);
            this.Controls.Add(this.btt_cadastrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastroParticipantes";
            this.Text = "Cadastro Participantes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb_sobrenome;
        private System.Windows.Forms.TextBox txtb_nome;
        private System.Windows.Forms.Button btt_cadastrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}