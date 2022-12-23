using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class Position
    {
        public Position()
        {
            Employees = new HashSet<Employee>();
        }

        public int Id { get; set; }
        [Display(Name = "Должность")]
        public string Name { get; set; }
        public override string ToString()
        {
            return (new { Код_должности = Id, Название = Name }).ToString();
        }

        public ICollection<Employee> Employees { get; set; }
    }


}
