using Bovino.Application.Contexts;
using Bovino.Models;
using Bovino.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace Bovino.Application.Service
{
    public class BovinoService : IBovinoService
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public BovinoService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public BovinoModel CadastroBovino(BovinoModel bovinoModel)
        {
            _applicationDbContext.Add(bovinoModel);

            _applicationDbContext.SaveChanges();
            return bovinoModel;
        }

        public bool VerificaBrincoBovinoExistente(string brinco, string sexo)
        {
            var bovino = _applicationDbContext.Set<BovinoModel>()?.Where(b => b.Brinco == brinco && (sexo == null || b.Sexo == sexo)).FirstOrDefault();
            return bovino != null;
        }

        public List<BovinoModel> RecuperaBovinos()
        {
            return _applicationDbContext.Set<BovinoModel>()?.ToList();
        }
    }
}
