using System;

namespace HotellSavajBooking
{
    /// <summary>
    /// Class written by Radovan Mojsovski 
    /// 
    /// The class is a container class that holds a specific booking. It contains
    /// a start date, end date and a Room object. 
    /// </summary>
    public class Booking
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private Room _room;

        /// <summary>
        /// Constructor for the Booking class that takes a start and end date and
        /// a Room object.
        /// </summary>
        /// <param name="startDate">the start date</param>
        /// <param name="endDate">the end date</param>
        /// <param name="room">the Room object for the booking</param>
        public Booking(DateTime startDate, DateTime endDate, Room room)
        {
            _startTime = startDate;
            _endTime = endDate;
            _room = room;
        }

        /// <summary>
        /// Property for the start date.
        /// </summary>
        public DateTime Startime
        {
            get { return _startTime; }
            set { _startTime = value; }
        }

        /// <summary>
        /// Property for the end date.
        /// </summary>
        public DateTime EndTime
        {
            get { return _endTime; }
            set { _endTime = value; }
        }

        /// <summary>
        /// Property for the Room object.
        /// </summary>
        public Room BookedRoom
        {
            get { return _room; }
            set { _room = value; }
        }
    }
}