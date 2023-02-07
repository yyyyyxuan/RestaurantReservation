using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Shared.Domain
{
    public class SpotlightItem : BaseDomainModel, IValidatableObject
    {
        public virtual Spotlight Spotlight { get; set; }
        public int SpotlightId { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public int RestaurantId { get; set; }
        public DateTime ExpireDate { get; set; } = DateTime.Now;
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //throw new NotImplementedException();
            if (ExpireDate < DateTime.Now.AddDays(1))
            {
                yield return new ValidationResult("Date must be after today and last for more than a day", new[] { "ReservationDate" });
            }
       
        }
    }
}