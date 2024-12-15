using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Mdm.Core;

namespace Mdm.Infrastructure.Entities;

[Table("ElementAttribute")]
public class ElementAttributeEntity
{
    [Key]
    public long Id { get; set; }
    public string Value { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }

    public ElementAttribute ToModel()
    {
        return new ElementAttribute()
        {
            Type = Enum.Parse<ElementAttributeType>(Type),
            Value = Value
        };
    }
    
    public static ElementAttributeEntity FromModel(ElementAttribute model)
    {
        return new ElementAttributeEntity()
        {
            Type = model.Type.ToString(),
            Value = model.Value
        };
    }
}