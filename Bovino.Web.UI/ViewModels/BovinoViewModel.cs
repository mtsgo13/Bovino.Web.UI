using Bovino.Application.Service;
using Bovino.Models;
using Bovino.Web.UI.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bovino.Web.UI.ViewModels
{
    public class BovinoViewModel : BaseViewModel, IValidatableObject
    {
        [DisplayName("Nome")]
        [StringLength(20, ErrorMessage = "O campo deve ter no máximo 20 caracteres")]
        [Required(ErrorMessage ="O campo é obrigatório")]
        public string Nome { get; set; }
        [DisplayName("Brinco")]
        [StringLength(8, ErrorMessage = "O campo deve ter no máximo 8 caracteres")]
        [Required(ErrorMessage = "O campo é obrigatório")]
        public string Brinco { get; set; }
        [DisplayName("Situação")]
        public Situacao Situacao { get; set; }
        [DisplayName("Sexo")]
        public Sexo Sexo { get; set; }
        [DisplayName("Brinco da Mãe")]
        [StringLength(8, ErrorMessage = "O campo deve ter no máximo 8 caracteres")]
        public string? BrincoMae { get; set; }
        [DisplayName("Brinco do Pai")]
        [StringLength(8, ErrorMessage = "O campo deve ter no máximo 8 caracteres")]
        public string? BrincoPai { get; set; }
        [DisplayName("Raça")]
        public Raca Raca { get; set; }
        [DisplayName("Data de Nascimento")]
        public DateTime? DataNascimento { get; set; }
        [DisplayName("Data de Prenhe")]
        public DateTime? DataPrenhe { get; set; }
        [DisplayName("Data da próxima prenhe")]
        public DateTime? DataProxNasc { get; set; }
        [DisplayName("Data do último parto")]
        public DateTime? DataUltimoParto { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var list = new List<ValidationResult>();
            if (!string.IsNullOrEmpty(Brinco) && ConfigurationHelper.GetService<IBovinoService>().VerificaBrincoBovinoExistente(Brinco, null))
            {
                AddModelError("O numero do brinco informado já está cadastrado no sistema.", nameof(BrincoPai), list);
            }
            if (!string.IsNullOrEmpty(BrincoPai) && ConfigurationHelper.GetService<IBovinoService>().VerificaBrincoBovinoExistente(BrincoPai, "M"))
            {
                AddModelError("O numero do brinco informado não corresponde a nenhum animal macho cadastrado.", nameof(BrincoPai), list);
            }
            if (!string.IsNullOrEmpty(BrincoMae) && ConfigurationHelper.GetService<IBovinoService>().VerificaBrincoBovinoExistente(BrincoMae, "F"))
            {
                AddModelError("O numero do brinco informado não corresponde a nenhum animal femea cadastrado.", nameof(BrincoPai), list);
            }

            return list;
        }
    }
}
