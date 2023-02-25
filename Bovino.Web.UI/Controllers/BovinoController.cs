using Bovino.Application.Service;
using Bovino.Web.UI.Enums;
using Bovino.Web.UI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Bovino.Web.UI.Controllers
{
    public class BovinoController : Controller
    {
        private readonly IBovinoService _bovinoService;

        public BovinoController(IBovinoService bovinoService)
        {
            _bovinoService = bovinoService;
        }

        public IActionResult Index()
        {
            var retorno = _bovinoService.RecuperaBovinos();
            var viewModel = new List<BovinoViewModel>();

            if (retorno != null)
            { 
                foreach(var ret in retorno)
                {
                    viewModel.Add(new BovinoViewModel
                    {
                        Brinco = ret.Brinco,
                        BrincoMae = ret.BrincoMae,
                        BrincoPai = ret.BrincoPai,
                        DataNascimento = ret.DataNascimento,
                        Nome = ret.Nome,
                        Raca = (Raca)Convert.ToInt16(ret.Raca),
                        Sexo = ret.Sexo == "F" ? Sexo.FEMEA : Sexo.MACHO,
                        Situacao = (Situacao)Convert.ToInt16(ret.Situacao),
                        DataPrenhe = ret.DataPrenhes,
                        DataProxNasc = ret.DataProximoParto,
                        DataUltimoParto = ret.DataUltimoParto
                    });
                }
            }

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Create() 
        {
            return View(new BovinoViewModel()); 
        }

        [HttpPost]
        public IActionResult Create(BovinoViewModel viewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var bovino = _bovinoService.CadastroBovino(new Bovino.Models.Entities.BovinoModel
                    {
                        Brinco = viewModel.Brinco,
                        BrincoMae = viewModel.BrincoMae,
                        BrincoPai = viewModel.BrincoPai,
                        DataNascimento = viewModel.DataNascimento,
                        Nome = viewModel.Nome,
                        Raca = ((int)viewModel.Raca).ToString(),
                        Sexo = viewModel.Sexo == Enums.Sexo.FEMEA ? "F" : "M",
                        Situacao = ((int)viewModel.Situacao).ToString(),
                        DataPrenhes = viewModel.DataPrenhe,
                        DataProximoParto = viewModel.DataProxNasc,
                        DataUltimoParto = viewModel.DataUltimoParto
                    });

                    if(bovino.Id > 0)
                    {
                        AddSuccess("Bovino cadastrado com sucesso");

                        RedirectToAction("Index");
                    }
                    else
                    {
                        AddError("Algo inesperado aconteceu");
                    }
                }
            }
            catch (Exception e)
            {
                AddError("Não foi possivel concluir a operação.");     
            }

            return View(viewModel);
        }

        /// <summary>
        /// 
        /// </summary>
        public void AddError(string error)
        {
            TempData["success"] = null;
            TempData["error"] = error;
        }

        /// <summary>
        /// 
        /// </summary>
        public void AddSuccess(string sucess)
        {
            TempData["success"] = sucess;
            TempData["error"] = null;
        }
    }
}
