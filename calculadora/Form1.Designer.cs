namespace calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtResultado = new TextBox();
            btnSete = new Button();
            btnNove = new Button();
            btnDois = new Button();
            btnOito = new Button();
            btnQuatro = new Button();
            btnCinco = new Button();
            btnSeis = new Button();
            btnUm = new Button();
            btnTres = new Button();
            btnZero = new Button();
            btnVirgula = new Button();
            btnIgual = new Button();
            btnDivisao = new Button();
            btnMultiplicacao = new Button();
            btnSubtracao = new Button();
            btnAdicao = new Button();
            btnLimpar = new Button();
            lblOperacao = new Label();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(12, 12);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(239, 23);
            txtResultado.TabIndex = 0;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btnSete
            // 
            btnSete.Location = new Point(12, 137);
            btnSete.Name = "btnSete";
            btnSete.Size = new Size(55, 45);
            btnSete.TabIndex = 1;
            btnSete.Text = "7";
            btnSete.UseVisualStyleBackColor = true;
            btnSete.Click += btnSete_Click;
            // 
            // btnNove
            // 
            btnNove.Location = new Point(134, 137);
            btnNove.Name = "btnNove";
            btnNove.Size = new Size(55, 45);
            btnNove.TabIndex = 2;
            btnNove.Text = "9";
            btnNove.UseVisualStyleBackColor = true;
            btnNove.Click += btnNove_Click;
            // 
            // btnDois
            // 
            btnDois.Location = new Point(73, 239);
            btnDois.Name = "btnDois";
            btnDois.Size = new Size(55, 45);
            btnDois.TabIndex = 3;
            btnDois.Text = "2";
            btnDois.UseVisualStyleBackColor = true;
            btnDois.Click += btnDois_Click;
            // 
            // btnOito
            // 
            btnOito.Location = new Point(73, 137);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(55, 45);
            btnOito.TabIndex = 4;
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = true;
            btnOito.Click += btnOito_Click;
            // 
            // btnQuatro
            // 
            btnQuatro.Location = new Point(12, 188);
            btnQuatro.Name = "btnQuatro";
            btnQuatro.Size = new Size(55, 45);
            btnQuatro.TabIndex = 5;
            btnQuatro.Text = "4";
            btnQuatro.UseVisualStyleBackColor = true;
            btnQuatro.Click += btnQuatro_Click;
            // 
            // btnCinco
            // 
            btnCinco.Location = new Point(73, 188);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(55, 45);
            btnCinco.TabIndex = 6;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = true;
            btnCinco.Click += btnCinco_Click;
            // 
            // btnSeis
            // 
            btnSeis.Location = new Point(134, 188);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(55, 45);
            btnSeis.TabIndex = 7;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            btnSeis.Click += btnSeis_Click;
            // 
            // btnUm
            // 
            btnUm.Location = new Point(12, 239);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(55, 45);
            btnUm.TabIndex = 8;
            btnUm.Text = "1";
            btnUm.UseVisualStyleBackColor = true;
            btnUm.Click += btnUm_Click;
            // 
            // btnTres
            // 
            btnTres.Location = new Point(134, 239);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(55, 45);
            btnTres.TabIndex = 9;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = true;
            btnTres.Click += btnTres_Click;
            // 
            // btnZero
            // 
            btnZero.Location = new Point(73, 290);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(55, 45);
            btnZero.TabIndex = 10;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnVirgula
            // 
            btnVirgula.Location = new Point(12, 290);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(55, 45);
            btnVirgula.TabIndex = 11;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = true;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // btnIgual
            // 
            btnIgual.Location = new Point(134, 290);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(55, 45);
            btnIgual.TabIndex = 12;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.Location = new Point(195, 137);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(55, 45);
            btnDivisao.TabIndex = 13;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = true;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.Location = new Point(195, 188);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(55, 45);
            btnMultiplicacao.TabIndex = 14;
            btnMultiplicacao.Text = "X";
            btnMultiplicacao.UseVisualStyleBackColor = true;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.Location = new Point(195, 239);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(55, 45);
            btnSubtracao.TabIndex = 15;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = true;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btnAdicao
            // 
            btnAdicao.Location = new Point(195, 290);
            btnAdicao.Name = "btnAdicao";
            btnAdicao.Size = new Size(55, 45);
            btnAdicao.TabIndex = 16;
            btnAdicao.Text = "+";
            btnAdicao.UseVisualStyleBackColor = true;
            btnAdicao.Click += btnAdicao_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.Silver;
            btnLimpar.Location = new Point(195, 86);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(55, 45);
            btnLimpar.TabIndex = 17;
            btnLimpar.Text = "C";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lblOperacao
            // 
            lblOperacao.AutoSize = true;
            lblOperacao.Location = new Point(17, 16);
            lblOperacao.Name = "lblOperacao";
            lblOperacao.Size = new Size(0, 15);
            lblOperacao.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(266, 359);
            Controls.Add(lblOperacao);
            Controls.Add(btnLimpar);
            Controls.Add(btnAdicao);
            Controls.Add(btnSubtracao);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnDivisao);
            Controls.Add(btnIgual);
            Controls.Add(btnVirgula);
            Controls.Add(btnZero);
            Controls.Add(btnTres);
            Controls.Add(btnUm);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnQuatro);
            Controls.Add(btnOito);
            Controls.Add(btnDois);
            Controls.Add(btnNove);
            Controls.Add(btnSete);
            Controls.Add(txtResultado);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            TransparencyKey = Color.Gainsboro;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button btnSete;
        private Button btnNove;
        private Button btnDois;
        private Button btnOito;
        private Button btnQuatro;
        private Button btnCinco;
        private Button btnSeis;
        private Button btnUm;
        private Button btnTres;
        private Button btnZero;
        private Button btnVirgula;
        private Button btnIgual;
        private Button btnDivisao;
        private Button btnMultiplicacao;
        private Button btnSubtracao;
        private Button btnAdicao;
        private Button btnLimpar;
        private Label lblOperacao;
    }
}
