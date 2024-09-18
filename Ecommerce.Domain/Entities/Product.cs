using Ecommerce.Domain.Common;

namespace Ecommerce.Domain.Entities
{
    public class Product : BaseAuditableEntity
    {
        public string Code { get; set; } = "";
        public string Name { get; set; } = string.Empty;
        public string? NameKh {  get; set; } 
        public double? Price { get; set; }
        public int? Qty { get; set; }
        public string? Description { get; set; }
    }
}
