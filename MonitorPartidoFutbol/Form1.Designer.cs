namespace MonitorPartidoFutbol
{
    partial class buttonIniciar
    {
        private const bool V = true;

        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxLocal = new System.Windows.Forms.ComboBox();
            this.comboBoxVisitante = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonIniciarPartido = new System.Windows.Forms.Button();
            this.labelLocal = new System.Windows.Forms.Label();
            this.labelVisitante = new System.Windows.Forms.Label();
            this.textBoxGolesLocal = new System.Windows.Forms.TextBox();
            this.textBoxGolesVisitante = new System.Windows.Forms.TextBox();
            this.buttonSumarGolLocal = new System.Windows.Forms.Button();
            this.buttonRestarGolLocal = new System.Windows.Forms.Button();
            this.buttonSumarGolVisitante = new System.Windows.Forms.Button();
            this.buttonRestarGolVisitante = new System.Windows.Forms.Button();
            this.buttonReiniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxLocal
            // 
            this.comboBoxLocal.FormattingEnabled = true;
            this.comboBoxLocal.Location = new System.Drawing.Point(260, 175);
            this.comboBoxLocal.Name = "comboBoxLocal";
            this.comboBoxLocal.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLocal.TabIndex = 0;
            this.comboBoxLocal.SelectedIndexChanged += new System.EventHandler(this.comboBoxLocal_SelectedIndexChanged);
            // 
            // comboBoxVisitante
            // 
            this.comboBoxVisitante.FormattingEnabled = true;
            this.comboBoxVisitante.Location = new System.Drawing.Point(762, 175);
            this.comboBoxVisitante.Name = "comboBoxVisitante";
            this.comboBoxVisitante.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVisitante.TabIndex = 1;
            this.comboBoxVisitante.SelectedIndexChanged += new System.EventHandler(this.comboBoxVisitante_SelectedIndexChanged);
            // 
            // buttonIniciarPartido
            // 
            this.buttonIniciarPartido.Location = new System.Drawing.Point(430, 354);
            this.buttonIniciarPartido.Name = "buttonIniciarPartido";
            this.buttonIniciarPartido.Size = new System.Drawing.Size(155, 50);
            this.buttonIniciarPartido.TabIndex = 3;
            this.buttonIniciarPartido.Text = "Iniciar partido";
            this.buttonIniciarPartido.UseVisualStyleBackColor = true;
            this.buttonIniciarPartido.Click += new System.EventHandler(this.buttonIniciarPartido_Click);
            // 
            // labelLocal
            // 
            this.labelLocal.AutoSize = true;
            this.labelLocal.Location = new System.Drawing.Point(307, 205);
            this.labelLocal.Name = "labelLocal";
            this.labelLocal.Size = new System.Drawing.Size(35, 13);
            this.labelLocal.TabIndex = 4;
            this.labelLocal.Text = "label1";
            // 
            // labelVisitante
            // 
            this.labelVisitante.AutoSize = true;
            this.labelVisitante.Location = new System.Drawing.Point(805, 205);
            this.labelVisitante.Name = "labelVisitante";
            this.labelVisitante.Size = new System.Drawing.Size(35, 13);
            this.labelVisitante.TabIndex = 5;
            this.labelVisitante.Text = "label2";
            // 
            // textBoxGolesLocal
            // 
            this.textBoxGolesLocal.Location = new System.Drawing.Point(270, 232);
            this.textBoxGolesLocal.Name = "textBoxGolesLocal";
            this.textBoxGolesLocal.Size = new System.Drawing.Size(100, 20);
            this.textBoxGolesLocal.TabIndex = 6;
            this.textBoxGolesLocal.TextChanged += new System.EventHandler(this.textBoxGolesLocal_TextChanged);
            // 
            // textBoxGolesVisitante
            // 
            this.textBoxGolesVisitante.Location = new System.Drawing.Point(773, 232);
            this.textBoxGolesVisitante.Name = "textBoxGolesVisitante";
            this.textBoxGolesVisitante.Size = new System.Drawing.Size(100, 20);
            this.textBoxGolesVisitante.TabIndex = 7;
            this.textBoxGolesVisitante.TextChanged += new System.EventHandler(this.textBoxGolesVisitante_TextChanged);
            // 
            // buttonSumarGolLocal
            // 
            this.buttonSumarGolLocal.Location = new System.Drawing.Point(230, 280);
            this.buttonSumarGolLocal.Name = "buttonSumarGolLocal";
            this.buttonSumarGolLocal.Size = new System.Drawing.Size(75, 23);
            this.buttonSumarGolLocal.TabIndex = 8;
            this.buttonSumarGolLocal.Text = "Sumar gol";
            this.buttonSumarGolLocal.UseVisualStyleBackColor = true;
            this.buttonSumarGolLocal.Click += new System.EventHandler(this.buttonSumarGolLocal_Click);
            // 
            // buttonRestarGolLocal
            // 
            this.buttonRestarGolLocal.Location = new System.Drawing.Point(350, 280);
            this.buttonRestarGolLocal.Name = "buttonRestarGolLocal";
            this.buttonRestarGolLocal.Size = new System.Drawing.Size(75, 23);
            this.buttonRestarGolLocal.TabIndex = 9;
            this.buttonRestarGolLocal.Text = "Anular gol";
            this.buttonRestarGolLocal.UseVisualStyleBackColor = true;
            this.buttonRestarGolLocal.Click += new System.EventHandler(this.buttonRestarGolLocal_Click);
            // 
            // buttonSumarGolVisitante
            // 
            this.buttonSumarGolVisitante.Location = new System.Drawing.Point(716, 280);
            this.buttonSumarGolVisitante.Name = "buttonSumarGolVisitante";
            this.buttonSumarGolVisitante.Size = new System.Drawing.Size(75, 23);
            this.buttonSumarGolVisitante.TabIndex = 10;
            this.buttonSumarGolVisitante.Text = "Sumar gol";
            this.buttonSumarGolVisitante.UseVisualStyleBackColor = true;
            this.buttonSumarGolVisitante.Click += new System.EventHandler(this.buttonSumarGolVisitante_Click);
            // 
            // buttonRestarGolVisitante
            // 
            this.buttonRestarGolVisitante.Location = new System.Drawing.Point(855, 280);
            this.buttonRestarGolVisitante.Name = "buttonRestarGolVisitante";
            this.buttonRestarGolVisitante.Size = new System.Drawing.Size(75, 23);
            this.buttonRestarGolVisitante.TabIndex = 11;
            this.buttonRestarGolVisitante.Text = "Anular gol";
            this.buttonRestarGolVisitante.UseVisualStyleBackColor = true;
            this.buttonRestarGolVisitante.Click += new System.EventHandler(this.buttonRestarGolVisitante_Click);
            // 
            // buttonReiniciar
            // 
            this.buttonReiniciar.Location = new System.Drawing.Point(430, 423);
            this.buttonReiniciar.Name = "buttonReiniciar";
            this.buttonReiniciar.Size = new System.Drawing.Size(155, 50);
            this.buttonReiniciar.TabIndex = 12;
            this.buttonReiniciar.Text = "Reiniciar";
            this.buttonReiniciar.UseVisualStyleBackColor = true;
            this.buttonReiniciar.Click += new System.EventHandler(this.buttonReiniciar_Click);
            // 
            // buttonIniciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 696);
            this.Controls.Add(this.buttonReiniciar);
            this.Controls.Add(this.buttonRestarGolVisitante);
            this.Controls.Add(this.buttonSumarGolVisitante);
            this.Controls.Add(this.buttonRestarGolLocal);
            this.Controls.Add(this.buttonSumarGolLocal);
            this.Controls.Add(this.textBoxGolesVisitante);
            this.Controls.Add(this.textBoxGolesLocal);
            this.Controls.Add(this.labelVisitante);
            this.Controls.Add(this.labelLocal);
            this.Controls.Add(this.buttonIniciarPartido);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxVisitante);
            this.Controls.Add(this.comboBoxLocal);
            this.Name = "buttonIniciar";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxLocal;
        private System.Windows.Forms.ComboBox comboBoxVisitante;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonIniciarPartido;
        private System.Windows.Forms.Label labelLocal;
        private System.Windows.Forms.Label labelVisitante;
        private System.Windows.Forms.TextBox textBoxGolesLocal;
        private System.Windows.Forms.TextBox textBoxGolesVisitante;
        private System.Windows.Forms.Button buttonSumarGolLocal;
        private System.Windows.Forms.Button buttonRestarGolLocal;
        private System.Windows.Forms.Button buttonSumarGolVisitante;
        private System.Windows.Forms.Button buttonRestarGolVisitante;
        private System.Windows.Forms.Button buttonReiniciar;
    }
}

