namespace SimplePaint
{
    partial class FrmSimplePaint
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCorCaneta = new System.Windows.Forms.Button();
            this.lblCorCaneta = new System.Windows.Forms.Label();
            this.cmbEspessuraCaneta = new System.Windows.Forms.ComboBox();
            this.lblEspessuraCaneta = new System.Windows.Forms.Label();
            this.btnBorracha = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pnlPintura = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.btnBorracha);
            this.groupBox1.Controls.Add(this.lblEspessuraCaneta);
            this.groupBox1.Controls.Add(this.cmbEspessuraCaneta);
            this.groupBox1.Controls.Add(this.lblCorCaneta);
            this.groupBox1.Controls.Add(this.btnCorCaneta);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 99);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personalizar";
            // 
            // btnCorCaneta
            // 
            this.btnCorCaneta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCorCaneta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorCaneta.Location = new System.Drawing.Point(127, 40);
            this.btnCorCaneta.Name = "btnCorCaneta";
            this.btnCorCaneta.Size = new System.Drawing.Size(84, 31);
            this.btnCorCaneta.TabIndex = 0;
            this.btnCorCaneta.UseVisualStyleBackColor = false;
            this.btnCorCaneta.Click += new System.EventHandler(this.btnCorCaneta_Click);
            // 
            // lblCorCaneta
            // 
            this.lblCorCaneta.AutoSize = true;
            this.lblCorCaneta.Location = new System.Drawing.Point(6, 47);
            this.lblCorCaneta.Name = "lblCorCaneta";
            this.lblCorCaneta.Size = new System.Drawing.Size(115, 18);
            this.lblCorCaneta.TabIndex = 1;
            this.lblCorCaneta.Text = "Cor da Caneta:";
            // 
            // cmbEspessuraCaneta
            // 
            this.cmbEspessuraCaneta.FormattingEnabled = true;
            this.cmbEspessuraCaneta.Location = new System.Drawing.Point(388, 44);
            this.cmbEspessuraCaneta.Name = "cmbEspessuraCaneta";
            this.cmbEspessuraCaneta.Size = new System.Drawing.Size(121, 26);
            this.cmbEspessuraCaneta.TabIndex = 2;
            this.cmbEspessuraCaneta.SelectedIndexChanged += new System.EventHandler(this.cmbEspessuraCaneta_SelectedIndexChanged);
            // 
            // lblEspessuraCaneta
            // 
            this.lblEspessuraCaneta.AutoSize = true;
            this.lblEspessuraCaneta.Location = new System.Drawing.Point(218, 47);
            this.lblEspessuraCaneta.Name = "lblEspessuraCaneta";
            this.lblEspessuraCaneta.Size = new System.Drawing.Size(164, 18);
            this.lblEspessuraCaneta.TabIndex = 3;
            this.lblEspessuraCaneta.Text = "Espessura da Caneta:";
            // 
            // btnBorracha
            // 
            this.btnBorracha.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBorracha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorracha.Location = new System.Drawing.Point(530, 39);
            this.btnBorracha.Name = "btnBorracha";
            this.btnBorracha.Size = new System.Drawing.Size(84, 31);
            this.btnBorracha.TabIndex = 4;
            this.btnBorracha.Text = "Borracha";
            this.btnBorracha.UseVisualStyleBackColor = false;
            this.btnBorracha.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnBorracha_MouseDown);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Location = new System.Drawing.Point(620, 40);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(79, 31);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(705, 40);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(65, 31);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // pnlPintura
            // 
            this.pnlPintura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPintura.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlPintura.Location = new System.Drawing.Point(12, 117);
            this.pnlPintura.Name = "pnlPintura";
            this.pnlPintura.Size = new System.Drawing.Size(776, 317);
            this.pnlPintura.TabIndex = 1;
            this.pnlPintura.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlPintura_MouseDown);
            this.pnlPintura.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlPintura_MouseMove);
            this.pnlPintura.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlPintura_MouseUp);
            // 
            // FrmSimplePaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 446);
            this.Controls.Add(this.pnlPintura);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmSimplePaint";
            this.Text = "Simple Paint";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnBorracha;
        private System.Windows.Forms.Label lblEspessuraCaneta;
        private System.Windows.Forms.ComboBox cmbEspessuraCaneta;
        private System.Windows.Forms.Label lblCorCaneta;
        private System.Windows.Forms.Button btnCorCaneta;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel pnlPintura;
    }
}

