using System;
using System.Linq;
using System.Reflection;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MvcApp.TagHelpers
{
    public class EnumTextTagHelper : TagHelper
    {
        private readonly IModelMetadataProvider _metadataProvider;

        public EnumTextTagHelper(IModelMetadataProvider metadataProvider)
        {
            _metadataProvider = metadataProvider;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = string.Empty;
            output.Content.SetContent(GetValueName(Value));
        }

        private string GetValueName(object value)
        {
            if (value == null || !value.GetType().GetTypeInfo().IsEnum)
            {
                return string.Empty;
            }
            ModelMetadata metadataForType = _metadataProvider.GetMetadataForType(value.GetType());
            var names = metadataForType.EnumGroupedDisplayNamesAndValues;

            var iValue = (int)Enum.ToObject(value.GetType(), value);
            var item = names?.FirstOrDefault(p => p.Value == iValue.ToString());
            return item != null ? item.Value.Key.Name : value.ToString();
        }

        public object Value { get; set; }
    }
}