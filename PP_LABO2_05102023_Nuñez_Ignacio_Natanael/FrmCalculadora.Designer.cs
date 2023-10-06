namespace PP_LABO2_05102023_Nuñez_Ignacio_Natanael
{
    partial class FrmCalculadora
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
            this.cmbOperacion = new System.Windows.Forms.ComboBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnOperar = new System.Windows.Forms.Button();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.lblPrimerOperador = new System.Windows.Forms.Label();
            this.lblSegundoOperador = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.grpSistema = new System.Windows.Forms.GroupBox();
            this.rdbDecimal = new System.Windows.Forms.RadioButton();
            this.rdbBinario = new System.Windows.Forms.RadioButton();
            this.txtSegundoOperando = new System.Windows.Forms.TextBox();
            this.txtPrimerOperando = new System.Windows.Forms.TextBox();
            this.lstHistorial = new System.Windows.Forms.ListBox();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.grpSistema.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbOperacion
            // 
            this.cmbOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbOperacion.FormattingEnabled = true;
            this.cmbOperacion.Location = new System.Drawing.Point(257, 290);
            this.cmbOperacion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbOperacion.Name = "cmbOperacion";
            this.cmbOperacion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbOperacion.Size = new System.Drawing.Size(140, 21);
            this.cmbOperacion.TabIndex = 0;
            this.cmbOperacion.SelectedIndexChanged += new System.EventHandler(this.cmbOperacion_SelectedIndexChanged);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(530, 352);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(88, 27);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(268, 352);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(88, 27);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnOperar
            // 
            this.btnOperar.Location = new System.Drawing.Point(55, 352);
            this.btnOperar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(88, 27);
            this.btnOperar.TabIndex = 3;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // lblOperacion
            // 
            this.lblOperacion.AutoSize = true;
            this.lblOperacion.Location = new System.Drawing.Point(294, 264);
            this.lblOperacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(62, 15);
            this.lblOperacion.TabIndex = 4;
            this.lblOperacion.Text = "Operacion";
            // 
            // lblPrimerOperador
            // 
            this.lblPrimerOperador.AutoSize = true;
            this.lblPrimerOperador.Location = new System.Drawing.Point(55, 264);
            this.lblPrimerOperador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrimerOperador.Name = "lblPrimerOperador";
            this.lblPrimerOperador.Size = new System.Drawing.Size(92, 15);
            this.lblPrimerOperador.TabIndex = 5;
            this.lblPrimerOperador.Text = "PrimerOperador";
            // 
            // lblSegundoOperador
            // 
            this.lblSegundoOperador.AutoSize = true;
            this.lblSegundoOperador.Location = new System.Drawing.Point(511, 264);
            this.lblSegundoOperador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSegundoOperador.Name = "lblSegundoOperador";
            this.lblSegundoOperador.Size = new System.Drawing.Size(104, 15);
            this.lblSegundoOperador.TabIndex = 6;
            this.lblSegundoOperador.Text = "SegundoOperador";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(55, 42);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblResultado.Size = new System.Drawing.Size(62, 15);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "Resultado:";
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // grpSistema
            // 
            this.grpSistema.AutoSize = true;
            this.grpSistema.Controls.Add(this.rdbDecimal);
            this.grpSistema.Controls.Add(this.rdbBinario);
            this.grpSistema.Location = new System.Drawing.Point(208, 132);
            this.grpSistema.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpSistema.Name = "grpSistema";
            this.grpSistema.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpSistema.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpSistema.Size = new System.Drawing.Size(233, 130);
            this.grpSistema.TabIndex = 8;
            this.grpSistema.TabStop = false;
            this.grpSistema.Text = "Representar resultado en:";
            this.grpSistema.UseWaitCursor = true;
            this.grpSistema.Enter += new System.EventHandler(this.grpSistema_Enter_1);
            // 
            // rdbDecimal
            // 
            this.rdbDecimal.AutoSize = true;
            this.rdbDecimal.Checked = true;
            this.rdbDecimal.Location = new System.Drawing.Point(23, 89);
            this.rdbDecimal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbDecimal.Name = "rdbDecimal";
            this.rdbDecimal.Size = new System.Drawing.Size(86, 19);
            this.rdbDecimal.TabIndex = 1;
            this.rdbDecimal.TabStop = true;
            this.rdbDecimal.Text = "rdbDecimal";
            this.rdbDecimal.UseVisualStyleBackColor = true;
            this.rdbDecimal.UseWaitCursor = true;
            this.rdbDecimal.CheckedChanged += new System.EventHandler(this.rdbDecimal_CheckedChanged);
            // 
            // rdbBinario
            // 
            this.rdbBinario.AutoSize = true;
            this.rdbBinario.Location = new System.Drawing.Point(23, 44);
            this.rdbBinario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbBinario.Name = "rdbBinario";
            this.rdbBinario.Size = new System.Drawing.Size(80, 19);
            this.rdbBinario.TabIndex = 0;
            this.rdbBinario.Text = "rdbBinario";
            this.rdbBinario.UseVisualStyleBackColor = true;
            this.rdbBinario.UseWaitCursor = true;
            this.rdbBinario.CheckedChanged += new System.EventHandler(this.rdbBinario_CheckedChanged);
            // 
            // txtSegundoOperando
            // 
            this.txtSegundoOperando.Location = new System.Drawing.Point(511, 291);
            this.txtSegundoOperando.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSegundoOperando.Name = "txtSegundoOperando";
            this.txtSegundoOperando.Size = new System.Drawing.Size(116, 23);
            this.txtSegundoOperando.TabIndex = 11;
            // 
            // txtPrimerOperando
            // 
            this.txtPrimerOperando.Location = new System.Drawing.Point(43, 291);
            this.txtPrimerOperando.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPrimerOperando.Name = "txtPrimerOperando";
            this.txtPrimerOperando.Size = new System.Drawing.Size(116, 23);
            this.txtPrimerOperando.TabIndex = 12;
            // 
            // lstHistorial
            // 
            this.lstHistorial.FormattingEnabled = true;
            this.lstHistorial.ItemHeight = 15;
            this.lstHistorial.Location = new System.Drawing.Point(662, 135);
            this.lstHistorial.Name = "lstHistorial";
            this.lstHistorial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstHistorial.Size = new System.Drawing.Size(219, 244);
            this.lstHistorial.TabIndex = 13;
            this.lstHistorial.SelectedIndexChanged += new System.EventHandler(this.lstHistorial_SelectedIndexChanged);
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.Location = new System.Drawing.Point(751, 117);
            this.lblHistorial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(51, 15);
            this.lblHistorial.TabIndex = 14;
            this.lblHistorial.Text = "Historial";
            // 
            // FrmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(893, 417);
            this.Controls.Add(this.lblHistorial);
            this.Controls.Add(this.lstHistorial);
            this.Controls.Add(this.txtPrimerOperando);
            this.Controls.Add(this.txtSegundoOperando);
            this.Controls.Add(this.grpSistema);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblSegundoOperador);
            this.Controls.Add(this.lblPrimerOperador);
            this.Controls.Add(this.lblOperacion);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.cmbOperacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalculadora";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCalculadora";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCalculadora_FormClosing);
            this.Load += new System.EventHandler(this.FrmCalculadora_Load_1);
            this.grpSistema.ResumeLayout(false);
            this.grpSistema.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOperacion;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Label lblOperacion;
        private System.Windows.Forms.Label lblPrimerOperador;
        private System.Windows.Forms.Label lblSegundoOperador;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.GroupBox grpSistema;
        private System.Windows.Forms.RadioButton rdbDecimal;
        private System.Windows.Forms.RadioButton rdbBinario;
        private System.Windows.Forms.TextBox txtSegundoOperando;
        private System.Windows.Forms.TextBox txtPrimerOperando;
        private ListBox lstHistorial;
        private Label lblHistorial;
    }
}