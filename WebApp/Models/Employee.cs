using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class Employee
    {
        public Employee()
        {
            EmployeesCourses = new List<EmployeesCourse>();
        }

        public int Id { get; set; }
        [Display(Name = "Фамилия")]
        public string Surname { get; set; }
        [Display(Name = "Имя")]
        public string FirstName { get; set; }
        [Display(Name = "Отчество")]
        public string Patronymic { get; set; }
        [Display(Name = "Образование")]
        public string Education { get; set; }
        [Display(Name = "Должность")]
        public int PositionId { get; set; }
        [Display(Name = "Должность")]
        public Position? Position { get; set; }
        public ICollection<EmployeesCourse> EmployeesCourses { get; set; }
    }
}
