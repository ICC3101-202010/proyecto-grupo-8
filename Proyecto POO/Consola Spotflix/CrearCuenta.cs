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
            Sexo.Items.Add("Mujer");        }
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
            show1();
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
                //Crear
                string nombre1 = Nombre.Text;
                string apellido = Apellido.Text;


                string sexo1 = (string)Sexo.SelectedItem;
                int sexo = 0;
                if (sexo1 == "Mujer")
                {
                    sexo = 2;
                }
                else
                {
                    sexo=1;
                }
                string pais = Pais.Text;
                string email = Email.Text;
                string contraseña = Contraseña.Text;
                string memb = (string)Membresia.SelectedItem;
                int membb = 1;
                if (memb == "Premium")
                {
                    membb = 2;
                }
                else
                {
                    membb = 1;
                }
                string fechnac = FechaNac.Text;
                DateTime dt = Convert.ToDateTime(fechnac);
                Usuario us1 = new Usuario(nombre1, apellido, dt, sexo, pais, email, contraseña, membb);
                //Spotflix.Lista_Usuarios.Add(us1);
            }
            else
            {
                Remember.Show();
            }
        }
        private void CrearCuenta_Load(object sender, EventArgs e)
        {

            Membresia.Items.Add("Gratis");
            Membresia.Items.Add("Premium");
            Sexo.Items.Add("Hombre");
            Sexo.Items.Add("Mujer");
        }

        private void Nombre_TextChanged(object sender, EventArgs e)
        {
            Creado.Hide();
        }
    }
}
