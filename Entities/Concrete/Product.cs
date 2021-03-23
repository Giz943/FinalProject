using System;

namespace Entities.Concrete
{
    public class Product : Core.Entities.IEntity //Public:Bu clasa diğerleride ulaşabilsin.
    {

        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }

    }
}
