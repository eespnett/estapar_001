using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationEstapar.Data.Estapar;
using WebApplicationEstapar.Estapar.Entity;

namespace WebApplicationEstapar.Business.Estapar
{
    public class ClassificacaoBusiness:ClassificacaoData
    {
        internal List<ClassificacaoEntity> ListarClassificacoes()
        {
            List<ClassificacaoEntity> myListClassificacaoEntity = new List<ClassificacaoEntity>();

            myListClassificacaoEntity = base.ListarClassificacoes();


            return myListClassificacaoEntity;
        }

        internal ClassificacaoEntity SelecionarClassificacao(ClassificacaoEntity oClassificacao)
        {
            ClassificacaoEntity returnClassificacaoEntity = new ClassificacaoEntity();

            returnClassificacaoEntity = base.SelecionarClassificacao(oClassificacao);
            return returnClassificacaoEntity;    
        }

        internal int ProximoID()
        {
            int returnProximoID = int.MinValue;

            returnProximoID = base.ProximoID();


            return returnProximoID;
        }

        internal int IncluirClassificacao(ClassificacaoEntity myClassificacaoEntity)
        {
            int returnIncluirClassificacao = int.MinValue;

            returnIncluirClassificacao = base.IncluirClassificacao(myClassificacaoEntity);

            return returnIncluirClassificacao;
        }

        internal int AlterarClassificacao(ClassificacaoEntity myClassificacaoEntity)
        {
            int returnAlterarClassificacao = int.MinValue;

            returnAlterarClassificacao = base.AlterarClassificacao(myClassificacaoEntity);

            return returnAlterarClassificacao;
        }

        internal int ExcluirClassificacao(int id)
        {
            int returnExcluirClassificacao = int.MinValue;

            returnExcluirClassificacao = base.ExcluirClassificacao(id);

            return returnExcluirClassificacao;
        }
    }
}
