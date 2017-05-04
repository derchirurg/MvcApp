using System.ComponentModel.DataAnnotations;

namespace MvcApp.ViewModel
{
    public enum Salutation
    {
        [Display(Name = "Unbekannt")]
        Unknown,
        [Display(Name = "Herr")]
        Mr,
        [Display(Name = "Frau")]
        Ms
    }
}