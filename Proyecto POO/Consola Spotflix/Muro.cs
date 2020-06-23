using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Consola_Spotflix
{
    [Serializable]
    class Muro: ISerializable
    {
        public static List<string> listBox_registro = new List<string>();
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            
            info.AddValue("listBox_registro", listBox_registro);
        }
        public Muro(SerializationInfo info, StreamingContext context)
        {
            
            listBox_registro = (List<string>)info.GetValue("listBox_registro", typeof(List<string>));

        }
    }
}
