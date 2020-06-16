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
    public partial class CrearPlaylist : UserControl
    {
        string tipoperfil;
        public CrearPlaylist()
        {
            InitializeComponent();
            Registro.Crear_playlist = this;
        }

        private void comboBoxTipoMulti_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CrearPlaylist_Load(object sender, EventArgs e)
        {
            comboBoxTipoMulti.Items.Add("Canciones");
            comboBoxTipoMulti.Items.Add("Videos");
            comboBoxTipoMulti.Items.Add("Peliculas");
            comboBoxTipoMulti.Items.Add("Podcasts");
            comboBoxTipoMulti.Items.Add("Audiolibros");
            comboBoxPrivacidad.Items.Add("Publica");
            comboBoxPrivacidad.Items.Add("Privada");
            label5.Hide();
        }
        int a = 0;

        private void botonCrear_Click(object sender, EventArgs e)
        {

            a += 1;
            if (a%2 == 0)
            {
                Show();
                string nombre = textBoxnombre.Text;
                tipoperfil = (string)comboBoxPrivacidad.SelectedItem;

                int tipo = 2;
                if (tipoperfil == "Publica")
                {
                    tipo = 1;
                }
                if ((string)comboBoxTipoMulti.SelectedItem == "Canciones")
                {
                    Playlist p1 = new Playlist(new List<Cancion>(), nombre, tipo);
                    Spotflix.perfilenlinea.Playlists_Canciones_Propias.Add(p1);
                }
                else if ((string)comboBoxTipoMulti.SelectedItem == "Videos")
                {
                    Playlist p1 = new Playlist(new List<Video>(), nombre, tipo);
                    Spotflix.perfilenlinea.Playlists_Video_Propios.Add(p1);
                }
                else if ((string)comboBoxTipoMulti.SelectedItem == "Peliculas")
                {
                    Playlist p1 = new Playlist(new List<Pelicula>(), nombre, tipo);
                    Spotflix.perfilenlinea.Playlists_Peliculas_Propias.Add(p1);
                }
                else if ((string)comboBoxTipoMulti.SelectedItem == "Podcasts")
                {
                    Playlist p1 = new Playlist(new List<Podcast>(), nombre, tipo);
                    Spotflix.perfilenlinea.Playlists_Podcast_Propios.Add(p1);
                }
                else if ((string)comboBoxTipoMulti.SelectedItem == "Audiolibros")
                {
                    Playlist p1 = new Playlist(new List<AudioLibro>(), nombre, tipo);
                    Spotflix.perfilenlinea.Playlists_Audiolibro_Propios.Add(p1);
                }

                label5.Show();
                label6.Hide();
            }
            else
            {

                label6.Show();
            }

        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            Hide();
            textBoxnombre.Clear();
            comboBoxPrivacidad.Items.Clear();
            comboBoxTipoMulti.Items.Clear();
            
        }
    }
}
