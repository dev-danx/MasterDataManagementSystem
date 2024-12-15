using Orleans;

namespace Mdm.Core;

[GenerateSerializer, Alias(nameof(Element))]
public class Element
{
    [Id(0)]
    public Guid Id { get; set; }
    [Id(1)]
    public string Name { get; set; } = string.Empty;
    [Id(2)]
    public ElementType Type { get; set; } = new();
    [Id(3)]
    public List<ElementAttribute> Attributes { get; set; } = new();
    
    public List<string> Validate()
    {
        var errors = new List<string>();
        if (string.IsNullOrWhiteSpace(Name))
        {
            errors.Add("Name is required");
        }
        errors.AddRange(from attribute in Attributes where !attribute.Validate() select $"Attribute: {attribute.Name} - {attribute.Value} is invalid");
        return errors;
    }
}