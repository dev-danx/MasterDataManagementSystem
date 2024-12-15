using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mdm.Infrastructure.Entities;

[Table("ElementType")]
public class ElementTypeEntity
{
    [Key]
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
}