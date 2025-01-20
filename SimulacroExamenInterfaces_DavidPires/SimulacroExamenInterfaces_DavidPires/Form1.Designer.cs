namespace SimulacroExamenInterfaces_DavidPires
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
            this.checkedListBoxContinents = new System.Windows.Forms.CheckedListBox();
            this.pictureBoxEuropa = new System.Windows.Forms.PictureBox();
            this.pictureBoxAfrica = new System.Windows.Forms.PictureBox();
            this.pictureBoxOceania = new System.Windows.Forms.PictureBox();
            this.pictureBoxAsia = new System.Windows.Forms.PictureBox();
            this.pictureBoxAmerica = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEuropa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAfrica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOceania)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAsia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAmerica)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBoxContinents
            // 
            this.checkedListBoxContinents.FormattingEnabled = true;
            this.checkedListBoxContinents.Items.AddRange(new object[] {
            "Europa",
            "Asia",
            "África",
            "Oceanía",
            "América"});
            this.checkedListBoxContinents.Location = new System.Drawing.Point(413, 29);
            this.checkedListBoxContinents.Name = "checkedListBoxContinents";
            this.checkedListBoxContinents.Size = new System.Drawing.Size(120, 94);
            this.checkedListBoxContinents.TabIndex = 0;
            this.checkedListBoxContinents.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxContinents_SelectedIndexChanged);
            // 
            // pictureBoxEuropa
            // 
            this.pictureBoxEuropa.Location = new System.Drawing.Point(41, 29);
            this.pictureBoxEuropa.Name = "pictureBoxEuropa";
            this.pictureBoxEuropa.Size = new System.Drawing.Size(249, 256);
            this.pictureBoxEuropa.TabIndex = 1;
            this.pictureBoxEuropa.TabStop = false;
            // 
            // pictureBoxAfrica
            // 
            this.pictureBoxAfrica.Location = new System.Drawing.Point(370, 334);
            this.pictureBoxAfrica.Name = "pictureBoxAfrica";
            this.pictureBoxAfrica.Size = new System.Drawing.Size(246, 243);
            this.pictureBoxAfrica.TabIndex = 2;
            this.pictureBoxAfrica.TabStop = false;
            // 
            // pictureBoxOceania
            // 
            this.pictureBoxOceania.Location = new System.Drawing.Point(657, 336);
            this.pictureBoxOceania.Name = "pictureBoxOceania";
            this.pictureBoxOceania.Size = new System.Drawing.Size(235, 243);
            this.pictureBoxOceania.TabIndex = 3;
            this.pictureBoxOceania.TabStop = false;
            // 
            // pictureBoxAsia
            // 
            this.pictureBoxAsia.Location = new System.Drawing.Point(41, 334);
            this.pictureBoxAsia.Name = "pictureBoxAsia";
            this.pictureBoxAsia.Size = new System.Drawing.Size(249, 245);
            this.pictureBoxAsia.TabIndex = 4;
            this.pictureBoxAsia.TabStop = false;
            // 
            // pictureBoxAmerica
            // 
            this.pictureBoxAmerica.Location = new System.Drawing.Point(657, 29);
            this.pictureBoxAmerica.Name = "pictureBoxAmerica";
            this.pictureBoxAmerica.Size = new System.Drawing.Size(242, 256);
            this.pictureBoxAmerica.TabIndex = 5;
            this.pictureBoxAmerica.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 617);
            this.Controls.Add(this.pictureBoxAmerica);
            this.Controls.Add(this.pictureBoxAsia);
            this.Controls.Add(this.pictureBoxOceania);
            this.Controls.Add(this.pictureBoxAfrica);
            this.Controls.Add(this.pictureBoxEuropa);
            this.Controls.Add(this.checkedListBoxContinents);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEuropa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAfrica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOceania)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAsia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAmerica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxContinents;
        private System.Windows.Forms.PictureBox pictureBoxEuropa;
        private System.Windows.Forms.PictureBox pictureBoxAfrica;
        private System.Windows.Forms.PictureBox pictureBoxOceania;
        private System.Windows.Forms.PictureBox pictureBoxAsia;
        private System.Windows.Forms.PictureBox pictureBoxAmerica;
    }
}

