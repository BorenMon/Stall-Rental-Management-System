using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;

namespace Stall_Rental_Management_System.Presenters.Common
{
    public static class ModelDataValidation
    {
        public static void Validate(object model)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(model);
            var isValid = Validator.TryValidateObject(model, context, results, true);
            if (isValid) return;
            var errorMessage = results.Aggregate("", (current, item) => current + ("- " + item.ErrorMessage + "\n"));
            MessageBox.Show(errorMessage);
            throw new Exception(errorMessage);
        }
    }
}