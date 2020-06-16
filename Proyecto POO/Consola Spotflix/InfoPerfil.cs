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
            Registro.Infoperf = this;
        }
        public void CargarPerfil()
        {
            Show();
            BringToFront();
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
            label9.Text = "Publico";
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

            string seguidores = Spotflix.perfilenlinea.Seguidores.Count().ToString();
            label10.Text = seguidores;

            string seguidos = Spotflix.perfilenlinea.Seguidos.Count().ToString();
            label11.Text = seguidos;

            string artistas = Spotflix.perfilenlinea.Personas_Seguidas.Count().ToString();
            label12.Text = artistas;

            string canciones = Spotflix.perfilenlinea.Playlists_Canciones_Propias.Count().ToString();
            label13.Text = canciones;

            string videos = Spotflix.perfilenlinea.Playlists_Video_Propios.Count().ToString();
            label18.Text = videos;

            string pelicula = Spotflix.perfilenlinea.Playlists_Peliculas_Propias.Count().ToString();
            label20.Text = pelicula;

            string podcast = Spotflix.perfilenlinea.Playlists_Podcast_Propios.Count().ToString();
            label22.Text = podcast;

            string audiol = Spotflix.perfilenlinea.Playlists_Audiolibro_Propios.Count().ToString();
            label24.Text = audiol;

            int pc = Spotflix.perfilenlinea.Playlists_Canciones_De_Otros.Count();
            int pc1 = Spotflix.perfilenlinea.Playlists_Audiolibro_De_Otros.Count();
            int pc2 = Spotflix.perfilenlinea.Playlists_Peliculas_De_Otros.Count();
            int pc3= Spotflix.perfilenlinea.Playlists_Podcast_Propios.Count();
            int pc4 = Spotflix.perfilenlinea.Playlists_Video_De_Otros.Count();
            int ps = pc + pc1 + pc2 + pc3 + pc4;
            label14.Text = ps.ToString();

        }

        private void botonatras_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
