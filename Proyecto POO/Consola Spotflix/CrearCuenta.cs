using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consola_Spotflix
{
    public partial class CrearCuenta : UserControl
    {
        public CrearCuenta()
        {
            InitializeComponent();
        }

        private void Membresia_SelectedIndexChanged(object sender, EventArgs e)
        {
            string memb = (string)Membresia.SelectedItem;
            if (memb == "Premium")
            {
                labelBanco.Show();
                labelFechaV.Show();
                labelCodSeg.Show();
                labelNoomTarj.Show();
                Banco.Show();
                CodSeguridad.Show();
                Vencimiento.Show();
                Ntarjeta.Show();


            }
            else
            {
                HidePremiumstuff();
            }
        }
        public void show1()
        {
            Membresia.Items.Add("Gratis");
            Membresia.Items.Add("Premium");
            Sexo.Items.Add("Hombre");
            Sexo.Items.Add("Mujer");
            Show();
        }
        public void HidePremiumstuff()
        {
            labelBanco.Hide();
            labelFechaV.Hide();
            labelCodSeg.Hide();
            labelNoomTarj.Hide();
            Banco.Hide();
            CodSeguridad.Hide();
            Vencimiento.Hide();
            Ntarjeta.Hide();
        }
        private void Menu_Click(object sender, EventArgs e)
        {
            Hide();
            Remember.Hide();
            Creado.Hide();

            Nombre.Clear();
            Apellido.Clear();
            FechaNac.Clear();
            Sexo.Items.Clear();
            Membresia.Items.Clear();
            Pais.Clear();
            Email.Clear();
            Contraseña.Clear();
            Banco.Clear();
            Ntarjeta.Clear();
            Vencimiento.Clear();
            CodSeguridad.Clear();
        }
        int a = 0;
        private void Crear_Click(object sender, EventArgs e)
        {
            a += 1;
            if (a % 2 == 0)
            {
                Remember.Hide();
                Creado.Show();
            }
            else
            {
                Remember.Show();
            }
        }

        private void CrearCuenta_Load(object sender, EventArgs e)
        {
        }
    }
}
