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

namespace Consola_Spotflix
{
    public partial class Buscador : UserControl
    {

        public Buscador()
        {
            InitializeComponent();
        }
        public void CargarBuscador(string tipo)
        {
            Show();
            if (tipo == "Perfil")
            {
                label1.Text = "Accion";
                comboBox1.Items.Add("Seguir");
                comboBox1.Items.Add("Dejar de seguir");
                comboBox3.Hide();
                comboBox4.Hide();
                label4.Hide();
                label5.Hide();
                label2.Text = "Perfiles"; ;
                comboBox2.Hide();
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
            else if (tipo == "Canciones")
            {
                label1.Text = "Añadir a ";
                comboBox1.Items.Add("Playlist");
                comboBox1.Items.Add("En Cola");
                label2.Text = "Categoria";
                comboBox2.Items.Add("Titulo");
                comboBox2.Items.Add("Cantante");
                comboBox2.Items.Add("Album");
                comboBox2.Items.Add("Genero");
                label4.Text = "Tipo de Categoria";
                label5.Text = "Canciones";
                int profesion = 0;
                if (textBox1.Text == "Cantante")
                {
                    profesion = 1;
                }


                foreach (var item in Spotflix.Lista_Canciones)
                {
                    int i = 0;
                    if ((string)comboBox2.SelectedItem == "Cantante")
                    {
                        foreach (var item1 in Spotflix.Lista_Personas)
                        {
                            if ((Persona.enum_Profesion)profesion == Persona.enum_Profesion.Cantante)
                            {
                                comboBox4.Items.Add(Spotflix.Lista_Podcasts[i - 1].Titulo);

                            }
                        }
                        comboBox4.Items.Add(Spotflix.Lista_Canciones[i - 1].Titulo);
                        i++;
                    }
                    else if ((string)comboBox2.SelectedItem == "Album" && item.Album == textBox1.Text)
                    {
                        comboBox4.Items.Add(Spotflix.Lista_Canciones[i - 1].Titulo);
                        i++;
                    }
                    else if ((string)comboBox2.SelectedItem == "Genero" && item.Genero == textBox1.Text)
                    {
                        comboBox4.Items.Add(Spotflix.Lista_Canciones[i - 1].Titulo);
                        i++;
                    }
                    else if ((string)comboBox2.SelectedItem == "Titulo" && item.Titulo == textBox1.Text)
                    {
                        comboBox4.Items.Add(Spotflix.Lista_Canciones[i - 1].Titulo);
                        i++;
                    }

                }
            }
            else if (tipo == "Videos")
            {
                label1.Text = "Añadir a ";
                comboBox1.Items.Add("Playlist");
                comboBox1.Items.Add("En Cola");
                label2.Text = "Categoria";
                comboBox2.Items.Add("Titulo");
                comboBox2.Items.Add("Genero");
                comboBox2.Items.Add("Clasificacion");
                label4.Text = "Tipo de Categoria";
                label5.Text = "Videos";
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
                    int i = 0;
                    if ((string)comboBox2.SelectedItem == "Titulo" && item.Titulo == textBox1.Text)
                    {
                        comboBox4.Items.Add( Spotflix.Lista_Videos[i - 1].Titulo);
                        i++;
                    }
                    else if ((string)comboBox2.SelectedItem == "Genero" && item.Genero == textBox1.Text)
                    {
                        comboBox4.Items.Add(Spotflix.Lista_Videos[i - 1].Titulo);
                        i++;
                    }
                    else if ((string)comboBox2.SelectedItem == "Clasificacion" && item.Clasificacion == clasificacion)
                    {
                        comboBox4.Items.Add(Spotflix.Lista_Videos[i - 1].Titulo);
                        i++;
                    }

                }
            }
            else if (tipo == "Peliculas")
            {
                label1.Text = "Añadir a ";
                comboBox1.Items.Add("Playlist");
                comboBox1.Items.Add("En Cola");
                label2.Text = "Categoria";
                comboBox2.Items.Add("Titulo");
                comboBox2.Items.Add("Genero");
                comboBox2.Items.Add("Clasificacion");
                label4.Text = "Tipo de Categoria";
                label5.Text = "Peliculas";
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
                        comboBox4.Items.Add(Spotflix.Lista_Peliculas[i - 1].Titulo);
                        i++;
                    }
                    else if ((string)comboBox2.SelectedItem == "Genero" && item.Genero == textBox1.Text)
                    {
                        comboBox4.Items.Add(Spotflix.Lista_Peliculas[i - 1].Titulo);
                        i++;
                    }
                    else if ((string)comboBox2.SelectedItem == "Clasificacion" && item.Clasificacion == clasificacion)
                    {
                        comboBox4.Items.Add(Spotflix.Lista_Peliculas[i - 1].Titulo);
                        i++;
                    }

                }
            }
            else if (tipo == "Podcasts")
            {
                label1.Text = "Añadir a ";
                comboBox1.Items.Add("Playlist");
                comboBox1.Items.Add("En Cola");
                label2.Text = "Categoria";
                comboBox2.Items.Add("Titulo");
                comboBox2.Items.Add("Genero");
                comboBox2.Items.Add("Locutor");
                label4.Text = "Tipo de Categoria";
                label5.Text = "Podcasts";
                int profesion = 0;

                if (textBox1.Text == "Locutor")
                {
                    profesion = 5;
                }


                foreach (var item in Spotflix.Lista_Podcasts)
                {
                    int i = 0;
                    if ((string)comboBox2.SelectedItem == "Titulo" && item.Titulo == textBox1.Text)
                    {
                        comboBox4.Items.Add(Spotflix.Lista_Podcasts[i - 1].Titulo);
                        i++;
                    }
                    else if ((string)comboBox2.SelectedItem == "Genero" && item.Genero == textBox1.Text)
                    {
                        comboBox4.Items.Add(Spotflix.Lista_Podcasts[i - 1].Titulo);
                        i++;
                    }
                    else if ((string)comboBox2.SelectedItem == "Locutor")
                    {
                        foreach (var item1 in Spotflix.Lista_Personas)
                        {
                            if ((Persona.enum_Profesion)profesion == Persona.enum_Profesion.Locutor)
                            {
                                comboBox4.Items.Add(Spotflix.Lista_Podcasts[i - 1].Titulo);
                                
                            }
                        }
                        i++;
                    }
                }
            }
            else if (tipo == "Audiolibros")
            {
                label1.Text = "Añadir a ";
                comboBox1.Items.Add("Playlist");
                comboBox1.Items.Add("En Cola");
                label2.Text = "Categoria";
                comboBox2.Items.Add("Titulo");
                comboBox2.Items.Add("Genero");
                comboBox2.Items.Add("Lector");
                label4.Text = "Tipo de Categoria";
                label5.Text = "Audiolibro";
                int profesion = 0;

                if (textBox1.Text == "Lector")
                {
                    profesion = 6;
                }
                foreach (var item in Spotflix.Lista_AudioLibros)
                {
                    int i = 0;
                    if ((string)comboBox2.SelectedItem == "Titulo" && item.Titulo == textBox1.Text)
                    {
                        comboBox4.Items.Add(Spotflix.Lista_AudioLibros[i - 1].Titulo);
                        i++;
                    }
                    else if ((string)comboBox2.SelectedItem == "Genero" && item.Genero == textBox1.Text)
                    {
                        comboBox4.Items.Add(Spotflix.Lista_AudioLibros[i - 1].Titulo);
                        i++;
                    }
                    else if ((string)comboBox2.SelectedItem == "Locutor")
                    {
                        foreach (var item1 in Spotflix.Lista_Personas)
                        {
                            if ((Persona.enum_Profesion)profesion == Persona.enum_Profesion.Locutor)
                            {
                                comboBox4.Items.Add(Spotflix.Lista_AudioLibros[i - 1].Titulo);

                            }
                        }
                        i++;
                    }
                }
            }

            else if (tipo == "Artista")
            {
                label1.Text = "Accion";
                comboBox1.Items.Add("Seguir");
                comboBox1.Items.Add("Dejar de seguir");
                label2.Text = "Categoria";
                comboBox2.Items.Add("Nacionalidad");
                comboBox2.Items.Add("Sexo");
                comboBox2.Items.Add("Profesion");
                comboBox2.Items.Add("Edad");
                label4.Text = "Tipo de busqueda";
                int sexo = 0;
                if (textBox1.Text == "Mujer")
                {
                    sexo = 2;
                }
                else 
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

                

                int i = 0;
                foreach (var item in Spotflix.Lista_Personas)
                {
                    if ((string)comboBox2.SelectedItem == "Nacionalidad" && item.Nacionalidad == textBox1.Text)
                    {
                        comboBox4.Items.Add(Spotflix.Lista_Personas[i - 1].Nombre_y_Apellido);
                        i++;
                    }
                    else if ((string)comboBox2.SelectedItem == "Sexo" && item.Sexo == sexo)
                    {
                        comboBox4.Items.Add(Spotflix.Lista_Personas[i-1].Nombre_y_Apellido);
                        i++;
                    }
                    else if ((string)comboBox2.SelectedItem == "Profesion" && item.Profesion[0] == profesion)
                    {
                        comboBox4.Items.Add(Spotflix.Lista_Personas[i - 1].Nombre_y_Apellido);
                        i++;
                    }
                    else if ((string)comboBox2.SelectedItem == "Edad" && 2020 -item.Fecha_De_Nacimiento.Year == Convert.ToInt32(textBox1.Text))
                    {
                        comboBox4.Items.Add(Spotflix.Lista_Personas[i - 1].Nombre_y_Apellido);
                        i++;
                    }
                }

            }
            else if (tipo == "Playlist")
            {
                foreach (var item in Spotflix.Lista_Playlists)
                {
                    comboBox2.Items.Add(item);
                }

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

        }

        private void atras_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
