using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class Listener
    {
        public Listener()
        {
            ListenersCourses = new List<ListenersCourse>();
            Payments = new List<Payment>();
        }

        public int Id { get; set; }
        [Display(Name = "Фамилия")]
        public string Surname { get; set; }
        [Display(Name = "Имя")]
        public string FirstName { get; set; }
        [Display(Name = "Отчество")]
        public string Patronymic { get; set; }
        [Display(Name = "Дата рождения")]
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }
        [Display(Name = "Адрес")]
        public string Address { get; set; }
        [Display(Name = "Телефон")]
        public string Phone { get; set; }
        [Display(Name = "Номер паспорта")]
        public string PassportNumber { get; set; }

        public ICollection<ListenersCourse> ListenersCourses { get; set; }
        public ICollection<Payment> Payments { get; set; }
    }
}
