using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationEstapar.Data.Estapar;
using WebApplicationEstapar.Estapar.Entity;

namespace WebApplicationEstapar.Business.Estapar
{
    public class CarroBusiness : CarroData
    {
        internal List<EntityCarro> ListarCarros()
        {
            List<EntityCarro> returnListEntityCarro = new List<EntityCarro>();

            returnListEntityCarro = base.ListarCarros();

            return returnListEntityCarro;
        }

        internal EntityCarro SelecionarCarro(EntityCarro item)
        {
            EntityCarro returnEntityCarro = new EntityCarro();

            returnEntityCarro = base.SelecionarCarro(item);

            return returnEntityCarro;
        }

        internal int IncluirCarro(EntityCarro entityCarro)
        {
            int returnIncluirCarro = int.MinValue;

            returnIncluirCarro = base.IncluirCarro(entityCarro);

            return returnIncluirCarro;
        }

        internal int ProximoID()
        {
            int returnProximoID = int.MinValue;

            returnProximoID = base.ProximoID();

            return returnProximoID;
        }

        internal int ExcluirCarro(EntityCarro myCarro)
        {
            int returnExcluirCarro = int.MinValue;

            returnExcluirCarro = base.ExcluirCarro(myCarro);

            return returnExcluirCarro;
        }

        internal int AlterarCarro(EntityCarro entityCarro)
        {
            int returnAlterarCarro = int.MinValue;

            returnAlterarCarro = base.AlterarCarro(entityCarro);

            return returnAlterarCarro;
        }
    }
}
