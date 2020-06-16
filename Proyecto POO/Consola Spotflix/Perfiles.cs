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

        private void botonPerfil2_Click(object sender, EventArgs e)
        {
            Hide();
            Spotflix.perfilenlinea = Spotflix.Lista_perfilesenlinea[1];
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
                botonPerfil1.Show();
                botonPerfil1.Location= new Point(86, 148);
                botonPerfil1.Text = Spotflix.Lista_perfilesenlinea[0].Nombre_perfil;
            }
            else if (b == 2)
            {
                botonCrearPerfil.Show();
                botonCrearPerfil.Location = new Point(363, 148);
                botonPerfil1.Show();
                botonPerfil1.Location = new Point(86, 148);
                botonPerfil1.Text = Spotflix.Lista_perfilesenlinea[0].Nombre_perfil;
                botonPerfil2.Show();
                botonPerfil2.Location = new Point(222, 148);
                botonPerfil2.Text = Spotflix.Lista_perfilesenlinea[1].Nombre_perfil;
            }
            else if (b==3)
            {
                botonCrearPerfil.Show();
                botonPerfil1.Show();
                botonPerfil1.Location = new Point(86, 148);
                botonPerfil1.Text = Spotflix.Lista_perfilesenlinea[0].Nombre_perfil;
                botonPerfil2.Show();
                botonPerfil2.Location = new Point(222, 148);
                botonPerfil2.Text = Spotflix.Lista_perfilesenlinea[1].Nombre_perfil;
                botonPerfil3.Show();
                botonPerfil3.Location = new Point(363, 148);
                botonPerfil3.Text = Spotflix.Lista_perfilesenlinea[2].Nombre_perfil;
            }
        }
        private void Perfiles_Load(object sender, EventArgs e)
        {
        }
    }
}
