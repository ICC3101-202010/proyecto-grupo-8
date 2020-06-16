using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consola_Spotflix
{
    public partial class Archivo : UserControl
    {
        public Archivo()
        {
            InitializeComponent();
            Registro.Crear_Archivo = this;
            panel_Agregar_Archivo.Dock = DockStyle.Fill;
        }

        private void button_Atras_Agregar_archivo_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button_Atras_Agregar_persona_Click(object sender, EventArgs e)
        {
            panel_Agregar_Persona.Hide();
            panel_Agregar_Archivo.Show();
            panel_Agregar_Archivo.Dock = DockStyle.Fill;
                
        }

        private void button_Crear_Persona_Click(object sender, EventArgs e)
        {
            panel_Agregar_Archivo.Hide();
            panel_Agregar_Persona.Show();
            panel_Agregar_Persona.Dock = DockStyle.Fill;
        }

        private void buttonAgregar_segundo_compositor_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Crear_Persona_Click(object sender, EventArgs e)
        {
            panel_Agregar_Archivo.Hide();
            panel_Agregar_Persona.Show();
            panel_Agregar_Persona.Dock = DockStyle.Fill;
        }

        private void comboBox_Categorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Categorias.SelectedItem =="Canciones")
            {

            }
        }
    }
}
