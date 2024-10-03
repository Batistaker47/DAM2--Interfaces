using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MonitorPartidoFutbol.Partido;

namespace MonitorPartidoFutbol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }


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

        private void buttonIniciar_Click(object sender, EventArgs e)
        {
            if (comboBoxLocal.SelectedItem == null || comboBoxVisitante.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione los equipos locales y visitantes.");
                return;
            }

            // Mostrar los nombres de los equipos
            labelLocal.Text = comboBoxLocal.SelectedItem.ToString();
            labelVisitante.Text = comboBoxVisitante.SelectedItem.ToString();
            // Inicializar los marcadores en 0
            textBoxGolesLocal.Text = "0";
            textBoxGolesVisitante.Text = "0";
            // Habilitar los controles del marcador
            textBoxGolesLocal.Enabled = true;
            textBoxGolesVisitante.Enabled = true;
            buttonSumarGolLocal.Enabled = true;
            buttonRestarGolLocal.Enabled = true;
            buttonSumarGolVisitante.Enabled = true;
            buttonRestarGolVisitante.Enabled = true;
            // Dar inicio al contedo del cronómetro
            segundos = 0;
            timerPartido.Start();
        }
        private void comboBoxLocal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void comboBoxVisitante_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelLocal_Click(object sender, EventArgs e)
        {

        }

        private void labelVisitante_Click(object sender, EventArgs e)
        {

        }

        private void textBoxGolesLocal_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxGolesVisitante_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSumarGolLocal_Click(object sender, EventArgs e)
        {
            int golesLocal = int.Parse(textBoxGolesLocal.Text);
            golesLocal++;
            textBoxGolesLocal.Text = golesLocal.ToString();
            string tiempoGol = labelCronometro.Text;
            listBoxGoles.Items.Add("Gol Local - " + tiempoGol);
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
            string tiempoGol = labelCronometro.Text;
            listBoxGoles.Items.Add("Gol Visitante - " + tiempoGol);
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
            GuardarPartido();
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
            // Reiniciar el cronómetro y los segundos
            segundos = 0;
            labelCronometro.Text = "00:00";
            // Detener y reiniciar el Timer
            timerPartido.Stop();
            // Limpiar la lista de goles
            listBoxGoles.Items.Clear();
        }

        private void labelCronometro_Click(object sender, EventArgs e)
        {

        }

        private void listBoxGoles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        int segundos = 0;
        private void timerPartido_Tick(object sender, EventArgs e)
        {
            // Incrementar el tiempo en segundos
            segundos++;
            // Calcular los minutos y segundos para mostrarlos en el Label
            int minutos = segundos / 60;
            int segundosRestantes = segundos % 60;
            // Actualizar el Label del cronómetro
            labelCronometro.Text = minutos.ToString("00") + ":" +
            segundosRestantes.ToString("00");
        }

        private void lblTotalGoles_Click(object sender, EventArgs e)
        {

        }

        private void lblGolesLocal_Click(object sender, EventArgs e)
        {

        }

        private void lblGolesVisitante_Click(object sender, EventArgs e)
        {

        }

        private void buttonExportar_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new
            StreamWriter("partido.csv"))
            {
                writer.WriteLine("Equipo,Minuto");
                foreach (var item in listBoxGoles.Items)
                {
                    writer.WriteLine(item.ToString());
                }
                writer.WriteLine("Duración Total: " +
                labelCronometro.Text);
            }
            MessageBox.Show("Datos exportados correctamente.");
        }

        private void lstHistorial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ActualizarEstadisticas()
        {
            int golesLocal = listBoxGoles.Items.Cast<string>().Count(g =>
            g.Contains("Gol Local"));
            int golesVisitante = listBoxGoles.Items.Cast<string>().Count(g
            => g.Contains("Gol Visitante"));
            lblTotalGoles.Text = "Total Goles: " + (golesLocal +
            golesVisitante);
            lblGolesLocal.Text = "Goles Local: " + golesLocal;
            lblGolesVisitante.Text = "Goles Visitante: " +
            golesVisitante;
        }

        List<Partido> historialPartidos = new List<Partido>();

        private void GuardarPartido()
        {
            String EquipoLocal = comboBoxLocal.SelectedItem.ToString();
            String EquipoVisitante = comboBoxVisitante.SelectedItem.ToString();
            int GolesLocal = int.Parse(textBoxGolesLocal.Text);
            int GolesVisitante = int.Parse(textBoxGolesVisitante.Text);
            String Duracion = labelCronometro.Text;
            DateTime Fecha = DateTime.Now;
            Partido partido = new Partido(EquipoLocal, EquipoVisitante, GolesLocal, GolesVisitante, Duracion, Fecha);
           
            historialPartidos.Add(partido);
            lstHistorial.Items.Add(partido.ToString());
            // ListBox para mostrar el historial
        }

        private void ExportarHistorial_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("historial.csv"))
            {
                writer.WriteLine("Fecha,Equipo Local,Goles Local,Equipo Visitante, Goles Visitante, Duración");
                foreach (var partido in historialPartidos)
                {
                    writer.WriteLine($"{partido.Fecha},{partido.EquipoLocal},{partido.GolesLocal},{partido.EquipoVisitante},{partido.GolesVisitante},{partido.Duracion}");
                }
            }
            MessageBox.Show("Historial exportado correctamente.");
        }
    }


}