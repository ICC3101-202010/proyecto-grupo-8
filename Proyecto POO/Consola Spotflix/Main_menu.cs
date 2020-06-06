using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.InteropServices;
using WMPLib;
using Proyecto_POO;
using AxWMPLib;
using System.Threading;

namespace Consola_Spotflix
{
    public partial class Main_menu : UserControl
    {
        public Main_menu()
        {
            InitializeComponent();
        }
        private void button35_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = Spotflix.Lista_Canciones[0].URL;
        }


        private void button32_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }
    }
}
