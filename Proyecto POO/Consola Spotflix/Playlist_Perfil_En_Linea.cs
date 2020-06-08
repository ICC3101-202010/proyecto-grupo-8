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
using AxWMPLib;

namespace Consola_Spotflix
{
    public partial class Playlist_Perfil_En_Linea : UserControl
    {
        public Playlist_Perfil_En_Linea()
        {
            InitializeComponent();
        }
        public void Iniciar()
        {
            try
            {
                //Canciones:
                button1.Text = "Todas las canciones";
                button2.Text = Spotflix.perfilenlinea.Playlists_Canciones_Propias[0].Nombre;
                button3.Text = Spotflix.perfilenlinea.Playlists_Canciones_Propias[1].Nombre;
                button4.Text = Spotflix.perfilenlinea.Playlists_Canciones_Propias[2].Nombre;
                //Peliculas
                button9.Text = "Todas las peliculas";
                button10.Text = Spotflix.perfilenlinea.Playlists_Peliculas_Propias[0].Nombre;
                button11.Text = Spotflix.perfilenlinea.Playlists_Peliculas_Propias[1].Nombre;
                button12.Text = Spotflix.perfilenlinea.Playlists_Peliculas_Propias[2].Nombre;
                //Podcast
                button17.Text = "Todos los podcast";
                button18.Text = Spotflix.perfilenlinea.Playlists_Podcast_Propios[0].Nombre;
                button19.Text = Spotflix.perfilenlinea.Playlists_Podcast_Propios[1].Nombre;
                button20.Text = Spotflix.perfilenlinea.Playlists_Podcast_Propios[2].Nombre;
                //AudioLibro
                button25.Text = "Todos los audiolibros";
                button26.Text = Spotflix.perfilenlinea.Playlists_Audiolibro_Propios[0].Nombre;
                button27.Text = Spotflix.perfilenlinea.Playlists_Audiolibro_Propios[1].Nombre;
                button28.Text = Spotflix.perfilenlinea.Playlists_Audiolibro_Propios[2].Nombre;
                //Videos
                button33.Text = "Todos los videos";
                button34.Text = Spotflix.perfilenlinea.Playlists_Video_Propios[0].Nombre;
                button35.Text = Spotflix.perfilenlinea.Playlists_Video_Propios[1].Nombre;
                button36.Text = Spotflix.perfilenlinea.Playlists_Video_Propios[2].Nombre;
            }
            catch 
            {
            }
                         
        }
        //Botones Canciones
        private void button1_Click(object sender, EventArgs e)
        {
            Spotflix.Temporal.clear();
            Spotflix.Agregar_a_temportal(Spotflix.Lista_Canciones);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button1.Text;
            try
            {
                Registro.mm1.button23.Text = Spotflix.Temporal_Info_Ca[0].Titulo;
                Registro.mm1.button24.Text = Spotflix.Temporal_Info_Ca[1].Titulo;
                Registro.mm1.button25.Text = Spotflix.Temporal_Info_Ca[2].Titulo;
                Registro.mm1.button26.Text = Spotflix.Temporal_Info_Ca[3].Titulo;
                Registro.mm1.button27.Text = Spotflix.Temporal_Info_Ca[4].Titulo;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Spotflix.Temporal.clear();
            Spotflix.Agregar_a_temportal(Spotflix.perfilenlinea.Playlists_Canciones_Propias[0].Playlist_paralista_Ca);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button2.Text;
            try
            {
                Registro.mm1.button23.Text = Spotflix.Temporal_Info_Ca[0].Titulo;
                Registro.mm1.button24.Text = Spotflix.Temporal_Info_Ca[1].Titulo;
                Registro.mm1.button25.Text = Spotflix.Temporal_Info_Ca[2].Titulo;
                Registro.mm1.button26.Text = Spotflix.Temporal_Info_Ca[3].Titulo;
                Registro.mm1.button27.Text = Spotflix.Temporal_Info_Ca[4].Titulo;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Spotflix.Temporal.clear();
            Spotflix.Agregar_a_temportal(Spotflix.perfilenlinea.Playlists_Canciones_Propias[1].Playlist_paralista_Ca);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button3.Text;
            try
            {
                Registro.mm1.button23.Text = Spotflix.Temporal_Info_Ca[0].Titulo;
                Registro.mm1.button24.Text = Spotflix.Temporal_Info_Ca[1].Titulo;
                Registro.mm1.button25.Text = Spotflix.Temporal_Info_Ca[2].Titulo;
                Registro.mm1.button26.Text = Spotflix.Temporal_Info_Ca[3].Titulo;
                Registro.mm1.button27.Text = Spotflix.Temporal_Info_Ca[4].Titulo;

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Spotflix.Temporal.clear();
            Spotflix.Agregar_a_temportal(Spotflix.perfilenlinea.Playlists_Canciones_Propias[2].Playlist_paralista_Ca);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button4.Text;
            try
            {
                Registro.mm1.button23.Text = Spotflix.Temporal_Info_Ca[0].Titulo;
                Registro.mm1.button24.Text = Spotflix.Temporal_Info_Ca[1].Titulo;
                Registro.mm1.button25.Text = Spotflix.Temporal_Info_Ca[2].Titulo;
                Registro.mm1.button26.Text = Spotflix.Temporal_Info_Ca[3].Titulo;
                Registro.mm1.button27.Text = Spotflix.Temporal_Info_Ca[4].Titulo;

            }
            catch (Exception)
            {

                throw;
            }
        }
        //Botones Peliculas
        private void button9_Click(object sender, EventArgs e)
        {
            Spotflix.Temporal.clear();
            Spotflix.Agregar_a_temportal(Spotflix.Lista_Peliculas);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button9.Text;
            try
            {
                Registro.mm1.button23.Text = Spotflix.Temporal_Info_Pe[0].Titulo;
                Registro.mm1.button24.Text = Spotflix.Temporal_Info_Pe[1].Titulo;
                Registro.mm1.button25.Text = Spotflix.Temporal_Info_Pe[2].Titulo;
                Registro.mm1.button26.Text = Spotflix.Temporal_Info_Pe[3].Titulo;
                Registro.mm1.button27.Text = Spotflix.Temporal_Info_Pe[4].Titulo;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Spotflix.Temporal.clear();
            Spotflix.Agregar_a_temportal(Spotflix.perfilenlinea.Playlists_Peliculas_Propias[0].Playlist_paralista_Pe);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button10.Text;
            try
            {
                Registro.mm1.button23.Text = Spotflix.Temporal_Info_Pe[0].Titulo;
                Registro.mm1.button24.Text = Spotflix.Temporal_Info_Pe[1].Titulo;
                Registro.mm1.button25.Text = Spotflix.Temporal_Info_Pe[2].Titulo;
                Registro.mm1.button26.Text = Spotflix.Temporal_Info_Pe[3].Titulo;
                Registro.mm1.button27.Text = Spotflix.Temporal_Info_Pe[4].Titulo;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Spotflix.Temporal.clear();
            Spotflix.Agregar_a_temportal(Spotflix.perfilenlinea.Playlists_Peliculas_Propias[1].Playlist_paralista_Pe);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button11.Text;
            try
            {
                Registro.mm1.button23.Text = Spotflix.Temporal_Info_Pe[0].Titulo;
                Registro.mm1.button24.Text = Spotflix.Temporal_Info_Pe[1].Titulo;
                Registro.mm1.button25.Text = Spotflix.Temporal_Info_Pe[2].Titulo;
                Registro.mm1.button26.Text = Spotflix.Temporal_Info_Pe[3].Titulo;
                Registro.mm1.button27.Text = Spotflix.Temporal_Info_Pe[4].Titulo;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Spotflix.Temporal.clear();
            Spotflix.Agregar_a_temportal(Spotflix.perfilenlinea.Playlists_Peliculas_Propias[2].Playlist_paralista_Pe);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button12.Text;
            try
            {
                Registro.mm1.button23.Text = Spotflix.Temporal_Info_Pe[0].Titulo;
                Registro.mm1.button24.Text = Spotflix.Temporal_Info_Pe[1].Titulo;
                Registro.mm1.button25.Text = Spotflix.Temporal_Info_Pe[2].Titulo;
                Registro.mm1.button26.Text = Spotflix.Temporal_Info_Pe[3].Titulo;
                Registro.mm1.button27.Text = Spotflix.Temporal_Info_Pe[4].Titulo;

            }
            catch (Exception)
            {

                throw;
            }
        }

        //Botones Podcast
        private void button17_Click(object sender, EventArgs e)
        {
            Spotflix.Temporal.clear();
            Spotflix.Agregar_a_temportal(Spotflix.Lista_Podcasts);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button17.Text;
            try
            {
                Registro.mm1.button23.Text = Spotflix.Temporal_Info_Po[0].Titulo;
                Registro.mm1.button24.Text = Spotflix.Temporal_Info_Po[1].Titulo;
                Registro.mm1.button25.Text = Spotflix.Temporal_Info_Po[2].Titulo;
                Registro.mm1.button26.Text = Spotflix.Temporal_Info_Po[3].Titulo;
                Registro.mm1.button27.Text = Spotflix.Temporal_Info_Po[4].Titulo;

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void button18_Click(object sender, EventArgs e)
        {
            Spotflix.Temporal.clear();
            Spotflix.Agregar_a_temportal(Spotflix.perfilenlinea.Playlists_Podcast_Propios[0].Playlist_paralista_Po);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button18.Text;
            try
            {
                Registro.mm1.button23.Text = Spotflix.Temporal_Info_Po[0].Titulo;
                Registro.mm1.button24.Text = Spotflix.Temporal_Info_Po[1].Titulo;
                Registro.mm1.button25.Text = Spotflix.Temporal_Info_Po[2].Titulo;
                Registro.mm1.button26.Text = Spotflix.Temporal_Info_Po[3].Titulo;
                Registro.mm1.button27.Text = Spotflix.Temporal_Info_Po[4].Titulo;

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void button19_Click(object sender, EventArgs e)
        {
            Spotflix.Temporal.clear();
            Spotflix.Agregar_a_temportal(Spotflix.perfilenlinea.Playlists_Podcast_Propios[1].Playlist_paralista_Po);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button19.Text;
            try
            {
                Registro.mm1.button23.Text = Spotflix.Temporal_Info_Po[0].Titulo;
                Registro.mm1.button24.Text = Spotflix.Temporal_Info_Po[1].Titulo;
                Registro.mm1.button25.Text = Spotflix.Temporal_Info_Po[2].Titulo;
                Registro.mm1.button26.Text = Spotflix.Temporal_Info_Po[3].Titulo;
                Registro.mm1.button27.Text = Spotflix.Temporal_Info_Po[4].Titulo;

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void button20_Click(object sender, EventArgs e)
        {
            Spotflix.Temporal.clear();
            Spotflix.Agregar_a_temportal(Spotflix.perfilenlinea.Playlists_Podcast_Propios[2].Playlist_paralista_Po);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button20.Text;
            try
            {
                Registro.mm1.button23.Text = Spotflix.Temporal_Info_Po[0].Titulo;
                Registro.mm1.button24.Text = Spotflix.Temporal_Info_Po[1].Titulo;
                Registro.mm1.button25.Text = Spotflix.Temporal_Info_Po[2].Titulo;
                Registro.mm1.button26.Text = Spotflix.Temporal_Info_Po[3].Titulo;
                Registro.mm1.button27.Text = Spotflix.Temporal_Info_Po[4].Titulo;

            }
            catch (Exception)
            {

                throw;
            }
        }
        //Botones Audiolibros
        private void button25_Click(object sender, EventArgs e)
        {
            Spotflix.Temporal.clear();
            Spotflix.Agregar_a_temportal(Spotflix.Lista_AudioLibros);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button25.Text;
            try
            {
                Registro.mm1.button23.Text = Spotflix.Temporal_Info_AL[0].Titulo;
                Registro.mm1.button24.Text = Spotflix.Temporal_Info_AL[1].Titulo;
                Registro.mm1.button25.Text = Spotflix.Temporal_Info_AL[2].Titulo;
                Registro.mm1.button26.Text = Spotflix.Temporal_Info_AL[3].Titulo;
                Registro.mm1.button27.Text = Spotflix.Temporal_Info_AL[4].Titulo;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Spotflix.Temporal.clear();
            Spotflix.Agregar_a_temportal(Spotflix.perfilenlinea.Playlists_Audiolibro_Propios[0].Playlist_paralista_AL);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button26.Text;
            try
            {
                Registro.mm1.button23.Text = Spotflix.Temporal_Info_AL[0].Titulo;
                Registro.mm1.button24.Text = Spotflix.Temporal_Info_AL[1].Titulo;
                Registro.mm1.button25.Text = Spotflix.Temporal_Info_AL[2].Titulo;
                Registro.mm1.button26.Text = Spotflix.Temporal_Info_AL[3].Titulo;
                Registro.mm1.button27.Text = Spotflix.Temporal_Info_AL[4].Titulo;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Spotflix.Temporal.clear();
            Spotflix.Agregar_a_temportal(Spotflix.perfilenlinea.Playlists_Audiolibro_Propios[1].Playlist_paralista_AL);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button27.Text;
            try
            {
                Registro.mm1.button23.Text = Spotflix.Temporal_Info_AL[0].Titulo;
                Registro.mm1.button24.Text = Spotflix.Temporal_Info_AL[1].Titulo;
                Registro.mm1.button25.Text = Spotflix.Temporal_Info_AL[2].Titulo;
                Registro.mm1.button26.Text = Spotflix.Temporal_Info_AL[3].Titulo;
                Registro.mm1.button27.Text = Spotflix.Temporal_Info_AL[4].Titulo;

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void button28_Click(object sender, EventArgs e)
        {
            Spotflix.Temporal.clear();
            Spotflix.Agregar_a_temportal(Spotflix.perfilenlinea.Playlists_Audiolibro_Propios[2].Playlist_paralista_AL);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button28.Text;
            try
            {
                Registro.mm1.button23.Text = Spotflix.Temporal_Info_AL[0].Titulo;
                Registro.mm1.button24.Text = Spotflix.Temporal_Info_AL[1].Titulo;
                Registro.mm1.button25.Text = Spotflix.Temporal_Info_AL[2].Titulo;
                Registro.mm1.button26.Text = Spotflix.Temporal_Info_AL[3].Titulo;
                Registro.mm1.button27.Text = Spotflix.Temporal_Info_AL[4].Titulo;

            }
            catch (Exception)
            {

                throw;
            }
        }
        //Botones Videos
        private void button33_Click(object sender, EventArgs e)
        {
            Spotflix.Temporal.clear();
            Spotflix.Agregar_a_temportal(Spotflix.Lista_Videos);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button33.Text;
            try
            {
                Registro.mm1.button23.Text = Spotflix.Temporal_Info_Vi[0].Titulo;
                Registro.mm1.button24.Text = Spotflix.Temporal_Info_Vi[1].Titulo;
                Registro.mm1.button25.Text = Spotflix.Temporal_Info_Vi[2].Titulo;
                Registro.mm1.button26.Text = Spotflix.Temporal_Info_Vi[3].Titulo;
                Registro.mm1.button27.Text = Spotflix.Temporal_Info_Vi[4].Titulo;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Spotflix.Temporal.clear();
            Spotflix.Agregar_a_temportal(Spotflix.perfilenlinea.Playlists_Video_Propios[0].Playlist_paralista_Vi);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button34.Text;
            try
            {
                Registro.mm1.button23.Text = Spotflix.Temporal_Info_Vi[0].Titulo;
                Registro.mm1.button24.Text = Spotflix.Temporal_Info_Vi[1].Titulo;
                Registro.mm1.button25.Text = Spotflix.Temporal_Info_Vi[2].Titulo;
                Registro.mm1.button26.Text = Spotflix.Temporal_Info_Vi[3].Titulo;
                Registro.mm1.button27.Text = Spotflix.Temporal_Info_Vi[4].Titulo;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Spotflix.Temporal.clear();
            Spotflix.Agregar_a_temportal(Spotflix.perfilenlinea.Playlists_Video_Propios[1].Playlist_paralista_Vi);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button35.Text;
            try
            {
                Registro.mm1.button23.Text = Spotflix.Temporal_Info_Vi[0].Titulo;
                Registro.mm1.button24.Text = Spotflix.Temporal_Info_Vi[1].Titulo;
                Registro.mm1.button25.Text = Spotflix.Temporal_Info_Vi[2].Titulo;
                Registro.mm1.button26.Text = Spotflix.Temporal_Info_Vi[3].Titulo;
                Registro.mm1.button27.Text = Spotflix.Temporal_Info_Vi[4].Titulo;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Spotflix.Temporal.clear();
            Spotflix.Agregar_a_temportal(Spotflix.perfilenlinea.Playlists_Video_Propios[2].Playlist_paralista_Vi);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button36.Text;
            try
            {
                Registro.mm1.button23.Text = Spotflix.Temporal_Info_Vi[0].Titulo;
                Registro.mm1.button24.Text = Spotflix.Temporal_Info_Vi[1].Titulo;
                Registro.mm1.button25.Text = Spotflix.Temporal_Info_Vi[2].Titulo;
                Registro.mm1.button26.Text = Spotflix.Temporal_Info_Vi[3].Titulo;
                Registro.mm1.button27.Text = Spotflix.Temporal_Info_Vi[4].Titulo;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
