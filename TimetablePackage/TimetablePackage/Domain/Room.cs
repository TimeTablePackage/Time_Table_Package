using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
		class Room 
        {
            /// <summary>
            /// Generates a new Id
            /// </summary>
            private static int autoNumber { get; set; }
            /// <summary>
            /// ID will be used for identifying the Room in the database.
            /// </summary>
            public string ID { get; set; }
            /// <summary>
            /// The maximum number of students that a room can host.
            /// </summary>
            public int capacity { get; set; }
            /// <summary>
            /// The room number is the number/name of the room in the building.
            /// </summary>
            public string roomNumber { get; set; }
            /// <summary>
            /// The room type specifies the purpose of the room used for.
            /// </summary>
            public string roomType { get; set; }
            /// <summary>
            /// The time slots that a room is not available for hosting a class
            /// </summary>
            public string slotsOff { get; set; }
            public string buildingId { get; set; }
            
            /// <summary>
			/// Default constructor of the Room class.
			/// </summary>
			public Room() {
                this.ID = autoNumber++.ToString();
			}
            /// <summary>
            /// Constructer for database
            /// </summary>
            /// <param name="roomNum">String value for the name/number of the room in the building.</param>
            /// <param name="capacity">Integer value for the setting the maximum capacity.</param>
            public Room(string id, string roomNum, int capacity, string roomType, string slotsOff)
            {
                this.ID = autoNumber++.ToString();
                this.roomNumber = roomNum;
                this.capacity = capacity;
                this.roomNumber = roomType;
                this.slotsOff = slotsOff;
            }

			
		}

}
