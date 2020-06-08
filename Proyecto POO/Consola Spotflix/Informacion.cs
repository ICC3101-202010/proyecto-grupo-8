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
using static Proyecto_POO.Perfil;
using static Proyecto_POO.Persona;
using static Proyecto_POO.AudioLibro;
using static Proyecto_POO.Video;

namespace Consola_Spotflix
{
    public partial class Informacion : UserControl
    {
        public Informacion()
        {
            InitializeComponent();
        }

        private void UsPer_Click_1(object sender, EventArgs e)
        {
            listBox1.Show();
            listBox2.Hide();
            listBox3.Hide();
            int a = 1;
            listBox1.Items.Clear();
            foreach (Usuario u in Spotflix.Lista_Usuarios)
            {
                listBox1.Items.Add(a.ToString() + ". Usuario:" + u.Nombre + " Email: " + u.Email + " Pais: " + u.Pais + " Membresia: " + (enum_TipoDeMembresia)u.Tipo_de_Membresia);
                listBox1.Items.Add("Perfiles:");
                foreach (Perfil p in Spotflix.Lista_Perfiles)
                {
                    if (p.Usuario_Asociado == u)
                    {
                        listBox1.Items.Add("Perfil: " + p.Nombre_perfil + " Tipo de perfil: " + (enum_TipoDePerfil)p.Tipo_de_Perfil + " Usuario Asociado: " + p.Usuario_Asociado.Nombre);
                    }
                }
            }
        }

        private void People_Click_1(object sender, EventArgs e)
        {
            listBox1.Hide();
            listBox2.Show();
            listBox3.Hide();

            listBox2.Items.Clear();
            int b = 1;
            foreach (Persona p in Spotflix.Lista_Personas)
            {
                string profesion = "";
                foreach (var item in p.Profesion)
                {
                    profesion += (enum_Profesion)item + " ";
                }
                listBox2.Items.Add(b.ToString() + ". Persona: " + p.Nombre_y_Apellido + "Nacionalidad: " + p.Nacionalidad + " Profesion: " + profesion);
                b += 1;
            }
        }

        private void Multimedia_Click_1(object sender, EventArgs e)
        {
            listBox1.Hide();
            listBox2.Hide();
            listBox3.Show();
            listBox3.Items.Clear();
            int c = 1;
            foreach (AudioLibro al in Spotflix.Lista_AudioLibros)
            {
                listBox3.Items.Add(c.ToString() + ". AudioLibro: " + al.Titulo + " Año: " + al.Año + " Genero:" + al.Genero + " Idioma: " + (enum_Idioma)al.Idioma + " Ranking; " + al.Ranking);
                c += 1;
            }
            listBox3.Items.Add("------------------------------------------------------------------------");
            c = 0;
            foreach (Cancion al in Spotflix.Lista_Canciones)
            {
                string cantantes = "";
                foreach (var item in al.Cantante)
                {
                    cantantes += item + " ";
                }
                c += 1;
                listBox3.Items.Add(c.ToString() + ". Cancion: " + al.Titulo + " Año: " + al.Año + " Genero:" + al.Genero + " Cantante/s: " + cantantes + " Ranking; " + al.Ranking);
            }
            listBox3.Items.Add("------------------------------------------------------------------------");
            c = 0;
            foreach (Pelicula al in Spotflix.Lista_Peliculas)
            {
                c += 1;
                string actores = "";
                foreach (var item in al.Actor)
                {
                    actores += item + " ";
                }
                listBox3.Items.Add(c.ToString() + ". Pelicula: " + al.Titulo + " Año: " + al.Año + " Genero:" + al.Genero + " Actores : " + actores + " Ranking; " + al.Ranking);
                c += 1;
            }
            listBox3.Items.Add("------------------------------------------------------------------------");
            c = 1;
            foreach (Podcast al in Spotflix.Lista_Podcasts)
            {
                string locutores = "";
                foreach (var item in al.Locutor)
                {
                    locutores += item + " ";
                }
                listBox3.Items.Add(c.ToString() + ". AudioLibro: " + al.Titulo + " Año: " + al.Año + " Genero:" + al.Genero + " Locutor " + locutores + " Ranking; " + al.Ranking);
                c += 1;
            }
            listBox3.Items.Add("------------------------------------------------------------------------");
            c = 0;
            foreach (Video al in Spotflix.Lista_Videos)
            {
                c += 1;
                listBox3.Items.Add(c.ToString() + ". Video: " + al.Titulo + " Año: " + al.Año + " Genero:" + al.Genero + "Clasificacion: " + (enum_Clasificacion)al.Clasificacion + " Ranking; " + al.Ranking);

            }
        }

        private void Atras_Click_1(object sender, EventArgs e)
        {
            Hide();
            Registro.mm1.Show();
        }
    }
}
