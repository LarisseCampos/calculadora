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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            txtResultado.BackColor = SystemColors.AppWorkspace;
            resources.ApplyResources(txtResultado, "txtResultado");
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            // 
            // btnSete
            // 
            resources.ApplyResources(btnSete, "btnSete");
            btnSete.Name = "btnSete";
            btnSete.UseVisualStyleBackColor = true;
            btnSete.Click += btnSete_Click;
            // 
            // btnNove
            // 
            resources.ApplyResources(btnNove, "btnNove");
            btnNove.Name = "btnNove";
            btnNove.UseVisualStyleBackColor = true;
            btnNove.Click += btnNove_Click;
            // 
            // btnDois
            // 
            resources.ApplyResources(btnDois, "btnDois");
            btnDois.Name = "btnDois";
            btnDois.UseVisualStyleBackColor = true;
            btnDois.Click += btnDois_Click;
            // 
            // btnOito
            // 
            resources.ApplyResources(btnOito, "btnOito");
            btnOito.Name = "btnOito";
            btnOito.UseVisualStyleBackColor = true;
            btnOito.Click += btnOito_Click;
            // 
            // btnQuatro
            // 
            resources.ApplyResources(btnQuatro, "btnQuatro");
            btnQuatro.Name = "btnQuatro";
            btnQuatro.UseVisualStyleBackColor = true;
            btnQuatro.Click += btnQuatro_Click;
            // 
            // btnCinco
            // 
            resources.ApplyResources(btnCinco, "btnCinco");
            btnCinco.Name = "btnCinco";
            btnCinco.UseVisualStyleBackColor = true;
            btnCinco.Click += btnCinco_Click;
            // 
            // btnSeis
            // 
            resources.ApplyResources(btnSeis, "btnSeis");
            btnSeis.Name = "btnSeis";
            btnSeis.UseVisualStyleBackColor = true;
            btnSeis.Click += btnSeis_Click;
            // 
            // btnUm
            // 
            resources.ApplyResources(btnUm, "btnUm");
            btnUm.Name = "btnUm";
            btnUm.UseVisualStyleBackColor = true;
            btnUm.Click += btnUm_Click;
            // 
            // btnTres
            // 
            resources.ApplyResources(btnTres, "btnTres");
            btnTres.Name = "btnTres";
            btnTres.UseVisualStyleBackColor = true;
            btnTres.Click += btnTres_Click;
            // 
            // btnZero
            // 
            resources.ApplyResources(btnZero, "btnZero");
            btnZero.Name = "btnZero";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnVirgula
            // 
            resources.ApplyResources(btnVirgula, "btnVirgula");
            btnVirgula.Name = "btnVirgula";
            btnVirgula.UseVisualStyleBackColor = true;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // btnIgual
            // 
            resources.ApplyResources(btnIgual, "btnIgual");
            btnIgual.Name = "btnIgual";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnDivisao
            // 
            resources.ApplyResources(btnDivisao, "btnDivisao");
            btnDivisao.Name = "btnDivisao";
            btnDivisao.UseVisualStyleBackColor = true;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnMultiplicacao
            // 
            resources.ApplyResources(btnMultiplicacao, "btnMultiplicacao");
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.UseVisualStyleBackColor = true;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btnSubtracao
            // 
            resources.ApplyResources(btnSubtracao, "btnSubtracao");
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.UseVisualStyleBackColor = true;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btnAdicao
            // 
            resources.ApplyResources(btnAdicao, "btnAdicao");
            btnAdicao.Name = "btnAdicao";
            btnAdicao.UseVisualStyleBackColor = true;
            btnAdicao.Click += btnAdicao_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = SystemColors.ControlDark;
            resources.ApplyResources(btnLimpar, "btnLimpar");
            btnLimpar.Name = "btnLimpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lblOperacao
            // 
            resources.ApplyResources(lblOperacao, "lblOperacao");
            lblOperacao.Name = "lblOperacao";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
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
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            ShowInTaskbar = false;
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
