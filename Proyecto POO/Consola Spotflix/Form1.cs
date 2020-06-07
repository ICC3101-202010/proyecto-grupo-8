using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_POO;

namespace Consola_Spotflix
{
    public partial class Main_Spotflix : Form
    {
        
        public Main_Spotflix()
        {
            InitializeComponent();
            Main_menu main_Menu = new Main_menu();
            main_Menu.Show();
        }
        

        private void Main_Spotflix_Load(object sender, EventArgs e)
        {
            main_menu1.Hide();
        }

        private void Registrarse_Click(object sender, EventArgs e)
        {

            crearCuenta1.Show();
            crearCuenta1.HidePremiumstuff();
            textBox1.Clear();
            textBox2.Clear();
        }

        private void Aceptar_Click_1(object sender, EventArgs e)
        {
            int b = 0;
            string email = textBox1.Text;
            string contraseña = textBox2.Text;
            foreach (var item in Spotflix.Lista_Usuarios)
            {
                MessageBox.Show("HOLA RONCA");
                if(item.Email==email && item.Contraseña == contraseña)
                {
                    Spotflix.usuarioenlinea = item;
                    //perfiles1.Show();
                    //perfiles1.BringToFront();
                    main_menu1.Show();
                    b += 1;
                    break;
                }

            }
            if (b == 0)
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