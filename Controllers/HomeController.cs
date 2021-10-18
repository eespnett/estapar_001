using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationEstapar.Business.Estapar;
using WebApplicationEstapar.Estapar.Entity;
using WebApplicationEstapar.Models;

namespace WebApplicationEstapar.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }


        public IActionResult Classificacao()
        {
            List<ClassificacaoEntity> myListEntityClassificao = new List<ClassificacaoEntity>();

            myListEntityClassificao = new ClassificacaoBusiness().ListarClassificacoes();

            ViewData["dataClassificacao"] = myListEntityClassificao;
            return View();
        }



        public IActionResult ClassificacaoCreate()
        {
            ClassificacaoModel myModel = new ClassificacaoModel();

            myModel.Id = new ClassificacaoBusiness().ProximoID();



            return View(myModel);
        }

        //ClassificacaoAlterar



        public IActionResult ExcluirClassificacao(int idClassificacao)
        {
            ClassificacaoEntity myClassificacaoEntity = new ClassificacaoBusiness().SelecionarClassificacao(new ClassificacaoEntity() { id = idClassificacao });

            int ExcluirClassificacaoCreate = int.MinValue;

            if (myClassificacaoEntity.id > 0)
            {
                ExcluirClassificacaoCreate = new ClassificacaoBusiness().ExcluirClassificacao(myClassificacaoEntity.id);

            }

            return RedirectToAction("Classificacao", "Home");
        }


        public IActionResult ClassificacaoAlterar(int idClassificacao)
        {
            ClassificacaoModel myModel = new ClassificacaoModel();

            ClassificacaoEntity omyClassificaoEntity = new ClassificacaoEntity();
            omyClassificaoEntity.id = idClassificacao;

            omyClassificaoEntity = new ClassificacaoBusiness().SelecionarClassificacao(omyClassificaoEntity);
            myModel.Descricao = omyClassificaoEntity.Descricao;
            myModel.Id = omyClassificaoEntity.id;



            return View("ClassificacaoCreate", myModel);

        }
        [HttpPost]
        public IActionResult ClassificacaoCreate(ClassificacaoModel myModel)
        {
            ClassificacaoEntity myClassificacaoEntity = new ClassificacaoEntity();
            myClassificacaoEntity.id = myModel.Id;
            myClassificacaoEntity = new ClassificacaoBusiness().SelecionarClassificacao(myClassificacaoEntity);
            int IncluirAlterarClassificacao = int.MinValue;

            if (myClassificacaoEntity.id <= 0)
            {
                myClassificacaoEntity.id = myModel.Id;
                myClassificacaoEntity.Descricao = myModel.Descricao;
                IncluirAlterarClassificacao = new ClassificacaoBusiness().IncluirClassificacao(myClassificacaoEntity);
            }
            else
            {
                myClassificacaoEntity.Descricao = myModel.Descricao;
                myClassificacaoEntity.id = myModel.Id;
                IncluirAlterarClassificacao = new ClassificacaoBusiness().AlterarClassificacao(myClassificacaoEntity);
            }



            return RedirectToAction("Classificacao", "Home");
        }



        #region Carro


        public IActionResult ExcluirCarro(int idCarro)
        {
            EntityCarro myCarro = new CarroBusiness().SelecionarCarro(new EntityCarro() { id = idCarro });

            int ExcluirCarro = int.MinValue;

            if (myCarro.id > 0)
            {
                ExcluirCarro = new CarroBusiness().ExcluirCarro(myCarro);

            }

            return RedirectToAction("Carro", "Home");
        }
        public IActionResult CarroAlterar(int idCarro)
        {
            EntityCarro myCarro = new CarroBusiness().SelecionarCarro(new EntityCarro() { id = idCarro });

            CarroModel myModel = new CarroModel();
            myModel.Id = myCarro.id;
            myModel.MarcaCarro = myCarro.MarcaCarro;
            myModel.ModeloCarro = myCarro.ModeloCarro;
            myModel.PlacaCarro = myCarro.PlacaCarro;


            return View("CarroCreate", myModel);
        }


        public IActionResult CarroCreate()
        {
            CarroModel myModel = new CarroModel();
            myModel.Id = new CarroBusiness().ProximoID();
            return View(myModel);
        }




        [HttpPost]
        public IActionResult CarroCreate(CarroModel myModel)
        {
            int intIncluirAlterarCarro = int.MinValue;

            EntityCarro myCarro = new EntityCarro();
            myCarro.id = myModel.Id;
            myCarro = new CarroBusiness().SelecionarCarro(myCarro);

            if (ModelState.IsValid)
            {

                if (myCarro.id <= 0)
                {

                    intIncluirAlterarCarro = new CarroBusiness().IncluirCarro(new EntityCarro()
                    {
                        id = myModel.Id,
                        MarcaCarro = myModel.MarcaCarro,
                        ModeloCarro = myModel.ModeloCarro,
                        PlacaCarro = myModel.PlacaCarro,

                    });
                }
                else
                {
                    intIncluirAlterarCarro = new CarroBusiness().AlterarCarro(new EntityCarro()
                    {
                        id = myModel.Id,
                        MarcaCarro = myModel.MarcaCarro,
                        ModeloCarro = myModel.ModeloCarro,
                        PlacaCarro = myModel.PlacaCarro,

                    });
                }

            }
            return RedirectToAction("Carro", "Home");
        }
        public IActionResult Carro()
        {
            List<EntityCarro> myListEntityCarro = new List<EntityCarro>();

            myListEntityCarro = new CarroBusiness().ListarCarros();

            ViewData["dataCarro"] = myListEntityCarro;
            return View();
        }

        #endregion

        #region TipoManobra


        public IActionResult ExcluirTipoManobra(int idTipoManobra)
        {
            TipoManobra myidTipoManobra = new TipoManobraBusiness().SelecionarTipoManobra(new TipoManobra() { id = idTipoManobra });

            int ExcluirmyidTipoManobra = int.MinValue;

            if (myidTipoManobra.id > 0)
            {
                ExcluirmyidTipoManobra = new TipoManobraBusiness().ExcluirTipoManobra(myidTipoManobra.id);

            }

            return RedirectToAction("TipoManobra", "Home");
        }
        public IActionResult TipoManobraAlterar(int idTipoManobra)
        {
            TipoManobra myTipoManobra = new TipoManobraBusiness().SelecionarTipoManobra(new TipoManobra() { id = idTipoManobra });

            TipoManobraModel myModel = new TipoManobraModel();
            myModel.Id = myTipoManobra.id;
            myModel.TipoManobra = myTipoManobra._TipoManobra;


            return View("TipoManobraCreate", myModel);
        }

        public IActionResult TipoManobraCreate()
        {
            TipoManobraModel myModel = new TipoManobraModel();
            myModel.Id = new TipoManobraBusiness().ProximoID();



            return View(myModel);
        }

        [HttpPost]
        public IActionResult TipoManobraCreate(TipoManobraModel myModel)
        {
            TipoManobra myTipoManobra = new TipoManobra();
            int intIncluirAlterar = int.MinValue;
            myTipoManobra = new TipoManobraBusiness().SelecionarTipoManobra(new Estapar.Entity.TipoManobra() { id = myModel.Id });

            if (ModelState.IsValid)
            {
                if (myTipoManobra.id <= 0)
                {
                    intIncluirAlterar = new TipoManobraBusiness().IncluirTipoManobra(new TipoManobra()
                    {
                        id = myModel.Id,
                        _TipoManobra = myModel.TipoManobra
                    });
                }
                else
                {
                    intIncluirAlterar = new TipoManobraBusiness().AlterarTipoManobra(new TipoManobra()
                    {
                        id = myModel.Id,
                        _TipoManobra = myModel.TipoManobra
                    });
                }
            }



            return RedirectToAction("TipoManobra", "Home");
        }

        public IActionResult TipoManobra()
        {
            List<TipoManobra> myListEntityTipoManobra = new List<TipoManobra>();

            myListEntityTipoManobra = new TipoManobraBusiness().ListarTipoManobras();

            ViewData["dataTipoManobra"] = myListEntityTipoManobra;
            return View();
        }


        #endregion



        public IActionResult ExcluirManobrista(int idManobrista)
        {

            int ExcluirManobrista = int.MinValue;

            ExcluirManobrista = new ManobristaBusiness().ExcluirManobrista(idManobrista);

            return RedirectToAction("Manobrista", "Home");
        }
        public IActionResult ManobristaAlterar(int idManobrista)
        {
            ManobristaModel myModel = new ManobristaModel();
            ManobristaEntity oManobristaEntity = new ManobristaBusiness().SelecionarManobrista(new ManobristaEntity() { id = idManobrista });

            myModel.Id = oManobristaEntity.id;
            myModel.CPF = oManobristaEntity.CPF;
            myModel.DtNascimento = oManobristaEntity.DtNascicmento;
            myModel.Nome = oManobristaEntity.Nome;

            return View("ManobristaCreate", myModel);
        }

        public IActionResult ManobristaCreate()
        {
            ManobristaModel myModel = new ManobristaModel();
            myModel.Id = new ManobristaBusiness().ProximoID();

            return View(myModel);
        }
        [HttpPost]
        public IActionResult ManobristaCreate(ManobristaModel myModel)
        {

            ManobristaEntity ManobristaEntity = new ManobristaEntity();
            int IncluirAlterarManobrista = int.MinValue;


            ManobristaEntity = new ManobristaBusiness().SelecionarManobrista(new ManobristaEntity() { id = myModel.Id });

            if (ManobristaEntity.id <= 0)
            {
                ManobristaEntity.id = myModel.Id;
                ManobristaEntity.CPF = myModel.CPF;
                ManobristaEntity.DtNascicmento = myModel.DtNascimento;
                ManobristaEntity.Nome = myModel.Nome;

                IncluirAlterarManobrista = new ManobristaBusiness().IncluirManobrista(ManobristaEntity);
            }
            else
            {
                ManobristaEntity.id = myModel.Id;
                ManobristaEntity.CPF = myModel.CPF;
                ManobristaEntity.DtNascicmento = myModel.DtNascimento;
                ManobristaEntity.Nome = myModel.Nome;

                IncluirAlterarManobrista = new ManobristaBusiness().AlterarManobrista(ManobristaEntity);
            }
            return RedirectToAction("Manobrista", "Home");

        }

        public IActionResult Manobrista()
        {
            List<ManobristaEntity> myListEntityManobrista = new List<ManobristaEntity>();

            myListEntityManobrista = new ManobristaBusiness().ListarManobristras();

            ViewData["dataManobrista"] = myListEntityManobrista;

            return View();
        }



        public IActionResult ExcluirManbra(int idManobrista)
        {
            int ExcluirManobra = int.MinValue;
            ExcluirManobra = new ManobraBusiness().ExcluirManobra(idManobrista);


            return RedirectToAction("Manobra", "Home");

        }

        public IActionResult ManobraAlterar(int idManobrista)
        {
            ManobraModel myModel = new ManobraModel();
            myModel.oCarro = new EntityCarro();
            myModel.oClassificacao = new ClassificacaoEntity();
            myModel.oManobrista = new ManobristaEntity();
            myModel.oTipoManobra = new TipoManobra();


            ManobaEnity oManobaEnity = new ManobaEnity();
            oManobaEnity = new ManobraBusiness().SelecionarManbra(idManobrista);
            myModel.Id = oManobaEnity.Id;
            myModel.Concluido = oManobaEnity.Concluido;
            myModel.DtManobraFim = oManobaEnity.dtManobraFim;
            myModel.DtManobraInicio = oManobaEnity.dtManobraInicio;
            myModel.oCarro.id = oManobaEnity.oCarro.id;
            myModel.oClassificacao.id = oManobaEnity.oClassificacao.id;
            myModel.oManobrista.id = oManobaEnity.oManobrista.id;
            myModel.oTipoManobra.id = oManobaEnity.oTipoManobra.id;

            myModel.oListClassificacaoEntity = new ClassificacaoBusiness().ListarClassificacoes();
            myModel.oListEntityCarro = new CarroBusiness().ListarCarros();
            myModel.oListManobristaEntity = new ManobristaBusiness().ListarManobristras();
            myModel.oListTipoManobra = new TipoManobraBusiness().ListarTipoManobras();

            return View("CreateManobra", myModel);
        }

        [HttpPost]
        public IActionResult CreateManobra(ManobraModel myModel)
        {

            ManobaEnity myManobra = new ManobraBusiness().SelecionarManobra(myModel.Id);
            int IncluirAlterarManobra = int.MinValue;
            myManobra.oCarro = new EntityCarro();
            myManobra.oClassificacao = new ClassificacaoEntity();
            myManobra.oManobrista = new ManobristaEntity();
            myManobra.oTipoManobra = new TipoManobra();

            if (myManobra.Id <= 0)
            {
                myManobra.Id = myModel.Id;
                myManobra.oCarro.id = myModel.oCarro.id;
                myManobra.oClassificacao.id = myModel.oClassificacao.id;
                myManobra.oManobrista.id = myModel.oManobrista.id;
                myManobra.oTipoManobra.id = myModel.oTipoManobra.id;
                myManobra.dtManobraFim = myModel.DtManobraFim;
                myManobra.dtManobraInicio = myModel.DtManobraInicio;

                IncluirAlterarManobra = new ManobraBusiness().IncluirManobra(myManobra);
            }
            else
            {
                myManobra.Id = myModel.Id;
                myManobra.oCarro.id = myModel.oCarro.id;
                myManobra.oClassificacao.id = myModel.oClassificacao.id;
                myManobra.oManobrista.id = myModel.oManobrista.id;
                myManobra.oTipoManobra.id = myModel.oTipoManobra.id;


                IncluirAlterarManobra = new ManobraBusiness().AtualizarManobra(myManobra);
            }


            return RedirectToAction("Manobra", "Home");
        }

        public IActionResult CreateManobra()
        {
            ManobraModel myModel = new ManobraModel();
            myModel.oCarro = new EntityCarro();
            myModel.oClassificacao = new ClassificacaoEntity();
            myModel.oManobrista = new ManobristaEntity();
            myModel.oTipoManobra = new TipoManobra();


            myModel.Id = new ManobraBusiness().ProximoID();

            myModel.oListClassificacaoEntity = new ClassificacaoBusiness().ListarClassificacoes();
            myModel.oListManobristaEntity = new ManobristaBusiness().ListarManobristras();
            myModel.oListTipoManobra = new TipoManobraBusiness().ListarTipoManobras();
            myModel.oListEntityCarro = new CarroBusiness().ListarCarros();


            return View(myModel);
        }

        public IActionResult Manobra()
        {
            List<ManobaEnity> myListEntityManobaEnity = new List<ManobaEnity>();

            myListEntityManobaEnity = new ManobraBusiness().ListarManobras();

            ViewData["dataManobra"] = myListEntityManobaEnity;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
