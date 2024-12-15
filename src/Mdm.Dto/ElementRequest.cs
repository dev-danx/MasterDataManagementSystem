using System.Collections.Generic;

namespace Mdm.Dto
{
    public class ElementRequest
    {
        public long? Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public long TypeId { get; set; }
        public List<ElementRequestAttribute>? Attributes { get; set; }
        
    }
    
    public class ElementRequestAttribute
    {
        public string Name { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
        public ElementAttributeType Type { get; set; }
    }
    
    public enum ElementAttributeType
    {
        Number,
        Text
    }
}