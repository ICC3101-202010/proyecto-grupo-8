﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_POO;
using Consola_Spotflix;
using System.IO;
using System.Xml.Serialization;

namespace Proyecto_POO
{
    public partial class NuevoPerfil : UserControl
    {
        string nombreperfil;
        string tipodeperfil;
        string direccion_imagen = "";

        public NuevoPerfil()
        {
            InitializeComponent();
            Registro.np1=this;
        }
        

        private void NombrePerfil_TextChanged(object sender, EventArgs e)
        {
           nombreperfil = NombrePerfil.Text;
        }


        private void comboTipoPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipodeperfil = comboTipoPerfil.SelectedItem.ToString();
        }
        int a = 0;
        private void botonCrearPerfil_Click(object sender, EventArgs e)
        {
            a += 1;
            if (a % 2 == 0)
            {
                if (NombrePerfil.Text == null || comboTipoPerfil.Items == null)
                {
                    NoCreado.Show();
                }

                int tipo = 0;
                if (tipodeperfil == "Artista")
                {
                    tipo = 1;
                }
                if (tipodeperfil == "Publico")
                {
                    tipo = 2;

                }
                if (tipodeperfil == "Privado")
                {
                    tipo = 3;
                }

                string foto = direccion_imagen;
                Perfil p1 = new Perfil(Spotflix.usuarioenlinea, nombreperfil, tipo, foto);
                Creado.Show();
                Spotflix.Lista_Perfiles.Add(p1);
                Spotflix.Lista_perfilesenlinea.Add(p1);
                MessageBox.Show("Tu perfil " + nombreperfil + " ha sido añadido a tu cuenta!");
                //Serializar la info de perfil.
            }
            else
            {
                NoCreado.Show();
            }
           
        }

        private void NuevoPerfil_Load(object sender, EventArgs e)
        {
            Creado.Hide();
            NoCreado.Hide();
            comboTipoPerfil.Items.Add("Artista");
            comboTipoPerfil.Items.Add("Publico");
            comboTipoPerfil.Items.Add("Privado");

        }

        private void Back_Click(object sender, EventArgs e)
        {
            int cantperfenlinea = Spotflix.Lista_perfilesenlinea.Count();
            Registro.p1.loadPerfiles(cantperfenlinea);
            Hide();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string sourceFile;
            string destFile = "";
            openFileDialog1.Filter = "Archivo files|*.png;*.jpg;.*;";
            DialogResult dres1 = openFileDialog1.ShowDialog();
            if (dres1 == DialogResult.Abort)
            {
                return;
            }
            if (dres1 == DialogResult.Cancel)
            {
                return;
            }
            sourceFile = openFileDialog1.FileName;
            
            destFile = Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Informacion\Perfiles\" + Path.GetFileName(openFileDialog1.FileName); ;
            File.Copy(sourceFile, destFile, true);

            direccion_imagen = destFile;
            FotoDePerfil.Text = Path.GetFileName(openFileDialog1.FileName);
        }
    }
}
