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

namespace Consola_Spotflix
{
    public partial class Main_menu : UserControl
    {
        int v1 = 50;
        public OpenFileDialog archivo = new OpenFileDialog();
        int play = 0;
        public string ruta;
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
        private void button35_Click(object sender, EventArgs e)
        {
            try
            {
                AbrirArchivo();
                if (ruta != "")
                {
                    play = 2;
                    AbrirMusica();
                }
                else
                {

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.fullScreen = true;
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
            try
            {

                //axWindowsMediaPlayer1.URL = @"" + ruta;
                axWindowsMediaPlayer1.URL = Spotflix.Lista_Canciones[0].URL;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                this.Visible = true;
                tmSlider.Start();
                trackBar_Duracion.Enabled = true;
                button_PlayPausa.Text = "Pausa";
                play = 2;
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
        private void tmSlider_Tick(object sender, EventArgs e)
        {
            try
            {
                trackBar_Duracion.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
                label_Tiempo_Inicio.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
                label_Tiempo_Fin.Text = axWindowsMediaPlayer1.currentMedia.durationString;

            }
            catch
            {

            }
        }
        public void AbrirArchivo()
        {
            archivo.Filter = "Archivo files|*.wav;*.mp3;*.mp4;.*;";
            DialogResult dres1 = archivo.ShowDialog();
            if (dres1 ==DialogResult.Abort)
            {
                return;
            }
            if (dres1 == DialogResult.Cancel)
            {
                return;
            }
            ruta = archivo.FileName;
        }

        private void Button_Perfil_En_Linea_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Spotflix.perfilenlinea.Usuario_Asociado.Nombre);
        }
    }
}
