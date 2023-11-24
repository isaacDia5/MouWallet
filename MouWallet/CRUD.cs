using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouWallet
{
    internal class CRUD
    {
        private string nombre_cuenta = "";
        private string categoria_cuenta = "";
        private int monto_cuenta;
        private int id_cuenta;
        private string fecha_cuenta = "";

        public string Nombre_cuenta { get => nombre_cuenta; set => nombre_cuenta = value; }
        public string Categoria_cuenta { get => categoria_cuenta; set => categoria_cuenta = value; }
        public int Monto_cuenta { get => monto_cuenta; set => monto_cuenta = value; }
        public int Id_cuenta { get => id_cuenta; set => id_cuenta = value; }
        public string Fecha_cuenta { get => fecha_cuenta; set => fecha_cuenta = value; }
    }
}
