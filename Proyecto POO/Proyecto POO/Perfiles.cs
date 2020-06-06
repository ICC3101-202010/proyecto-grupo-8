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
            foreach (var item in Spotflix.Lista_Perfiles) 
            {
               
            }
        }
    }
}
