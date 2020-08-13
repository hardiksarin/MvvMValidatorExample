using Microsoft.AspNetCore.SignalR;
using System;
using System.Globalization;
using System.Text;
using System.Windows.Controls;

namespace ValidatorExample
{
 public class MinimumCharacterRule :ValidationRule
    {
       public int MinimumCharacters { get; set; } 
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            

                string inputString = value as string;
                if (inputString.Length < MinimumCharacters)
                {
                    return new ValidationResult(false, $"Please Enter Minimum {MinimumCharacters} Characters!");

                }
                return (new ValidationResult(true, null));
            
        }
    }
}
