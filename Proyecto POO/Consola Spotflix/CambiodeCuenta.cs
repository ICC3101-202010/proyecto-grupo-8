using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_POO;

namespace Consola_Spotflix
{
    public partial class CambiodeCuenta : UserControl
    {
        public CambiodeCuenta()
        {
            InitializeComponent();
        }

        private void CambiodeCuenta_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Nombre de perfil");
            comboBox1.Items.Add("Tipo de Perfil");
            comboBox1.Items.Add("Contraseña");
            comboBox1.Items.Add("Membresia");



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = (string)comboBox1.SelectedItem;
            if (opcion == "Nombre de perfil")
            {
                label3.Text = "Nombre";
                textBox2.Hide();
                textBox3.Hide();
                textBox4.Hide();
                textBox5.Hide();
                textBox6.Hide();
                label4.Hide();
                label5.Hide();
                label6.Hide();
                label7.Hide();
                label8.Hide();
                comboBox2.Hide();
                
            }
            else if (opcion == "Tipo de perfil")
            {
                label3.Text = "Tipo de perfil";
                comboBox2.Items.Add("Publico");
                comboBox2.Items.Add("Privado");
                textBox2.Hide();
                textBox3.Hide();
                textBox4.Hide();
                textBox5.Hide();
                textBox6.Hide();
                label4.Hide();
                label5.Hide();
                label6.Hide();
                label7.Hide();
                label8.Hide();
                
            }
            else if (opcion == "Contraseña")
            {
                label3.Text = "Contraseña antigua";
                label4.Text = "Contraseña nueva";
                textBox3.Hide();
                textBox4.Hide();
                textBox5.Hide();
                textBox6.Hide();
                label5.Hide();
                label6.Hide();
                label7.Hide();
                label8.Hide();
                comboBox2.Hide();
                

            }
            else if (opcion == "Membresia")
            {
                textBox1.Hide();
                textBox2.Hide();
                label3.Text = "Membresia";
                label5.Text = "Banco";
                label6.Text = "Numero de tarjeta";
                label7.Text = "Fecha Vencimiento";
                label8.Text = "Codigo de Seguridad";
                label4.Hide();
                comboBox2.Items.Add("Gratis");
                comboBox2.Items.Add("Premium");

            }

        }

        private void Cambiar_Click(object sender, EventArgs e)
        {
            if ((string)comboBox1.SelectedItem == "Nombre de perfil")
            {
                string nombreperfil = textBox1.Text;
                foreach (Perfil p in Spotflix.Lista_Perfiles)
                {
                    if (p == Spotflix.perfilenlinea)
                    {
                        p.Nombre_perfil = nombreperfil;
                    }
                }

            }
            else if ((string)comboBox1.SelectedItem == "Tipo de perfil")
            {
                int tipo = 0;
                if ((string)comboBox2.SelectedItem == "Publico") 
                {
                    tipo = 1;
                }
                else 
                {
                    tipo = 2;
                }

                foreach (Perfil p in Spotflix.Lista_Perfiles)
                {
                    if (p == Spotflix.perfilenlinea)
                    {
                        p.Tipo_de_Perfil = tipo;
                    }
                }

            }
            else if ((string)comboBox1.SelectedItem == "Contraseña")
            {
                string contraseña = textBox2.Text;

                foreach (Usuario p in Spotflix.Lista_Usuarios)
                {
                    if (p == Spotflix.usuarioenlinea)
                    {
                        p.Contraseña = contraseña;
                    }
        

                }

            }
            else if ((string)comboBox1.SelectedItem == "Membresia")
            {
                int membresia = 0;
                if ((string)comboBox2.SelectedItem == "Gratis")
                {
                    membresia = 1;
                    label5.Hide();
                    label6.Hide();
                    label7.Hide();
                    label8.Hide();
                }
                else
                {
                    membresia = 2;
                }
                foreach (Usuario p in Spotflix.Lista_Usuarios)
                {
                    if (p == Spotflix.usuarioenlinea)
                    {
                        p.Tipo_de_Membresia = membresia;
                    }
                }

            }
        }
    }
}
