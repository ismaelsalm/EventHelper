
namespace EventHelper.Janelas
{
    partial class CadastroCafe
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_lotacao = new System.Windows.Forms.NumericUpDown();
            this.txtentry_nome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_lotacao)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Lotação:";
            // 
            // nud_lotacao
            // 
            this.nud_lotacao.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.nud_lotacao.Location = new System.Drawing.Point(59, 38);
            this.nud_lotacao.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_lotacao.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_lotacao.Name = "nud_lotacao";
            this.nud_lotacao.Size = new System.Drawing.Size(120, 20);
            this.nud_lotacao.TabIndex = 13;
            this.nud_lotacao.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtentry_nome
            // 
            this.txtentry_nome.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtentry_nome.Location = new System.Drawing.Point(59, 12);
            this.txtentry_nome.Name = "txtentry_nome";
            this.txtentry_nome.Size = new System.Drawing.Size(271, 20);
            this.txtentry_nome.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GrayText;
            this.button1.Location = new System.Drawing.Point(255, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CadastroCafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(338, 73);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud_lotacao);
            this.Controls.Add(this.txtentry_nome);
            this.Controls.Add(this.button1);
            this.Name = "CadastroCafe";
            this.Text = "CadastroCafe";
            ((System.ComponentModel.ISupportInitialize)(this.nud_lotacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_lotacao;
        private System.Windows.Forms.TextBox txtentry_nome;
        private System.Windows.Forms.Button button1;
    }
}