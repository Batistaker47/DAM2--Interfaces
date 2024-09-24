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
            this.comboBoxLocal = new System.Windows.Forms.ComboBox();
            this.comboBoxVisitante = new System.Windows.Forms.ComboBox();
            this.buttonIniciar = new System.Windows.Forms.Button();
            this.labelLocal = new System.Windows.Forms.Label();
            this.labelVisitante = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxLocal
            // 
            this.comboBoxLocal.FormattingEnabled = true;
            this.comboBoxLocal.Location = new System.Drawing.Point(252, 175);
            this.comboBoxLocal.Name = "comboBoxLocal";
            this.comboBoxLocal.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLocal.TabIndex = 0;
            this.comboBoxLocal.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxVisitante
            // 
            this.comboBoxVisitante.FormattingEnabled = true;
            this.comboBoxVisitante.Location = new System.Drawing.Point(619, 175);
            this.comboBoxVisitante.Name = "comboBoxVisitante";
            this.comboBoxVisitante.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVisitante.TabIndex = 1;
            this.comboBoxVisitante.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.Location = new System.Drawing.Point(433, 267);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(116, 23);
            this.buttonIniciar.TabIndex = 2;
            this.buttonIniciar.Text = "Iniciar partido";
            this.buttonIniciar.UseVisualStyleBackColor = true;
            this.buttonIniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelLocal
            // 
            this.labelLocal.AutoSize = true;
            this.labelLocal.Location = new System.Drawing.Point(282, 141);
            this.labelLocal.Name = "labelLocal";
            this.labelLocal.Size = new System.Drawing.Size(35, 13);
            this.labelLocal.TabIndex = 3;
            this.labelLocal.Text = "label1";
            // 
            // labelVisitante
            // 
            this.labelVisitante.AutoSize = true;
            this.labelVisitante.Location = new System.Drawing.Point(669, 141);
            this.labelVisitante.Name = "labelVisitante";
            this.labelVisitante.Size = new System.Drawing.Size(35, 13);
            this.labelVisitante.TabIndex = 4;
            this.labelVisitante.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "buttonSumarGolLocal";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(244, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "buttonRestarGolLocal";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(596, 202);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "buttonSumarGolVisitante";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(596, 231);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(171, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "buttonRestarGolVisitante";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(433, 307);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(116, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Reiniciar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 504);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

