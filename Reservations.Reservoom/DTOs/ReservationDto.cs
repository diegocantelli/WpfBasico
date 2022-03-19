using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations.Reservoom.DTOs
{
    public class ReservationDto
    {
        public Guid Id { get; set; }
        public int FloorNumber { get; set; }
        public int RoomNumber { get; set; }
        public string UserNumber { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
