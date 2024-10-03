using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitorPartidoFutbol
{
    public class Partido
    {
        public string EquipoLocal { get; set; }
        public string EquipoVisitante { get; set; }
        public int GolesLocal { get; set; }
        public int GolesVisitante { get; set; }
        public string Duracion { get; set; }
        public DateTime Fecha { get; set; }

        public Partido(string equipoLocal, string equipoVisitante, int golesLocal, int golesVisitante, string duracion, DateTime fecha)
        {
            EquipoLocal = equipoLocal;
            EquipoVisitante = equipoVisitante;
            GolesLocal = golesLocal;
            GolesVisitante = golesVisitante;
            Duracion = duracion;
            Fecha = fecha;
        }

        public override string ToString()
        {
        return $"{Fecha.ToString("g")}: {EquipoLocal} {GolesLocal} - { GolesVisitante} { EquipoVisitante} (Duración: { Duracion})";
        }
    }

}
