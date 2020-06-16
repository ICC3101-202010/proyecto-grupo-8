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


                Perfil p1 = new Perfil(Spotflix.usuarioenlinea, nombreperfil, tipo);
                Creado.Show();
                Spotflix.Lista_Perfiles.Add(p1);
                Spotflix.Lista_perfilesenlinea.Add(p1);
                MessageBox.Show("Tu perfil " + nombreperfil + " ha sido añadido a tu cuenta!");
                //Serializar la info de perfil.
                using (Stream fs1 = new FileStream(Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Informacion\Perfiles\Data_Perfiles.xml", FileMode.Create,
                    FileAccess.Write, FileShare.None))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Perfil>));
                    serializer.Serialize(fs1, Spotflix.Lista_Perfiles);
                }
                //Serializar la info de usuario
                using (Stream fs2 = new FileStream(Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Informacion\Usuarios\Data_Usuarios.xml", FileMode.Create,
                    FileAccess.Write, FileShare.None))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Usuario>));
                    serializer.Serialize(fs2, Spotflix.Lista_Usuarios);
                }
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
            Hide();
            Registro.p1.loadPerfiles(Registro.Cantidaddeperfiles(Spotflix.usuarioenlinea));

        }
    }
}
