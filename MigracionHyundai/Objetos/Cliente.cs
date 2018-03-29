using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigracionHyundai.Objetos
{
    public class Cliente
    {
        public string rut { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }

        public string fullname { get;  }
    }
}
