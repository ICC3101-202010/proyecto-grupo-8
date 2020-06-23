using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_POO;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using WMPLib;
using System.IO;
using Timer = System.Threading.Timer;
using System.IO.Ports;

namespace Consola_Spotflix
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            //////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////
            //Crear Personas:
            Persona Bad_Bunny = new Persona("Bad Bunny", 1, "Puertorriqueño", new DateTime(1994, 03, 10), new List<int> { 1, 2 });
            Persona ShawnLevy = new Persona("Shawn Levy", 1, "Estadounidense", new DateTime(1968, 07, 23), new List<int> { 4 });
            Persona SteveMartin = new Persona("Steve Martin", 1, "Canadiense", new DateTime(1945, 08, 14), new List<int> { 3 });
            Persona BonnieHunt = new Persona("Bonnie Hunt", 2, "Estadounidense", new DateTime(1961, 09, 22), new List<int> { 3 });
            Persona PiperPerabo = new Persona("Piper Perabo", 2, "Estadounidense", new DateTime(1976, 10, 31), new List<int> { 3 });
            Persona HenryJoost = new Persona("Henry Joost", 1, "Estadounidense", new DateTime(1981, 07, 25), new List<int> { 4 });
            Persona EmmaRoberts = new Persona("Emma Roberts", 2, "Estadounidense", new DateTime(1991, 02, 10), new List<int> { 3 });
            Persona DaveFranco = new Persona("Dave Franco", 1, "Estadounidense", new DateTime(1985, 06, 2), new List<int> { 3 });
            Persona JulietteLewis = new Persona("Juliette Lewis", 2, "Estadounidense", new DateTime(1973, 06, 21), new List<int> { 3 });
            Persona KennethBranagh = new Persona("Kenneth Branagh", 1, "Britanico", new DateTime(1960, 12, 10), new List<int> { 4 });
            Persona LilyJames = new Persona("Lily James", 2, "Britanica", new DateTime(1989, 04, 05), new List<int> { 3 });
            Persona BenChaplin = new Persona("Ben Chaplin", 1, "Britanico", new DateTime(1969, 07, 31), new List<int> { 3 });
            Persona RichardMadden = new Persona("Richard Madden", 1, "Britanico", new DateTime(1986, 06, 18), new List<int> { 3 });
            Persona KennyOrtega = new Persona("Kenny Ortega", 1, "Estadounidense", new DateTime(1950, 04, 18), new List<int> { 4 });
            Persona ZacEfron = new Persona("Zac Efron", 1, "Estadounidense", new DateTime(1987, 10, 18), new List<int> { 3 });
            Persona VanessaHudgens = new Persona("Vanessa Hudgens", 2, "Estadounidense", new DateTime(1988, 12, 14), new List<int> { 3 });
            Persona AshleyTisdale = new Persona("Ashley Tisdale", 2, "Estadounidense", new DateTime(1985, 07, 02), new List<int> { 3 });
            Persona DennisDugan = new Persona("Dennis Dugan", 1, "Estadounidense", new DateTime(1946, 09, 05), new List<int> { 4 });
            Persona AdamSandler = new Persona("Adam Sandles", 1, "Estadounidense", new DateTime(1966, 09, 09), new List<int> { 3 });
            Persona KevinJames = new Persona("Kevin James", 1, "Estadounidense", new DateTime(1965, 04, 28), new List<int> { 3 });
            Persona ChrisRock = new Persona("Chris Rock", 1, "Estadounidense", new DateTime(1967, 02, 13), new List<int> { 3 });
            Persona Coolio = new Persona("Coolio", 1, "Estadounidense", new DateTime(1963, 08, 01), new List<int> { 1, 2 });
            Persona Anuel = new Persona("Anuel AA", 1, "Puertorriqueño", new DateTime(1992, 11, 27), new List<int> { 1, 2 });
            Persona Karol_G = new Persona("Karol G", 2, "Colombiana", new DateTime(1991, 02, 14), new List<int> { 1, 2 });
            Persona DripReport = new Persona("DripReport", 1, "Indio", new DateTime(1970, 06, 14), new List<int> { 1, 2 });
            Persona Roxana_Gonzalez = new Persona("Roxana Gonzalez", 1, "Española", new DateTime(1998, 2, 2), new List<int> { 6 });
            Persona Miguel_Granados = new Persona("Miguel Granados", 1, "Argentino", new DateTime(1986, 10, 25), new List<int> { 5 });

            //Agregar a lista:
            Spotflix.Lista_Personas.Add(Bad_Bunny);
            Spotflix.Lista_Personas.Add(ShawnLevy);
            Spotflix.Lista_Personas.Add(SteveMartin);
            Spotflix.Lista_Personas.Add(BonnieHunt);
            Spotflix.Lista_Personas.Add(PiperPerabo);
            Spotflix.Lista_Personas.Add(HenryJoost);
            Spotflix.Lista_Personas.Add(EmmaRoberts);
            Spotflix.Lista_Personas.Add(DaveFranco);
            Spotflix.Lista_Personas.Add(JulietteLewis);
            Spotflix.Lista_Personas.Add(KennethBranagh);
            Spotflix.Lista_Personas.Add(LilyJames);
            Spotflix.Lista_Personas.Add(BenChaplin);
            Spotflix.Lista_Personas.Add(RichardMadden);
            Spotflix.Lista_Personas.Add(KennyOrtega);
            Spotflix.Lista_Personas.Add(ZacEfron);
            Spotflix.Lista_Personas.Add(VanessaHudgens);
            Spotflix.Lista_Personas.Add(AshleyTisdale);
            Spotflix.Lista_Personas.Add(DennisDugan);
            Spotflix.Lista_Personas.Add(AdamSandler);
            Spotflix.Lista_Personas.Add(KevinJames);
            Spotflix.Lista_Personas.Add(ChrisRock);
            Spotflix.Lista_Personas.Add(Coolio);
            Spotflix.Lista_Personas.Add(Anuel);
            Spotflix.Lista_Personas.Add(Karol_G);
            Spotflix.Lista_Personas.Add(DripReport);
            Spotflix.Lista_Personas.Add(Roxana_Gonzalez);
            Spotflix.Lista_Personas.Add(Miguel_Granados);

            //Crear Canciones:
            Cancion Como_se_siente = new Cancion("Como se siente", 1, new DateTime(2020, 05, 11), TimeSpan.Zero, 10.0, 2,
                Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Biblioteca\Musica\Bad bunny - Como se siente.mp3"
                , new List<Persona> { Bad_Bunny }, new List<Persona> { Bad_Bunny }, "Las que no iban a salir", "Imagen", "Letra", "Trap");
            Cancion Gangstas_paradise = new Cancion("Gangsta's paradise", 1, new DateTime(1995, 08, 08), TimeSpan.Zero, 10.0, 2,
                Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Biblioteca\Musica\Coolio - gangstas paradise.wav",
                new List<Persona> { Coolio }, new List<Persona> { Coolio }, "Gangsta's Paradise 2k11", "Imagen", "Letra", "Rap");
            Cancion Tres_de_abril = new Cancion("3 de Abril", 1, new DateTime(2020, 04, 03), TimeSpan.Zero, 10.0, 2,
                Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Biblioteca\Musica\Anuel AA - 3 de abril.wav",
                new List<Persona> { Anuel }, new List<Persona> { Anuel }, "3 de Abril", "Imagen", "Letra", "Trap");
            Cancion Keii = new Cancion("Keii", 1, new DateTime(2020, 02, 07), TimeSpan.Zero, 10.0, 2,
                Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Biblioteca\Musica\Anuel AA - Keii.wav",
                new List<Persona> { Anuel }, new List<Persona> { Anuel }, "Keii", "Imagen", "Letra", "Trap");
            Cancion Follow = new Cancion("Follow", 1, new DateTime(2020, 04, 01), TimeSpan.Zero, 10.0, 2,
                Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Biblioteca\Musica\Karol G, Anuel AA - Follow.wav",
                new List<Persona> { Karol_G, Anuel }, new List<Persona> { Karol_G }, "Keii", "Imagen", "Letra", "Reggaeton");
            Cancion Skechers = new Cancion("Skechers", 1, new DateTime(2020, 01, 12), TimeSpan.Zero, 10.0, 2,
                Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Biblioteca\Musica\DripReport - Skechers.wav",
                new List<Persona> { DripReport }, new List<Persona> { DripReport }, "Skechers", "Imagen", "Letra", "Rap");

            //Agregar Canciones:
            Spotflix.Lista_Canciones.Add(Como_se_siente);
            Spotflix.Lista_Canciones.Add(Gangstas_paradise);
            Spotflix.Lista_Canciones.Add(Tres_de_abril);
            Spotflix.Lista_Canciones.Add(Keii);
            Spotflix.Lista_Canciones.Add(Follow);
            Spotflix.Lista_Canciones.Add(Skechers);

            //Crear Peliculas:
            Pelicula MasBaratoPorDocena = new Pelicula("Mas Barato Por Docena", 4, new DateTime(2003, 12, 25), new TimeSpan(1, 46, 0), 10.0, 1,
                Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Biblioteca\Peliculas\Mas Barato por Docena - Trailer.mp4", new List<Persona> { SteveMartin, BonnieHunt, PiperPerabo }, new List<Persona> { ShawnLevy },
                "‎20th Century Fox Home Entertainment", 2, "Descripcion", 1, "Familiar");
            Pelicula Nerve = new Pelicula("Nerve", 4, new DateTime(2016, 09, 01), new TimeSpan(1, 36, 0), 10.0, 1,
                Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Biblioteca\Peliculas\Nerve - Trailer Oficial.mp4", new List<Persona> { EmmaRoberts, DaveFranco, JulietteLewis }, new List<Persona> { HenryJoost },
                "‎Allison Shearmur Productions", 2, "Descripcion", 1, "Accion");
            Pelicula LaCenicienta = new Pelicula("La Cenicienta", 4, new DateTime(2015, 03, 13), new TimeSpan(1, 54, 0), 10.0, 1,
                Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Biblioteca\Peliculas\La Cenicienta - Trailer Oficial.mp4", new List<Persona> { LilyJames, BenChaplin, RichardMadden }, new List<Persona> { KennethBranagh },
                "Walt Disney Productions", 2, "Descripcion", 1, "Fantasia");
            Pelicula HighSchoolMusical = new Pelicula("High School Musical", 4, new DateTime(2006, 01, 20), new TimeSpan(1, 38, 0), 10.0, 1,
                Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Biblioteca\Peliculas\High School Musical – Original Trailer.mp4", new List<Persona> { ZacEfron, VanessaHudgens, AshleyTisdale }, new List<Persona> { KennyOrtega },
                "Salty Films", 1, "Descripcion", 2, "Musical");
            Pelicula SonComoNiños = new Pelicula("Son Como Niños", 4, new DateTime(2010, 06, 24), new TimeSpan(1, 42, 0), 10.0, 1,
                Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Biblioteca\Peliculas\Son como Niños - Trailer Oficial.mp4", new List<Persona> { AdamSandler, KevinJames, ChrisRock }, new List<Persona> { DennisDugan },
                "Relativity Media", 2, "Descripcion", 1, "Comedia");

            //Agregar Peliculas:
            Spotflix.Lista_Peliculas.Add(MasBaratoPorDocena);
            Spotflix.Lista_Peliculas.Add(Nerve);
            Spotflix.Lista_Peliculas.Add(LaCenicienta);
            Spotflix.Lista_Peliculas.Add(HighSchoolMusical);
            Spotflix.Lista_Peliculas.Add(SonComoNiños);

            //Crear Audiolibros
            AudioLibro Azafata_Chistosa = new AudioLibro("Azafata chistosa", 3, new DateTime(2020, 05, 11), TimeSpan.Zero, 10.0, 2,
                Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Biblioteca\Audio libros\Azafata Chistosa\Azafata chistosa.mp3",
                Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Biblioteca\Audio libros\Azafata Chistosa\Azafata chistosa.txt", "Comedia", 1, Roxana_Gonzalez);
            AudioLibro Hijo_Huerfano = new AudioLibro("Hijo huerfano", 3, new DateTime(2020, 05, 11), TimeSpan.Zero, 10.0, 2,
                Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Biblioteca\Audio libros\Hijo Huerfano\Hijo huerfano.mp3",
                Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Biblioteca\Audio libros\Hijo Huerfano\Hijo huerfano.txt", "Comedia", 1, Roxana_Gonzalez);

            //Agregar Audilibors:
            Spotflix.Lista_AudioLibros.Add(Azafata_Chistosa);
            Spotflix.Lista_AudioLibros.Add(Hijo_Huerfano);

            //Crear Videos:
            Video Como_Bajar_videos = new Video("Como bajar videos de youtube", 2, new DateTime(2020, 01, 15), TimeSpan.Zero, 10.0, 2,
                 Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Biblioteca\Videos\2 Formas Increibles de bajar videos en youtube sin programas 2020.mp4", 2, "", 2, "Informativo");

            //Agregar Videos:
            Spotflix.Lista_Videos.Add(Como_Bajar_videos);

            //Crear Podcast:
            Podcast Comedia_Miguel_Granados = new Podcast("Comedia Miguel Granados", 3, new DateTime(2019, 10, 17), TimeSpan.Zero, 10.0, 2,
                Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Biblioteca\Podcast\Comedia - Miguel Granados.mp3", new List<Persona> { Miguel_Granados }, "Imagen", "Comedia");

            //Agregar Podcast:
            Spotflix.Lista_Podcasts.Add(Comedia_Miguel_Granados);

            //Crear Usuarios:
            Usuario User_Ronca = new Usuario("Juan", "Roncagliolo", new DateTime(1998, 01, 16), 1, "Chile", "ronca@spotflix.com", "ronca", 2);

            //Agregar Usuarios:
            Spotflix.Lista_Usuarios.Add(User_Ronca);

            //Crear Perfil
            Perfil Perfil_Ronca = new Perfil(User_Ronca, "Ronca", 1, "");

            //Agregar perfil:
            Spotflix.Lista_Perfiles.Add(Perfil_Ronca);

            Spotflix.Lista_Perfiles = null;
            Spotflix.Lista_Usuarios = null;

            Spotflix.Lista_Canciones = null;
            Spotflix.Lista_Peliculas = null;
            Spotflix.Lista_Podcasts = null;
            Spotflix.Lista_AudioLibros = null;
            Spotflix.Lista_Videos = null;




            //Deserializar info perfil

            XmlSerializer serializer101 = new XmlSerializer(typeof(List<Perfil>));
            using (FileStream fs4 = File.OpenRead(Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Informacion\Perfiles\Data_Perfiles.xml"))
            {
                Spotflix.Lista_Perfiles = (List<Perfil>)serializer101.Deserialize(fs4);
            }
            //Deserializar info usuarios
            XmlSerializer serializer102 = new XmlSerializer(typeof(List<Usuario>));
            using (FileStream fs4 = File.OpenRead(Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Informacion\Usuarios\Data_Usuarios.xml"))
            {
                Spotflix.Lista_Usuarios = (List<Usuario>)serializer102.Deserialize(fs4);
            }

            //Deserializar info canciones
            XmlSerializer serializer111 = new XmlSerializer(typeof(List<Cancion>));
            using (FileStream fs4 = File.OpenRead(Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Informacion\Multimedia\Data_Multimedia_Canciones.xml"))
            {
                Spotflix.Lista_Canciones = (List<Cancion>)serializer111.Deserialize(fs4);
            }
            //Deserializar info peliculas
            XmlSerializer serializer112 = new XmlSerializer(typeof(List<Pelicula>));
            using (FileStream fs4 = File.OpenRead(Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Informacion\Multimedia\Data_Multimedia_Peliculas.xml"))
            {
                Spotflix.Lista_Peliculas = (List<Pelicula>)serializer112.Deserialize(fs4);
            }
            //Deserializar info podcast
            XmlSerializer serializer113 = new XmlSerializer(typeof(List<Podcast>));
            using (FileStream fs4 = File.OpenRead(Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Informacion\Multimedia\Data_Multimedia_Podcast.xml"))
            {
                Spotflix.Lista_Podcasts = (List<Podcast>)serializer113.Deserialize(fs4);
            }
            //Deserializar info audiolibors
            XmlSerializer serializer114 = new XmlSerializer(typeof(List<AudioLibro>));
            using (FileStream fs4 = File.OpenRead(Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Informacion\Multimedia\Data_Multimedia_Audiolibro.xml"))
            {
                Spotflix.Lista_AudioLibros = (List<AudioLibro>)serializer114.Deserialize(fs4);
            }
            //Deserializar info videos
            XmlSerializer serializer115 = new XmlSerializer(typeof(List<Video>));
            using (FileStream fs4 = File.OpenRead(Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Informacion\Multimedia\Data_Multimedia_Videos.xml"))
            {
                Spotflix.Lista_Videos = (List<Video>)serializer115.Deserialize(fs4);
            }

            /////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////
            Application.EnableVisualStyles();                    ////
            Application.SetCompatibleTextRenderingDefault(false);////
            Application.Run(new Main_Spotflix());                ////
            /////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////




            //Serializar la info de perfil.
            using (Stream fs1 = new FileStream(Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Informacion\Perfiles\Data_Perfiles.xml", FileMode.Create,
                FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer001 = new XmlSerializer(typeof(List<Perfil>));
                serializer001.Serialize(fs1, Spotflix.Lista_Perfiles);
            }
            //Serializar la info de usuario
            using (Stream fs2 = new FileStream(Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Informacion\Usuarios\Data_Usuarios.xml", FileMode.Create,
                FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer002 = new XmlSerializer(typeof(List<Usuario>));
                serializer002.Serialize(fs2, Spotflix.Lista_Usuarios);
            }
            //Serializar la info de canciones.
            using (Stream fs3 = new FileStream(Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Informacion\Multimedia\Data_Multimedia_Canciones.xml", FileMode.Create,
                FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer011 = new XmlSerializer(typeof(List<Cancion>));                
                serializer011.Serialize(fs3, Spotflix.Lista_Canciones);
            }
            //Serializar la info de peliculas.
            using (Stream fs3 = new FileStream(Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Informacion\Multimedia\Data_Multimedia_Peliculas.xml", FileMode.Create,
                FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer012 = new XmlSerializer(typeof(List<Pelicula>));
                serializer012.Serialize(fs3, Spotflix.Lista_Peliculas);
            }
            //Serializar la info de podcast.
            using (Stream fs3 = new FileStream(Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Informacion\Multimedia\Data_Multimedia_Podcast.xml", FileMode.Create,
                FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer013 = new XmlSerializer(typeof(List<Podcast>));
                serializer013.Serialize(fs3, Spotflix.Lista_Podcasts);
            }
            //Serializar la info de audiolibro.
            using (Stream fs3 = new FileStream(Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Informacion\Multimedia\Data_Multimedia_Audiolibro.xml", FileMode.Create,
                FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer014 = new XmlSerializer(typeof(List<AudioLibro>));
                serializer014.Serialize(fs3, Spotflix.Lista_AudioLibros);
            }
            //Serializar la info de videos.
            using (Stream fs3 = new FileStream(Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Informacion\Multimedia\Data_Multimedia_Videos.xml", FileMode.Create,
                FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer015 = new XmlSerializer(typeof(List<Video>));
                serializer015.Serialize(fs3, Spotflix.Lista_Videos);
            }
        }

    }

}