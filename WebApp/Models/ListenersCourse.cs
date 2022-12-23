using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class ListenersCourse
    {
        public int Id { get; set; }
        [Display(Name = "Курс")]
        public int CourseId { get; set; }
        [Display(Name = "Слушатель")]
        public int ListenerId { get; set; }
        [Display(Name = "Курс")]
        public Course? Course { get; set; }
        [Display(Name = "Слушатель")]
        public Listener? Listener { get; set; }
    }
}
