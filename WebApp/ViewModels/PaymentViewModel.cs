using System.ComponentModel.DataAnnotations;
using WebApplication.Models;

namespace WebApplication.ViewModels
{
    public class PaymentViewModel
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
        public string ListenerFIO { get; set; }
        [Display(Name = "Назначение")]
        public string PurposeName { get; set; }
    }
}
