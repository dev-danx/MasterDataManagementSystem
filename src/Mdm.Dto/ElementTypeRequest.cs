using System;

namespace Mdm.Dto;

public class ElementTypeRequest
{
    public Guid? Id { get; set; }
    public string Name { get; set; } = string.Empty;
}