using Orleans;

namespace Mdm.Core;

[GenerateSerializer, Alias(nameof(ElementType))]
public class ElementType
{
    [Id(0)]
    public Guid Id { get; set; }
    [Id(1)]
    public string Name { get; set; }
    [Id(2)]    
    public DateTimeOffset CreatedAt { get; set; }
    [Id(3)]
    public DateTimeOffset? UpdatedAt { get; set; }
}