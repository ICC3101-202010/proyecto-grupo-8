using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using Proyecto_POO;

namespace Consola_Spotflix
{
    public partial class Main_Spotflix : Form
    {
        
        public Main_Spotflix()
        {
            InitializeComponent();
        }
        

        private void Main_Spotflix_Load(object sender, EventArgs e)
        {
            
        }

        private void Registrarse_Click(object sender, EventArgs e)
        {

            crearCuenta1.Show();
            crearCuenta1.HidePremiumstuff();
            textBox1.Clear();
            textBox2.Clear();
            Usuarionoencontrado.Hide();
        }

        private void Aceptar_Click_1(object sender, EventArgs e)
        {
            int b = 0;
            Spotflix.Lista_perfilesenlinea.Clear();
            string email = textBox1.Text;
            string contraseña = textBox2.Text;
            //cantidad de perfiles
            foreach (Perfil p in Spotflix.Lista_Perfiles)
            {
                if (p.Usuario_Asociado.Email == email && p.Usuario_Asociado.Contraseña == contraseña)
                {
                    Spotflix.Lista_perfilesenlinea.Add(p);
                    b += 1;
                    Spotflix.usuarioenlinea = p.Usuario_Asociado;
                }
            }
            int c = 0;
            foreach (Usuario u in Spotflix.Lista_Usuarios)
            {
                if (u.Email==email && u.Contraseña == contraseña)
                {
                    c += 1;
                    perfiles1.loadPerfiles(b);
                    break;
                }
            }
            if (c == 0)
            {
                Usuarionoencontrado.Show();
            }
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Usuarionoencontrado.Hide();
        }
    }
}