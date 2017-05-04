using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcApp.ViewModel;

namespace MvcApp.ViewComponents
{
    public class PersonViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(PersonModel person)
        {
            return View(person);   
        }
    }
}