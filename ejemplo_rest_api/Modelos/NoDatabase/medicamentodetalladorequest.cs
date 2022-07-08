using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.NoDatabase
{
    public class medicamentodetalladorequest
    {
        public MedicamentoModel Medicamento { get; set; }
        public CategoriaModel Categoria { get; set; }
        public PresentacionModel Presentacion { get; set; }
        public LaboratorioModel Laboratorio { get; set; }     
    }
}
