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

namespace Proyecto_POO
{
    public partial class Perfiles : UserControl
    {
        public Perfiles()
        {
            InitializeComponent();
        }
        Usuario Usuarioasociado;
        private void botonCrearPerfil_Click(object sender, EventArgs e)
        {
            Hide();
            
        }

        private void botonPerfil1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void botonPerfil2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void botonPerfil3_Click(object sender, EventArgs e)
        {
            Hide();
            
        }

        private void Perfiles_Load(object sender, EventArgs e)
        {
            int b = 0;
            foreach (var item in Spotflix.Lista_Perfiles)
            {
                if (item.Usuario_Asociado == Usuarioasociado)
                {
                    b += 1;
                }
            }
            if (b == 0)
            {
                botonPerfil1.Hide();
                botonPerfil2.Hide();
                botonPerfil3.Hide();
                botonCrearPerfil.Location=new Point(247, 155);

            }
            else if (b == 1)
            {
                botonPerfil2.Hide();
                botonPerfil3.Hide();
                botonCrearPerfil.Location = new Point(247, 155);

            }
            else if (b == 2)
            {
                botonPerfil3.Hide();
                botonCrearPerfil.Location = new Point(410, 155);
            }
            else
            {
            }

        }
    }
}
