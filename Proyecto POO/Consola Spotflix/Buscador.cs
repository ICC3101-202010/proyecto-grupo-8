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
        public string tipo;
        public Buscador()
        {
            InitializeComponent();
        }
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
            else if (tipo == "Artistas")
            {
                Buscar.Hide();
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
                label4.Hide();
                label5.Hide();
                comboBox3.Hide();
                textBox1.Hide();
                label3.Hide();
                comboBox4.Hide();
                label6.Hide();
            }
            else if (tipo == "Canciones")
            {
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
                comboBox4.Items.Add("Canciones Favoritas");
                comboBox4.Items.Add("En Cola");
                label5.Text = "Cancion: ";
                label4.Text = "Valor";

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
                label1.Text = "Accion";
                comboBox1.Items.Add("Agregar");
                comboBox1.Items.Add("Eliminar");

                comboBox2.Items.Add("Titulo");
                comboBox2.Items.Add("Cantante");
                comboBox2.Items.Add("Album");
                comboBox2.Items.Add("Genero");
                label2.Text = "Tipo de Categoria";

                label6.Text = "En que lista?";
                comboBox4.Items.Add("Videos Favoritos");
                comboBox4.Items.Add("En Cola");
                label5.Text = "Video: ";

                label4.Text = "Valor";
                Buscar.Show();

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
                comboBox4.Items.Add("Peliculas Favoritas");
                comboBox4.Items.Add("En Cola");
                label5.Text = "Pelicula: ";

                label4.Text = "Valor";
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
                comboBox4.Items.Add("Podcast Favoritos");
                comboBox4.Items.Add("En Cola");
                label5.Text = "Podcast: ";

                label4.Text = "Valor";
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
                Buscar.Show();
                label1.Text = "Accion";
                comboBox1.Items.Add("Agregar");
                comboBox1.Items.Add("Eliminar");

                comboBox2.Items.Add("Titulo");
                comboBox2.Items.Add("Lector");
                comboBox2.Items.Add("Album");
                comboBox2.Items.Add("Genero");
                label2.Text = "Tipo de Categoria";

                label6.Text = "En que lista?";
                comboBox4.Items.Add("AudioLibro Favorito");
                comboBox4.Items.Add("En Cola");
                label5.Text = "AudioLibro: ";

                label4.Text = "Valor";

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
            //Alfinal
            //agregar mullt a playlist
            else if (tipo == "Playlist")
            {
                Buscar.Hide();
                label1.Text = "Accion";
                comboBox1.Items.Add("Agregar");
                comboBox1.Items.Add("Eliminar");
                foreach (var item in Spotflix.Lista_Playlists)
                {
                    comboBox2.Items.Add(item);
                }
                label2.Text = "Playlists:";
                comboBox3.Items.Add("");
                label4.Hide();
                label5.Hide();
                comboBox3.Hide();
                textBox1.Hide();
                label3.Hide();
                comboBox4.Hide();
                label6.Hide();
                //DONDE HACER LA ACCION


            }
        }

        private void Buscador_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            
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

            }
            else if (tipo == "Canciones")
            {

            }
        }

        //Faltan los hides y clears
        private void atras_Click(object sender, EventArgs e)
        {
            Hide();
            //clears.
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)//BORRAR
        {
             //Agregar el tipo de load.

            if (tipo == "Perfil")
            {
                label1.Text = "Accion";
                comboBox3.Hide();
                label4.Hide();
                label5.Hide();
                label2.Text = "Perfiles"; ;
                foreach (var item in Spotflix.Lista_Perfiles)
                {
                    foreach (var item2 in Spotflix.perfilenlinea.Seguidos)
                    {
                        if (item != item2)
                        {
                            comboBox2.Items.Add(item);
                        }

                    }
                }
                label3.Text = "Perfil seguido!";
            }

        }

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
                label4.Hide();
                label5.Hide();
                comboBox3.Hide();
                textBox1.Hide();
                label3.Hide();
                comboBox4.Hide();
                label6.Hide();
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
            //Alfinal
            //agregar mullt a playlist
            else if (tipo == "Playlist")
            {
                Buscar.Hide();
                label1.Text = "Accion";
                comboBox1.Items.Add("Agregar");
                comboBox1.Items.Add("Eliminar");
                foreach (var item in Spotflix.Lista_Playlists)
                {
                    comboBox2.Items.Add(item);
                }
                label2.Text = "Playlists:";
                comboBox3.Items.Add("");
                label4.Hide();
                label5.Hide();
                comboBox3.Hide();
                textBox1.Hide();
                label3.Hide();
                comboBox4.Hide();
                label6.Hide();
                //DONDE HACER LA ACCION


            }
        }
    }
}
