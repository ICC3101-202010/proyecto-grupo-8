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
                button1.Text = "Todas las canciones";
            }
            catch 
            {
            }
                         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Spotflix.Temporal.clear();
            Spotflix.Agregar_a_temportal(Spotflix.Lista_Canciones);
            Registro.mm1.AbrirMusica();
            Registro.mm1.Nombre_Playlist.Text = button1.Text;
            try
            {
                Registro.mm1.button23.Text = Spotflix.Temporal_Info[0].Titulo;
                Registro.mm1.button24.Text = Spotflix.Temporal_Info[1].Titulo;
                Registro.mm1.button25.Text = Spotflix.Temporal_Info[2].Titulo;
                Registro.mm1.button26.Text = Spotflix.Temporal_Info[3].Titulo;
                Registro.mm1.button27.Text = Spotflix.Temporal_Info[4].Titulo;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
