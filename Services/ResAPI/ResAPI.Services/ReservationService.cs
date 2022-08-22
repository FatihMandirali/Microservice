using ResAPI.Infrastructure;
using ResAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResAPI.Services
{
    public class ReservationService : IReservationService
    {
        public ReservationDTO GetReservationById(int reservationId)
        {
            return new ReservationDTO {Amount = 3, BkgDate= DateTime.Now, BkgNumber="deneme", CheckinDate=DateTime.Now,CheckoutDate=DateTime.Now, Id= reservationId };
        }
    }
}
