using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationEstapar.Data.Estapar;
using WebApplicationEstapar.Estapar.Entity;

namespace WebApplicationEstapar.Business.Estapar
{
    public class ManobraBusiness: ManobraData
    {
        internal List<ManobaEnity> ListarManobras()
        {
            List<ManobaEnity> retornoListManobaEnity = new List<ManobaEnity>();

            retornoListManobaEnity = base.ListarManobras();

            foreach (var item in retornoListManobaEnity)
            {
                if (item.oCarro!=null)                
                    item.oCarro = new CarroBusiness().SelecionarCarro(item.oCarro);

                if (item.oManobrista != null)
                    item.oManobrista = new ManobristaBusiness().SelecionarManobrista(item.oManobrista);

                if (item.oTipoManobra != null)
                        item.oTipoManobra = new TipoManobraBusiness().SelecionarTipoManobrista(item.oTipoManobra);


                if (item.oClassificacao != null)
                    item.oClassificacao = new ClassificacaoBusiness().SelecionarClassificacao(item.oClassificacao);
            }

            return retornoListManobaEnity;
        }

        internal int ProximoID()
        {
            int returnProximoID = int.MinValue;

            returnProximoID = base.ProximoID();

            return returnProximoID;
        }

        internal ManobaEnity SelecionarManobra(int idManobra)
        {
            ManobaEnity returnSelecionarManabra = new ManobaEnity();


            returnSelecionarManabra = base.SelecionarManbra(idManobra);

            return returnSelecionarManabra;
        }

        internal int IncluirManobra(ManobaEnity myManobra)
        {
            int returnIncluirManobra = int.MinValue;

            returnIncluirManobra = base.IncluirManobra(myManobra);

            return returnIncluirManobra;
        }

        internal int AtualizarManobra(ManobaEnity myManobra)
        {
            int returnIncluirManobra = int.MinValue;

            returnIncluirManobra = base.AtualizarManobra(myManobra);

            return returnIncluirManobra;
        }

        internal int ExcluirManobra(int idManobrista)
        {
            int returnExcluirManobra = int.MinValue;

            returnExcluirManobra = base.ExcluirManobra(idManobrista);

            return returnExcluirManobra;
        }
    }
}
