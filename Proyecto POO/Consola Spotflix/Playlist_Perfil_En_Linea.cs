using Proyecto_POO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Consola_Spotflix
{
    public partial class Playlist_Perfil_En_Linea : UserControl
    {
        public Playlist_Perfil_En_Linea()
        {
            InitializeComponent();
        }
        public List<Cancion> canciones = new List<Cancion>();
        public List<Pelicula> peliculas = new List<Pelicula>();
        public List<Podcast> podcasts = new List<Podcast>();
        public List<AudioLibro> audiolibros = new List<AudioLibro>();
        public List<Video> videos = new List<Video>();
        public void Iniciar()
        {
            button0.Text = "Todas las Canciones";
            button0.Show();
            button0.Click += new EventHandler(this.button0_Click);
            button1.Text = "Canciones Favoritas";
            button1.Show();
            button1.Click += new EventHandler(this.button1_Click);
            button10.Text = "Todas las Peliculas";
            button10.Show();
            button10.Click += new EventHandler(this.button10_Click);
            button11.Text = "Peliculas Favoritas";
            button11.Show();
            button11.Click += new EventHandler(this.button11_Click);
            button20.Text = "Todas los Podcast";
            button20.Show();
            button20.Click += new EventHandler(this.button20_Click);
            button21.Text = "Podcast Favoritos";
            button21.Show();
            button21.Click += new EventHandler(this.button21_Click);
            button30.Text = "Todas los Audiolibros";
            button30.Show();
            button30.Click += new EventHandler(this.button30_Click);
            button31.Text = "Audiolibros Favoritas";
            button31.Show();
            button31.Click += new EventHandler(this.button31_Click);
            button40.Text = "Todas los Videos";
            button40.Show();
            button40.Click += new EventHandler(this.button40_Click);
            button41.Text = "Videos Favoritas";
            button41.Show();
            button41.Click += new EventHandler(this.button41_Click);

            foreach ( Control C in this.Controls)
            {
                
                if (C.GetType() == typeof(Panel))
                {
                    int i_Ca = 7;
                    int i_Pe = 7;
                    int i_Po = 7;
                    int i_AL = 7;
                    int i_Vi = 7;
                    
                    foreach (Control control in C.Controls)
                    {
                        if (control.GetType() == typeof(Button))
                        {
                            if (Convert.ToInt32(control.Name.Substring(6))<= 9 && Convert.ToInt32(control.Name.Substring(6)) >= 2)
                            {
                                try
                                {
                                    control.Text = Spotflix.perfilenlinea.Playlists_Canciones_Propias[i_Ca].Nombre;
                                    control.Show();
                                    EventArgs e = new EventArgs();
                                    canciones = Spotflix.perfilenlinea.Playlists_Canciones_Propias[i_Ca].Playlist_paralista_Ca;
                                    control.Click += new EventHandler(this.Prueba_Ca);
                                }

                                catch 
                                {
                                }
                                i_Ca -= 1;
                            }
                            else if (Convert.ToInt32(control.Name.Substring(6)) <= 19 && Convert.ToInt32(control.Name.Substring(6)) >= 12)
                            {
                                try
                                {
                                    control.Text = Spotflix.perfilenlinea.Playlists_Peliculas_Propias[i_Pe].Nombre;
                                    control.Show();
                                    peliculas = Spotflix.perfilenlinea.Playlists_Peliculas_Propias[i_Pe].Playlist_paralista_Pe;
                                    control.Click += new EventHandler(this.Prueba_Pe);
                                }
                                catch
                                {
                                }
                                i_Pe -= 1;
                            }
                            else if (Convert.ToInt32(control.Name.Substring(6)) <= 29 && Convert.ToInt32(control.Name.Substring(6)) >= 22)
                            {
                                try
                                {
                                    control.Text = Spotflix.perfilenlinea.Playlists_Podcast_Propios[i_Po].Nombre;
                                    control.Show();
                                    podcasts = Spotflix.perfilenlinea.Playlists_Podcast_Propios[i_Po].Playlist_paralista_Po;
                                    control.Click += new EventHandler(this.Prueba_Po);
                                }
                                catch
                                {
                                }
                                i_Po -= 1;
                            }
                            else if (Convert.ToInt32(control.Name.Substring(6)) <= 39 && Convert.ToInt32(control.Name.Substring(6)) >= 32)
                            {
                                try
                                {
                                    control.Text = Spotflix.perfilenlinea.Playlists_Audiolibro_Propios[i_AL].Nombre;
                                    control.Show();
                                    audiolibros = Spotflix.perfilenlinea.Playlists_Audiolibro_Propios[i_AL].Playlist_paralista_AL;
                                    control.Click += new EventHandler(this.Prueba_AL);
                                }
                                catch
                                {
                                }
                                i_AL -= 1;
                            }
                            else if (Convert.ToInt32(control.Name.Substring(6)) <= 49 && Convert.ToInt32(control.Name.Substring(6)) >= 42)
                            {
                                try
                                {
                                    control.Text = Spotflix.perfilenlinea.Playlists_Video_Propios[i_Vi].Nombre;
                                    control.Show();
                                    videos = Spotflix.perfilenlinea.Playlists_Video_Propios[i_Vi].Playlist_paralista_Vi;
                                    control.Click += new EventHandler(this.Prueba_Vi);
                                }
                                catch
                                {
                                }
                                i_Vi -= 1;
                            }
                        }
                    }
                    //C.Text = "Botones Cambiados por foreach";
                }
            }    
        }

        public void Prueba_Ca(object sender, EventArgs e)
        {
            
            Button button =  sender as Button;
            Spotflix.Temporal.clear();
            Registro.mm1.tipo = 1;
            Spotflix.Agregar_a_temportal(canciones);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button.Text;
        }
        public void Prueba_Pe(object sender, EventArgs e)
        {

            Button button = sender as Button;
            Spotflix.Temporal.clear();
            Registro.mm1.tipo = 1;
            Spotflix.Agregar_a_temportal(peliculas);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button.Text;
        }
        public void Prueba_Po(object sender, EventArgs e)
        {

            Button button = sender as Button;
            Spotflix.Temporal.clear();
            Registro.mm1.tipo = 1;
            Spotflix.Agregar_a_temportal(podcasts);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button.Text;
        }
        public void Prueba_AL(object sender, EventArgs e)
        {

            Button button = sender as Button;
            Spotflix.Temporal.clear();
            Registro.mm1.tipo = 1;
            Spotflix.Agregar_a_temportal(audiolibros);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button.Text;
        }
        public void Prueba_Vi(object sender, EventArgs e)
        {

            Button button = sender as Button;
            Spotflix.Temporal.clear();
            Registro.mm1.tipo = 1;
            Spotflix.Agregar_a_temportal(videos);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button.Text;
        }

        public void button0_Click(object sender, EventArgs e)
        {
            canciones = Spotflix.Lista_Canciones;
            Button button = sender as Button;
            Spotflix.Temporal.clear();
            Registro.mm1.tipo = 1;
            Spotflix.Agregar_a_temportal(canciones);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button.Text;

        }
        public void button1_Click(object sender, EventArgs e)
        {
            canciones = Spotflix.perfilenlinea.Fav_Canciones;
            Button button = sender as Button;
            Spotflix.Temporal.clear();
            Registro.mm1.tipo = 1;
            Spotflix.Agregar_a_temportal(canciones);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button.Text;

        }
        public void button10_Click(object sender, EventArgs e)
        {
            peliculas = Spotflix.Lista_Peliculas;
            Button button = sender as Button;
            Spotflix.Temporal.clear();
            Registro.mm1.tipo = 1;
            Spotflix.Agregar_a_temportal(peliculas);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button.Text;

        }
        public void button11_Click(object sender, EventArgs e)
        {
            peliculas = Spotflix.perfilenlinea.Fav_Pelicula;
            Button button = sender as Button;
            Spotflix.Temporal.clear();
            Registro.mm1.tipo = 1;
            Spotflix.Agregar_a_temportal(peliculas);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button.Text;

        }
        public void button20_Click(object sender, EventArgs e)
        {
            podcasts = Spotflix.Lista_Podcasts;
            Button button = sender as Button;
            Spotflix.Temporal.clear();
            Registro.mm1.tipo = 1;
            Spotflix.Agregar_a_temportal(podcasts);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button.Text;

        }
        public void button21_Click(object sender, EventArgs e)
        {
            podcasts = Spotflix.perfilenlinea.Fav_Podcast;
            Button button = sender as Button;
            Spotflix.Temporal.clear();
            Registro.mm1.tipo = 1;
            Spotflix.Agregar_a_temportal(podcasts);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button.Text;

        }
        public void button30_Click(object sender, EventArgs e)
        {
            audiolibros = Spotflix.Lista_AudioLibros;
            Button button = sender as Button;
            Spotflix.Temporal.clear();
            Registro.mm1.tipo = 1;
            Spotflix.Agregar_a_temportal(audiolibros);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button.Text;

        }
        public void button31_Click(object sender, EventArgs e)
        {
            audiolibros = Spotflix.perfilenlinea.Fav_AudioLibro;
            Button button = sender as Button;
            Spotflix.Temporal.clear();
            Registro.mm1.tipo = 1;
            Spotflix.Agregar_a_temportal(audiolibros);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button.Text;

        }
        public void button40_Click(object sender, EventArgs e)
        {
            videos = Spotflix.Lista_Videos;
            Button button = sender as Button;
            Spotflix.Temporal.clear();
            Registro.mm1.tipo = 1;
            Spotflix.Agregar_a_temportal(videos);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button.Text;

        }
        public void button41_Click(object sender, EventArgs e)
        {
            videos = Spotflix.perfilenlinea.Fav_Videos;
            Button button = sender as Button;
            Spotflix.Temporal.clear();
            Registro.mm1.tipo = 1;
            Spotflix.Agregar_a_temportal(videos);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button.Text;

        }































        //Botones Canciones
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Spotflix.Temporal.clear();
        //    Registro.mm1.tipo = 1;
        //    Spotflix.Agregar_a_temportal(Spotflix.Lista_Canciones);
        //    Registro.mm1.AbrirMusica();
        //    Registro.mm1.Nombre_Playlist.Text = button1.Text;

        //    try
        //    {
        //        Registro.mm1.button23.Text = Spotflix.Temporal_Info_Ca[0].Titulo;
        //        Registro.mm1.button24.Text = Spotflix.Temporal_Info_Ca[1].Titulo;
        //        Registro.mm1.button25.Text = Spotflix.Temporal_Info_Ca[2].Titulo;
        //        Registro.mm1.button26.Text = Spotflix.Temporal_Info_Ca[3].Titulo;
        //        Registro.mm1.button27.Text = Spotflix.Temporal_Info_Ca[4].Titulo;

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        //private void button2_Click_1(object sender, EventArgs e)
        //{
        //    Spotflix.Temporal.clear();
        //    Registro.mm1.tipo = 1;
        //    Spotflix.Agregar_a_temportal(Spotflix.perfilenlinea.Playlists_Canciones_Propias[0].Playlist_paralista_Ca);
        //    Registro.mm1.AbrirMusica();
        //    Registro.mm1.Nombre_Playlist.Text = button2.Text;


        //    try
        //    {
        //        Registro.mm1.button23.Text = Spotflix.Temporal_Info_Ca[0].Titulo;
        //        Registro.mm1.button24.Text = Spotflix.Temporal_Info_Ca[1].Titulo;
        //        Registro.mm1.button25.Text = Spotflix.Temporal_Info_Ca[2].Titulo;
        //        Registro.mm1.button26.Text = Spotflix.Temporal_Info_Ca[3].Titulo;
        //        Registro.mm1.button27.Text = Spotflix.Temporal_Info_Ca[4].Titulo;

        //    }
        //    catch 
        //    {

        //    }
        //}

        //private void button3_Click_1(object sender, EventArgs e)
        //{
        //    Spotflix.Temporal.clear();
        //    Registro.mm1.tipo = 1;
        //    Spotflix.Agregar_a_temportal(Spotflix.perfilenlinea.Playlists_Canciones_Propias[1].Playlist_paralista_Ca);
        //    Registro.mm1.AbrirMusica();
        //    Registro.mm1.Nombre_Playlist.Text = button3.Text;


        //    try
        //    {
        //        Registro.mm1.button23.Text = Spotflix.Temporal_Info_Ca[0].Titulo;
        //        Registro.mm1.button24.Text = Spotflix.Temporal_Info_Ca[1].Titulo;
        //        Registro.mm1.button25.Text = Spotflix.Temporal_Info_Ca[2].Titulo;
        //        Registro.mm1.button26.Text = Spotflix.Temporal_Info_Ca[3].Titulo;
        //        Registro.mm1.button27.Text = Spotflix.Temporal_Info_Ca[4].Titulo;

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
        //private void button4_Click(object sender, EventArgs e)
        //{
        //    Spotflix.Temporal.clear();
        //    Registro.mm1.tipo = 1;
        //    Spotflix.Agregar_a_temportal(Spotflix.perfilenlinea.Playlists_Canciones_Propias[2].Playlist_paralista_Ca);
        //    Registro.mm1.AbrirMusica();
        //    Registro.mm1.Nombre_Playlist.Text = button4.Text;


        //    try
        //    {
        //        Registro.mm1.button23.Text = Spotflix.Temporal_Info_Ca[0].Titulo;
        //        Registro.mm1.button24.Text = Spotflix.Temporal_Info_Ca[1].Titulo;
        //        Registro.mm1.button25.Text = Spotflix.Temporal_Info_Ca[2].Titulo;
        //        Registro.mm1.button26.Text = Spotflix.Temporal_Info_Ca[3].Titulo;
        //        Registro.mm1.button27.Text = Spotflix.Temporal_Info_Ca[4].Titulo;

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
        ////Botones Peliculas
        //private void button9_Click(object sender, EventArgs e)
        //{
        //    Spotflix.Temporal.clear();
        //    Registro.mm1.tipo = 2;
        //    Spotflix.Agregar_a_temportal(Spotflix.Lista_Peliculas);
        //    Registro.mm1.AbrirMusica();
        //    Registro.mm1.Nombre_Playlist.Text = button9.Text;


        //    try
        //    {
        //        Registro.mm1.button23.Text = Spotflix.Temporal_Info_Pe[0].Titulo;
        //        Registro.mm1.button24.Text = Spotflix.Temporal_Info_Pe[1].Titulo;
        //        Registro.mm1.button25.Text = Spotflix.Temporal_Info_Pe[2].Titulo;
        //        Registro.mm1.button26.Text = Spotflix.Temporal_Info_Pe[3].Titulo;
        //        Registro.mm1.button27.Text = Spotflix.Temporal_Info_Pe[4].Titulo;

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        //private void button10_Click(object sender, EventArgs e)
        //{
        //    Spotflix.Temporal.clear();
        //    Registro.mm1.tipo = 2;
        //    Spotflix.Agregar_a_temportal(Spotflix.perfilenlinea.Playlists_Peliculas_Propias[0].Playlist_paralista_Pe);
        //    Registro.mm1.AbrirMusica();
        //    Registro.mm1.Nombre_Playlist.Text = button10.Text;


        //    try
        //    {
        //        Registro.mm1.button23.Text = Spotflix.Temporal_Info_Pe[0].Titulo;
        //        Registro.mm1.button24.Text = Spotflix.Temporal_Info_Pe[1].Titulo;
        //        Registro.mm1.button25.Text = Spotflix.Temporal_Info_Pe[2].Titulo;
        //        Registro.mm1.button26.Text = Spotflix.Temporal_Info_Pe[3].Titulo;
        //        Registro.mm1.button27.Text = Spotflix.Temporal_Info_Pe[4].Titulo;

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        //private void button11_Click(object sender, EventArgs e)
        //{
        //    Spotflix.Temporal.clear();
        //    Registro.mm1.tipo = 2;
        //    Spotflix.Agregar_a_temportal(Spotflix.perfilenlinea.Playlists_Peliculas_Propias[1].Playlist_paralista_Pe);
        //    Registro.mm1.AbrirMusica();
        //    Registro.mm1.Nombre_Playlist.Text = button11.Text;


        //    try
        //    {
        //        Registro.mm1.button23.Text = Spotflix.Temporal_Info_Pe[0].Titulo;
        //        Registro.mm1.button24.Text = Spotflix.Temporal_Info_Pe[1].Titulo;
        //        Registro.mm1.button25.Text = Spotflix.Temporal_Info_Pe[2].Titulo;
        //        Registro.mm1.button26.Text = Spotflix.Temporal_Info_Pe[3].Titulo;
        //        Registro.mm1.button27.Text = Spotflix.Temporal_Info_Pe[4].Titulo;

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        //private void button12_Click(object sender, EventArgs e)
        //{
        //    Spotflix.Temporal.clear();
        //    Registro.mm1.tipo = 2;
        //    Spotflix.Agregar_a_temportal(Spotflix.perfilenlinea.Playlists_Peliculas_Propias[2].Playlist_paralista_Pe);
        //    Registro.mm1.AbrirMusica();
        //    Registro.mm1.Nombre_Playlist.Text = button12.Text;


        //    try
        //    {
        //        Registro.mm1.button23.Text = Spotflix.Temporal_Info_Pe[0].Titulo;
        //        Registro.mm1.button24.Text = Spotflix.Temporal_Info_Pe[1].Titulo;
        //        Registro.mm1.button25.Text = Spotflix.Temporal_Info_Pe[2].Titulo;
        //        Registro.mm1.button26.Text = Spotflix.Temporal_Info_Pe[3].Titulo;
        //        Registro.mm1.button27.Text = Spotflix.Temporal_Info_Pe[4].Titulo;

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        ////Botones Podcast
        //private void button17_Click(object sender, EventArgs e)
        //{
        //    Spotflix.Temporal.clear();
        //    Registro.mm1.tipo = 3;
        //    Spotflix.Agregar_a_temportal(Spotflix.Lista_Podcasts);
        //    Registro.mm1.AbrirMusica();
        //    Registro.mm1.Nombre_Playlist.Text = button17.Text;


        //    try
        //    {
        //        Registro.mm1.button23.Text = Spotflix.Temporal_Info_Po[0].Titulo;
        //        Registro.mm1.button24.Text = Spotflix.Temporal_Info_Po[1].Titulo;
        //        Registro.mm1.button25.Text = Spotflix.Temporal_Info_Po[2].Titulo;
        //        Registro.mm1.button26.Text = Spotflix.Temporal_Info_Po[3].Titulo;
        //        Registro.mm1.button27.Text = Spotflix.Temporal_Info_Po[4].Titulo;

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
        //private void button18_Click(object sender, EventArgs e)
        //{
        //    Spotflix.Temporal.clear();
        //    Registro.mm1.tipo = 3;
        //    Spotflix.Agregar_a_temportal(Spotflix.perfilenlinea.Playlists_Podcast_Propios[0].Playlist_paralista_Po);
        //    Registro.mm1.AbrirMusica();
        //    Registro.mm1.Nombre_Playlist.Text = button18.Text;


        //    try
        //    {
        //        Registro.mm1.button23.Text = Spotflix.Temporal_Info_Po[0].Titulo;
        //        Registro.mm1.button24.Text = Spotflix.Temporal_Info_Po[1].Titulo;
        //        Registro.mm1.button25.Text = Spotflix.Temporal_Info_Po[2].Titulo;
        //        Registro.mm1.button26.Text = Spotflix.Temporal_Info_Po[3].Titulo;
        //        Registro.mm1.button27.Text = Spotflix.Temporal_Info_Po[4].Titulo;

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
        //private void button19_Click(object sender, EventArgs e)
        //{
        //    Spotflix.Temporal.clear();
        //    Registro.mm1.tipo = 3;
        //    Spotflix.Agregar_a_temportal(Spotflix.perfilenlinea.Playlists_Podcast_Propios[1].Playlist_paralista_Po);
        //    Registro.mm1.AbrirMusica();
        //    Registro.mm1.Nombre_Playlist.Text = button19.Text;


        //    try
        //    {
        //        Registro.mm1.button23.Text = Spotflix.Temporal_Info_Po[0].Titulo;
        //        Registro.mm1.button24.Text = Spotflix.Temporal_Info_Po[1].Titulo;
        //        Registro.mm1.button25.Text = Spotflix.Temporal_Info_Po[2].Titulo;
        //        Registro.mm1.button26.Text = Spotflix.Temporal_Info_Po[3].Titulo;
        //        Registro.mm1.button27.Text = Spotflix.Temporal_Info_Po[4].Titulo;

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
        //private void button20_Click(object sender, EventArgs e)
        //{
        //    Spotflix.Temporal.clear();
        //    Registro.mm1.tipo = 3;
        //    Spotflix.Agregar_a_temportal(Spotflix.perfilenlinea.Playlists_Podcast_Propios[2].Playlist_paralista_Po);
        //    Registro.mm1.AbrirMusica();
        //    Registro.mm1.Nombre_Playlist.Text = button20.Text;


        //    try
        //    {
        //        Registro.mm1.button23.Text = Spotflix.Temporal_Info_Po[0].Titulo;
        //        Registro.mm1.button24.Text = Spotflix.Temporal_Info_Po[1].Titulo;
        //        Registro.mm1.button25.Text = Spotflix.Temporal_Info_Po[2].Titulo;
        //        Registro.mm1.button26.Text = Spotflix.Temporal_Info_Po[3].Titulo;
        //        Registro.mm1.button27.Text = Spotflix.Temporal_Info_Po[4].Titulo;

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
        ////Botones Audiolibros
        //private void button25_Click(object sender, EventArgs e)
        //{
        //    Spotflix.Temporal.clear();
        //    Registro.mm1.tipo = 4;
        //    Spotflix.Agregar_a_temportal(Spotflix.Lista_AudioLibros);
        //    Registro.mm1.AbrirMusica();
        //    Registro.mm1.Nombre_Playlist.Text = button25.Text;


        //    try
        //    {
        //        Registro.mm1.button23.Text = Spotflix.Temporal_Info_AL[0].Titulo;
        //        Registro.mm1.button24.Text = Spotflix.Temporal_Info_AL[1].Titulo;
        //        Registro.mm1.button25.Text = Spotflix.Temporal_Info_AL[2].Titulo;
        //        Registro.mm1.button26.Text = Spotflix.Temporal_Info_AL[3].Titulo;
        //        Registro.mm1.button27.Text = Spotflix.Temporal_Info_AL[4].Titulo;

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        //private void button26_Click(object sender, EventArgs e)
        //{
        //    Spotflix.Temporal.clear();
        //    Registro.mm1.tipo = 4;
        //    Spotflix.Agregar_a_temportal(Spotflix.perfilenlinea.Playlists_Audiolibro_Propios[0].Playlist_paralista_AL);
        //    Registro.mm1.AbrirMusica();
        //    Registro.mm1.Nombre_Playlist.Text = button26.Text;


        //    try
        //    {
        //        Registro.mm1.button23.Text = Spotflix.Temporal_Info_AL[0].Titulo;
        //        Registro.mm1.button24.Text = Spotflix.Temporal_Info_AL[1].Titulo;
        //        Registro.mm1.button25.Text = Spotflix.Temporal_Info_AL[2].Titulo;
        //        Registro.mm1.button26.Text = Spotflix.Temporal_Info_AL[3].Titulo;
        //        Registro.mm1.button27.Text = Spotflix.Temporal_Info_AL[4].Titulo;

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        //private void button27_Click(object sender, EventArgs e)
        //{
        //    Spotflix.Temporal.clear();
        //    Registro.mm1.tipo = 4;
        //    Spotflix.Agregar_a_temportal(Spotflix.perfilenlinea.Playlists_Audiolibro_Propios[1].Playlist_paralista_AL);
        //    Registro.mm1.AbrirMusica();
        //    Registro.mm1.Nombre_Playlist.Text = button27.Text;


        //    try
        //    {
        //        Registro.mm1.button23.Text = Spotflix.Temporal_Info_AL[0].Titulo;
        //        Registro.mm1.button24.Text = Spotflix.Temporal_Info_AL[1].Titulo;
        //        Registro.mm1.button25.Text = Spotflix.Temporal_Info_AL[2].Titulo;
        //        Registro.mm1.button26.Text = Spotflix.Temporal_Info_AL[3].Titulo;
        //        Registro.mm1.button27.Text = Spotflix.Temporal_Info_AL[4].Titulo;

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //}

        //private void button28_Click(object sender, EventArgs e)
        //{
        //    Spotflix.Temporal.clear();
        //    Registro.mm1.tipo = 4;
        //    Spotflix.Agregar_a_temportal(Spotflix.perfilenlinea.Playlists_Audiolibro_Propios[2].Playlist_paralista_AL);
        //    Registro.mm1.AbrirMusica();
        //    Registro.mm1.Nombre_Playlist.Text = button28.Text;


        //    try
        //    {
        //        Registro.mm1.button23.Text = Spotflix.Temporal_Info_AL[0].Titulo;
        //        Registro.mm1.button24.Text = Spotflix.Temporal_Info_AL[1].Titulo;
        //        Registro.mm1.button25.Text = Spotflix.Temporal_Info_AL[2].Titulo;
        //        Registro.mm1.button26.Text = Spotflix.Temporal_Info_AL[3].Titulo;
        //        Registro.mm1.button27.Text = Spotflix.Temporal_Info_AL[4].Titulo;

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
        ////Botones Videos
        //private void button33_Click(object sender, EventArgs e)
        //{
        //    Spotflix.Temporal.clear();
        //    Registro.mm1.tipo = 5;
        //    Spotflix.Agregar_a_temportal(Spotflix.Lista_Videos);
        //    Registro.mm1.AbrirMusica();
        //    Registro.mm1.Nombre_Playlist.Text = button33.Text;


        //    try
        //    {
        //        Registro.mm1.button23.Text = Spotflix.Temporal_Info_Vi[0].Titulo;
        //        Registro.mm1.button24.Text = Spotflix.Temporal_Info_Vi[1].Titulo;
        //        Registro.mm1.button25.Text = Spotflix.Temporal_Info_Vi[2].Titulo;
        //        Registro.mm1.button26.Text = Spotflix.Temporal_Info_Vi[3].Titulo;
        //        Registro.mm1.button27.Text = Spotflix.Temporal_Info_Vi[4].Titulo;

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        //private void button34_Click(object sender, EventArgs e)
        //{
        //    Spotflix.Temporal.clear();
        //    Registro.mm1.tipo = 5;
        //    Spotflix.Agregar_a_temportal(Spotflix.perfilenlinea.Playlists_Video_Propios[0].Playlist_paralista_Vi);
        //    Registro.mm1.AbrirMusica();
        //    Registro.mm1.Nombre_Playlist.Text = button34.Text;


        //    try
        //    {
        //        Registro.mm1.button23.Text = Spotflix.Temporal_Info_Vi[0].Titulo;
        //        Registro.mm1.button24.Text = Spotflix.Temporal_Info_Vi[1].Titulo;
        //        Registro.mm1.button25.Text = Spotflix.Temporal_Info_Vi[2].Titulo;
        //        Registro.mm1.button26.Text = Spotflix.Temporal_Info_Vi[3].Titulo;
        //        Registro.mm1.button27.Text = Spotflix.Temporal_Info_Vi[4].Titulo;

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        //private void button35_Click(object sender, EventArgs e)
        //{
        //    Spotflix.Temporal.clear();
        //    Registro.mm1.tipo = 5;
        //    Spotflix.Agregar_a_temportal(Spotflix.perfilenlinea.Playlists_Video_Propios[1].Playlist_paralista_Vi);
        //    Registro.mm1.AbrirMusica();
        //    Registro.mm1.Nombre_Playlist.Text = button35.Text;


        //    try
        //    {
        //        Registro.mm1.button23.Text = Spotflix.Temporal_Info_Vi[0].Titulo;
        //        Registro.mm1.button24.Text = Spotflix.Temporal_Info_Vi[1].Titulo;
        //        Registro.mm1.button25.Text = Spotflix.Temporal_Info_Vi[2].Titulo;
        //        Registro.mm1.button26.Text = Spotflix.Temporal_Info_Vi[3].Titulo;
        //        Registro.mm1.button27.Text = Spotflix.Temporal_Info_Vi[4].Titulo;

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        //private void button36_Click(object sender, EventArgs e)
        //{
        //    Spotflix.Temporal.clear();
        //    Registro.mm1.tipo = 5;
        //    Spotflix.Agregar_a_temportal(Spotflix.perfilenlinea.Playlists_Video_Propios[2].Playlist_paralista_Vi);
        //    Registro.mm1.AbrirMusica();
        //    Registro.mm1.Nombre_Playlist.Text = button36.Text;


        //    try
        //    {
        //        Registro.mm1.button23.Text = Spotflix.Temporal_Info_Vi[0].Titulo;
        //        Registro.mm1.button24.Text = Spotflix.Temporal_Info_Vi[1].Titulo;
        //        Registro.mm1.button25.Text = Spotflix.Temporal_Info_Vi[2].Titulo;
        //        Registro.mm1.button26.Text = Spotflix.Temporal_Info_Vi[3].Titulo;
        //        Registro.mm1.button27.Text = Spotflix.Temporal_Info_Vi[4].Titulo;

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}


    }
}
