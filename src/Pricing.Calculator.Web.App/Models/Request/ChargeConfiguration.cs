using Pricing.Calculator.Web.App.ApiClients.CalculatorClient.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

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
            tt.BaseCharges =  source.BaseChargeNames.Select(x => (true, x)).ToList();
            tt.Enabled = true;
            return tt;
        }

        public static ChargeConfigurationDto MapTo(ChargeConfiguration source)
        {
            var tt = new ChargeConfigurationDto(source.ChargeType.ToString(),
                source.Name,
                rate: Convert.ToDouble(source.Rate),
                baseChargeNames: source.BaseCharges.Where(x => x.selected).Select(x => x.name).ToList(),
                deminimis: new DeminimisDto(new PriceDto(Convert.ToDouble(source.DeminimisThreshold), "EUR"), true) 
            );

            return tt;
        }
    }
}