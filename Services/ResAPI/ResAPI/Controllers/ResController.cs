﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResAPI.Infrastructure;
using ResAPI.Models;

namespace ResAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResController : ControllerBase
    {
        private readonly IReservationService reservationService;

        public ResController(IReservationService reservationService)
        {
            this.reservationService = reservationService;
        }

        [HttpGet("{id}")]
        public ReservationDTO Reservation(int id)
        {
            return reservationService.GetReservationById(id);
        }
    }
}
