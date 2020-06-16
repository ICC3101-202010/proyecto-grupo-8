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
using static Proyecto_POO.Persona;

namespace Consola_Spotflix
{
    public partial class Buscador : UserControl
    {
        public string tipo = "";
        public Buscador()
        {
            InitializeComponent();
            Registro.busc1 = this;
        }
        //PLAYLIST 
        //ORDEN DE ESTA WEA
        //VER
        public void CargarBuscador()
        {
            Show();
            if (tipo == "Perfiles")
            {
                Buscar.Hide();
                comboBox1.Items.Add("Seguir");
                comboBox1.Items.Add("Dejar de seguir");
                label1.Text = "Accion";
                label2.Text = "Perfil:";
                foreach (var item in Spotflix.Lista_Perfiles)
                {
                    comboBox2.Items.Add(item.Nombre_perfil);
                }
                label4.Hide();
                label5.Hide();
                comboBox3.Hide();
                textBox1.Hide();
                label3.Hide();
                comboBox4.Hide();
                label6.Hide();
            }
            //ok
            else if (tipo == "Artistas")
            {
                Buscar.Show();
                label1.Text = "Accion";
                comboBox1.Items.Add("Seguir");
                comboBox1.Items.Add("Dejar de seguir");

                label2.Text = "Categoria";
                comboBox2.Items.Add("Nacionalidad");
                comboBox2.Items.Add("Sexo");
                comboBox2.Items.Add("Profesion");
                comboBox2.Items.Add("Edad");

                label4.Text = "Valor:";
                //
                label5.Text = "Artista:";
                label4.Show();
                label1.Show();
                label2.Show();
                label5.Show();
                comboBox3.Show();
                textBox1.Show();
                label3.Hide();
                comboBox4.Hide();
                label6.Hide();
            }
            //ok
            else if (tipo == "Canciones")
            {
                Buscar.Show();

                label1.Show();
                label2.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                comboBox1.Show();
                comboBox2.Show();
                comboBox3.Show();
                comboBox4.Show();
                label6.Text = "Playlist";

                label1.Text = "Accion";
                comboBox1.Items.Add("Agregar");
                comboBox1.Items.Add("Eliminar");

                comboBox2.Items.Add("Titulo");
                comboBox2.Items.Add("Cantante");
                comboBox2.Items.Add("Album");
                comboBox2.Items.Add("Genero");
                label2.Text = "Tipo de Categoria";

                label6.Text = "En que lista?";
                comboBox4.Items.Add("Canciones favoritas");
                comboBox4.Items.Add("En Cola");
                foreach (var item in Spotflix.perfilenlinea.Playlists_Canciones_Propias)
                {
                    comboBox4.Items.Add(item.Nombre);
                }
                label5.Text = "Cancion: ";
                label4.Text = "Valor";

            }
            //ok
            else if (tipo == "Videos")
            {
                label1.Show();
                label2.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                comboBox1.Show();
                comboBox2.Show();
                comboBox3.Show();
                comboBox4.Show();
                label6.Text = "Playlist";
                label1.Text = "Accion";
                comboBox1.Items.Add("Agregar");
                comboBox1.Items.Add("Eliminar");

                comboBox2.Items.Add("Titulo");
                comboBox2.Items.Add("Cantante");
                comboBox2.Items.Add("Album");
                comboBox2.Items.Add("Genero");
                label2.Text = "Tipo de Categoria";

                label6.Text = "En que lista?";
                comboBox4.Items.Add("Videos favoritos");
                comboBox4.Items.Add("En Cola");
                foreach (var item in Spotflix.perfilenlinea.Playlists_Video_Propios)
                {
                    comboBox4.Items.Add(item.Nombre);
                }
                label5.Text = "Video: ";

                label4.Text = "Valor";
                Buscar.Show();

                
            }
            //ok
            else if (tipo == "Peliculas")
            {
                Buscar.Show();
                label1.Show();
                label2.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                comboBox1.Show();
                comboBox2.Show();
                comboBox3.Show();
                comboBox4.Show();
                label6.Text = "Playlist";
                label1.Text = "Accion";
                comboBox1.Items.Add("Agregar");
                comboBox1.Items.Add("Eliminar");

                comboBox2.Items.Add("Titulo");
                comboBox2.Items.Add("Cantante");
                comboBox2.Items.Add("Album");
                comboBox2.Items.Add("Genero");
                label2.Text = "Tipo de Categoria";

                label6.Text = "En que lista?";
                comboBox4.Items.Add("Peliculas favoritas");
                comboBox4.Items.Add("En Cola");
                foreach (var item in Spotflix.perfilenlinea.Playlists_Peliculas_Propias)
                {
                    comboBox4.Items.Add(item.Nombre);
                }
                label5.Text = "Pelicula: ";

                label4.Text = "Valor";

            }
            //ok
            else if (tipo == "Podcasts")
            {
                label1.Show();
                label2.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                comboBox1.Show();
                comboBox2.Show();
                comboBox3.Show();
                comboBox4.Show();
                label6.Text = "Playlist";
                Buscar.Show();
                label1.Text = "Accion";
                comboBox1.Items.Add("Agregar");
                comboBox1.Items.Add("Eliminar");

                comboBox2.Items.Add("Titulo");
                comboBox2.Items.Add("Cantante");
                comboBox2.Items.Add("Album");
                comboBox2.Items.Add("Genero");
                label2.Text = "Tipo de Categoria";

                label6.Text = "En que lista?";
                comboBox4.Items.Add("Podcasts favoritos");
                comboBox4.Items.Add("En Cola");
                foreach (var item in Spotflix.perfilenlinea.Playlists_Podcast_Propios)
                {
                    comboBox4.Items.Add(item.Nombre);
                }

                label5.Text = "Podcast: ";

                label4.Text = "Valor";
                
            }
            //ok
            else if (tipo == "Audiolibros")
            {
                Buscar.Show();
                label1.Show();
                label2.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                comboBox1.Show();
                comboBox2.Show();
                comboBox3.Show();
                comboBox4.Show();
                label6.Text = "Playlist";
                label1.Text = "Accion";
                comboBox1.Items.Add("Agregar");
                comboBox1.Items.Add("Eliminar");

                comboBox2.Items.Add("Titulo");
                comboBox2.Items.Add("Lector");
                comboBox2.Items.Add("Album");
                comboBox2.Items.Add("Genero");
                label2.Text = "Tipo de Categoria";

                label6.Text = "En que lista?";
                comboBox4.Items.Add("Audiolibros favoritos");
                comboBox4.Items.Add("En Cola");

                foreach (var item in Spotflix.perfilenlinea.Playlists_Audiolibro_Propios)
                {
                    comboBox4.Items.Add(item.Nombre);
                }

                label5.Text = "AudioLibro: ";

                label4.Text = "Valor";

                
            }
            //agregar mullt a playlist
            else if (tipo == "Playlist")
            {
                Buscar.Show();
                label1.Show();
                label1.Text = "Accion";
                comboBox1.Items.Add("Seguir");
                comboBox1.Items.Add("Dejar de Seguir");
                comboBox2.Items.Add("AudioLibros");
                comboBox2.Items.Add("Canciones");
                comboBox2.Items.Add("Peliculas");
                comboBox2.Items.Add("Podcasts"); 
                comboBox2.Items.Add("Videos");


                label2.Text = "Tipo de Playlists:";
                label2.Show();
                comboBox3.Items.Add("");
                label4.Text = "Valor:";
                label5.Text = "Playlist";
                label4.Show();
                label5.Show();
                comboBox3.Show();
                textBox1.Show();
                comboBox4.Hide();
                label6.Hide();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (tipo == "Perfiles")
            {
                if ((string)comboBox1.SelectedItem == "Seguir")
                {
                    Perfil p2 = new Perfil();
                    string nombreperfilseleccionado = (string)comboBox2.SelectedItem;//
                    foreach (var item in Spotflix.Lista_Perfiles)
                    {
                        if (item.Nombre_perfil == nombreperfilseleccionado)
                        {
                            p2 = item;
                        }
                    }
                    foreach (Perfil p in Spotflix.Lista_Perfiles)
                    {
                        int o = 0;
                        if (p == Spotflix.perfilenlinea)
                        {
                            foreach (var item1 in p.Seguidos)
                            {
                                if (p2 != item1)
                                {
                                    p.Seguidos.Add(p2);
                                    o += 1;
                                    break;
                                }

                            }
                            if (o == 0)
                            {
                                label3.Show();
                                label3.Text = "Ya sigues a este perfil";
                            }
                        }
                    }
                }
                else if ((string)comboBox1.SelectedItem == "Dejar de seguir")
                {
                    Perfil p2 = new Perfil();
                    string nombreperfilseleccionado = (string)comboBox2.SelectedItem;//
                    foreach (var item in Spotflix.Lista_Perfiles)
                    {
                        if (item.Nombre_perfil == nombreperfilseleccionado)
                        {
                            p2 = item;
                        }
                    }
                    int o = 0;
                    foreach (Perfil p in Spotflix.Lista_Perfiles)
                    {
                        if (p == Spotflix.perfilenlinea)
                        {
                            foreach (var item1 in p.Seguidos)
                            {
                                if (p2 == item1)
                                {
                                    p.Seguidos.Remove(p2);
                                    o += 1;
                                    label3.Show();
                                    label3.Text = "Lo dejaste de seguir";
                                    break;
                                }

                            }
                            if (o == 0)
                            {
                                label3.Show();
                                label3.Text = "No sigues a este perfil";
                            }

                        }
                    }
                }
            }
            else if (tipo == "Artistas")
            {
                bool encontrado = false;

                if ((string)comboBox1.SelectedItem == "Seguir")
                {
                    Persona p = new Persona();

                    foreach (var item in Spotflix.Lista_Personas)
                    {
                        if (item.Nombre_y_Apellido == (string)comboBox3.SelectedItem)
                        {
                            p = item;
                            break;
                        }

                    }

                    foreach (var item in Spotflix.perfilenlinea.Personas_Seguidas)
                    {
                        if (item == p)
                        {
                            encontrado = true;
                        }
                    }

                    if (encontrado == false)
                    {
                        label3.Show();
                        label3.Text = "Artista seguido";
                        Spotflix.perfilenlinea.Personas_Seguidas.Add(p);
                    }
                    else
                    {
                        label3.Show();
                        label3.Text = "Ya sigues a este artista";
                    }


                }
                else if ((string)comboBox1.SelectedItem == "Dejar de seguir")
                {
                    Persona p = new Persona();

                    foreach (var item in Spotflix.Lista_Personas)
                    {
                        if (item.Nombre_y_Apellido == (string)comboBox3.SelectedItem)
                        {
                            p = item;
                            break;
                        }

                    }

                    foreach (var item in Spotflix.perfilenlinea.Personas_Seguidas)
                    {
                        if (item == p)
                        {
                            encontrado = true;
                        }
                    }

                    if (encontrado == true)
                    {
                        label3.Show();
                        label3.Text = "Dejaste de seguir al artista";
                        Spotflix.perfilenlinea.Personas_Seguidas.Remove(p);
                    }
                    else
                    {
                        label3.Show();
                        label3.Text = "No sigues a este artista";
                    }
                }

            }
            else if (tipo == "AudioLibros")
            {
                bool encontrado = false;
                bool encontrado2 = false;
                if ((string)comboBox1.SelectedItem == "Agregar")
                {
                    AudioLibro c1 = new AudioLibro();

                    foreach (var item in Spotflix.Lista_AudioLibros)
                    {
                        if (item.Titulo == (string)comboBox3.SelectedItem)
                        {
                            c1 = item;
                            break;
                        }
                    }
                    if ((string)comboBox4.SelectedItem == "Audiolibros Favoritos")
                    {
                        foreach (var item2 in Spotflix.perfilenlinea.Fav_AudioLibro)
                        {
                            if (item2 == c1)
                            {
                                encontrado = true;
                            }
                        }
                        if (encontrado == true)
                        {
                            label3.Show();
                            label3.Text = "AudioLibro ya existe en la lista!";
                        }
                        else
                        {
                            label3.Show();
                            label3.Text = "AudioLibro Agregada a la lista!";
                            Spotflix.perfilenlinea.Fav_AudioLibro.Add(c1);
                        }
                    }
                    else if ((string)comboBox4.SelectedItem == "En Cola")
                    {
                        foreach (var item2 in Spotflix.perfilenlinea.En_Cola_audiolibro)
                        {
                            if (item2 == c1)
                            {
                                encontrado = true;
                            }
                        }
                        if (encontrado == true)
                        {
                            label3.Show();
                            label3.Text = "Audiolibro ya existe en la lista!";
                        }
                        else
                        {
                            label3.Show();
                            label3.Text = "AudioLibro Agregada a la lista!";
                            Spotflix.perfilenlinea.En_Cola_audiolibro.Add(c1);
                        }
                    }
                    else
                    {
                        foreach (var item3 in Spotflix.perfilenlinea.Playlists_Audiolibro_Propios)
                        {

                            if (item3.Nombre == (string)comboBox4.SelectedItem)
                            {
                                encontrado2 = true; ;
                            }
                            if (encontrado2 == true)
                            {
                                foreach (var item2 in Spotflix.perfilenlinea.En_Cola_audiolibro)
                                {
                                    if (item2 == c1)
                                    {
                                        encontrado = true;
                                    }
                                }
                            }
                            if (encontrado2 == true && encontrado==true)
                            {
                                label3.Show();
                                label3.Text = "Audiolibro ya existe en la lista!";
                                break;
                            }
                            else if (encontrado2 == true && encontrado == false)
                            {
                                label3.Show();
                                label3.Text = "AudioLibro Agregada a la lista!";
                                item3.Playlist_paralista_AL.Add(c1);
                                break;
                            }
                        }
                        

                    }

                    }
                if ((string)comboBox1.SelectedItem == "Eliminar")
                {
                    AudioLibro c1 = new AudioLibro();
                    foreach (var item in Spotflix.Lista_AudioLibros)
                    {
                        if (item.Titulo == (string)comboBox3.SelectedItem)
                        {
                            c1 = item;
                            break;
                        }
                    }
                    if ((string)comboBox4.SelectedItem == "AudioLibros Favoritas")
                    {
                        foreach (var item2 in Spotflix.perfilenlinea.Fav_AudioLibro)
                        {
                            if (item2 == c1)
                            {
                                encontrado = true;
                            }
                        }
                        if (encontrado == true)
                        {
                            label3.Show();
                            label3.Text = "AudioLibro eliminado de la lista!";
                            Spotflix.perfilenlinea.Fav_AudioLibro.Remove(c1);
                        }
                        else
                        {
                            label3.Show();
                            label3.Text = "AudioLibro no esta en la lista";
                        }
                    }
                    else
                    {
                        foreach (var item2 in Spotflix.perfilenlinea.En_Cola_audiolibro)
                        {
                            if (item2 == c1)
                            {
                                encontrado = true;
                            }
                        }
                        if (encontrado == true)
                        {
                            label3.Text = "AudioLibro eliminada de la lista!";
                            Spotflix.perfilenlinea.En_Cola_audiolibro.Remove(c1);
                        }
                        else
                        {
                            label3.Text = "AudioLibro no esta en la lista";
                        }
                    }

                }
            }
            else if (tipo == "Canciones")
            {
                bool encontrado = false;
                bool encontrado2 = false;

                if ((string)comboBox1.SelectedItem == "Agregar")
                {
                    Cancion c1 = new Cancion();
                    foreach (var item in Spotflix.Lista_Canciones)
                    {
                        if (item.Titulo == (string)comboBox3.SelectedItem)
                        {
                            c1 = item;
                            break;
                        }
                    }
                    if ((string)comboBox4.SelectedItem == "Canciones Favoritas")
                    {
                        foreach (var item2 in Spotflix.perfilenlinea.Fav_Canciones)
                        {
                            if (item2 == c1)
                            {
                                encontrado = true;
                            }
                        }
                        if (encontrado == true)
                        {
                            label3.Text = "Cancion ya existe en la lista!";
                        }
                        else
                        {
                            label3.Text = "Cancion Agregada a la lista!";
                            Spotflix.perfilenlinea.Fav_Canciones.Add(c1);
                        }
                    }
                    else if ((string)comboBox4.SelectedItem == "En Cola")
                    {
                        foreach (var item2 in Spotflix.perfilenlinea.En_Cola_cancion)
                        {
                            if (item2 == c1)
                            {
                                encontrado = true;
                            }
                        }
                        if (encontrado == true)
                        {
                            label3.Show();
                            label3.Text = "Cancion ya existe en la lista!";
                        }
                        else
                        {
                            label3.Show();
                            label3.Text = "Cancion Agregada a la lista!";
                            Spotflix.perfilenlinea.En_Cola_cancion.Add(c1);
                        }
                    }
                    else
                    {
                        foreach (var item3 in Spotflix.perfilenlinea.Playlists_Canciones_Propias)
                        {

                            if (item3.Nombre == (string)comboBox4.SelectedItem)
                            {
                                encontrado2 = true; ;
                            }
                            if (encontrado2 == true)
                            {
                                foreach (var item2 in Spotflix.perfilenlinea.En_Cola_cancion)
                                {
                                    if (item2 == c1)
                                    {
                                        encontrado = true;
                                    }
                                }
                            }
                            if (encontrado2 == true && encontrado == true)
                            {
                                label3.Show();
                                label3.Text = "Cancion ya existe en la lista!";
                                MessageBox.Show("");
                                break;
                            }
                            else if (encontrado2 == true && encontrado == false)
                            {
                                label3.Show();
                                MessageBox.Show("HOla");
                                label3.Text = "Cancion Agregada a la lista!";
                                item3.Playlist_paralista_Ca.Add(c1);
                                break;
                            }
                        }


                    }
                }
                if ((string)comboBox1.SelectedItem == "Eliminar")
                {
                    Cancion c1 = new Cancion();
                    foreach (var item in Spotflix.Lista_Canciones)
                    {
                        if (item.Titulo == (string)comboBox3.SelectedItem)
                        {
                            c1 = item;
                            break;
                        }
                    }
                    if ((string)comboBox4.SelectedItem == "Canciones Favoritas")
                    {
                        foreach (var item2 in Spotflix.perfilenlinea.Fav_Canciones)
                        {
                            if (item2 == c1)
                            {
                                encontrado = true;
                            }
                        }
                        if (encontrado == true)
                        {
                            label3.Show();
                            label3.Text = "Cancion eliminadad de la lista!";
                            Spotflix.perfilenlinea.Fav_Canciones.Remove(c1);
                        }
                        else
                        {
                            label3.Show();
                            label3.Text = "Cancion no esta en la lista";
                        }
                    }
                    else
                    {
                        foreach (var item2 in Spotflix.perfilenlinea.En_Cola_cancion)
                        {
                            if (item2 == c1)
                            {
                                encontrado = true;
                            }
                        }
                        if (encontrado == true)
                        {
                            label3.Show();
                            label3.Text = "Cancion eliminadad de la lista!";
                            Spotflix.perfilenlinea.En_Cola_cancion.Remove(c1);
                        }
                        else
                        {
                            label3.Show();
                            label3.Text = "Cancion no esta en la lista";
                        }
                    }

                }
            }
            else if (tipo == "Peliculas")
            {
                bool encontrado = false;

                if ((string)comboBox1.SelectedItem == "Agregar")
                {
                    Pelicula c1 = new Pelicula();
                    foreach (var item in Spotflix.Lista_Peliculas)
                    {
                        if (item.Titulo == (string)comboBox3.SelectedItem)
                        {
                            c1 = item;
                            break;
                        }
                    }
                    if ((string)comboBox4.SelectedItem == "Canciones Favoritas")
                    {
                        foreach (var item2 in Spotflix.perfilenlinea.Fav_Pelicula)
                        {
                            if (item2 == c1)
                            {
                                encontrado = true;
                            }
                        }
                        if (encontrado == true)
                        {
                            label3.Show();
                            label3.Text = "Pelicula ya existe en la lista!";
                        }
                        else
                        {
                            label3.Show();
                            label3.Text = "Pelicula Agregada a la lista!";
                            Spotflix.perfilenlinea.Fav_Pelicula.Add(c1);
                        }
                    }
                    else
                    {
                        foreach (var item2 in Spotflix.perfilenlinea.En_Cola_pelicula)
                        {
                            if (item2 == c1)
                            {
                                encontrado = true;
                            }
                        }
                        if (encontrado == true)
                        {
                            label3.Show();
                            label3.Text = "Pelicula ya existe en la lista!";
                        }
                        else
                        {
                            label3.Show();
                            label3.Text = "Pelicula Agregada a la lista!";
                            Spotflix.perfilenlinea.En_Cola_pelicula.Add(c1);
                        }
                    }
                }
                if ((string)comboBox1.SelectedItem == "Eliminar")
                {
                    Pelicula c1 = new Pelicula();
                    foreach (var item in Spotflix.Lista_Peliculas)
                    {
                        if (item.Titulo == (string)comboBox3.SelectedItem)
                        {
                            c1 = item;
                            break;
                        }
                    }
                    if ((string)comboBox4.SelectedItem == "Peliculas Favoritas")
                    {
                        foreach (var item2 in Spotflix.perfilenlinea.Fav_Pelicula)
                        {
                            if (item2 == c1)
                            {
                                encontrado = true;
                            }
                        }
                        if (encontrado == true)
                        {
                            label3.Show();
                            label3.Text = "Pelicula eliminada de la lista!";
                            Spotflix.perfilenlinea.Fav_Pelicula.Remove(c1);
                        }
                        else
                        {
                            label3.Show();
                            label3.Text = "Pelicula no esta en la lista";
                        }
                    }
                    else
                    {
                        foreach (var item2 in Spotflix.perfilenlinea.En_Cola_pelicula)
                        {
                            if (item2 == c1)
                            {
                                encontrado = true;
                            }
                        }
                        if (encontrado == true)
                        {
                            label3.Show();
                            label3.Text = "Pelicula eliminadad de la lista!";
                            Spotflix.perfilenlinea.En_Cola_pelicula.Remove(c1);
                        }
                        else
                        {
                            label3.Show();
                            label3.Text = "Pelicula no esta en la lista";
                        }
                    }

                }
            }
            else if (tipo == "Podcasts")
            {
                bool encontrado = false;

                if ((string)comboBox1.SelectedItem == "Agregar")
                {
                    Podcast c1 = new Podcast();
                    foreach (var item in Spotflix.Lista_Podcasts)
                    {
                        if (item.Titulo == (string)comboBox3.SelectedItem)
                        {
                            c1 = item;
                            break;
                        }
                    }
                    if ((string)comboBox4.SelectedItem == "Podcasts Favoritas")
                    {
                        foreach (var item2 in Spotflix.perfilenlinea.Fav_Podcast)
                        {
                            if (item2 == c1)
                            {
                                encontrado = true;
                            }
                        }
                        if (encontrado == true)
                        {
                            label3.Show();
                            label3.Text = "Podcast ya existe en la lista!";
                        }
                        else
                        {
                            label3.Show();
                            label3.Text = "Podcast Agregada a la lista!";
                            Spotflix.perfilenlinea.Fav_Podcast.Add(c1);
                        }
                    }
                    else
                    {
                        foreach (var item2 in Spotflix.perfilenlinea.En_Cola_podcast)
                        {
                            if (item2 == c1)
                            {
                                encontrado = true;
                            }
                        }
                        if (encontrado == true)
                        {
                            label3.Show();
                            label3.Text = "Podcast ya existe en la lista!";
                        }
                        else
                        {
                            label3.Show();
                            label3.Text = "Podcast Agregada a la lista!";
                            Spotflix.perfilenlinea.En_Cola_podcast.Add(c1);
                        }
                    }
                }
                if ((string)comboBox1.SelectedItem == "Eliminar")
                {
                    Podcast c1 = new Podcast();
                    foreach (var item in Spotflix.Lista_Podcasts)
                    {
                        if (item.Titulo == (string)comboBox3.SelectedItem)
                        {
                            c1 = item;
                            break;
                        }
                    }
                    if ((string)comboBox4.SelectedItem == "Podcasts Favoritas")
                    {
                        foreach (var item2 in Spotflix.perfilenlinea.Fav_Podcast)
                        {
                            if (item2 == c1)
                            {
                                encontrado = true;
                            }
                        }
                        if (encontrado == true)
                        {
                            label3.Show();
                            label3.Text = "Podcast eliminado de la lista!";
                            Spotflix.perfilenlinea.Fav_Podcast.Remove(c1);
                        }
                        else
                        {
                            label3.Show();
                            label3.Text = "Podcast no esta en la lista";
                        }
                    }
                    else
                    {
                        foreach (var item2 in Spotflix.perfilenlinea.En_Cola_podcast)
                        {
                            if (item2 == c1)
                            {
                                encontrado = true;
                            }
                        }
                        if (encontrado == true)
                        {
                            label3.Show();
                            label3.Text = "Podcast eliminadad de la lista!";
                            Spotflix.perfilenlinea.En_Cola_podcast.Remove(c1);
                        }
                        else
                        {
                            label3.Show();
                            label3.Text = "Podcast no esta en la lista";
                        }
                    }

                }
            }
            else if (tipo == "Videos")
            {
                bool encontrado = false;

                if ((string)comboBox1.SelectedItem == "Agregar")
                {
                    Video c1 = new Video();
                    foreach (var item in Spotflix.Lista_Videos)
                    {
                        if (item.Titulo == (string)comboBox3.SelectedItem)
                        {
                            c1 = item;
                            break;
                        }
                    }
                    if ((string)comboBox4.SelectedItem == "Videos Favoritas")
                    {
                        foreach (var item2 in Spotflix.perfilenlinea.Fav_Videos)
                        {
                            if (item2 == c1)
                            {
                                encontrado = true;
                            }
                        }
                        if (encontrado == true)
                        {
                            label3.Show();
                            label3.Text = "Video ya existe en la lista!";
                        }
                        else
                        {
                            label3.Show();
                            label3.Text = "Video Agregada a la lista!";
                            Spotflix.perfilenlinea.Fav_Videos.Add(c1);
                        }
                    }
                    else
                    {
                        foreach (var item2 in Spotflix.perfilenlinea.En_Cola_video)
                        {
                            if (item2 == c1)
                            {
                                encontrado = true;
                            }
                        }
                        if (encontrado == true)
                        {
                            label3.Show();
                            label3.Text = "Cancion ya existe en la lista!";
                        }
                        else
                        {
                            label3.Show();
                            label3.Text = "Cancion Agregada a la lista!";
                            Spotflix.perfilenlinea.En_Cola_video.Add(c1);
                        }
                    }
                }
                if ((string)comboBox1.SelectedItem == "Eliminar")
                {
                    Video c1 = new Video();
                    foreach (var item in Spotflix.Lista_Videos)
                    {
                        if (item.Titulo == (string)comboBox3.SelectedItem)
                        {
                            c1 = item;
                            break;
                        }
                    }
                    if ((string)comboBox4.SelectedItem == "Videos Favoritas")
                    {
                        foreach (var item2 in Spotflix.perfilenlinea.Fav_Videos)
                        {
                            if (item2 == c1)
                            {
                                encontrado = true;
                            }
                        }
                        if (encontrado == true)
                        {
                            label3.Show();
                            label3.Text = "Video eliminado de la lista!";
                            Spotflix.perfilenlinea.Fav_Videos.Remove(c1);
                        }
                        else
                        {
                            label3.Show();
                            label3.Text = "Video no esta en la lista";
                        }
                    }
                    else
                    {
                        foreach (var item2 in Spotflix.perfilenlinea.En_Cola_video)
                        {
                            if (item2 == c1)
                            {
                                encontrado = true;
                            }
                        }
                        if (encontrado == true)
                        {
                            label3.Show();
                            label3.Text = "Video eliminado de la lista!";
                            Spotflix.perfilenlinea.En_Cola_video.Remove(c1);
                        }
                        else
                        {
                            label3.Show();
                            label3.Text = "Video no esta en la lista";
                        }
                    }

                }
            }
            else if (tipo == "Playlist")
            {
                if ((string)comboBox1.SelectedItem == "Seguir")
                {
                    bool encontrado = false;
                    if ((string)comboBox2.SelectedItem == "AudioLibros")
                    {
                        Playlist p1 = new Playlist();
                        foreach (var item in Spotflix.Lista_Perfiles)
                        {
                            foreach (var item2 in item.Playlists_Audiolibro_Propios)
                            {
                                if (item2.Nombre == textBox1.Text)
                                {
                                    p1 = item2;
                                }
                            }
                        }
                        foreach (var item3 in Spotflix.perfilenlinea.Playlists_Audiolibro_Propios)
                        {
                            if (item3 == p1)
                            {
                                encontrado = true;
                            }
                        }
                        if (encontrado == true)
                        {
                            label3.Show();
                            label3.Text = "Playlist ya seguida";
                        }
                        else
                        {
                            label3.Show();
                            label3.Text = "Playlist seguida!";
                            Spotflix.perfilenlinea.Playlists_Audiolibro_Propios.Add(p1);

                        }

                    }
                    if ((string)comboBox2.SelectedItem == "Cancion")
                    {
                        Playlist p1 = new Playlist();
                        foreach (var item in Spotflix.Lista_Perfiles)
                        {
                            foreach (var item2 in item.Playlists_Canciones_Propias)
                            {
                                if (item2.Nombre == textBox1.Text)
                                {
                                    p1 = item2;
                                }
                            }
                        }
                        foreach (var item3 in Spotflix.perfilenlinea.Playlists_Canciones_Propias)
                        {
                            if (item3 == p1)
                            {
                                encontrado = true;
                            }
                        }
                        if (encontrado == true)
                        {
                            label3.Show();
                            label3.Text = "Playlist ya seguida";
                        }
                        else
                        {
                            label3.Show();
                            label3.Text = "Playlist seguida!";
                            Spotflix.perfilenlinea.Playlists_Canciones_Propias.Add(p1);

                        }
                    }
                    if ((string)comboBox2.SelectedItem == "Peliculas")
                    {
                        Playlist p1 = new Playlist();
                        foreach (var item in Spotflix.Lista_Perfiles)
                        {
                            foreach (var item2 in item.Playlists_Peliculas_Propias)
                            {
                                if (item2.Nombre == textBox1.Text)
                                {
                                    p1 = item2;
                                }
                            }
                        }
                        foreach (var item3 in Spotflix.perfilenlinea.Playlists_Peliculas_Propias)
                        {
                            if (item3 == p1)
                            {
                                encontrado = true;
                            }
                        }
                        if (encontrado == true)
                        {
                            label3.Show();
                            label3.Text = "Playlist ya seguida";
                        }
                        else
                        {
                            label3.Show();
                            label3.Text = "Playlist seguida!";
                            Spotflix.perfilenlinea.Playlists_Peliculas_Propias.Add(p1);

                        }
                    }
                    if ((string)comboBox2.SelectedItem == "Podcasts")
                    {
                        Playlist p1 = new Playlist();
                        foreach (var item in Spotflix.Lista_Perfiles)
                        {
                            foreach (var item2 in item.Playlists_Podcast_Propios)
                            {
                                if (item2.Nombre == textBox1.Text)
                                {
                                    p1 = item2;
                                }
                            }
                        }
                        foreach (var item3 in Spotflix.perfilenlinea.Playlists_Podcast_Propios)
                        {
                            if (item3 == p1)
                            {
                                encontrado = true;
                            }
                        }
                        if (encontrado == true)
                        {
                            label3.Show();
                            label3.Text = "Playlist ya seguida";
                        }
                        else
                        {
                            label3.Show();
                            label3.Text = "Playlist seguida!";
                            Spotflix.perfilenlinea.Playlists_Podcast_Propios.Add(p1);

                        }
                    }
                    if ((string)comboBox2.SelectedItem == "Videos")
                    {
                        Playlist p1 = new Playlist();
                        foreach (var item in Spotflix.Lista_Perfiles)
                        {
                            foreach (var item2 in item.Playlists_Video_Propios)
                            {
                                if (item2.Nombre == textBox1.Text)
                                {
                                    p1 = item2;
                                }
                            }
                        }
                        foreach (var item3 in Spotflix.perfilenlinea.Playlists_Video_Propios)
                        {
                            if (item3 == p1)
                            {
                                encontrado = true;
                            }
                        }
                        if (encontrado == true)
                        {
                            label3.Show();
                            label3.Text = "Playlist ya seguida";
                        }
                        else
                        {
                            label3.Show();
                            label3.Text = "Playlist seguida!";
                            Spotflix.perfilenlinea.Playlists_Video_Propios.Add(p1);

                        }
                    }

                }
                else
                {
                    bool encontrado = false;
                    if ((string)comboBox2.SelectedItem == "AudioLibros")
                    {
                        Playlist p1 = new Playlist();
                        foreach (var item in Spotflix.Lista_Perfiles)
                        {
                            foreach (var item2 in item.Playlists_Audiolibro_Propios)
                            {
                                if (item2.Nombre == textBox1.Text)
                                {
                                    p1 = item2;
                                }
                            }
                        }
                        foreach (var item3 in Spotflix.perfilenlinea.Playlists_Audiolibro_Propios)
                        {
                            if (item3 == p1)
                            {
                                encontrado = true;
                            }
                        }
                        if (encontrado != true)
                        {
                            label3.Show();
                            label3.Text = "Playlist no seguida";
                        }
                        else
                        {
                            label3.Show();
                            label3.Text = "Playlist eliminada!";
                            Spotflix.perfilenlinea.Playlists_Audiolibro_Propios.Remove(p1);

                        }

                    }
                    if ((string)comboBox2.SelectedItem == "Cancion")
                    {
                        Playlist p1 = new Playlist();
                        foreach (var item in Spotflix.Lista_Perfiles)
                        {
                            foreach (var item2 in item.Playlists_Canciones_Propias)
                            {
                                if (item2.Nombre == textBox1.Text)
                                {
                                    p1 = item2;
                                }
                            }
                        }
                        foreach (var item3 in Spotflix.perfilenlinea.Playlists_Canciones_Propias)
                        {
                            if (item3 == p1)
                            {
                                encontrado = true;
                            }
                        }
                        if (encontrado != true)
                        {
                            label3.Show();
                            label3.Text = "Playlist no seguida";
                        }
                        else
                        {
                            label3.Show();
                            label3.Text = "Playlist eliminada!";
                            Spotflix.perfilenlinea.Playlists_Canciones_Propias.Add(p1);

                        }
                    }
                    if ((string)comboBox2.SelectedItem == "Peliculas")
                    {
                        Playlist p1 = new Playlist();
                        foreach (var item in Spotflix.Lista_Perfiles)
                        {
                            foreach (var item2 in item.Playlists_Peliculas_Propias)
                            {
                                if (item2.Nombre == textBox1.Text)
                                {
                                    p1 = item2;
                                }
                            }
                        }
                        foreach (var item3 in Spotflix.perfilenlinea.Playlists_Peliculas_Propias)
                        {
                            if (item3 == p1)
                            {
                                encontrado = true;
                            }
                        }
                        if (encontrado != true)
                        {
                            label3.Show();
                            label3.Text = "Playlist no seguida";
                        }
                        else
                        {
                            label3.Show();
                            label3.Text = "Playlist eliminada!";
                            Spotflix.perfilenlinea.Playlists_Peliculas_Propias.Add(p1);

                        }
                    }
                    if ((string)comboBox2.SelectedItem == "Podcasts")
                    {
                        Playlist p1 = new Playlist();
                        foreach (var item in Spotflix.Lista_Perfiles)
                        {
                            foreach (var item2 in item.Playlists_Podcast_Propios)
                            {
                                if (item2.Nombre == textBox1.Text)
                                {
                                    p1 = item2;
                                }
                            }
                        }
                        foreach (var item3 in Spotflix.perfilenlinea.Playlists_Podcast_Propios)
                        {
                            if (item3 == p1)
                            {
                                encontrado = true;
                            }
                        }
                        if (encontrado != true)
                        {
                            label3.Show();
                            label3.Text = "Playlist no seguida";
                        }
                        else
                        {
                            label3.Show();
                            label3.Text = "Playlist eliminada!";
                            Spotflix.perfilenlinea.Playlists_Podcast_Propios.Add(p1);

                        }
                    }
                    if ((string)comboBox2.SelectedItem == "Videos")
                    {
                        Playlist p1 = new Playlist();
                        foreach (var item in Spotflix.Lista_Perfiles)
                        {
                            foreach (var item2 in item.Playlists_Video_Propios)
                            {
                                if (item2.Nombre == textBox1.Text)
                                {
                                    p1 = item2;
                                }
                            }
                        }
                        foreach (var item3 in Spotflix.perfilenlinea.Playlists_Video_Propios)
                        {
                            if (item3 == p1)
                            {
                                encontrado = true;
                            }
                        }
                        if (encontrado != true)
                        {
                            label3.Show();
                            label3.Text = "Playlist no seguida";
                        }
                        else
                        {
                            label3.Show();
                            label3.Text = "Playlist eliminada!";
                            Spotflix.perfilenlinea.Playlists_Video_Propios.Add(p1);

                        }
                    }

                }
            }
            //Playlist
        }

        private void Buscador_Load(object sender, EventArgs e)
        {
            BringToFront();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            
        }

        //Faltan los hides y clears
        private void atras_Click(object sender, EventArgs e)
        {
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            textBox1.Clear();
            Hide();
            //clears.
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //boton del text (abajo)
        private void Buscar_Click(object sender, EventArgs e)
        {
            if (tipo == "Artistas")
            {
                //
                int sexo = 2;
                if (textBox1.Text == "Hombre")
                {
                    sexo = 1;
                }
                int profesion = 0;
                if (textBox1.Text == "Cantante")
                {
                    profesion = 1;
                }
                else if (textBox1.Text == "Actor")
                {
                    profesion = 3;
                }
                else if (textBox1.Text == "Locutor")
                {
                    profesion = 5;
                }
                else if (textBox1.Text == "Lector")
                {
                    profesion = 6;
                }

                foreach (var item in Spotflix.Lista_Personas)
                {
                    if ((string)comboBox2.SelectedItem == "Nacionalidad" && item.Nacionalidad == textBox1.Text)
                    {
                        //if (item.Nacionalidad.Contains(textBox1.Text)==true)
                        //{
                        //   comboBox3.Items.Add(item.Nombre_y_Apellido);
                        //
                        //}
                        comboBox3.Items.Add(item.Nombre_y_Apellido);

                    }

                    else if ((string)comboBox2.SelectedItem == "Sexo" && item.Sexo == sexo)
                    {
                        comboBox3.Items.Add(item.Nombre_y_Apellido);

                    }
                    else if ((string)comboBox2.SelectedItem == "Profesion" && item.Profesion[0] == profesion)
                    {
                        comboBox3.Items.Add(item.Nombre_y_Apellido);

                    }
                    else if ((string)comboBox2.SelectedItem == "Edad" && 2020 - item.Fecha_De_Nacimiento.Year == Convert.ToInt32(textBox1.Text))
                    {
                        comboBox3.Items.Add(item.Nombre_y_Apellido);

                    }
                }
                
            }
            else if (tipo == "Canciones")
            {

                foreach (var item in Spotflix.Lista_Canciones)
                {
                    if ((string)comboBox2.SelectedItem == "Cantante")
                    {
                        foreach (var item2 in item.Cantante)
                        {
                            if (textBox1.Text == item2.Nombre_y_Apellido)
                            {
                                comboBox3.Items.Add(item.Titulo);
                            }
                        }
                    }
                    else if ((string)comboBox2.SelectedItem == "Album" && item.Album == textBox1.Text)
                    {
                        comboBox3.Items.Add(item.Titulo);
                    }
                    else if ((string)comboBox2.SelectedItem == "Genero" && item.Genero == textBox1.Text)
                    {
                        comboBox3.Items.Add(item.Titulo);
                    }
                    else if ((string)comboBox2.SelectedItem == "Titulo" && item.Titulo == textBox1.Text)
                    {
                        comboBox3.Items.Add(item.Titulo);

                    }

                }
            }
            else if (tipo == "Videos")
            {

                int clasificacion = 0;
                if (textBox1.Text == "AA")
                {
                    clasificacion = 1;
                }
                else if (textBox1.Text == "A")
                {
                    clasificacion = 2;
                }
                else if (textBox1.Text == "B")
                {
                    clasificacion = 3;
                }
                else if (textBox1.Text == "C")
                {
                    clasificacion = 4;
                }
                else if (textBox1.Text == "D")
                {
                    clasificacion = 5;
                }

                foreach (var item in Spotflix.Lista_Videos)
                {

                    if ((string)comboBox2.SelectedItem == "Titulo" && item.Titulo == textBox1.Text)
                    {
                        comboBox3.Items.Add(item.Titulo);

                    }
                    else if ((string)comboBox2.SelectedItem == "Genero" && item.Genero == textBox1.Text)
                    {
                        comboBox3.Items.Add(item.Titulo);

                    }
                    else if ((string)comboBox2.SelectedItem == "Clasificacion" && item.Clasificacion == clasificacion)
                    {
                        comboBox3.Items.Add(item.Titulo);

                    }

                }
            }
            else if (tipo == "Peliculas")
            {

                int clasificacion = 0;

                if (textBox1.Text == "AA")
                {
                    clasificacion = 1;
                }
                else if (textBox1.Text == "A")
                {
                    clasificacion = 2;
                }
                else if (textBox1.Text == "B")
                {
                    clasificacion = 3;
                }
                else if (textBox1.Text == "C")
                {
                    clasificacion = 4;
                }
                else if (textBox1.Text == "D")
                {
                    clasificacion = 5;
                }

                foreach (var item in Spotflix.Lista_Peliculas)
                {
                    int i = 0;
                    if ((string)comboBox2.SelectedItem == "Titulo" && item.Titulo == textBox1.Text)
                    {
                        comboBox3.Items.Add(item.Titulo);

                    }
                    else if ((string)comboBox2.SelectedItem == "Genero" && item.Genero == textBox1.Text)
                    {
                        comboBox3.Items.Add(item.Titulo);

                    }
                    else if ((string)comboBox2.SelectedItem == "Clasificacion" && item.Clasificacion == clasificacion)
                    {
                        comboBox3.Items.Add(item.Titulo);

                    }

                }
            }
            else if (tipo == "Podcasts")
            {

                int profesion = 0;

                if (textBox1.Text == "Locutor")
                {
                    profesion = 5;
                }


                foreach (var item in Spotflix.Lista_Podcasts)
                {

                    if ((string)comboBox2.SelectedItem == "Titulo" && item.Titulo == textBox1.Text)
                    {
                        comboBox3.Items.Add(item.Titulo);

                    }
                    else if ((string)comboBox2.SelectedItem == "Genero" && item.Genero == textBox1.Text)
                    {
                        comboBox3.Items.Add(item.Titulo);

                    }
                    else if ((string)comboBox2.SelectedItem == "Locutor")
                    {
                        foreach (var item1 in Spotflix.Lista_Personas)
                        {
                            if ((Persona.enum_Profesion)profesion == Persona.enum_Profesion.Locutor)
                            {
                                comboBox3.Items.Add(item.Titulo);
                            }
                        }

                    }
                }
            }
            else if (tipo == "Audiolibros")
            {


                int profesion = 0;

                if (comboBox2.Text == "Lector")
                {
                    profesion = 6;
                }
                foreach (var item in Spotflix.Lista_AudioLibros)
                {
                    int i = 0;
                    if ((string)comboBox2.SelectedItem == "Titulo" && item.Titulo == textBox1.Text)
                    {
                        comboBox3.Items.Add(item.Titulo);

                    }
                    else if ((string)comboBox2.SelectedItem == "Genero" && item.Genero == textBox1.Text)
                    {
                        comboBox3.Items.Add(item.Titulo);

                    }
                    else if ((string)comboBox2.SelectedItem == "Locutor")
                    {
                        foreach (var item1 in Spotflix.Lista_Personas)
                        {
                            if ((Persona.enum_Profesion)profesion == Persona.enum_Profesion.Locutor)
                            {
                                comboBox3.Items.Add(item.Titulo);

                            }
                        }

                    }
                }
            }
            //FUncion Playlist
            else if (tipo == "Playlists")
            {

                if ((string)comboBox2.SelectedItem == "AudioLibros")
                {
                    foreach (var item in Spotflix.Lista_Perfiles)
                    {
                        foreach (var item2 in item.Playlists_Audiolibro_Propios)
                        {
                            if (item2.Nombre == textBox1.Text)
                            {
                                comboBox3.Items.Add(item2.Nombre);
                            }
                        }
                    }
                }
                else if ((string)comboBox2.SelectedItem == "Canciones")
                {
                    foreach (var item in Spotflix.Lista_Perfiles)
                    {
                        foreach (var item2 in item.Playlists_Canciones_Propias)
                        {
                            if (item2.Nombre == textBox1.Text)
                            {
                                comboBox3.Items.Add(item2.Nombre);
                            }
                        }
                    }
                }
                if ((string)comboBox2.SelectedItem == "Peliculas")
                {
                    foreach (var item in Spotflix.Lista_Perfiles)
                    {
                        foreach (var item2 in item.Playlists_Peliculas_Propias)
                        {
                            if (item2.Nombre == textBox1.Text)
                            {
                                comboBox3.Items.Add(item2.Nombre);
                            }
                        }
                    }
                }
                if ((string)comboBox2.SelectedItem == "Podcasts")
                {
                    foreach (var item in Spotflix.Lista_Perfiles)
                    {
                        foreach (var item2 in item.Playlists_Podcast_Propios)
                        {
                            if (item2.Nombre == textBox1.Text)
                            {
                                comboBox3.Items.Add(item2.Nombre);
                            }
                        }
                    }
                }
                if ((string)comboBox2.SelectedItem == "Videos")
                {
                    foreach (var item in Spotflix.Lista_Perfiles)
                    {
                        foreach (var item2 in item.Playlists_Video_Propios)
                        {
                            if (item2.Nombre == textBox1.Text)
                            {
                                comboBox3.Items.Add(item2.Nombre);
                            }
                        }
                    }
                }
                

            }
        }
    }
}
