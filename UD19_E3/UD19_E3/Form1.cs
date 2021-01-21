using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UD19_E3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(trackBar1, trackBar1.Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sistema="";
            if (radioButton1.Checked)
            {
                sistema = "Windows";
            }
            else if (radioButton2.Checked)
            {
                sistema = "Linux";
            }
            else if (radioButton3.Checked)
            {
                sistema = "Mac";
            }
            else
            {
                MessageBox.Show("Tienes que seleccionar un sistema operativo");
                //Application.Exit();
            }
            string especialidades="";
            if (checkBox1.Checked)
            {
                especialidades+= "Programación ";
            }
            if (checkBox2.Checked)
            {
                especialidades= especialidades + "Diseño gráfico ";
            }
            if (checkBox3.Checked)
            {
                especialidades += "Administración ";
            }
            MessageBox.Show("El usuario prefiere" + sistema + ", es especialista en (" + especialidades + ") y dedica " + trackBar1.Value + " horas semanales al ordenador");
        }
    }
}
