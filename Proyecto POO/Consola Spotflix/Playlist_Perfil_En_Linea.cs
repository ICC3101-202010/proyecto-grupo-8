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
using AxWMPLib;

namespace Consola_Spotflix
{
    public partial class Playlist_Perfil_En_Linea : UserControl
    {
        public Playlist_Perfil_En_Linea()
        {
            InitializeComponent();
        }
        public void Iniciar()
        {
            try
            {
                button1.Text = Spotflix.perfilenlinea.Playlists_Canciones_Propias[0].Nombre;
                button2.Text = Spotflix.perfilenlinea.Playlists_Canciones_Propias[1].Nombre;
                button3.Text = Spotflix.perfilenlinea.Playlists_Canciones_Propias[2].Nombre;
                button4.Text = Spotflix.perfilenlinea.Playlists_Canciones_Propias[3].Nombre;
                button5.Text = Spotflix.perfilenlinea.Playlists_Canciones_Propias[4].Nombre;
                button6.Text = Spotflix.perfilenlinea.Playlists_Canciones_Propias[5].Nombre;
                button7.Text = Spotflix.perfilenlinea.Playlists_Canciones_Propias[6].Nombre;
                button8.Text = Spotflix.perfilenlinea.Playlists_Canciones_Propias[7].Nombre;

            }
            catch 
            {
            }
                         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
