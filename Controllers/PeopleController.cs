using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using MvcApp.ViewModel;

namespace MvcApp.Controllers
{
    public class PeopleController
    {
        [ViewDataDictionary]
        public ViewDataDictionary ViewData { get; set; }

        public IActionResult Index()
        {
            var models = new PersonModel[]
            {
                new PersonModel()
                {
                    Salutation = Salutation.Mr,
                    FirstName = "Hans",
                    LastName = "Wurst"
                },
                new PersonModel()
                {
                    Salutation = MvcApp.ViewModel.Salutation.Mr,
                    FirstName = "Peter",
                    LastName = "Müller"
                }
                ,
                new PersonModel()
                {
                    Salutation = MvcApp.ViewModel.Salutation.Ms,
                    FirstName = "Franzi",
                    LastName = "Schulz"
                }
            };

            ViewData.Model = models;

            return new ViewResult()
            {
                ViewData = ViewData
            };
        }
    }
}