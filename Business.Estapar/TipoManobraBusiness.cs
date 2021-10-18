using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationEstapar.Data.Estapar;
using WebApplicationEstapar.Estapar.Entity;

namespace WebApplicationEstapar.Business.Estapar
{
    public class TipoManobraBusiness:TipoManobraData
    {
        internal List<TipoManobra> ListarTipoManobras()
        {
            List<TipoManobra> returnListTipoManobra = new List<TipoManobra>();

            returnListTipoManobra =base.ListarTipoManobras();

            return returnListTipoManobra;

        }

        internal TipoManobra SelecionarManobrista(TipoManobra oTipoManobra)
        {
            TipoManobra returnTipoManobra = new TipoManobra();

            returnTipoManobra = base.SelecionarManobrista(oTipoManobra);


            return returnTipoManobra;
            
        }

        internal TipoManobra SelecionarTipoManobrista(TipoManobra oTipoManobra)
        {
            TipoManobra returnTipoManobra = new TipoManobra();

            returnTipoManobra = base.SelecionarTipoManobra(oTipoManobra);

            return returnTipoManobra;
        }

        internal int ProximoID()
        {
            int returnProximoID = int.MinValue;

            returnProximoID = base.ProximoID();

            return returnProximoID;
        }

        internal int AlterarTipoManobra(TipoManobra tipoManobra)
        {
            int returnAlterarTipoManobra = int.MinValue;

            returnAlterarTipoManobra = base.AlterarTipoManobra(tipoManobra);

            return returnAlterarTipoManobra;
        }

        internal int IncluirTipoManobra(TipoManobra tipoManobra)
        {
            int returnIncluirTipoManobra = int.MinValue;

            returnIncluirTipoManobra = base.IncluirTipoManobra(tipoManobra);

            return returnIncluirTipoManobra;
        }

        internal int ExcluirTipoManobra(int excluirmyidTipoManobra)
        {
            int returnExcluirTipoManobra = int.MinValue;

            returnExcluirTipoManobra = base.ExcuirTipoManobra(excluirmyidTipoManobra);

            return returnExcluirTipoManobra;
        }
    }
}
