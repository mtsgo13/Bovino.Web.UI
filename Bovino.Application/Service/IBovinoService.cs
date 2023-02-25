using Bovino.Models.Entities;

namespace Bovino.Application.Service
{
    public interface IBovinoService
    {
        BovinoModel CadastroBovino(BovinoModel bovinoModel);
        List<BovinoModel> RecuperaBovinos();
        bool VerificaBrincoBovinoExistente(string brinco, string sexo);
    }
}