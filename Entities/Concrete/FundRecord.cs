using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class FundRecord : IEntity
    {
        public int Id { get; set; }
        public int FundId { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
