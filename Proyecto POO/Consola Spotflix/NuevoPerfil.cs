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
    public partial class NuevoPerfil : UserControl
    {
        string nombreperfil;
        string tipodeperfil;

        public NuevoPerfil()
        {
            InitializeComponent();
        }

        private void NombrePerfil_TextChanged(object sender, EventArgs e)
        {
           nombreperfil = NombrePerfil.Text;
        }

        private void comboTipoPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboTipoPerfil.Items.Add("Artista");
            comboTipoPerfil.Items.Add("Publico");
            comboTipoPerfil.Items.Add("Privado");
            tipodeperfil = (string)comboTipoPerfil.SelectedItem;

        }

        private void botonCrearPerfil_Click(object sender, EventArgs e)
        {
            if (NombrePerfil.Text == null || comboTipoPerfil.Items == null)
            {
                NoCreado.Show();
            }

            int tipo = 0;
            if (tipodeperfil == "Artista")
            {
                tipo = 1;
            }
            if (tipodeperfil == "Publico")
            {
                tipo = 2;

            }
            if (tipodeperfil == "Privado")
            {
                tipo = 3;
            }

            Usuario usuarioenlinea = new Usuario();
            Perfil p1 = new Perfil(usuarioenlinea, nombreperfil, tipo);
            Creado.Show();
            //Spotflix.Lista_Perfiles.Add();
            Hide();
        }

        private void NuevoPerfil_Load(object sender, EventArgs e)
        {
            Creado.Hide();
            NoCreado.Hide();

        }
    }
}
