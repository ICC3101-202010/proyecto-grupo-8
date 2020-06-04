using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void button_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Maximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
                button_Restaurar.Show();
                button_Minimizar.Show();
            }
            button_Maximizar.Hide();
        }

        private void button_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_Restaurar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                button_Maximizar.Show();
                button_Minimizar.Show();
            }
            button_Restaurar.Hide();
        }

        private void button_Close_MouseHover(object sender, EventArgs e)
        {
            button_Close.BackColor = System.Drawing.Color.Red;
        }

        private void button_Close_MouseLeave(object sender, EventArgs e)
        {
            button_Close.BackColor = System.Drawing.Color.FromArgb(23,23,23) ;
        }
    }
}
