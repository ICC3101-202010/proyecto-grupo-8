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
                label2.Hide();
                comboBox2.Hide();
                foreach (var item in Spotflix.Lista_Perfiles)
                {
                    foreach (var item2 in Spotflix.perfilenlinea.Seguidos)
                    {
                        if (item != item2)
                        {
                            comboBox1.Items.Add(item);
                        }

                    }
                }
                label3.Text = "Perfil seguido!";
            }
            else if (tipo == "Multimedia")
            {
                label1.Text = "Multimedia";
            }
           
            else if (tipo == "Artista")
            {

            }
            else if (tipo == "Playlist")
            {

            }
            
        }
        private void Buscador_Load(object sender, EventArgs e)
        {

        }
    }
}
