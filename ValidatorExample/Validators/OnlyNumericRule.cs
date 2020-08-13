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
   public class OnlyNumericRule : ValidationRule
    {

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            int R;
           string v = value as string;
            if (v.All(char.IsDigit))
            {
                return (new ValidationResult(true, null));

                             }

            else 
            {
                return new ValidationResult(false, $"Please Enter Numeric Charcters!");

            }

        }

     
    }
}
