using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqExamen
{
    public partial class Historia
    {
        historiasUsuarioDataContext historias = new historiasUsuarioDataContext();
            public string diagn()
            {
                var consulta = historias.Diagnosticos;
                return Convert.ToString(consulta);
            }

    }
}
