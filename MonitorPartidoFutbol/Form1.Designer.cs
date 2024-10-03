namespace MonitorPartidoFutbol
{
    partial class Form1
    {
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
            this.components = new System.ComponentModel.Container();
            this.comboBoxLocal = new System.Windows.Forms.ComboBox();
            this.comboBoxVisitante = new System.Windows.Forms.ComboBox();
            this.buttonIniciar = new System.Windows.Forms.Button();
            this.labelLocal = new System.Windows.Forms.Label();
            this.labelVisitante = new System.Windows.Forms.Label();
            this.textBoxGolesLocal = new System.Windows.Forms.TextBox();
            this.textBoxGolesVisitante = new System.Windows.Forms.TextBox();
            this.buttonSumarGolLocal = new System.Windows.Forms.Button();
            this.buttonRestarGolLocal = new System.Windows.Forms.Button();
            this.buttonSumarGolVisitante = new System.Windows.Forms.Button();
            this.buttonRestarGolVisitante = new System.Windows.Forms.Button();
            this.buttonReiniciar = new System.Windows.Forms.Button();
            this.labelCronometro = new System.Windows.Forms.Label();
            this.listBoxGoles = new System.Windows.Forms.ListBox();
            this.timerPartido = new System.Windows.Forms.Timer(this.components);
            this.lblTotalGoles = new System.Windows.Forms.Label();
            this.lblGolesLocal = new System.Windows.Forms.Label();
            this.lblGolesVisitante = new System.Windows.Forms.Label();
            this.buttonExportar = new System.Windows.Forms.Button();
            this.lstHistorial = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // comboBoxLocal
            // 
            this.comboBoxLocal.FormattingEnabled = true;
            this.comboBoxLocal.Location = new System.Drawing.Point(100, 94);
            this.comboBoxLocal.Name = "comboBoxLocal";
            this.comboBoxLocal.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLocal.TabIndex = 0;
            this.comboBoxLocal.SelectedIndexChanged += new System.EventHandler(this.comboBoxLocal_SelectedIndexChanged);
            // 
            // comboBoxVisitante
            // 
            this.comboBoxVisitante.FormattingEnabled = true;
            this.comboBoxVisitante.Location = new System.Drawing.Point(420, 94);
            this.comboBoxVisitante.Name = "comboBoxVisitante";
            this.comboBoxVisitante.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVisitante.TabIndex = 1;
            this.comboBoxVisitante.SelectedIndexChanged += new System.EventHandler(this.comboBoxVisitante_SelectedIndexChanged);
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.Location = new System.Drawing.Point(283, 224);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(95, 23);
            this.buttonIniciar.TabIndex = 2;
            this.buttonIniciar.Text = "Iniciar Partido";
            this.buttonIniciar.UseVisualStyleBackColor = true;
            this.buttonIniciar.Click += new System.EventHandler(this.buttonIniciar_Click);
            // 
            // labelLocal
            // 
            this.labelLocal.AutoSize = true;
            this.labelLocal.Location = new System.Drawing.Point(142, 130);
            this.labelLocal.Name = "labelLocal";
            this.labelLocal.Size = new System.Drawing.Size(35, 13);
            this.labelLocal.TabIndex = 3;
            this.labelLocal.Text = "label1";
            this.labelLocal.Click += new System.EventHandler(this.labelLocal_Click);
            // 
            // labelVisitante
            // 
            this.labelVisitante.AutoSize = true;
            this.labelVisitante.Location = new System.Drawing.Point(465, 130);
            this.labelVisitante.Name = "labelVisitante";
            this.labelVisitante.Size = new System.Drawing.Size(35, 13);
            this.labelVisitante.TabIndex = 4;
            this.labelVisitante.Text = "label2";
            this.labelVisitante.Click += new System.EventHandler(this.labelVisitante_Click);
            // 
            // textBoxGolesLocal
            // 
            this.textBoxGolesLocal.Location = new System.Drawing.Point(111, 159);
            this.textBoxGolesLocal.Name = "textBoxGolesLocal";
            this.textBoxGolesLocal.Size = new System.Drawing.Size(100, 20);
            this.textBoxGolesLocal.TabIndex = 5;
            this.textBoxGolesLocal.TextChanged += new System.EventHandler(this.textBoxGolesLocal_TextChanged);
            // 
            // textBoxGolesVisitante
            // 
            this.textBoxGolesVisitante.Location = new System.Drawing.Point(430, 158);
            this.textBoxGolesVisitante.Name = "textBoxGolesVisitante";
            this.textBoxGolesVisitante.Size = new System.Drawing.Size(100, 20);
            this.textBoxGolesVisitante.TabIndex = 6;
            this.textBoxGolesVisitante.TextChanged += new System.EventHandler(this.textBoxGolesVisitante_TextChanged);
            // 
            // buttonSumarGolLocal
            // 
            this.buttonSumarGolLocal.Location = new System.Drawing.Point(63, 185);
            this.buttonSumarGolLocal.Name = "buttonSumarGolLocal";
            this.buttonSumarGolLocal.Size = new System.Drawing.Size(75, 23);
            this.buttonSumarGolLocal.TabIndex = 7;
            this.buttonSumarGolLocal.Text = "Añadir Gol";
            this.buttonSumarGolLocal.UseVisualStyleBackColor = true;
            this.buttonSumarGolLocal.Click += new System.EventHandler(this.buttonSumarGolLocal_Click);
            // 
            // buttonRestarGolLocal
            // 
            this.buttonRestarGolLocal.Location = new System.Drawing.Point(173, 185);
            this.buttonRestarGolLocal.Name = "buttonRestarGolLocal";
            this.buttonRestarGolLocal.Size = new System.Drawing.Size(75, 23);
            this.buttonRestarGolLocal.TabIndex = 8;
            this.buttonRestarGolLocal.Text = "Anular Gol";
            this.buttonRestarGolLocal.UseVisualStyleBackColor = true;
            this.buttonRestarGolLocal.Click += new System.EventHandler(this.buttonRestarGolLocal_Click);
            // 
            // buttonSumarGolVisitante
            // 
            this.buttonSumarGolVisitante.Location = new System.Drawing.Point(386, 184);
            this.buttonSumarGolVisitante.Name = "buttonSumarGolVisitante";
            this.buttonSumarGolVisitante.Size = new System.Drawing.Size(75, 23);
            this.buttonSumarGolVisitante.TabIndex = 9;
            this.buttonSumarGolVisitante.Text = "Añadir Gol";
            this.buttonSumarGolVisitante.UseVisualStyleBackColor = true;
            this.buttonSumarGolVisitante.Click += new System.EventHandler(this.buttonSumarGolVisitante_Click);
            // 
            // buttonRestarGolVisitante
            // 
            this.buttonRestarGolVisitante.Location = new System.Drawing.Point(507, 184);
            this.buttonRestarGolVisitante.Name = "buttonRestarGolVisitante";
            this.buttonRestarGolVisitante.Size = new System.Drawing.Size(75, 23);
            this.buttonRestarGolVisitante.TabIndex = 10;
            this.buttonRestarGolVisitante.Text = "Anular Gol";
            this.buttonRestarGolVisitante.UseVisualStyleBackColor = true;
            this.buttonRestarGolVisitante.Click += new System.EventHandler(this.buttonRestarGolVisitante_Click);
            // 
            // buttonReiniciar
            // 
            this.buttonReiniciar.Location = new System.Drawing.Point(283, 262);
            this.buttonReiniciar.Name = "buttonReiniciar";
            this.buttonReiniciar.Size = new System.Drawing.Size(95, 23);
            this.buttonReiniciar.TabIndex = 11;
            this.buttonReiniciar.Text = "Reiniciar";
            this.buttonReiniciar.UseVisualStyleBackColor = true;
            this.buttonReiniciar.Click += new System.EventHandler(this.buttonReiniciar_Click);
            // 
            // labelCronometro
            // 
            this.labelCronometro.AutoSize = true;
            this.labelCronometro.Location = new System.Drawing.Point(307, 61);
            this.labelCronometro.Name = "labelCronometro";
            this.labelCronometro.Size = new System.Drawing.Size(34, 13);
            this.labelCronometro.TabIndex = 12;
            this.labelCronometro.Text = "00:00";
            this.labelCronometro.Click += new System.EventHandler(this.labelCronometro_Click);
            // 
            // listBoxGoles
            // 
            this.listBoxGoles.FormattingEnabled = true;
            this.listBoxGoles.Location = new System.Drawing.Point(111, 309);
            this.listBoxGoles.Name = "listBoxGoles";
            this.listBoxGoles.Size = new System.Drawing.Size(454, 95);
            this.listBoxGoles.TabIndex = 13;
            this.listBoxGoles.SelectedIndexChanged += new System.EventHandler(this.listBoxGoles_SelectedIndexChanged);
            // 
            // timerPartido
            // 
            this.timerPartido.Interval = 1000;
            this.timerPartido.Tick += new System.EventHandler(this.timerPartido_Tick);
            // 
            // lblTotalGoles
            // 
            this.lblTotalGoles.AutoSize = true;
            this.lblTotalGoles.Location = new System.Drawing.Point(68, 432);
            this.lblTotalGoles.Name = "lblTotalGoles";
            this.lblTotalGoles.Size = new System.Drawing.Size(86, 13);
            this.lblTotalGoles.TabIndex = 14;
            this.lblTotalGoles.Text = "Total de goles: 0";
            this.lblTotalGoles.Click += new System.EventHandler(this.lblTotalGoles_Click);
            // 
            // lblGolesLocal
            // 
            this.lblGolesLocal.AutoSize = true;
            this.lblGolesLocal.Location = new System.Drawing.Point(185, 432);
            this.lblGolesLocal.Name = "lblGolesLocal";
            this.lblGolesLocal.Size = new System.Drawing.Size(35, 13);
            this.lblGolesLocal.TabIndex = 15;
            this.lblGolesLocal.Text = "label1";
            this.lblGolesLocal.Click += new System.EventHandler(this.lblGolesLocal_Click);
            // 
            // lblGolesVisitante
            // 
            this.lblGolesVisitante.AutoSize = true;
            this.lblGolesVisitante.Location = new System.Drawing.Point(247, 432);
            this.lblGolesVisitante.Name = "lblGolesVisitante";
            this.lblGolesVisitante.Size = new System.Drawing.Size(35, 13);
            this.lblGolesVisitante.TabIndex = 16;
            this.lblGolesVisitante.Text = "label2";
            this.lblGolesVisitante.Click += new System.EventHandler(this.lblGolesVisitante_Click);
            // 
            // buttonExportar
            // 
            this.buttonExportar.Location = new System.Drawing.Point(333, 432);
            this.buttonExportar.Name = "buttonExportar";
            this.buttonExportar.Size = new System.Drawing.Size(75, 23);
            this.buttonExportar.TabIndex = 17;
            this.buttonExportar.Text = "Exportar";
            this.buttonExportar.UseVisualStyleBackColor = true;
            this.buttonExportar.Click += new System.EventHandler(this.ExportarHistorial_Click);
            // 
            // lstHistorial
            // 
            this.lstHistorial.FormattingEnabled = true;
            this.lstHistorial.Location = new System.Drawing.Point(46, 461);
            this.lstHistorial.Name = "lstHistorial";
            this.lstHistorial.Size = new System.Drawing.Size(566, 56);
            this.lstHistorial.TabIndex = 18;
            this.lstHistorial.SelectedIndexChanged += new System.EventHandler(this.lstHistorial_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 538);
            this.Controls.Add(this.lstHistorial);
            this.Controls.Add(this.buttonExportar);
            this.Controls.Add(this.lblGolesVisitante);
            this.Controls.Add(this.lblGolesLocal);
            this.Controls.Add(this.lblTotalGoles);
            this.Controls.Add(this.listBoxGoles);
            this.Controls.Add(this.labelCronometro);
            this.Controls.Add(this.buttonReiniciar);
            this.Controls.Add(this.buttonRestarGolVisitante);
            this.Controls.Add(this.buttonSumarGolVisitante);
            this.Controls.Add(this.buttonRestarGolLocal);
            this.Controls.Add(this.buttonSumarGolLocal);
            this.Controls.Add(this.textBoxGolesVisitante);
            this.Controls.Add(this.textBoxGolesLocal);
            this.Controls.Add(this.labelVisitante);
            this.Controls.Add(this.labelLocal);
            this.Controls.Add(this.buttonIniciar);
            this.Controls.Add(this.comboBoxVisitante);
            this.Controls.Add(this.comboBoxLocal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxLocal;
        private System.Windows.Forms.ComboBox comboBoxVisitante;
        private System.Windows.Forms.Button buttonIniciar;
        private System.Windows.Forms.Label labelLocal;
        private System.Windows.Forms.Label labelVisitante;
        private System.Windows.Forms.TextBox textBoxGolesLocal;
        private System.Windows.Forms.TextBox textBoxGolesVisitante;
        private System.Windows.Forms.Button buttonSumarGolLocal;
        private System.Windows.Forms.Button buttonRestarGolLocal;
        private System.Windows.Forms.Button buttonSumarGolVisitante;
        private System.Windows.Forms.Button buttonRestarGolVisitante;
        private System.Windows.Forms.Button buttonReiniciar;
        private System.Windows.Forms.Label labelCronometro;
        private System.Windows.Forms.ListBox listBoxGoles;
        private System.Windows.Forms.Timer timerPartido;
        private System.Windows.Forms.Label lblTotalGoles;
        private System.Windows.Forms.Label lblGolesLocal;
        private System.Windows.Forms.Label lblGolesVisitante;
        private System.Windows.Forms.Button buttonExportar;
        private System.Windows.Forms.ListBox lstHistorial;
    }
}

