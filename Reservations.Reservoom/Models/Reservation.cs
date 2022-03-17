using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations.Reservoom.Models
{
    public class Reservation
    {
        public RoomID RoomID { get; set; }
        public string UserName { get; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }


        public TimeSpan Length => EndTime.Subtract(StartTime);

        public Reservation(RoomID roomID, DateTime startTime, DateTime endTime, string userName)
        {
            RoomID = roomID;
            StartTime = startTime;
            EndTime = endTime;
            UserName = userName;
        }

        public bool Conflict(Reservation reservation)
        {
            if (reservation.RoomID != RoomID) return false;

            return reservation.StartTime < EndTime && reservation.EndTime > StartTime;
        }
    }
}
