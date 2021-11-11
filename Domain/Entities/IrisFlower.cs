using Domain.Common;
namespace Domain.Entities
{
    public class IrisFlower : BaseEntity
    {
        public string Class { get; set; }
        public decimal SepalLength { get; set; }
        public decimal SepalWidth { get; set; }
        public decimal PetalLength { get; set; }
        public decimal PetalWidth { get; set; }
        
    }
}
