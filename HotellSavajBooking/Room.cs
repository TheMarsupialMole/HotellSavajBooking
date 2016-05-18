using System;

namespace HotellSavajBooking
{
    /// <summary>
    /// Class written by Radovan Mojsovski 
    /// 
    /// A Container class that represents the Rooms at the hotel. Each object
    /// contains a room id, a room type, a wakeuptime and a boolean of the room has
    /// a minibar.
    /// </summary>
    public class Room
    {
        // Variable that holds the room id
        private int _roomId;
        // Variable that holds the type of the room
        private RoomType _type;
        // Variable that holds the wakeup time
        private DateTime _wakeupTime;
        // Variable that shows if the room has a minibar or not
        private bool _hasMiniBar;

        /// <summary>
        /// The constuctor for the class that takes a room id, Room type, wakeup time
        /// and a boolean if the room has a minibar
        /// </summary>
        /// <param name="roomId">the room id</param>
        /// <param name="type">the room type</param>
        /// <param name="wakeUpTime">the wake up call</param>
        /// <param name="hasMinibar">boolean if there is a minibar</param>
        public Room(int roomId, RoomType type, DateTime wakeUpTime, bool hasMinibar)
        {
            _roomId = roomId;
            _type = type;
            _wakeupTime = wakeUpTime;
            _hasMiniBar = hasMinibar;
        }

        /// <summary>
        /// Property for the Room id with only a getter.
        /// </summary>
        public int RoomNumber
        {
            get { return _roomId; }
        }

        /// <summary>
        /// Property for the room type with only a getter
        /// </summary>
        public RoomType Type
        {
            get { return _type; }
        }

        /// <summary>
        /// Property for the wake up time
        /// </summary>
        public DateTime WakeUpTime
        {
            get { return _wakeupTime; }
            set { _wakeupTime = value; }
        }

        /// <summary>
        /// Property for the hasMinibar with only a getter
        /// </summary>
        public bool HasMinibar
        {
            get { return _hasMiniBar; }
        }
    }
}
