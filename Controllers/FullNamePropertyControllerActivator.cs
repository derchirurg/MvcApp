using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Internal;

namespace MvcApp.Controllers
{
    public class FullNamePropertyControllerActivator : IControllerPropertyActivator
    {
        public void Activate(ControllerContext context, object controller)
        {
            foreach (var propertyInfo in GetPropertiesToActivate(controller.GetType()))
            {
                propertyInfo.SetValue(controller, "Hans Wurst");
            }   
        }

        private IEnumerable<PropertyInfo> GetPropertiesToActivate(Type type)
        {

            return type.GetProperties().Where(s => s.Name == "FullName" && s.PropertyType == typeof(string));
        }
    }
}