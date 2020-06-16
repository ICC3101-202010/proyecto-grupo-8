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
using System.DirectoryServices;

namespace Consola_Spotflix
{
    public partial class Archivo : UserControl
    {
        public Archivo()
        {
            InitializeComponent();
            Registro.Crear_Archivo = this;
            panel_Agregar_Archivo.Dock = DockStyle.Fill;
        }
        public string direccion_archivo;
        public string direccion_imagen;
        public string direccion_letra;
        public List<Persona> Cantantes = new List<Persona>();
        public List<Persona> Compositores = new List<Persona>();
        public List<int> profesion = new List<int>();

        private void button_Atras_Agregar_archivo_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button_Atras_Agregar_persona_Click(object sender, EventArgs e)
        {
            panel_Agregar_Persona.Hide();
            panel_Agregar_Archivo.Show();
            panel_Agregar_Archivo.Dock = DockStyle.Fill;
            clear();                
        }

        private void button_Crear_Persona_Click(object sender, EventArgs e)
        {
            panel_Agregar_Archivo.Hide();
            panel_Agregar_Persona.Show();
            panel_Agregar_Persona.Dock = DockStyle.Fill;
        }

        private void buttonAgregar_segundo_compositor_Click(object sender, EventArgs e)
        {
            label_compositor_2.Show();
            Compositor2.Show();
        }

        private void button2_Crear_Persona_Click(object sender, EventArgs e)
        {
            panel_Agregar_Archivo.Hide();
            panel_Agregar_Persona.Show();
            panel_Agregar_Persona.Dock = DockStyle.Fill;
        }

        private void comboBox_Categorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            clear();
            label_Titulo.Show();
            textBox_Titulo.Show();
            label_Año.Show();
            textBox_año.Show();
            label_Direccion_Archivo.Show();
            textBox_Direccion.Show();
            button_Examinar_Direccion.Show();
            button_Agregar_Archivo.Show();
            button_Limpiar.Show();
            if (comboBox_Categorias.SelectedItem.ToString() =="Cancion")
            {
                label_Cantante_1.Text = "Cantante 1:";
                Cantantes1.Show();
                button_Agregar_Segundo_cantante.Show();
                label_Cantante_2.Text = "Cantante 2:";
                button_Crear_Persona.Show();
                label_Compositor_1.Text = "Compositor 1:";
                label_Compositor_1.Show();
                Compositor1.Show();
                buttonAgregar_segundo_compositor.Show();
                label_compositor_2.Text = "Compositor 2:";
                label_album.Text = "Album:";
                label_album.Show();
                label_Imagen.Text = "Imagen:";
                textBox_Imagen.Show();
                button_Examinar_Imagen.Show();
                label_Genero.Text = "Genero:";
                textBox_Genero.Show();
                label_Letra.Text = "Letra:";
                textBox_Letra.Show();
                button_Examinar_Letra.Show();
                foreach (var item in Registro.compositores())
                {
                    Compositor1.Items.Add(item.Nombre_y_Apellido);
                    Compositor2.Items.Add(item.Nombre_y_Apellido);
                }
                foreach(var item in Registro.cantantes())
                {
                    Cantantes1.Items.Add(item.Nombre_y_Apellido);
                    Cantantes2.Items.Add(item.Nombre_y_Apellido);
                }
            }
            else if (comboBox_Categorias.SelectedItem.ToString() == "Pelicula")
            {
                label_Cantante_1.Text = "Actor 1:";
                Cantantes1.Show();
                button_Agregar_Segundo_cantante.Show();
                label_Cantante_2.Text = "Actor 2:";
                button_Crear_Persona.Show();
                label_Compositor_1.Text = "Director 1:";
                label_Compositor_1.Show();
                Compositor1.Show();
                buttonAgregar_segundo_compositor.Show();
                label_compositor_2.Text = "Director 2:";
                label_album.Text = "Estudio:";
                label_album.Show();
                label_Imagen.Text = "Calificacion:";
                comboBox_Calificacion.Show();
                label_Genero.Text = "Genero:";
                textBox_Genero.Show();
                foreach (var item in Registro.compositores())
                {
                    Compositor1.Items.Add(item.Nombre_y_Apellido);
                    Compositor2.Items.Add(item.Nombre_y_Apellido);
                }
                foreach (var item in Registro.cantantes())
                {
                    Cantantes1.Items.Add(item.Nombre_y_Apellido);
                    Cantantes2.Items.Add(item.Nombre_y_Apellido);
                }
            }
            else if (comboBox_Categorias.SelectedItem.ToString() == "Podcast")
            {
                label_Cantante_1.Text = "Locutor 1:";
                Cantantes1.Show();
                button_Agregar_Segundo_cantante.Show();
                label_Cantante_2.Text = "Locutor 2:";
                button_Crear_Persona.Show();
                label_Imagen.Text = "Imagen:";
                textBox_Imagen.Show();
                button_Examinar_Imagen.Show();
                label_Genero.Text = "Genero:";
                textBox_Genero.Show();
                foreach (var item in Registro.compositores())
                {
                    Compositor1.Items.Add(item.Nombre_y_Apellido);
                    Compositor2.Items.Add(item.Nombre_y_Apellido);
                }
                foreach (var item in Registro.cantantes())
                {
                    Cantantes1.Items.Add(item.Nombre_y_Apellido);
                    Cantantes2.Items.Add(item.Nombre_y_Apellido);
                }
            }
            else if (comboBox_Categorias.SelectedItem.ToString() == "Audio Libro")
            {
                label_Cantante_1.Text = "Lector 1:";
                Cantantes1.Show();
                button_Crear_Persona.Show();
                label_album.Text = "Idioma:";
                comboBoxIdioma.Show();
                label_Imagen.Text = "Imagen:";
                textBox_Imagen.Show();
                button_Examinar_Imagen.Show();
                label_Genero.Text = "Genero:";
                textBox_Genero.Show();
                label_Letra.Text = "Direccion Texto:";
                textBox_Letra.Show();
                button_Examinar_Letra.Show();
                foreach (var item in Registro.compositores())
                {
                    Compositor1.Items.Add(item.Nombre_y_Apellido);
                    Compositor2.Items.Add(item.Nombre_y_Apellido);
                }
                foreach (var item in Registro.cantantes())
                {
                    Cantantes1.Items.Add(item.Nombre_y_Apellido);
                    Cantantes2.Items.Add(item.Nombre_y_Apellido);
                }
            }
            else if (comboBox_Categorias.SelectedItem.ToString() == "Videos")
            {                
                label_Imagen.Text = "Calificacion:";
                comboBox_Calificacion.Show();
                label_Genero.Text = "Genero:";
                textBox_Genero.Show();
            }
        }
        public void clear()
        {
            label_Titulo.Hide();
            textBox_Titulo.Clear();
            textBox_Titulo.Hide();
            label_Año.Hide();
            textBox_año.Clear();
            textBox_año.Hide();
            label_Direccion_Archivo.Hide();
            textBox_Direccion.Clear();
            textBox_Direccion.Hide();
            button_Examinar_Direccion.Hide();
            label_Cantante_1.Hide();
            Cantantes1.Hide();
            button_Agregar_Segundo_cantante.Hide();
            label_Cantante_2.Hide();
            Cantantes2.Hide();
            button_Crear_Persona.Hide();
            label_Compositor_1.Hide();
            Compositor1.Hide();
            buttonAgregar_segundo_compositor.Hide();
            label_compositor_2.Hide();
            Compositor2.Hide();
            button2_Crear_Persona.Hide();
            label_album.Hide();
            textBox_Album.Clear();
            textBox_Album.Hide();
            comboBox_Calificacion.Hide();
            label_Imagen.Hide();
            textBox_Imagen.Clear();
            textBox_Imagen.Hide();
            comboBoxIdioma.Hide();
            button_Examinar_Imagen.Hide();
            label_Genero.Hide();
            textBox_Genero.Clear();
            textBox_Genero.Hide();
            label_Letra.Hide();
            textBox_Letra.Clear();
            textBox_Letra.Hide();
            button_Examinar_Letra.Hide();

        }
        private void button_Limpiar_Agregar_Archivo_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button_Agregar_Archivo_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_Categorias.SelectedItem.ToString() == "Canciones")
                {
                    listas(1, 2);
                    Spotflix.Lista_Canciones.Add(new Cancion(textBox_Titulo.Text, 1, Convert.ToDateTime(textBox_año.Text), TimeSpan.Zero, 10, 0, direccion_archivo, Cantantes, Compositores, textBox_Album.Text, direccion_imagen, direccion_letra, textBox_Genero.Text));
                    label_Archivo_Creado.Show();
                    clear();
                }
                else if (comboBox_Categorias.SelectedItem.ToString() == "Pelicula")
                {
                    listas(3, 4);
                    Spotflix.Lista_Peliculas.Add(new Pelicula(textBox_Titulo.Text, 2, Convert.ToDateTime(textBox_año.Text), TimeSpan.Zero, 10, 0, direccion_archivo, Cantantes, Compositores, textBox_Album.Text, 2, "", comboBox_Calificacion.SelectedIndex, textBox_Genero.Text));
                    label_Archivo_Creado.Show();
                    clear();
                }
                else if (comboBox_Categorias.SelectedItem.ToString() == "Podcast")
                {
                    listas(5, 0);
                    Spotflix.Lista_Podcasts.Add(new Podcast(textBox_Titulo.Text, 3, Convert.ToDateTime(textBox_año.Text), TimeSpan.Zero, 10, 0, direccion_archivo, Cantantes, direccion_imagen, textBox_Genero.Text));
                    label_Archivo_Creado.Show();
                    clear();
                }
                else if (comboBox_Categorias.SelectedItem.ToString() == "Audio Libro")
                {
                    listas(6, 0);
                    Spotflix.Lista_AudioLibros.Add(new AudioLibro(textBox_Titulo.Text, 3, Convert.ToDateTime(textBox_año.Text), TimeSpan.Zero, 10, 0, direccion_archivo, direccion_letra, textBox_Genero.Text, comboBoxIdioma.SelectedIndex, Cantantes[0]));
                    label_Archivo_Creado.Show();
                    clear();

                }
                else if (comboBox_Categorias.SelectedItem.ToString() == "Videos")
                {
                    Spotflix.Lista_Videos.Add(new Video(textBox_Titulo.Text, 3, Convert.ToDateTime(textBox_año.Text), TimeSpan.Zero, 10, 0, direccion_archivo, 2, "", comboBox_Calificacion.SelectedIndex, textBox_Genero.Text));
                    label_Archivo_Creado.Show();
                    clear();
                }
            }
            catch 
            {
                label_Faltan_Datos.Show();
            }
        }
        public void listas(int cantante,int compositores)
        {
            foreach (var item in Spotflix.Lista_Personas)
            {
                for (int i = 0; i < item.Profesion.Count; i++)
                {
                    if (item.Profesion[i] == cantante)
                    {
                        if (item.Nombre_y_Apellido == Cantantes1.SelectedItem.ToString())
                        {
                            Cantantes.Add(item);
                        }
                        if (item.Nombre_y_Apellido == Cantantes2.SelectedItem.ToString())
                        {
                            Cantantes.Add(item);
                        }
                    }
                }
                
            }
            foreach (var item in Spotflix.Lista_Personas)
            {
                for (int i = 0; i < item.Profesion.Count; i++)
                {
                    if (item.Profesion[i] == compositores)
                    {
                        if (item.Nombre_y_Apellido == Compositor1.SelectedItem.ToString())
                        {
                            
                            Compositores.Add(item);
                        }
                        if (item.Nombre_y_Apellido == Compositor2.SelectedItem.ToString())
                        {
                            Compositores.Add(item);
                        }
                    }
                }

            }
        }

        private void button_Agregar_Segundo_cantante_Click(object sender, EventArgs e)
        {
            label_Cantante_2.Show();
            Cantantes2.Show();
        }

        private void button_Examinar_Direccion_Click(object sender, EventArgs e)
        {
            string sourceFile;
            string destFile="";
            openFileDialog1.Filter = "Archivo files|*.wav;*.mp3;*.mp4;.*;";
            DialogResult dres1 = openFileDialog1.ShowDialog();
            if (dres1 == DialogResult.Abort)
            {
                return;
            }
            if (dres1 == DialogResult.Cancel)
            {
                return;
            }
            sourceFile = openFileDialog1.FileName;
            if (comboBox_Categorias.SelectedItem.ToString() == "Cancion")
            {
                destFile = Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Biblioteca\Musica\" + Path.GetFileName(openFileDialog1.FileName); ;
                File.Copy(sourceFile, destFile, true);
            }
            else if (comboBox_Categorias.SelectedItem.ToString() == "Pelicula")
            {
                destFile = Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Biblioteca\Peliculas\" + Path.GetFileName(openFileDialog1.FileName); ;
                File.Copy(sourceFile, destFile, true);
            }
            else if (comboBox_Categorias.SelectedItem.ToString() == "Podcast")
            {
                destFile = Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Biblioteca\Podcast\" + Path.GetFileName(openFileDialog1.FileName); ;
                File.Copy(sourceFile, destFile, true);
            }
            else if (comboBox_Categorias.SelectedItem.ToString() == "Audio Libro")
            {
                destFile = Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Biblioteca\Audio Libros\" + Path.GetFileName(openFileDialog1.FileName); ;
                File.Copy(sourceFile, destFile, true);
            }
            else if (comboBox_Categorias.SelectedItem.ToString() == "Videos")
            {
                destFile = Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Biblioteca\Videos\" + Path.GetFileName(openFileDialog1.FileName); ;
                File.Copy(sourceFile, destFile, true);
            }
            direccion_archivo = destFile;
            textBox_Direccion.Text = Path.GetFileName(openFileDialog1.FileName);
        }

        private void button_Examinar_Imagen_Click(object sender, EventArgs e)
        {
            string sourceFile;
            string destFile = "";
            openFileDialog1.Filter = "Archivo files|*.png;*.jpg;.*;";
            DialogResult dres1 = openFileDialog1.ShowDialog();
            if (dres1 == DialogResult.Abort)
            {
                return;
            }
            if (dres1 == DialogResult.Cancel)
            {
                return;
            }
            sourceFile = openFileDialog1.FileName;
            if (comboBox_Categorias.SelectedItem.ToString() == "Cancion")
            {
                destFile = Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Biblioteca\Musica\" + Path.GetFileName(openFileDialog1.FileName); ;
                File.Copy(sourceFile, destFile, true);
            }
            else if (comboBox_Categorias.SelectedItem.ToString() == "Pelicula")
            {
                destFile = Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Biblioteca\Peliculas\" + Path.GetFileName(openFileDialog1.FileName); ;
                File.Copy(sourceFile, destFile, true);
            }
            else if (comboBox_Categorias.SelectedItem.ToString() == "Podcast")
            {
                destFile = Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Biblioteca\Podcast\" + Path.GetFileName(openFileDialog1.FileName); ;
                File.Copy(sourceFile, destFile, true);
            }
            else if (comboBox_Categorias.SelectedItem.ToString() == "Audio Libro")
            {
                destFile = Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Biblioteca\Audio Libros\" + Path.GetFileName(openFileDialog1.FileName); ;
                File.Copy(sourceFile, destFile, true);
            }
            else if (comboBox_Categorias.SelectedItem.ToString() == "Videos")
            {
                destFile = Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Biblioteca\Videos\" + Path.GetFileName(openFileDialog1.FileName); ;
                File.Copy(sourceFile, destFile, true);
            }
            direccion_imagen = destFile;
            textBox_Imagen.Text = Path.GetFileName(openFileDialog1.FileName);
        }

        private void button_Examinar_Letra_Click(object sender, EventArgs e)
        {
            string sourceFile;
            string destFile = "";
            openFileDialog1.Filter = "Archivo files|*.txt;.*;";
            DialogResult dres1 = openFileDialog1.ShowDialog();
            if (dres1 == DialogResult.Abort)
            {
                return;
            }
            if (dres1 == DialogResult.Cancel)
            {
                return;
            }
            sourceFile = openFileDialog1.FileName;
            if (comboBox_Categorias.SelectedItem.ToString() == "Cancion")
            {
                destFile = Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Biblioteca\Musica\" + Path.GetFileName(openFileDialog1.FileName); ;
                File.Copy(sourceFile, destFile, true);
            }
            else if (comboBox_Categorias.SelectedItem.ToString() == "Pelicula")
            {
                destFile = Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Biblioteca\Peliculas\" + Path.GetFileName(openFileDialog1.FileName); ;
                File.Copy(sourceFile, destFile, true);
            }
            else if (comboBox_Categorias.SelectedItem.ToString() == "Podcast")
            {
                destFile = Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Biblioteca\Podcast\" + Path.GetFileName(openFileDialog1.FileName); ;
                File.Copy(sourceFile, destFile, true);
            }
            else if (comboBox_Categorias.SelectedItem.ToString() == "Audio Libro")
            {
                destFile = Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Biblioteca\Audio Libros\" + Path.GetFileName(openFileDialog1.FileName); ;
                File.Copy(sourceFile, destFile, true);
            }
            else if (comboBox_Categorias.SelectedItem.ToString() == "Videos")
            {
                destFile = Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Biblioteca\Videos\" + Path.GetFileName(openFileDialog1.FileName); ;
                File.Copy(sourceFile, destFile, true);
            }
            direccion_letra = destFile;
            textBox_Letra.Text = Path.GetFileName(openFileDialog1.FileName);
        }

        private void button_Agregar_Persona_Click(object sender, EventArgs e)
        {
            lista1();
            Spotflix.Lista_Personas.Add(new Persona(textBox_Nombre_persona.Text, comboBox_Sexo.SelectedIndex, textBox_Nacionalidad.Text, Convert.ToDateTime(textBox_Fecha_De_Nacimiento.Text), profesion));
        }
        public void lista1()
        {
            profesion.Add(comboBox_Profesion_1.SelectedIndex);
            try
            {
                profesion.Add(comboBox_Profesion_2.SelectedIndex);
            }
            catch 
            {

            }

        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {

        }

        private void button_Mostrar_Segunda_Profesion_Click(object sender, EventArgs e)
        {
            label_Profesion_2.Show();
            comboBox_Profesion_2.Show();
        }
    }
}
