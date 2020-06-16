using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.InteropServices;
using WMPLib;
using Proyecto_POO;
using System.Threading;
using System.Security.AccessControl;
using System.Xml.Serialization;
using System.IO;

namespace Consola_Spotflix
{
    public partial class Main_menu : UserControl
    {
        int v1 = 50;
        public OpenFileDialog archivo = new OpenFileDialog();
        int play = 0;
        public string ruta;
        public int tipo = 0;
        public void Iniciar()
        {
            Button_Perfil_En_Linea.Text = Spotflix.perfilenlinea.Nombre_perfil;
            playlist_Perfil_En_Linea1.Iniciar();        
        }
        public Main_menu()
        {
            InitializeComponent();
            Registro.mm1 = this;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            tmSlider.Stop();
            axWindowsMediaPlayer1.Ctlcontrols.next();
            tmSlider.Start();
            Thread.Sleep(500);
            if (tipo ==1)
            {
                Cancion_Artista_Ca();
            }
            else if (tipo == 2)
            {
                Cancion_Artista_Pe();
            }
            else if (tipo == 3)
            {
                Cancion_Artista_Po();
            }
            else if (tipo == 4)
            {
                Cancion_Artista_AL();
            }
            else if (tipo == 5)
            {
                Cancion_Artista_Vi();
            }
            
            
        }

        private void button_PlayPausa_Click(object sender, EventArgs e)
        {
            if (play==1)
            {
                AbrirMusica();
                play = 2;
            }
            else if (play == 2)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                tmSlider.Stop();
                button_PlayPausa.Text = "Play";
                play = 3;
            }
            else if (play == 3)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                tmSlider.Start();
                button_PlayPausa.Text = "Pausa";
                play = 2;
            }
        }
        public void AbrirMusica()
        {
            tmSlider.Stop();
            try
            {

                //axWindowsMediaPlayer1.URL = @"" + ruta;
                axWindowsMediaPlayer1.currentPlaylist = Spotflix.Temporal;
                //axWindowsMediaPlayer1.URL = ruta;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                this.Visible = true;
                tmSlider.Start();
                trackBar_Duracion.Enabled = true;
                button_PlayPausa.Text = "Pausa";
                play = 2;
                if (tipo == 1)
                {
                    Cancion_Artista_Ca();
                }
                else if (tipo == 2)
                {
                    Cancion_Artista_Pe();
                }
                else if (tipo == 3)
                {
                    Cancion_Artista_Po();
                }
                else if (tipo == 4)
                {
                    Cancion_Artista_AL();
                }
                else if (tipo == 5)
                {
                    Cancion_Artista_Vi();
                }

            }
            catch 
            {
            }
        }
        private void trackBar_Duracion_ValueChanged(object sender, EventArgs e)
        {
            trackBar_Duracion.Maximum = (int)axWindowsMediaPlayer1.currentMedia.duration;
            if (trackBar_Duracion.Value == (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition)
            {

            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition = trackBar_Duracion.Value;
            }
        }
        private void Cancion_Artista_Ca()
        {
            for (int i = 0; i < Spotflix.Temporal.count; i++)
            {
                if (axWindowsMediaPlayer1.currentMedia.isIdentical[Spotflix.Temporal.Item[i]])
                {
                    Nombre_Cancion.Text = Spotflix.Temporal_Info_Ca[i].Titulo;
                    Nombre_Artista.Text = Spotflix.Temporal_Info_Ca[i].Cantante[0].Nombre_y_Apellido;
                    Spotflix.Temporal_Info_Ca[i].Duracion = TimeSpan.Parse(axWindowsMediaPlayer1.currentMedia.durationString);
                    break;
                }
            }

        }
        private void Cancion_Artista_Pe()
        {
            for (int i = 0; i < Spotflix.Temporal.count; i++)
            {
                if (axWindowsMediaPlayer1.currentMedia.isIdentical[Spotflix.Temporal.Item[i]])
                {
                    Nombre_Cancion.Text = Spotflix.Temporal_Info_Pe[i].Titulo;
                    Nombre_Artista.Text = Spotflix.Temporal_Info_Pe[i].Director[0].Nombre_y_Apellido;
                    Spotflix.Temporal_Info_Pe[i].Duracion = TimeSpan.Parse(axWindowsMediaPlayer1.currentMedia.durationString);
                    break;
                }
            }

        }
        private void Cancion_Artista_Po()
        {
            for (int i = 0; i < Spotflix.Temporal.count; i++)
            {

                if (axWindowsMediaPlayer1.currentMedia.isIdentical[Spotflix.Temporal.Item[i]])
                {
                    Nombre_Cancion.Text = Spotflix.Temporal_Info_Po[i].Titulo;
                    Nombre_Artista.Text = Spotflix.Temporal_Info_Po[i].Locutor[0].Nombre_y_Apellido;
                    Spotflix.Temporal_Info_Po[i].Duracion = TimeSpan.Parse(axWindowsMediaPlayer1.currentMedia.durationString);
                    break;
                }
            }

        }
        private void Cancion_Artista_AL()
        {
            for (int i = 0; i < Spotflix.Temporal.count; i++)
            {
                if (axWindowsMediaPlayer1.currentMedia.isIdentical[Spotflix.Temporal.Item[i]])
                {
                    
                    Nombre_Cancion.Text = Spotflix.Temporal_Info_AL[i].Titulo;
                    Nombre_Artista.Text = Spotflix.Temporal_Info_AL[i].Lector.Nombre_y_Apellido;
                    Spotflix.Temporal_Info_AL[i].Duracion = TimeSpan.Parse(axWindowsMediaPlayer1.currentMedia.durationString);
                    break;
                }
            }

        }
        private void Cancion_Artista_Vi()
        {
            for (int i = 0; i < Spotflix.Temporal.count; i++)
            {
                if (axWindowsMediaPlayer1.currentMedia.isIdentical[Spotflix.Temporal.Item[i]])
                {
                    Nombre_Cancion.Text = Spotflix.Temporal_Info_Vi[i].Titulo;
                    Spotflix.Temporal_Info_Vi[i].Duracion = TimeSpan.Parse(axWindowsMediaPlayer1.currentMedia.durationString);
                    break;
                }
            }

        }
        private void tmSlider_Tick(object sender, EventArgs e)
        {
            try
            {
                trackBar_Duracion.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
                label_Tiempo_Inicio.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
                string a="";
                if (axWindowsMediaPlayer1.currentMedia==null)
                {
                  
                }
                else
                {
                    a = axWindowsMediaPlayer1.currentMedia.durationString;
                }
                if (a!="")
                {
                    label_Tiempo_Fin.Text = axWindowsMediaPlayer1.currentMedia.durationString;
                    if (tipo == 1)
                    {
                        Cancion_Artista_Ca();
                    }
                    else if (tipo == 2)
                    {
                        Cancion_Artista_Pe();
                    }
                    else if (tipo == 3)
                    {
                        Cancion_Artista_Po();
                    }
                    else if (tipo == 4)
                    {
                        Cancion_Artista_AL();
                    }
                    else if (tipo == 5)
                    {
                        Cancion_Artista_Vi();
                    }
                }
                
            }
            catch
            {

            }
        }



        private void Button_Perfil_En_Linea_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Spotflix.perfilenlinea.Usuario_Asociado.Nombre);
        }

        private void button_Retroceder_Click(object sender, EventArgs e)
        {
            tmSlider.Stop();
            axWindowsMediaPlayer1.Ctlcontrols.previous();
            tmSlider.Start();
            Thread.Sleep(500);
            if (tipo == 1)
            {
                Cancion_Artista_Ca();
            }
            else if (tipo == 2)
            {
                Cancion_Artista_Pe();
            }
            else if (tipo == 3)
            {
                Cancion_Artista_Po();
            }
            else if (tipo == 4)
            {
                Cancion_Artista_AL();
            }
            else if (tipo == 5)
            {
                Cancion_Artista_Vi();
            }

        }

        private void playlist_Perfil_En_Linea1_Load(object sender, EventArgs e)
        {
            
        }

        private void perfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro.busc1.tipo = "Perfiles";
            Registro.busc1.CargarBuscador();
        }

        private void artistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro.busc1.tipo = "Artistas";
            Registro.busc1.CargarBuscador();
        }

        private void playlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro.busc1.tipo = "Playlist";
            Registro.busc1.CargarBuscador();
        }

        private void cancionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro.busc1.tipo = "Canciones";
            Registro.busc1.CargarBuscador();
        }

        private void videosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro.busc1.tipo = "Videos";
            Registro.busc1.CargarBuscador();
        }

        private void peliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro.busc1.tipo = "Peliculas";
            Registro.busc1.CargarBuscador();
        }

        private void podcastsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro.busc1.tipo = "Podcasts";
            Registro.busc1.CargarBuscador();
        }

        private void audiolibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Registro.buscador1.cargar(); ;
            //buscador1.tipo = "Audio Libro";
        }

        private void botonCerrarSesion_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            Hide();
        }



        private void button_Informacion_Click(object sender, EventArgs e)
        {
            Spotflix.Lista_Perfiles = null;
            Spotflix.Lista_Usuarios = null;

            //Deserializar info perfil

            XmlSerializer serializer1 = new XmlSerializer(typeof(List<Perfil>));
            using (FileStream fs3 = File.OpenRead(Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Informacion\Perfiles\Data_Perfiles.xml"))
            {
                Spotflix.Lista_Perfiles = (List<Perfil>)serializer1.Deserialize(fs3);
            }
            ////Deserializar info perfil
            XmlSerializer serializer2 = new XmlSerializer(typeof(List<Usuario>));
            using (FileStream fs3 = File.OpenRead(Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Informacion\Usuarios\Data_Usuarios.xml"))
            {
                Spotflix.Lista_Usuarios = (List<Usuario>)serializer2.Deserialize(fs3);
            }
            //Serializar la info de perfil.
            using (Stream fs1 = new FileStream(Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Informacion\Perfiles\Data_Perfiles.xml", FileMode.Create,
                FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Perfil>));
                serializer.Serialize(fs1, Spotflix.Lista_Perfiles);
            }
            //Serializar la info de usuario
            using (Stream fs2 = new FileStream(Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Informacion\Usuarios\Data_Usuarios.xml", FileMode.Create,
                FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Usuario>));
                serializer.Serialize(fs2, Spotflix.Lista_Usuarios);
            }


            Registro.Informacion.Show();
            Registro.Informacion.BringToFront();
        }

        private void button_Cambio_de_Cuenta_Click(object sender, EventArgs e)
        {
            Registro.CambiodeCuenta.Show();
            Registro.CambiodeCuenta.BringToFront();
        }

        private void button_Crear_Playlist_Click(object sender, EventArgs e)
        {
            Registro.Crear_playlist.Show();
            Registro.Crear_playlist.BringToFront();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro.Crear_Archivo.Show();
            Registro.Crear_Archivo.BringToFront();
        }
    }
}
