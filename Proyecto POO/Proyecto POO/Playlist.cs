using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace Proyecto_POO
{
    public class Playlist
    {
        public enum enum_TipoDePlaylist
        {
            Publica = 1,
            Privada = 2,
        }
        public List<Cancion> Playlist_paralista_Ca = new List<Cancion>();//listas de Canciones
        public List<Pelicula> Playlist_paralista_Pe = new List<Pelicula>();//Lista de Peliculas
        public List<Podcast> Playlist_paralista_Po = new List<Podcast>();//listas de Podcast
        public List<AudioLibro> Playlist_paralista_AL = new List<AudioLibro>();//listas de Audiolibro
        public List<Video> Playlist_paralista_Vi = new List<Video>();//Lista de Video
        public string Nombre;
        public TimeSpan Duracion = TimeSpan.Zero;
        public int Tipo_De_Playlist;

        //Constructor
        public Playlist() { }
        public Playlist(List<Cancion> playlist_paralista, string nombre, int tipo_de_playlist)
        {
            Playlist_paralista_Ca = playlist_paralista;
            Nombre = nombre;
            Tipo_De_Playlist = tipo_de_playlist;
        }
        public Playlist(List<Pelicula> playlist_paralista, string nombre, int tipo_de_playlist)
        {
            Playlist_paralista_Pe = playlist_paralista;
            Nombre = nombre;
            Tipo_De_Playlist = tipo_de_playlist;
        }
        public Playlist(List<Podcast> playlist_paralista, string nombre, int tipo_de_playlist)
        {
            Playlist_paralista_Po = playlist_paralista;
            Nombre = nombre;
            Tipo_De_Playlist = tipo_de_playlist;
        }
        public Playlist(List<AudioLibro> playlist_paralista, string nombre, int tipo_de_playlist)
        {
            Playlist_paralista_AL = playlist_paralista;
            Nombre = nombre;
            Tipo_De_Playlist = tipo_de_playlist;
        }
        public Playlist(List<Video> playlist_paralista, string nombre, int tipo_de_playlist)
        {
            Playlist_paralista_Vi = playlist_paralista;
            Nombre = nombre;
            Tipo_De_Playlist = tipo_de_playlist;
        }

        public string Informacion_Playlist(List<Cancion> playlist_paralista)
        {
            string a = "Nombre playlist: " + Nombre + "Tipo de playlist" + (enum_TipoDePlaylist)Tipo_De_Playlist;
            a += "\n Nombre archivos en playlist: ";
            TimeSpan b = TimeSpan.Zero;
            for (int i = 0; i < playlist_paralista.Count; i++)
            {
                a += (i + 1) + ".  " + playlist_paralista[i].Titulo;
                b += playlist_paralista[i].Duracion;
            }
            a += "\nDuracion: " + b;
            return (a);
        }
        public string Informacion_Playlist(List<Pelicula> playlist_paralista)
        {
            string a = "Nombre playlist: " + Nombre + "Tipo de playlist" + (enum_TipoDePlaylist)Tipo_De_Playlist;
            a += "\n Nombre archivos en playlist: ";
            TimeSpan b = TimeSpan.Zero;
            for (int i = 0; i < playlist_paralista.Count; i++)
            {
                a += (i + 1) + ".  " + playlist_paralista[i].Titulo;
                b += playlist_paralista[i].Duracion;
            }
            a += "\nDuracion: " + b;
            return (a);
        }
        public string Informacion_Playlist(List<Podcast> playlist_paralista)
        {
            string a = "Nombre playlist: " + Nombre + "Tipo de playlist" + (enum_TipoDePlaylist)Tipo_De_Playlist;
            a += "\n Nombre archivos en playlist: ";
            TimeSpan b = TimeSpan.Zero;
            for (int i = 0; i < playlist_paralista.Count; i++)
            {
                a += (i + 1) + ".  " + playlist_paralista[i].Titulo;
                b += playlist_paralista[i].Duracion;
            }
            a += "\nDuracion: " + b;
            return (a);
        }
        public string Informacion_Playlist(List<AudioLibro> playlist_paralista)
        {
            string a = "Nombre playlist: " + Nombre + "Tipo de playlist" + (enum_TipoDePlaylist)Tipo_De_Playlist;
            a += "\n Nombre archivos en playlist: ";
            TimeSpan b = TimeSpan.Zero;
            for (int i = 0; i < playlist_paralista.Count; i++)
            {
                a += (i + 1) + ".  " + playlist_paralista[i].Titulo;
                b += playlist_paralista[i].Duracion;
            }
            a += "\nDuracion: " + b;
            return (a);
        }
        public string Informacion_Playlist(List<Video> playlist_paralista)
        {
            string a = "Nombre playlist: " + Nombre + "Tipo de playlist" + (enum_TipoDePlaylist)Tipo_De_Playlist;
            a += "\n Nombre archivos en playlist: ";
            TimeSpan b = TimeSpan.Zero;
            for (int i = 0; i < playlist_paralista.Count; i++)
            {
                a += (i+1) + ".  " + playlist_paralista[i].Titulo;
                b += playlist_paralista[i].Duracion;
            }
            a += "\nDuracion: " + b;
            return (a);
        }

    }
}
