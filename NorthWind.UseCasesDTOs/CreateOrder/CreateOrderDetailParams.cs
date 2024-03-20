using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.UseCasesDTOs.CreateOrder
{
    public class CreateOrderDetailParams
    {
        public int ProducId { get; set; }
        public decimal UniPrice { get; set; }
        public short Quantity { get; set; }
    }
}
