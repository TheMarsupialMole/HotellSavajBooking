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
        private string _firstName;
        private string _lastName;
        private int _roomId;
        private bool _wakeUp;
        private DateTime _wakeTime;


        public Booking(DateTime startDate, DateTime endDate, string firstName, string lastName, int roomId, bool wakeUp, DateTime wakeTime)
        {
            _startTime = startDate;
            _endTime = endDate;
            _firstName = firstName;
            _lastName = lastName;
            _roomId = roomId;
            _wakeUp = wakeUp;
            _wakeTime = wakeTime;
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
        /// Property for the first name
        /// </summary>
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        /// <summary>
        /// Property for the last name
        /// </summary>
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        /// <summary>
        /// Property for the Room object.
        /// </summary>
        public int BookedId
        {
            get { return _roomId; }
            set { _roomId = value; }
        }

        /// <summary>
        /// Property for the wake up boolean
        /// </summary>
        public bool WakeUp
        {
            get { return _wakeUp; }
            set { _wakeUp = value; }
        }

        /// <summary>
        /// Property for the wakeup time
        /// </summary>
        public DateTime WakeTime
        {
            get { return _wakeTime; }
            set { _wakeTime = value; }
        }
    }
}