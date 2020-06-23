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
            Registro.CambiodeCuenta = this;

        }

        private void CambiodeCuenta_Load(object sender, EventArgs e)
        {
            Show();
            comboBox1.Items.Add("Nombre de perfil");
            comboBox1.Items.Add("Tipo de Perfil");
            comboBox1.Items.Add("Contraseña");
            comboBox1.Items.Add("Membresia");
            comboBox1.Show();
            label2.Show();
            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            comboBox2.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = (string)comboBox1.SelectedItem;
            if (opcion == "Nombre de perfil")
            {
                label3.Text = "Nuevo nombre del perfil";
                textBox1.Show();
                textBox2.Hide();
                textBox3.Hide();
                textBox4.Hide();
                textBox5.Hide();
                textBox6.Hide();
                label3.Show();
                label4.Hide();
                label5.Hide();
                label6.Hide();
                label7.Hide();
                label8.Hide();
                comboBox2.Hide();

            }
            else if (opcion == "Tipo de Perfil")
            {
                comboBox2.Items.Clear();
                label3.Show();
                label3.Text = "Tipo de perfil";
                comboBox2.Show();
                comboBox2.Items.Add("Publico");
                comboBox2.Items.Add("Privado");
                comboBox2.Items.Add("Artista");
                textBox1.Hide();
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
                textBox1.Show();
                textBox2.Show();
                textBox3.Hide();
                textBox4.Hide();
                textBox5.Hide();
                textBox6.Hide();
                label3.Show();
                label4.Show();
                label5.Hide();
                label6.Hide();
                label7.Hide();
                label8.Hide();
                comboBox2.Hide();


            }
            else if (opcion == "Membresia")
            {
                comboBox2.Items.Clear();
                textBox1.Hide();
                textBox2.Hide();
                label3.Show();
                comboBox2.Show();
                label5.Hide();
                label6.Hide();
                label7.Hide();
                label8.Hide();
                textBox3.Hide();
                textBox4.Hide();
                textBox5.Hide();
                textBox6.Hide();
                label3.Text = "Membresia";
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
            else if ((string)comboBox1.SelectedItem == "Tipo de Perfil")
            {
                int tipo = 0;
                if ((string)comboBox2.SelectedItem == "Publico")
                {
                    tipo = 2;
                }
                else if ((string)comboBox2.SelectedItem == "Artista")
                {
                    tipo = 1;
                }
                else
                {
                    tipo = 3;
                }
                foreach (Perfil p in Spotflix.Lista_Perfiles)
                {

                    if (p == Spotflix.perfilenlinea)
                    {

                        Spotflix.perfilenlinea.Tipo_de_Perfil = tipo;
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
            MessageBox.Show("Cambio Realizado");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();

        }
        public void Showww()
        {
            label3.Show();
            label5.Show();
            label6.Show();
            label7.Show();
            label8.Show();
            textBox3.Show();
            textBox4.Show();
            textBox5.Show();
            textBox6.Show();
            label3.Text = "Membresia";
            label5.Text = "Banco";
            label6.Text = "Numero de tarjeta";
            label7.Text = "Fecha Vencimiento";
            label8.Text = "Codigo de Seguridad";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)comboBox1.SelectedItem == "Membresia")
            {
                string memb = (string)comboBox2.SelectedItem;
                if (memb == "Premium")
                {
                    Showww();
                }
                else
                {
                    label5.Hide();
                    label6.Hide();
                    label7.Hide();
                    label8.Hide();
                    textBox3.Hide();
                    textBox4.Hide();
                    textBox5.Hide();
                    textBox6.Hide();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Hide();
            
        }
    }
}
