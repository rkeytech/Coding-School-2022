using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Blazor.Shared
{
    public class TransactionLineListViewModel
    {
        public uint ID { get; set; }
        public string Item { get; set; }
        public double Quantity { get; set; }
        public double ItemPrice { get; set; }
        public float DiscountPercent { get; set; }
        public double TotalValue { get; set; }
    }
    
    public class TransactionLineCreateViewModel
    {
        public uint ID { get; set; }
        public uint ItemID { get; set; }
        public double Quantity { get; set; }
        public float DiscountPercent { get; set; }
        public List<string> Messages { get; set; } = new();

    }
}
