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
    public partial class InfoPerfil : UserControl
    {
        public InfoPerfil()
        {
            InitializeComponent();
        }
        public void CargarPerfil()
        {
            label8.Show();
            label9.Show();
            label10.Show();
            label11.Show();
            label12.Show();
            label13.Show();
            label14.Show();
            label18.Show();
            label20.Show();
            label22.Show();
            label24.Show();

            label8.Text = Spotflix.perfilenlinea.Nombre_perfil;
            if (Spotflix.perfilenlinea.Tipo_de_Perfil == 1)
            {
                label9.Text = "Artista";
            }
            else if (Spotflix.perfilenlinea.Tipo_de_Perfil == 2)
            {
                label9.Text = "Publico";
            }
            else if (Spotflix.perfilenlinea.Tipo_de_Perfil == 3)
            {
                label9.Text = "Privado";
            }

            int seguidores = Spotflix.perfilenlinea.Seguidores.Count;
            int seguir = Convert.ToInt16(label10.Text);
            seguir = seguidores;

            int seguidos = Spotflix.perfilenlinea.Seguidos.Count;
            int seguir2 = Convert.ToInt16(label11.Text);
            seguir2 = seguidos;

            int artistas = Spotflix.perfilenlinea.Personas_Seguidas.Count;
            int seguir3 = Convert.ToInt16(label12.Text);
            seguir3 = artistas;

            int canciones = Spotflix.perfilenlinea.Playlists_Canciones_Propias.Count;
            int label = Convert.ToInt16(label13.Text);
            label = canciones;
            int videos = Spotflix.perfilenlinea.Playlists_Video_Propios.Count;
            int label1 = Convert.ToInt16(label18.Text);
            label1 = videos;
            int pelicula = Spotflix.perfilenlinea.Playlists_Peliculas_Propias.Count;
            int label2 = Convert.ToInt16(label20.Text);
            label2 = pelicula;
            int podcast = Spotflix.perfilenlinea.Playlists_Podcast_Propios.Count;
            int label3 = Convert.ToInt16(label22.Text);
            label3 = podcast;
            int audiol = Spotflix.perfilenlinea.Playlists_Audiolibro_Propios.Count;
            int label4 = Convert.ToInt16(label24.Text);
            label4 = audiol;

            int pc = Spotflix.perfilenlinea.Playlists_Canciones_De_Otros.Count;
            int pc1 = Spotflix.perfilenlinea.Playlists_Audiolibro_De_Otros.Count;
            int pc2 = Spotflix.perfilenlinea.Playlists_Peliculas_De_Otros.Count;
            int pc3= Spotflix.perfilenlinea.Playlists_Podcast_Propios.Count;
            int pc4 = Spotflix.perfilenlinea.Playlists_Video_De_Otros.Count;
            int ps = pc + pc1 + pc2 + pc3 + pc4;
            int label5 = Convert.ToInt32(label14.Text);
            label5 = ps;

        }

        private void botonatras_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
