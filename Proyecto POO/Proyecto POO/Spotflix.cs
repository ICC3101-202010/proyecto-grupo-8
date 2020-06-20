using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using WMPLib;
using System.Threading;
using System.Windows.Forms;


namespace Proyecto_POO
{
    
    public static class Spotflix
    {

        public static IWMPPlaylist Temporal = new WindowsMediaPlayer().newPlaylist("Temporal", null);
        public static List<Cancion> Temporal_Info_Ca = new List<Cancion>();
        public static List<Pelicula> Temporal_Info_Pe = new List<Pelicula>();
        public static List<Podcast> Temporal_Info_Po = new List<Podcast>();
        public static List<AudioLibro> Temporal_Info_AL = new List<AudioLibro>();
        public static List<Video> Temporal_Info_Vi = new List<Video>();
        public static List<Usuario> Lista_Usuarios = new List<Usuario>();
        public static List<Perfil> Lista_Perfiles = new List<Perfil>();
        public static List<Persona> Lista_Personas = new List<Persona>();
        
        public static List<Cancion> Lista_Canciones =  new List<Cancion>();
        public static List<Video> Lista_Videos = new List<Video>();
        public static List<Podcast> Lista_Podcasts = new List<Podcast>();
        public static List<Pelicula> Lista_Peliculas = new List<Pelicula>();
        public static List<AudioLibro> Lista_AudioLibros = new List<AudioLibro>();
        public static List<Playlist> Lista_Playlists;

        public static Usuario usuarioenlinea;

        public static Perfil perfilenlinea;

        public static List<Perfil> Lista_perfilesenlinea = new List<Perfil>();
        
        public static MainMenu mm1;
        public static Perfiles p1;
        public static NuevoPerfil np1;


        //Metodos:

        public static void Agregar_a_temportal(List<Cancion> canciones)
        {
            foreach (var item_4 in canciones)
            {
                Temporal.appendItem(new WindowsMediaPlayer().newMedia(item_4.URL));
            }
            Temporal_Info_Ca = canciones;
        }
        public static void Agregar_a_temportal(List<Pelicula> peliculas)
        {
            foreach (var item_4 in peliculas)
            {
                Temporal.appendItem(new WindowsMediaPlayer().newMedia(item_4.URL));
            }
            Temporal_Info_Pe = peliculas;
        }
        public static void Agregar_a_temportal(List<Podcast> podcasts)
        {
            foreach (var item_4 in podcasts)
            {
                Temporal.appendItem(new WindowsMediaPlayer().newMedia(item_4.URL));
            }
            Temporal_Info_Po = podcasts;
        }
        public static void Agregar_a_temportal(List<AudioLibro> audioLibros)
        {
            foreach (var item_4 in audioLibros)
            {
                Temporal.appendItem(new WindowsMediaPlayer().newMedia(item_4.URL));
            }
            Temporal_Info_AL = audioLibros;
        }
        public static void Agregar_a_temportal(List<Video> videos)
        {
            foreach (var item_4 in videos)
            {
                Temporal.appendItem(new WindowsMediaPlayer().newMedia(item_4.URL));
            }
            Temporal_Info_Vi = videos;
        }



        public static WindowsMediaPlayer spotflix = new WindowsMediaPlayer();

        public static void Reproducir(IWMPPlaylist playlist, int v = 0)
        {
            Thread.Sleep(500);
            spotflix.currentPlaylist.clear();
            spotflix.currentPlaylist = playlist;
            spotflix.controls.play();
        }
        public static void Pausar()
        {
            spotflix.controls.pause();

        }
        public static void Reanudar()
        {
            spotflix.controls.play();

        }
        public static void Adelantar()
        {
            spotflix.controls.next();

        }
        public static void Retroceder()
        {
            spotflix.controls.previous();

        }
        public static void Info()//informacion playlist
        {
            for (int i = 0; i < spotflix.currentPlaylist.count; i++)
            {
                Console.WriteLine(i + ". " + spotflix.currentPlaylist.Item[i].name);
            }
        }
        public static string Estado()
        {
            string a = spotflix.controls.currentPositionString + ". " + spotflix.status.Split(':')[0];
            return (a);
        }
    }
}
