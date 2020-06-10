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
        public Cancion cancion = new Cancion();
        public Pelicula pelicula = new Pelicula();
        public Podcast podcast = new Podcast();
        public AudioLibro audiolibro = new AudioLibro();
        public Video video = new Video();
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

            foreach (Control C in this.Controls)
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
                            if (Convert.ToInt32(control.Name.Substring(6)) <= 9 && Convert.ToInt32(control.Name.Substring(6)) >= 2)
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

            Button button = sender as Button;
            Spotflix.Temporal.clear();
            Registro.mm1.tipo = 1;
            Spotflix.Agregar_a_temportal(canciones);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button.Text;
            Metodo(canciones);
        }
        public void Prueba_Pe(object sender, EventArgs e)
        {

            Button button = sender as Button;
            Spotflix.Temporal.clear();
            Registro.mm1.tipo = 2;
            Spotflix.Agregar_a_temportal(peliculas);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button.Text;
            Metodo(peliculas);
        }
        public void Prueba_Po(object sender, EventArgs e)
        {

            Button button = sender as Button;
            Spotflix.Temporal.clear();
            Registro.mm1.tipo = 3;
            Spotflix.Agregar_a_temportal(podcasts);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button.Text;
            Metodo(podcasts);
        }
        public void Prueba_AL(object sender, EventArgs e)
        {

            Button button = sender as Button;
            Spotflix.Temporal.clear();
            Registro.mm1.tipo = 4;
            Spotflix.Agregar_a_temportal(audiolibros);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button.Text;
            Metodo(audiolibros);
        }
        public void Prueba_Vi(object sender, EventArgs e)
        {

            Button button = sender as Button;
            Spotflix.Temporal.clear();
            Registro.mm1.tipo = 5;
            Spotflix.Agregar_a_temportal(videos);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button.Text;
            Metodo(videos);
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
            Metodo(canciones);


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
            Metodo(canciones);

        }
        public void button10_Click(object sender, EventArgs e)
        {
            peliculas = Spotflix.Lista_Peliculas;
            Button button = sender as Button;
            Spotflix.Temporal.clear();
            Registro.mm1.tipo = 2;
            Spotflix.Agregar_a_temportal(peliculas);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button.Text;
            Metodo(peliculas);

        }
        public void button11_Click(object sender, EventArgs e)
        {
            peliculas = Spotflix.perfilenlinea.Fav_Pelicula;
            Button button = sender as Button;
            Spotflix.Temporal.clear();
            Registro.mm1.tipo = 2;
            Spotflix.Agregar_a_temportal(peliculas);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button.Text;
            Metodo(peliculas);
        }
        public void button20_Click(object sender, EventArgs e)
        {
            podcasts = Spotflix.Lista_Podcasts;
            Button button = sender as Button;
            Spotflix.Temporal.clear();
            Registro.mm1.tipo = 3;
            Spotflix.Agregar_a_temportal(podcasts);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button.Text;
            Metodo(podcasts);
        }
        public void button21_Click(object sender, EventArgs e)
        {
            podcasts = Spotflix.perfilenlinea.Fav_Podcast;
            Button button = sender as Button;
            Spotflix.Temporal.clear();
            Registro.mm1.tipo = 3;
            Spotflix.Agregar_a_temportal(podcasts);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button.Text;
            Metodo(podcasts);
        }
        public void button30_Click(object sender, EventArgs e)
        {
            audiolibros = Spotflix.Lista_AudioLibros;
            Button button = sender as Button;
            Spotflix.Temporal.clear();
            Registro.mm1.tipo = 4;
            Spotflix.Agregar_a_temportal(audiolibros);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button.Text;
            Metodo(audiolibros);
        }
        public void button31_Click(object sender, EventArgs e)
        {
            audiolibros = Spotflix.perfilenlinea.Fav_AudioLibro;
            Button button = sender as Button;
            Spotflix.Temporal.clear();
            Registro.mm1.tipo = 4;
            Spotflix.Agregar_a_temportal(audiolibros);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button.Text;
            Metodo(audiolibros);
        }
        public void button40_Click(object sender, EventArgs e)
        {
            videos = Spotflix.Lista_Videos;
            Button button = sender as Button;
            Spotflix.Temporal.clear();
            Registro.mm1.tipo = 5;
            Spotflix.Agregar_a_temportal(videos);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button.Text;
            Metodo(videos);
        }
        public void button41_Click(object sender, EventArgs e)
        {
            videos = Spotflix.perfilenlinea.Fav_Videos;
            Button button = sender as Button;
            Spotflix.Temporal.clear();
            Registro.mm1.tipo = 5;
            Spotflix.Agregar_a_temportal(videos);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button.Text;
            Metodo(videos);
        }
        //
        private void Metodo(List<Cancion> canciones)
        {
            foreach (Control C in Registro.mm1.Controls)
            {
                foreach (Control D in C.Controls)
                {
                    if (D.Name == "panel5")
                    {
                        int i = 0;
                        foreach (Control E in D.Controls)
                        {

                            if (E.GetType() == typeof(Button))
                            {
                                E.Hide();
                                try
                                {
                                    E.Text = canciones[i].Titulo;
                                    E.Click += new EventHandler(this.Reproducir_Ca);
                                    E.Show();
                                    i++;
                                }
                                catch { }
                            }
                        }
                    }
                }

            }
        }
        private void Metodo(List<Pelicula> peliculas)
        {
            foreach (Control C in Registro.mm1.Controls)
            {
                foreach (Control D in C.Controls)
                {
                    if (D.Name == "panel5")
                    {
                        int i = 0;
                        foreach (Control E in D.Controls)
                        {

                            if (E.GetType() == typeof(Button))
                            {
                                E.Hide();
                                try
                                {
                                    E.Text = peliculas[i].Titulo;
                                    E.Click += new EventHandler(this.Reproducir_Pe);
                                    E.Show();
                                    i++;
                                }
                                catch { }
                            }
                        }
                    }
                }

            }
        }
        private void Metodo(List<Podcast> podcasts)
        {
            foreach (Control C in Registro.mm1.Controls)
            {
                foreach (Control D in C.Controls)
                {
                    if (D.Name == "panel5")
                    {
                        int i = 0;
                        foreach (Control E in D.Controls)
                        {

                            if (E.GetType() == typeof(Button))
                            {
                                E.Hide();
                                try
                                {
                                    E.Text = podcasts[i].Titulo;
                                    E.Click += new EventHandler(this.Reproducir_Po);
                                    E.Show();
                                    i++;
                                }
                                catch { }
                            }
                        }
                    }
                }

            }
        }
        private void Metodo(List<AudioLibro> audioLibros)
        {
            foreach (Control C in Registro.mm1.Controls)
            {
                foreach (Control D in C.Controls)
                {
                    if (D.Name == "panel5")
                    {
                        int i = 0;
                        foreach (Control E in D.Controls)
                        {

                            if (E.GetType() == typeof(Button))
                            {
                                E.Hide();
                                try
                                {
                                    E.Text = audioLibros[i].Titulo;
                                    E.Click += new EventHandler(this.Reproducir_AL);
                                    E.Show();
                                    i++;
                                }
                                catch { }
                            }
                        }
                    }
                }

            }
        }
        private void Metodo(List<Video> videos)
        {
            foreach (Control C in Registro.mm1.Controls)
            {
                foreach (Control D in C.Controls)
                {
                    if (D.Name == "panel5")
                    {
                        int i = 0;
                        foreach (Control E in D.Controls)
                        {

                            if (E.GetType() == typeof(Button))
                            {
                                E.Hide();
                                try
                                {
                                    E.Text = videos[i].Titulo;
                                    E.Click += new EventHandler(this.Reproducir_Vi);
                                    E.Show();
                                    i++;
                                }
                                catch { }
                            }
                        }
                    }
                }

            }
        }

        public void Reproducir_Ca(object sender, EventArgs e)
        {
            Button button = sender as Button;
            foreach (var item in canciones)
            {
                if (item.Titulo==button.Text )
                {
                    cancion = item;
                }
            }
            List<Cancion> temp = new List<Cancion>();
            temp.Add(cancion);
            Spotflix.Temporal.clear();
            Registro.mm1.tipo = 1;
            Spotflix.Agregar_a_temportal(temp);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button.Text;
        }     

        public void Reproducir_Pe(object sender, EventArgs e)
        {
            Button button = sender as Button;
            foreach (var item in peliculas)
            {
                if (item.Titulo == button.Text)
                {
                    pelicula = item;
                }
            }
            List<Pelicula> temp = new List<Pelicula>();
            temp.Add(pelicula);
            Spotflix.Temporal.clear();
            Registro.mm1.tipo = 2;
            Spotflix.Agregar_a_temportal(temp);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button.Text;
        }
        public void Reproducir_Po(object sender, EventArgs e)
        {
            Button button = sender as Button;
            foreach (var item in podcasts)
            {
                if (item.Titulo == button.Text)
                {
                    podcast = item;
                }
            }
            List<Podcast> temp = new List<Podcast>();
            temp.Add(podcast);
            Spotflix.Temporal.clear();
            Registro.mm1.tipo = 3;
            Spotflix.Agregar_a_temportal(temp);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button.Text;
        }
        public void Reproducir_AL(object sender, EventArgs e)
        {
            Button button = sender as Button;
            foreach (var item in audiolibros)
            {
                if (item.Titulo == button.Text)
                {
                    audiolibro = item;
                }
            }
            List<AudioLibro> temp = new List<AudioLibro>();
            temp.Add(audiolibro);
            Spotflix.Temporal.clear();
            Registro.mm1.tipo = 4;
            Spotflix.Agregar_a_temportal(temp);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button.Text;
        }
        public void Reproducir_Vi(object sender, EventArgs e)
        {
            Button button = sender as Button;
            foreach (var item in videos)
            {
                if (item.Titulo == button.Text)
                {
                    video = item;
                }
            }
            List<Video> temp = new List<Video>();
            temp.Add(video);
            Spotflix.Temporal.clear();
            Registro.mm1.tipo = 5;
            Spotflix.Agregar_a_temportal(temp);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button.Text;
        }



    }
}
