using Orleans;

namespace Mdm.Core;

[GenerateSerializer, Alias(nameof(ElementAttribute))]
public class ElementAttribute
{
    [Id(0)]
    public string Name { get; set; } = string.Empty;
    [Id(1)]
    public string Value { get; set; } = string.Empty;
    [Id(2)]
    public ElementAttributeType Type { get; set; }

    public bool Validate()
    {
        switch (Type)
        {
            case ElementAttributeType.Number:
                return double.TryParse(Value, out _);
            case ElementAttributeType.Text:
                return !string.IsNullOrWhiteSpace(Value);
            default:
                return false;
        }
    }
}