using ResAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResAPI.Infrastructure
{
    public interface IReservationService
    {
        ReservationDTO GetReservationById(int reservationId);
    }
}
