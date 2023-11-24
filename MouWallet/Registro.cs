using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Registro
{
    public string nombre_cuenta { get; set; } = "";
    public string categoria_cuenta { get; set; } = "";
    public int monto_cuenta { get; set; }
    public string ID_cuenta { get; set; } = "";
    public string fecha_cuenta { get; set; } = "";
    

    public override string ToString()
    {
        return $"{nombre_cuenta},{categoria_cuenta}, {monto_cuenta} pesos"; // Representación de cadena para mostrar en la lista
    }
}
