﻿using System.ComponentModel.DataAnnotations;

namespace Pricing.Calculator.Web.App.Models.Request
{
    public class Price
    {
        public string CurrencyIso => "EUR";

        [Required, Range(0, double.MaxValue, ErrorMessage = "The {0} field must have a value greater than 0.")]
        public decimal Value { get; set; } = 0;
    }
}
