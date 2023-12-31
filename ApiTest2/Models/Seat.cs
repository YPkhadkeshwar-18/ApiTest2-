﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApiTest2.Models
{
    public partial class Seat
    {
        public int SeatNo { get; set; }
        public int BookingId { get; set; }
        public int BusId { get; set; }
        public string Seatid { get; set; }

        public virtual Booking Booking { get; set; }
    }
}
