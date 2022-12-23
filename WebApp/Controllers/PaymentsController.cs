using WebApplication.Data;
using WebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.ViewModels;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    public class PaymentsController : ControllerBase
    {
        private readonly LanguageClassesContext _context;
        public PaymentsController(LanguageClassesContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Produces("application/json")]
        public List<PaymentViewModel> Get()
        {
            IQueryable <Payment> Payments = 
                _context.Payments.Include(a => a.Listener).Include(a => a.Purpose);
            IQueryable<PaymentViewModel> accRecs = Payments.Select(a => new PaymentViewModel
            {
                Id = a.Id,
                ListenerId = a.ListenerId,
                PurposeId = a.PurposeId,
                ListenerFIO = a.Listener.Surname + " " + a.Listener.FirstName + " " + a.Listener.Patronymic,
                PurposeName = a.Purpose.PurposeName,
                Date = a.Date,
                Amount = a.Amount
            });
            return accRecs.ToList();
        }

        [HttpGet("FilteredPayments")]
        [Produces("application/json")]
        public List<PaymentViewModel> GetFilteredPayments(int ListenerId, int PurposeId)
        {
            IQueryable<Payment> Payments =
                _context.Payments.Include(a => a.Listener).Include(a => a.Purpose);
            IQueryable<PaymentViewModel> accRecs = Payments.Select(a => new PaymentViewModel
            {
                Id = a.Id,
                ListenerId = a.ListenerId,
                PurposeId = a.PurposeId,
                ListenerFIO = a.Listener.Surname + " " + a.Listener.FirstName + " " + a.Listener.Patronymic,
                PurposeName = a.Purpose.PurposeName,
                Date = a.Date,
                Amount = a.Amount
            });
            if (ListenerId > 0)
            {
                accRecs = accRecs.Where(a => a.ListenerId == ListenerId);

            }
            if (PurposeId > 0)
            {
                accRecs = accRecs.Where(a => a.PurposeId == PurposeId);

            }
            return accRecs.ToList();
        }

        [HttpGet("Purposes")]
        [Produces("application/json")]
        public IEnumerable<Purpose> GetPurposes()
        {
            return _context.Purposes.ToList();
        }

        [HttpGet("Listeners")]
        [Produces("application/json")]
        public IEnumerable<Listener> GetListeners()
        {
            return _context.Listeners.ToList();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Payment Payment = _context.Payments.FirstOrDefault(x => x.Id == id);
            if (Payment == null)
                return NotFound();
            return new ObjectResult(Payment);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Payment Payment)
        {
            if (Payment == null)
            {
                return BadRequest();
            }

            _context.Payments.Add(Payment);
            _context.SaveChanges();
            return Ok(Payment);
        }

        [HttpPut]
        public IActionResult Put([FromBody] Payment Payment)
        {
            if (Payment == null)
            {
                return BadRequest();
            }
            if (!_context.Payments.Any(x => x.Id == Payment.Id))
            {
                return NotFound();
            }

            _context.Update(Payment);
            _context.SaveChanges();
            return Ok(Payment);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Payment Payment = _context.Payments.FirstOrDefault(x => x.Id == id);
            if (Payment == null)
            {
                return NotFound();
            }
            _context.Payments.Remove(Payment);
            _context.SaveChanges();
            return Ok(Payment);
        }
    }
}
