using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.UseCasesDTOs.CreateOrder
{
    public class CreateOrderParams
    {
        public String CustomerId { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipCountry { get; set; }
        public string ShipPostalCode { get; set;}
        public List<CreateOrderDetailParams> OrdeDetails { get; set; }
    }
}
