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
using Consola_Spotflix;
using Consola_Spotflix.Properties;

namespace Proyecto_POO
{
    public partial class Perfiles : UserControl
    {
        public Perfiles()
        {
            InitializeComponent();
            Registro.p1 = this;
        }
        private void botonCrearPerfil_Click(object sender, EventArgs e)
        {
            Hide();
            Registro.np1.Show();
            
        }
        private void botonPerfil1_Click(object sender, EventArgs e)
        {
            Hide();
            Spotflix.perfilenlinea = Spotflix.Lista_perfilesenlinea[0];
            Registro.mm1.Iniciar();
            Registro.mm1.Show();
        }


        private void botonPerfil3_Click(object sender, EventArgs e)
        {
            Hide();
            Spotflix.perfilenlinea = Spotflix.Lista_perfilesenlinea[2];
            Registro.mm1.Iniciar();
            Registro.mm1.Show();
        }

        public void loadPerfiles(int b)
        {
            Show();
            if (b == 0)
            {
                botonCrearPerfil.Show();
                botonCrearPerfil.Location = new Point(86, 148);
                
            }
            else if (b == 1)
            {
                botonCrearPerfil.Show();
                botonCrearPerfil.Location= new Point(222, 148);
                label1.Location = new Point(86, 118);
                PictureBox1.Show();
                PictureBox1.Location= new Point(86, 148);
                label1.Text = Spotflix.Lista_perfilesenlinea[0].Nombre_perfil;
                label1.Show();
                try
                {
                    PictureBox1.Image = new Bitmap(Spotflix.Lista_perfilesenlinea[0].Imagen);
                }
                catch 
                {
                    PictureBox1.Image = Resources.fondo_imagenes;
                }
                
            }
            else if (b == 2)
            {
                botonCrearPerfil.Show();
                botonCrearPerfil.Location = new Point(363, 148);
                PictureBox1.Show();
                PictureBox1.Location = new Point(86, 148);
                label1.Text = Spotflix.Lista_perfilesenlinea[0].Nombre_perfil;
                label1.Location = new Point(86, 118);
                label1.Show();
                try
                {
                    PictureBox1.Image = new Bitmap(Spotflix.Lista_perfilesenlinea[0].Imagen);
                }
                catch
                {
                    PictureBox1.Image = Resources.fondo_imagenes;
                }
                PictureBox2.Show();
                PictureBox2.Location = new Point(222, 148);
                label2.Location = new Point(222, 118);
                label2.Text = Spotflix.Lista_perfilesenlinea[1].Nombre_perfil;
                label2.Show();
                try
                {
                    PictureBox2.Image = new Bitmap(Spotflix.Lista_perfilesenlinea[1].Imagen);
                }
                catch
                {
                    PictureBox2.Image = Resources.fondo_imagenes;
                }
            }
            else if (b==3)
            {
                botonCrearPerfil.Show();
                PictureBox1.Show();
                PictureBox1.Location = new Point(86, 148);
                label1.Location = new Point(86, 118);
                label1.Text = Spotflix.Lista_perfilesenlinea[0].Nombre_perfil;
                label1.Show();
                try
                {
                    PictureBox1.Image = new Bitmap(Spotflix.Lista_perfilesenlinea[0].Imagen);
                }
                catch
                {
                    PictureBox1.Image = Resources.fondo_imagenes;
                }
                PictureBox2.Show();
                PictureBox2.Location = new Point(222, 148);
                label1.Location = new Point(222, 118);
                label2.Text = Spotflix.Lista_perfilesenlinea[1].Nombre_perfil;
                label2.Show();

                try
                {
                    PictureBox2.Image = new Bitmap(Spotflix.Lista_perfilesenlinea[1].Imagen);
                }
                catch
                {
                    PictureBox2.Image = Resources.fondo_imagenes;
                }
                PictureBox3.Show();
                PictureBox3.Location = new Point(363, 148);
                label1.Location = new Point(363, 118);
                label1.Text = Spotflix.Lista_perfilesenlinea[2].Nombre_perfil;
                label3.Show();
                try
                {
                    PictureBox3.Image = new Bitmap(Spotflix.Lista_perfilesenlinea[2].Imagen);
                }
                catch
                {
                    PictureBox3.Image = Resources.fondo_imagenes;
                }
            }
        }
        private void Perfiles_Load(object sender, EventArgs e)
        {
        }

        private void botonPerfil1_Click_1(object sender, EventArgs e)
        {
            Hide();
            Spotflix.perfilenlinea = Spotflix.Lista_perfilesenlinea[0];
            Registro.mm1.Iniciar();
            Registro.mm1.Show();
        }

        private void botonPerfil2_Click_1(object sender, EventArgs e)
        {
            Hide();
            Spotflix.perfilenlinea = Spotflix.Lista_perfilesenlinea[1];
            Registro.mm1.Iniciar();
            Registro.mm1.Show();
        }

        private void botonPerfil3_Click_1(object sender, EventArgs e)
        {
            Hide();
            Spotflix.perfilenlinea = Spotflix.Lista_perfilesenlinea[2];
            Registro.mm1.Iniciar();
            Registro.mm1.Show();
        }

    }
}
