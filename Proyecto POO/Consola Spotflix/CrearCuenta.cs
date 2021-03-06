﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_POO;
using System.Threading;
using System.IO;
using System.Xml.Serialization;

namespace Consola_Spotflix
{
    public partial class CrearCuenta : UserControl
    {
        public CrearCuenta()
        {
            InitializeComponent();
            Registro.Crear_Cuenta = this;
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
        public void ALMENU()
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
                
                string fechnac = FechaNac.Text;
                DateTime dt = Convert.ToDateTime(fechnac);
                Usuario us1 = new Usuario(nombre1, apellido, dt, sexo, pais, email, contraseña, membb);
                Spotflix.Lista_Usuarios.Add(us1);
                MessageBox.Show("Tu usuario " + nombre1 + " ha sido creado!");
                //Serializar la info de perfil.
                using (Stream fs1 = new FileStream(Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Informacion\Perfiles\Data_Perfiles.xml", FileMode.Create,
                    FileAccess.Write, FileShare.None))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Perfil>));
                    serializer.Serialize(fs1, Spotflix.Lista_Perfiles);
                }
                //Serializar la info de usuario
                using (Stream fs2 = new FileStream(Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 27) + @"\Informacion\Usuarios\Data_Usuarios.xml", FileMode.Create,
                    FileAccess.Write, FileShare.None))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Usuario>));
                    serializer.Serialize(fs2, Spotflix.Lista_Usuarios);
                }
                ALMENU();

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
