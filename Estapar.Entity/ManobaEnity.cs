using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationEstapar.Estapar.Entity
{
    public class ManobaEnity
    {
        public EntityCarro oCarro { get; set; }

        public  ManobristaEntity oManobrista { get; set; }

        public TipoManobra oTipoManobra { get; set; }


        public DateTime dtManobraInicio { get; set; }

        public DateTime dtManobraFim { get; set; }

        public bool Concluido { get; set; }

        public int Id { get; set; }

        public ClassificacaoEntity oClassificacao { get; set; }
    }
}
