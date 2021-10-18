using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationEstapar.Data.Estapar;
using WebApplicationEstapar.Estapar.Entity;

namespace WebApplicationEstapar.Business.Estapar
{
    public class ManobristaBusiness: ManobristaData
    {
        internal List<ManobristaEntity> ListarManobristras()
        {
            List<ManobristaEntity> retornoListManobristaBusiness = new List<ManobristaEntity>();

            retornoListManobristaBusiness = base.ListarManobrista();

            return retornoListManobristaBusiness;
        }

        internal ManobristaEntity SelecionarManobrista(ManobristaEntity oManobrista)
        {
            ManobristaEntity returnManobristaEntity = new ManobristaEntity();

            returnManobristaEntity = base.SelecionarManobrista(oManobrista);

            return returnManobristaEntity;
        }

        internal int ProximoID()
        {
            int returnProximoID = int.MinValue;

            returnProximoID = base.ProximoID();

            return returnProximoID;
        }

        internal int AlterarManobrista(ManobristaEntity manobristaEntity)
        {
            int returnAltararManobrista = int.MinValue;

            returnAltararManobrista = base.AltararManobrista(manobristaEntity);

            return returnAltararManobrista;
        }

        internal int IncluirManobrista(ManobristaEntity manobristaEntity)
        {
            int returnIncluirManobrista = int.MinValue;

            returnIncluirManobrista = base.IncluirManobrista(manobristaEntity);

            return returnIncluirManobrista;
        }
 

        internal int ExcluirManobrista(int idManobrista)
        {
            int returnExcluirManotrista = int.MinValue;


            returnExcluirManotrista = base.ExcluirManobrista(idManobrista);

            return returnExcluirManotrista;
        }
    }
}
