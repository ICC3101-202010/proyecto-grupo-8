using Proyecto_POO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consola_Spotflix
{
    public static class Registro
    {
        public static Main_menu mm1;
        public static NuevoPerfil np1;
        public static Perfiles p1;
        public static Buscador busc1;
        public static Informacion Informacion;
        public static CrearPlaylist Crear_playlist;
        public static CrearCuenta Crear_Cuenta;
        public static Buscador bubusc1;
        public static Archivo Crear_Archivo;
        public static CambiodeCuenta CambiodeCuenta;

        public static List<Persona> cantantes()
        {
            List<Persona> cantantes = new List<Persona>() ;
            foreach (var item in Spotflix.Lista_Personas)
            {
                foreach (var item2 in item.Profesion)
                {
                    if (item2 == 1)
                    {
                        cantantes.Add(item);
                    }
                }
            }
            return cantantes;
        }
        public static List<Persona> compositores()
        {
            List<Persona> compositores = new List<Persona>();
            foreach (var item in Spotflix.Lista_Personas)
            {
                foreach (var item2 in item.Profesion)
                {
                    if (item2 == 2)
                    {
                        compositores.Add(item);
                    }
                }
            }
            return compositores;
        }

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
