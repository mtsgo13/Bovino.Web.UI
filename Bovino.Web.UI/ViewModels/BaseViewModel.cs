using System.ComponentModel.DataAnnotations;

namespace Bovino.Web.UI.ViewModels
{
    public class BaseViewModel
    {
        public int? Id { get; set; }

        public void AddModelError(string message, string nomeMembro, List<ValidationResult> validationResults)
        {
            validationResults.Add(new ValidationResult(message, new List<string>() { nomeMembro }));
        }
    }
}
