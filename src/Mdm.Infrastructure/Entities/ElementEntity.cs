using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Mdm.Core;

namespace Mdm.Infrastructure.Entities;

[Table("Element")]
public class ElementEntity
{
    [Key]
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public long TypeId { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
    
    public Element ToModel()
    {
        return new Element()
        {
            Id = Id,
            Name = Name,
            Type = new ElementType()
            {
                Id = TypeId
            }
        };
    }
    
    public static ElementEntity FromModel(Element model)
    {
        return new ElementEntity()
        {
            Id = model.Id,
            Name = model.Name,
            TypeId = model.Type.Id
        };
    }
}