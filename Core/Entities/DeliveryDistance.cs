using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class DeliveryDistance : BaseEntity
    {
        public int Distance {get; set; }
        public decimal Amount {get; set; }
    }
}