using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1CSharp
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAzulOscuro fr2 = new FormAzulOscuro();
            fr2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormVerde fr3 = new FormVerde();
            fr3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormAmarillo fr4 = new FormAmarillo();
            fr4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormRosa fr5 = new FormRosa();
            fr5.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormBlanco fr6 = new FormBlanco();
            fr6.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormNegro fr7 = new FormNegro();
            fr7.ShowDialog();  
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormMorado fr8 = new FormMorado();
            fr8.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FormGris fr9 = new FormGris();
            fr9.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FormRojo fr10 = new FormRojo();
            fr10.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FormDorado fr11 = new FormDorado();
            fr11.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FormRosita fr12 = new FormRosita();
            fr12.ShowDialog();
        }
    }
}
