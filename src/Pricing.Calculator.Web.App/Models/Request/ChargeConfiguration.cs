using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pricing.Calculator.Web.App.Models.Request
{
    public class ChargeConfiguration
    {
        public List<(bool selected, string name)> DeminimisBaseCharges = new() { (true, "Item"), (false, "Delivery") };

        public List<(bool selected, string name)> BaseCharges = new() { (true, "Item"), (true, "Delivery"), (false, "Duty"), (false, "Vat") };

        [Required] public string Name { get; set; }

        [Required] public decimal Rate { get; set; }

        [Required] public decimal FixedValue { get; set; }

        [Required] public decimal DeminimisThreshold { get; set; }

        [Required] public bool Enabled { get; set; } = true;

        [Required] public ChargeType ChargeType { get; set; } = ChargeType.ValueBased;
    }
}