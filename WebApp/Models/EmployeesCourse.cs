using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class EmployeesCourse
    {
        public int Id { get; set; }
        [Display(Name = "Курс")]
        public int CourseId { get; set; }
        [Display(Name = "Сотрудник")]
        public int EmployeeId { get; set; }
        [Display(Name = "Курс")]
        public Course? Course { get; set; }
        [Display(Name = "Сотрудник")]
        public Employee? Employee { get; set; }
    }
}
