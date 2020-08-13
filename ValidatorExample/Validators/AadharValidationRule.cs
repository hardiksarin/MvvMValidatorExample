using System.Globalization;
using System.Windows.Controls;

using Microsoft.AspNetCore.SignalR;
using System;
using System.Globalization;
using System.Text;
using System.Windows.Controls;
using System.Linq;

namespace ValidatorExample.Validators
{
    class AadharValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string v = value as string;
            if (IsAadharValid.validateVerhoeff(v))
            {
                return (new ValidationResult(true, $"Valid Aadhar, yesssssss!"));

            }

            else
            {
                return new ValidationResult(false, $"InValid Aadhar!");

            }

        }
    }
}
