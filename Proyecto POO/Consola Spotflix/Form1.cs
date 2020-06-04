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
    }
}
