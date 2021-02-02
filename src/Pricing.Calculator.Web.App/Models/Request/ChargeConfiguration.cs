using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;
using System.Linq;
using Pricing.Calculator.Web.App.ApiClients.CalculatorClient.Models;

namespace Pricing.Calculator.Web.App.Models.Request
{
    public class ChargeConfiguration
    {
        public List<(bool selected, string name)> DeminimisBaseCharges = new() { (true, "Item"), (false, "Delivery") };

        public List<(bool selected, string name)> BaseCharges = new() { (true, "Item"), (true, "Delivery"), (false, "Duty"), (false, "Vat") };

        [Required] public string Name { get; set; } = string.Empty;

        [Required] public decimal Rate { get; set; }

        [Required] public decimal FixedValue { get; set; }

        [Required] public decimal DeminimisThreshold { get; set; }

        [Required] public bool Enabled { get; set; } = true;

        [Required] public ChargeType ChargeType { get; set; } = ChargeType.ValueBased;

        public static ChargeConfiguration MapFrom (ChargeConfigurationResponseDto source)
        {
            var tt = new ChargeConfiguration ();

            Request.ChargeType t;
            Request.ChargeType.TryParse (source.ChargeType, out t);

            tt.ChargeType = t;
            tt.DeminimisThreshold = (decimal)(source.Deminimis?.Threshold?.Value ?? 0);
            tt.Name = source.Name;
            tt.FixedValue = (decimal) (source.FixedChargeAmount?.Value ?? 0);
            tt.Rate = (decimal) (source.Rate ?? 0);
            tt.BaseCharges =  source.BaseChargeNames.Select(x => (false, x)).ToList();
            tt.Enabled = true;
            return tt;
        }
    }
}