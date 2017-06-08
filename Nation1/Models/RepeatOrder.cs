using System.ComponentModel.DataAnnotations;

namespace Nation1.Models
{
    public class RepeatOrder
    {
        public int RepeatOrderId { get; set; }

        public string RepeatPeriod { get; set; }
        public int OrderId { get; set; }

        public string Username { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public double? UnitPrice { get; set; }

    }
}