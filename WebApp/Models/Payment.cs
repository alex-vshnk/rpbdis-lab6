using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class Payment
    {
        public int Id { get; set; }
        [Display(Name = "Дата")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [Display(Name = "Сумма")]
        public double Amount { get; set; }
        [Display(Name = "Слушатель")]
        public int ListenerId { get; set; }
        [Display(Name = "Назначение")]
        public int PurposeId { get; set; }
        [Display(Name = "Слушатель")]
        public Listener? Listener { get; set; }
        [Display(Name = "Назначение")]
        public Purpose? Purpose { get; set; }
    }
}
