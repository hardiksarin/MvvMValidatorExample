using Caliburn.Micro;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Text;
namespace ValidatorExample.ViewModels
{
    public class ShellViewModel :Screen
    {

        private string _firstName ;

        public string FirstName
        {
            get {

                return _firstName; 
               
                }
            set {
                
                _firstName = value;
                NotifyOfPropertyChange(() => FirstName);
                

            }

        }

    }
}
