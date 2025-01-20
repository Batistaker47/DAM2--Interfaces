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
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace SimulacroExamenInterfaces_DavidPires
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // EN ESTE MÉTODO LOCALIZAREMOS QUÉ CHECK BOX ESTÁ PULSADO PARA CARGAR SU RESPECTIVA IMAGEN
        private void checkedListBoxContinents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBoxContinents.Text == "África")
            {
                LoadAfricaImg();
            }
            else if (checkedListBoxContinents.Text == "Oceanía")
            {
                LoadOceaniaImg();
            }
            else if (checkedListBoxContinents.Text == "América")
            {
                LoadAmericaImg();
            }
            else if (checkedListBoxContinents.Text == "Europa")
            {
                LoadEuropaImg();
            }
            else if (checkedListBoxContinents.Text == "Asia")
            {
                LoadAsiaImg();
            }
        }

        // EN ESTE MÉTODO CARGAMOS LA FOTO DE AFRICA EN EL PICTUREBOX CORRESPONDIENTE.
        private void LoadAfricaImg()
        {
            try
            {
                // Declaramos la ruta
                string path = "C:/Users/Alumno/Desktop/Africa.jpg";
                // Verificar si el archivo existe
                if (File.Exists(path))
                {
                    // Cargar la imagen
                    pictureBoxAfrica.Image = Image.FromFile(path);
                    pictureBoxAfrica.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    MessageBox.Show("La imagen no se encontró en la ruta especificada.", "Error al cargar imagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Error al cargar imagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // EN ESTE MÉTODO CARGAMOS LA FOTO DE OCEANIA EN EL PICTUREBOX CORRESPONDIENTE.
        private void LoadOceaniaImg()
        {
            try
            {
                // Declaramos la ruta
                string path = "C:/Users/Alumno/Desktop/Oceania.jpg";

                // Verificar si el archivo existe
                if (File.Exists(path))
                {
                    // Cargar la imagen
                    pictureBoxOceania.Image = Image.FromFile(path);
                    pictureBoxOceania.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    MessageBox.Show("La imagen no se encontró en la ruta especificada.", "Error al cargar imagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Error al cargar imagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // EN ESTE MÉTODO CARGAMOS LA FOTO DE ASIA EN EL PICTUREBOX CORRESPONDIENTE.

        private void LoadAsiaImg()
        {
            try
            {
                // Declaramos la ruta
                string path = "C:/Users/Alumno/Desktop/Asia.jpg";

                // Verificar si el archivo existe
                if (File.Exists(path))
                {
                    // Cargar la imagen
                    pictureBoxAsia.Image = Image.FromFile(path);
                    pictureBoxAsia.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    MessageBox.Show("La imagen no se encontró en la ruta especificada.", "Error al cargar imagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Error al cargar imagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // EN ESTE MÉTODO CARGAMOS LA FOTO DE AMERICA EN EL PICTUREBOX CORRESPONDIENTE.

        private void LoadAmericaImg()
        {
            try
            {
                // Declaramos la ruta
                string path = "C:/Users/Alumno/Desktop/America.jpg";

                // Verificar si el archivo existe
                if (File.Exists(path))
                {
                    // Cargar la imagen
                    pictureBoxAmerica.Image = Image.FromFile(path);
                    pictureBoxAmerica.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    // Si no se encuentra la ruta salta este error
                    MessageBox.Show("La imagen no se encontró en la ruta especificada.", "Error al cargar imagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Coge la excepción por si hay error en la carga
                MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Error al cargar imagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // EN ESTE MÉTODO CARGAMOS LA FOTO DE EUROPA EN EL PICTUREBOX CORRESPONDIENTE.
        private void LoadEuropaImg()
        {
            try
            {
                // Declaramos la ruta absoulta
                string path = "C:/Users/Alumno/Desktop/Europa.jpg";

                // Verificamos si el archivo existe
                if (File.Exists(path))
                {
                    // Cargamos la imagen en el picture box
                    pictureBoxEuropa.Image = Image.FromFile(path);
                    pictureBoxEuropa.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    // Si no se encuentra la ruta salta este error
                    MessageBox.Show("La imagen no se encontró en la ruta especificada.", "Error al cargar imagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Coge la excepción por si hay error en la carga
                MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Error al cargar imagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
