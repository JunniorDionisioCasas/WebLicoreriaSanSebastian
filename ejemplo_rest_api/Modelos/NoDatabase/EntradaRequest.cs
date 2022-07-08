using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.NoDatabase
{
    public class EntradaRequest
    {
        public EntradaModel Entrada { get; set; }
        public DetalleEntradaModel DetalleEntrada { get; set; }
    }
}
