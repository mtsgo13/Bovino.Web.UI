
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Bovino.Models.Entities
{
    public class BovinoModel : BaseModel
    {
        public string Nome { get; set; }
        public string Brinco { get; set; }
        public string Situacao { get; set; }
        public string Sexo { get; set; }
        public string? BrincoMae { get; set; }
        public string? BrincoPai { get; set; }
        public string Raca { get; set; }
        public DateTime? DataNascimento { get; set; }
        public DateTime? DataPrenhes { get; set; }
        public DateTime? DataProximoParto { get; set; }
        public DateTime? DataUltimoParto { get; set; }
    }
}
