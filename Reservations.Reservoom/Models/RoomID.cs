using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations.Reservoom.Models
{
    public class RoomID
    {
        public int FloorNumber { get; }
        public int RoomNumber { get; }

        public RoomID(int floorNumber, int roomNumber)
        {
            FloorNumber = floorNumber;
            RoomNumber = roomNumber;
        }

        public override bool Equals(object obj)
        {
            if (obj is RoomID)
            {
                return FloorNumber == ((RoomID)obj).FloorNumber &&
                    RoomNumber == ((RoomID)obj).RoomNumber;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FloorNumber, RoomNumber);
        }

        public static bool operator ==(RoomID roomID1, RoomID roomID2)
        {
            if (roomID1 == null && roomID2 == null) return true;

            return roomID1 != null && roomID1.Equals(roomID2);
        }
    }
}
