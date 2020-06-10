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
using System.IO;

namespace Consola_Spotflix
{
    public partial class Archivos : UserControl
    {
        public Archivos()
        {
            InitializeComponent();
            Registro.Crear_Archivo = this;

        }
        private string source;
        private string destination;


        private void button3_Click(object sender, EventArgs e)
        { 
            if (textBox2.Text == "Cancion")
            {
                source = openFileDialog1.FileName;
                destination = Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Biblioteca\Musica\"+textBox4;
                System.IO.File.Copy(source, destination, true);
                //Spotflix.Lista_Canciones.Add(new Cancion(textBox1.Text, 1, Convert.ToDateTime(textBox3), TimeSpan.Zero, 10, 1, destination,)));
            }
            else if (textBox2.Text == "Pelicula")
            {
                source = openFileDialog1.FileName;
                destination = Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Biblioteca\Peliculas\" + textBox4;
                System.IO.File.Copy(source, destination, true);
                //Spotflix.Lista_Peliculas.Add(new Pelicula(textBox1.Text, 1, Convert.ToDateTime(textBox3), TimeSpan.Zero, 10, 1, destination,));
            }
            else if (textBox2.Text == "Podcast")
            {
                source = openFileDialog1.FileName;
                destination = Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Biblioteca\Podcast\" + textBox4;
                System.IO.File.Copy(source, destination, true);
                //Spotflix.Lista_Podcasts.Add(new Podcast(textBox1.Text, 1, Convert.ToDateTime(textBox3), TimeSpan.Zero, 10, 1, destination,));
            }
            else if (textBox2.Text == "AudioLibro")
            {
                source = openFileDialog1.FileName;
                destination = Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Biblioteca\Audio Libro\" + textBox4;
                System.IO.File.Copy(source, destination, true);
                //Spotflix.Lista_AudioLibros.Add(new AudioLibro(textBox1.Text, 1, Convert.ToDateTime(textBox3), TimeSpan.Zero, 10, 1, destination,));
            }
            else if (textBox2.Text == "Video")
            {
                source = openFileDialog1.FileName;
                destination = Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Biblioteca\Videos\" + textBox4;
                System.IO.File.Copy(source, destination, true);
                Spotflix.Lista_Videos.Add(new Video(textBox1.Text, 1, Convert.ToDateTime(textBox3), TimeSpan.Zero, 10, 1, destination,0,"",5,textBox9.Text));
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog2.Filter = "Archivo files|*.wav;*.mp3;*.mp4;.*;";
            DialogResult dres1 = openFileDialog2.ShowDialog();
            if (dres1 == DialogResult.Abort)
            {
                return;
            }
            if (dres1 == DialogResult.Cancel)
            {
                return;
            }
            
            textBox4.Text = Path.GetFileName(openFileDialog2.FileName);
        }
    }
}