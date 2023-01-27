using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Shared.Domain
{
    public class Reservation : BaseDomainModel, IValidatableObject
    {
        [Required]
        public string TimeSlot { get; set; }
        [Required]
        public string Pax { get; set; }
        public DateTime  ReservationDate { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public int RestaurantId { get; set; }
        public string RestaurantName { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //throw new NotImplementedException();
            if (ReservationDate < DateTime.Today)
            {
                yield return new ValidationResult("Date must be after today",new[] { "ReservationDate" });
            }
        }
    }
}
