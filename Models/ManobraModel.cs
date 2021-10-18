
using System;
using System.Collections.Generic;
using WebApplicationEstapar.Estapar.Entity;

namespace WebApplicationEstapar.Models
{
    public class ManobraModel
    {
        public int Id { get; set; }

        public EntityCarro oCarro { get; set; }

        public ManobristaEntity oManobrista { get; set; }

        public TipoManobra oTipoManobra { get; set; }

        public DateTime DtManobraInicio { get; set; }

        public DateTime DtManobraFim { get; set; }

        public bool Concluido { get; set; }

        public ClassificacaoEntity oClassificacao { get; set; }

        public List<ManobristaEntity> oListManobristaEntity { get; set; }
        public List<TipoManobra> oListTipoManobra { get; set; }
        public List<ClassificacaoEntity> oListClassificacaoEntity { get; set; }
        public List<EntityCarro> oListEntityCarro { get; set; }

    }
}