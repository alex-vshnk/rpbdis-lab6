using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class Purpose
    {
        public Purpose()
        {
            Payments = new List<Payment>();
        }

        public int Id { get; set; }
        [Display(Name = "Назначение")]
        public string PurposeName { get; set; }

        public ICollection<Payment> Payments { get; set; }
    }
}
