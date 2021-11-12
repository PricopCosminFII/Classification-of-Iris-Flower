﻿using Domain.Common;
namespace Domain.Entities
{
    public class IrisFlower : BaseEntity
    {
        
        public decimal SepalLength { get; set; }
        public decimal SepalWidth { get; set; }
        public decimal PetalLength { get; set; }
        public decimal PetalWidth { get; set; }

        public string Class { get; set; }
    }
}
