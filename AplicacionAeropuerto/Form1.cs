using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Vuelos;

namespace AplicacionAeropuerto
{
    public partial class Form1 : Form
    {
        List<Vuelo> vuelos = new List<Vuelo> ();
        List<Aeropuerto> aeropuerto = new List<Aeropuerto> ();
        List<Aerolinea> aerolinea = new List<Aerolinea> ();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            aeropuerto = Aeropuerto.importar("aeropuertos.dat");
            aerolinea = Aerolinea.importar("aerolineas");
            vuelos = Vuelo.importar("vuelos.dat");
        }
    }
}
