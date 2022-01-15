using Microsoft.OData.Edm;
using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace lab2.Models
{

    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class FormModel
    {
        [Display(Name = "Nazwa elementu")]
        public string Name { get; set; }
        [Display(Name = "date of birth")]
        [DataType(DataType.Date)]
        public DateTime date_of_birth { get; set; }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}