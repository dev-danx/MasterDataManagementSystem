using Mdm.Core;
using Mdm.Dto;

namespace Mdm.API;

public static class Mapper
{
    public static Element Map(ElementRequest request)
    {
        return new Element
        {
            Name = request.Name,
            Attributes = request.Attributes.Select(x => new ElementAttribute
            {
                Name = x.Name,
                Value = x.Value,
            }).ToList()
        };
    }

    public static string ElementKey(ElementRequest element)
    {
        return $"{element.Name}-{element.TypeId}";
    }
}