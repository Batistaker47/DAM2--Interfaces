using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitorPartidoFutbol
{

    public partial class buttonIniciar : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {
            // Lista de equipos
            string[] equipos = { "Real Madrid", "FC Barcelona", "Atlético de Madrid", "Sevilla FC", "Valencia CF" };
            // Llenar ComboBox con los equipos
            comboBoxLocal.Items.AddRange(equipos);
            comboBoxVisitante.Items.AddRange(equipos);
            // Deshabilitar los controles del marcador hasta que se inicie el partido
            textBoxGolesLocal.Enabled = false;
            textBoxGolesVisitante.Enabled = false;
            buttonSumarGolLocal.Enabled = false;
            buttonRestarGolLocal.Enabled = false;
            buttonSumarGolVisitante.Enabled = false;
            buttonRestarGolVisitante.Enabled = false;
        }

        public buttonIniciar()
        {
            InitializeComponent();

        }
        private void comboBoxLocal_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxVisitante_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxGolesLocal_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxGolesVisitante_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void buttonIniciarPartido_Click(object sender, EventArgs e)
        {
            labelLocal.Text = comboBoxLocal.SelectedItem.ToString();
            labelVisitante.Text = comboBoxVisitante.SelectedItem.ToString();

            textBoxGolesLocal.Text = "0";
            textBoxGolesVisitante.Text = "0";

            textBoxGolesLocal.Enabled = true;
            textBoxGolesVisitante.Enabled = true;
            buttonSumarGolLocal.Enabled = true;
            buttonRestarGolLocal.Enabled = true;
            buttonSumarGolVisitante.Enabled = true;
            buttonRestarGolVisitante.Enabled = true;
            if (comboBoxLocal.SelectedItem == null || comboBoxVisitante.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione los equipos locales y visitantes.");
                return;
            }

        }

        private void buttonSumarGolLocal_Click(object sender, EventArgs e)
        {
            int golesLocal = int.Parse(textBoxGolesLocal.Text);
            golesLocal++;
            textBoxGolesLocal.Text = golesLocal.ToString();
        }

        private void buttonRestarGolLocal_Click(object sender, EventArgs e)
        {
            int golesLocal = int.Parse(textBoxGolesLocal.Text);
            if (golesLocal > 0)
            {
                golesLocal--;
            }
            textBoxGolesLocal.Text = golesLocal.ToString();
        }
        private void buttonSumarGolVisitante_Click(object sender, EventArgs e)
        {
            int golesVisitante = int.Parse(textBoxGolesVisitante.Text);
            golesVisitante++;
            textBoxGolesVisitante.Text = golesVisitante.ToString();
        }

        private void buttonRestarGolVisitante_Click(object sender, EventArgs e)
        {
            int golesVisitante = int.Parse(textBoxGolesVisitante.Text);
            if (golesVisitante > 0)
            {
                golesVisitante--;
            }
            textBoxGolesVisitante.Text = golesVisitante.ToString();
        }

        private void buttonReiniciar_Click(object sender, EventArgs e)
        {
            // Limpiar ComboBox y desactivar controles de marcador
            comboBoxLocal.SelectedItem = null;
            comboBoxVisitante.SelectedItem = null;
            textBoxGolesLocal.Text = "";
            textBoxGolesVisitante.Text = "";
            labelLocal.Text = "Equipo Local";
            labelVisitante.Text = "Equipo Visitante";
            // Deshabilitar los controles del marcador
            textBoxGolesLocal.Enabled = false;
            textBoxGolesVisitante.Enabled = false;
            buttonSumarGolLocal.Enabled = false;
            buttonRestarGolLocal.Enabled = false;
            buttonSumarGolVisitante.Enabled = false;
            buttonRestarGolVisitante.Enabled = false;
        }

    }
}
