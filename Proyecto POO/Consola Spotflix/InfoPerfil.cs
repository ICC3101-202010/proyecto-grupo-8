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
using WMPLib;

namespace Consola_Spotflix
{
    public partial class InfoPerfil : UserControl
    {
        public InfoPerfil()
        {
            InitializeComponent();
        }
        public int countPlaylists()
        {
            int playlists = 0;
            foreach (Playlist p in Spotflix.perfilenlinea.Playlists_Audiolibro_De_Otros)
            {
                playlists += 1;
            }
            foreach (Playlist p in Spotflix.perfilenlinea.Playlists_Audiolibro_Propios)
            {
                playlists += 1;
            }
            foreach (Playlist p in Spotflix.perfilenlinea.Playlists_Canciones_De_Otros)
            {
                playlists += 1;
            }
            foreach (Playlist p in Spotflix.perfilenlinea.Playlists_Canciones_Propias)
            {
                playlists += 1;
            }
            foreach (Playlist p in Spotflix.perfilenlinea.Playlists_Peliculas_De_Otros)
            {
                playlists += 1;
            }
            foreach (Playlist p in Spotflix.perfilenlinea.Playlists_Peliculas_Propias)
            {
                playlists += 1;

            }
            foreach (Playlist p in Spotflix.perfilenlinea.Playlists_Podcast_De_Otros)
            {
                playlists += 1;
            }
            foreach (Playlist p in Spotflix.perfilenlinea.Playlists_Podcast_Propios)
            {
                playlists += 1;
            }
            foreach (Playlist p in Spotflix.perfilenlinea.Playlists_Video_De_Otros)
            {
                playlists += 1;
            }
            foreach (Playlist p in Spotflix.perfilenlinea.Playlists_Video_Propios)
            {
                playlists += 1;
            }
            return playlists;
        }
        public void loadInfoPerfil()
        {
            Show();
            int play = countPlaylists();
            int seguidores = Spotflix.perfilenlinea.Seguidores.Count();
            int seguidos= Spotflix.perfilenlinea.Seguidos.Count();
            label1.Text = Spotflix.perfilenlinea.Nombre_perfil;
            label2.Text = "Seguidores: "+seguidores.ToString();
            label3.Text = "Seguidos: "+seguidos.ToString();
            label4.Text = "Playlists: "+play;
            label5.Text = "Tipo de Membresia: " + (enum_TipoDeMembresia)Spotflix.perfilenlinea.Tipo_de_Perfil;
        }
        private void InfoPerfil_Load(object sender, EventArgs e)
        {

        }
    }
}
