using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class Course
    {
        public Course()
        {
            EmployeesCourses = new List<EmployeesCourse>();
            ListenersCourses = new List<ListenersCourse>();
        }

        public int Id { get; set; }
        [Display(Name = "Название курса")]
        public string Name { get; set; }
        [Display(Name = "Программа")]
        public string Program { get; set; }
        [Display(Name = "Описание")]
        public string Description { get; set; }
        [Display(Name = "Интенсивность")]
        public int Intensity { get; set; }
        [Display(Name = "Размер группы")]
        public int GroupSize { get; set; }
        [Display(Name = "Количество свободных мест")]
        public int VacanciesNumber { get; set; }
        [Display(Name = "Количество часов")]
        public int HoursNumber { get; set; }
        [Display(Name = "Стоимость")]
        public double Cost { get; set; }

        public ICollection<EmployeesCourse> EmployeesCourses { get; set; }
        public ICollection<ListenersCourse> ListenersCourses { get; set; }
    }
}
