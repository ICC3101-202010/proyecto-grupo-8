﻿using Proyecto_POO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola_Spotflix
{
    public static class Registro
    {
        public static Main_menu mm1;
        public static NuevoPerfil np1;
        public static Perfiles p1;
        public static int Cantidaddeperfiles(Usuario u)
        {
            int c = 0;
            foreach (var item in Spotflix.Lista_Perfiles)
            {
                if (item.Usuario_Asociado == u)
                {
                    c += 1;
                }
            }
            return c;
        }

    }
}