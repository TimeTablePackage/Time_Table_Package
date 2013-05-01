using Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Services
{   
   public class DataBase
    {

        private LinkedList deptList = new LinkedList();
        private LinkedList buildingList = new LinkedList();
        private LinkedList roomList = new LinkedList();
        private LinkedList moduleList = new LinkedList();
        private LinkedList lecturerList = new LinkedList();
        private LinkedList courseList = new LinkedList();

        /// <summary>
        /// A string for the OleDbConnection object to connect to the access database
        /// </summary>
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ttp.accdb";

        /// <summary>
        /// A OleDbConnection object to connect to the access database
        /// </summary>
        private OleDbConnection conn ;
        /// <summary>
        /// A string for the OleDbCommand object to excute SQL commands on the access database
        /// </summary>
        private OleDbCommand cmd;
        /// <summary>
        /// A OleDbDataReader to read the results of the SQL commands
        /// </summary>
        private OleDbDataReader reader;
        
        /// <summary>
        ///     Connect to access database
        /// </summary>
        private void OpenConection()
        {
            conn = new OleDbConnection();
            conn.ConnectionString = connectionString ;
            try
             {
                conn.Open();
             }
            catch 
             {
                 Console.Write("no connection");
                //MessageBox.Show("Failed to connect to data source");
             }
        }
        /// <summary>
        ///     Disconnect from database
        /// </summary>
        private void CloseConnection()
        {
            try
            {
                conn.Close();
            }
            catch
            {
                Console.Write("No connection");
                //MessageBox.Show("Failed to close connection to data source");
            }
        }
        /// <summary>
        ///    Excute non-Query command on database i.e. INSERT or UPDATE
        /// </summary>
        /// <param name="sqlStatment">The SQL Command</param>
        private void excuteNonQuery(String sqlString)
        {
            try
            {
                OpenConection();
                cmd = new OleDbCommand(sqlString, conn);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
            catch
            {
                // MessageBox.Show("Failed insert data");
                Console.Write("cant excute insert command!");
            }
        }
        /// <summary>
        ///     Update a Lecturer in the database
        /// </summary>
        /// <param name="lecturers">The updated Lecturer</param>
        private void updateLecturer(Lecturer lecturer)
        {
            string sql;
            sql = "UPDATE Lecturer";
            sql += "Lec_Name='" + lecturer.getName() + "', ";
            sql += "Initials='" + lecturer.getInitials() + "', ";
            sql += "Email='" + lecturer.getEmail() + "', ";
            sql += "MaxHours=" + lecturer.getMaxHours() + ", ";
            sql += "MaxConsecHours=" + lecturer.getMaxConsecHours() + ", ";
            sql += "MinSlotsPerDay=" + lecturer.getMinSlotsPerDay() + ", ";
            sql += "SlotsOff='" + lecturer.getSlotsOff() + "' ";
            sql += "WHERE ID LIKE '" + lecturer.getId() + "'";
            excuteNonQuery(sql);
        }
        /// <summary>
        ///     Add a new Lecturer to the database
        /// </summary>
        /// <param name="lecturer">The new Lecturer</param>
        private void insertLecturer(Lecturer lecturer)
        {
            string sql;
            sql = "INSERT INTO Lecturer (Lec_Name, Initials, Email, MaxHours, MaxConsecHours, MinSlotsPerDay, SlotsOff, Deleted) VALUES(";
            sql += "'" + lecturer.getName() + "', ";
            sql += "'" + lecturer.getInitials() + "', ";
            sql += "'" + lecturer.getEmail() + "', ";
            sql += lecturer.getMaxHours() + ", ";
            sql += lecturer.getMaxConsecHours() + ", ";
            sql += lecturer.getMinSlotsPerDay() + ", ";
            sql += "'" + lecturer.getSlotsOff() + "', false)";
            excuteNonQuery(sql);
        }
        /// <summary>
        ///     Update a Module in the database
        /// </summary>
        /// <param name="module">The updated Module</param>
        private void updateModule(Module module)
        {
            string sql;
            sql = "UPDATE Module";
            sql += "Module_Name='" + module.getName() + "', ";
            sql += "Practical=" + module.getPractical() + ",";
            sql += "HoursPerWeek=" + module.getHoursPerWeek() + ", ";
            sql += "RoomType='" + module.getRommType() + "', ";
            sql += "MaxConsecHours=" + module.getMaxConsecHours() + ", ";
            sql += "DoubleSlots=" + module.getDoubleSlots() + ", ";
            sql += "WHERE ID LIKE " + module.getID();
            excuteNonQuery(sql);
        }
        /// <summary>
        ///     Insert a new Module into the database
        /// </summary>
        /// <param name="module">The new Module</param>
        private void insertModule(Module module)
        {
            string sql;
            sql = "INSERT INTO Module (Module_Name, Practical, HoursPerWeek, RoomType, MaxConsecHours, DoubleSlots, Deleted) VALUES(";
            sql = "'" + module.getName() + "', ";
            sql = module.getPractical() + ",";
            sql = module.getHoursPerWeek() + ", ";
            sql = "'" + module.getRommType() + "',";
            sql = module.getMaxConsecHours() + ", ";
            sql = module.getDoubleSlots() + ", false)";
            excuteNonQuery(sql);
        }
        /// <summary>
        ///     Update a Room in the database
        /// </summary>
        /// <param name="room">The updated Room</param>
        private void updateRoom(Room room)
        {
            string sql;
            sql = "UPDATE Room";
            sql += "Number='" + room.roomNumber + "', ";
            sql += "Capacity=" + room.capacity + ", ";
            sql += "RoomType='" + room.roomType + "', ";
            sql += "SlotsOff='" + room.slotsOff + "', ";
            sql += "WHERE ID LIKE " + room.ID;
            excuteNonQuery(sql);
        }
        /// <summary>
        ///  Insert Room to the database
        /// </summary>
        /// <param name="room">The Room to be inserted</param>
        private void insertRoom(Room room)
        {
            string sql;
            sql = "INSERT INTO Room (Number, Capacity, RoomType, SlotsOff, Deleted) VALUES(";
            sql += "'"+room.roomNumber+"', ";
            sql += room.capacity + ", ";
            sql += "'" + room.roomType + "', ";
            sql += "'" + room.slotsOff + "', false ";
            excuteNonQuery(sql);
        }
        /// <summary>
        ///     Update a Department
        /// </summary>
        /// <param name="dept">The updated Department</param>
        private void updateDept(Department dept)
        {
            string sql;
            sql = "Update Department Dept_Name=";
            sql += "'" + dept.getName() + "'";
            excuteNonQuery(sql);
        }
        /// <summary>
        ///     Insert a department into the database
        /// </summary>
        /// <param name="dept">The Department to be inserted</param>
        private void insertDept(Department dept)
        {
            string sql = "INSERT INTO Department VALUES('"+ dept.getName() + "')";
            excuteNonQuery(sql);
        }
        /// <summary>
        ///    Get data back in a data table
        /// </summary>
        /// <param name="sqlStatment">The SQL Query</param>
        /// <returns>Results in a DataTable</returns>
        public DataTable GetTableData(String sqlStatment)
        {
            DataTable dt = new DataTable();
            OpenConection();
            OleDbCommand cmd = new OleDbCommand(sqlStatment, conn);
            OleDbDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            CloseConnection();
            return dt ;
        }
        /// <summary>
        ///     Get result of a Query in String form
        /// </summary>
        /// <param name="sqlStatment">The SQL Query</param>
        /// <returns>Result of Query in a String</returns>
        public String GetData(String sqlStatment)
        {
            string outputString = "null";
            try
            {
                OpenConection();
                cmd = new OleDbCommand(sqlStatment, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["Deleted"].ToString().Equals("False"))
                    {
                        outputString = reader["Lec_Name"].ToString();
                        outputString += "$" + reader["Initials"].ToString();
                        outputString += "$" + reader["Email"].ToString();
                        outputString += "$" + reader["MaxHours"].ToString();
                        outputString += "$" + reader["MaxConsecHours"].ToString();
                        outputString += "$" + reader["MinSlotsPerDay"].ToString();
                        outputString += "$";
                    }
                    else
                    {
                        outputString = "N/A";
                    }
                }
                CloseConnection();
            }
            catch
            {
               // MessageBox.Show("Failed to get data from source");
            }
            return outputString;
        }
      /// <summary>
      /// 
      /// </summary>
       private void loadLectuerList()
       {
            Lecturer newLec;
            string sqlStatment = "SELECT * FROM Lecturer";
            try{
                    OpenConection();
                    cmd = new OleDbCommand(sqlStatment, conn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader["Deleted"].ToString().Equals("False"))
                        {
                            newLec = new Lecturer(reader["ID"].ToString(),
                                reader["Lec_Name"].ToString(),
                                reader["Initials"].ToString(),
                                reader["Email"].ToString(),
                                Convert.ToInt32(reader["MaxHours"]),
                                Convert.ToInt32(reader["MaxConsecHours"]),
                                Convert.ToInt32(reader["MinSlotsPerDays"]),
                                reader["SlotsOff"].ToString(),reader["DepartmentID"].ToString());
                                lecturerList.addAtTail(newLec);
                        }
                    }
                    CloseConnection();
                }
                catch 
                {
                    // MessageBox.Show("Failed to get data from source");
                } 
        }
        
        /// <summary>
        ///     Load LinkedList of Course for a Department
        /// </summary>
        /// <param name="dept">The Department the Courses are in</param>
        /// <returns>A LinkedList of Course</returns>
        private void loadCourseList()
        {
            Course tempCourse ;

            string sqlStatment = "SELECT ID, Code, CourseName, NumOfStudents FROM Course"; 
            try
            {
                OpenConection();
                cmd = new OleDbCommand(sqlStatment, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["Deleted"].ToString().Equals("False"))
                    {
                        tempCourse = new Course(reader["ID"].ToString(), 
                            reader["Code"].ToString(),
                            reader["CourseName"].ToString(), 
                            Convert.ToInt32(reader["NumOfStudents"]));
                        courseList.addAtTail(tempCourse);
                    }
                    
                }
                CloseConnection();
            }
            catch 
            {
                // MessageBox.Show("Failed to get data from source");
            }
        }
        /// <summary>
        ///     Load all rooms
        /// </summary>
       private void loadRoomList()
        {
            LinkedList roomList = new LinkedList();
            Room tempRoom;
            string sqlStatment = "SELECT * FROM Room ";
            try
            {
                OpenConection();
                cmd = new OleDbCommand(sqlStatment, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["Deleted"].ToString().Equals("False"))
                    {
                        tempRoom = new Room(
                        reader["ID"].ToString(),
                        reader["Number"].ToString(),
                        Convert.ToInt32(reader["Capacity"]),
                        reader["RoomType"].ToString(),
                        reader["SlotsOff"].ToString());
                        roomList.addAtTail(tempRoom);
                    }
                }
                CloseConnection();
            }
            catch
            {
                // MessageBox.Show("Failed to get data from source");
            }
        }
         /// <summary>
         /// load all the depts from the database
         /// </summary>
       private void loadDepartmentList()
        {
            Department tempDept ;
            string sqlStatment = "SELECT * FROM Department";
            try 
	        {	        
		        OpenConection();
                cmd = new OleDbCommand(sqlStatment, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["Deleted"].ToString().Equals("False"))
                    {
                        tempDept = new Department(reader["ID"].ToString(),
                            reader["Dept_Name"].ToString());
                        deptList.addAtTail(tempDept);
                    }
                }
                CloseConnection();
	        }
	        catch 
	        {
	
	        }
        }
        /// <summary>
        /// load all the buildings from the database
        /// </summary>
        private void loadBuildingList()
        {
            Building tempBuild;
            string sqlStatment = "SELECT * FROM Building";
            try
            {
                OpenConection();
                cmd = new OleDbCommand(sqlStatment, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["Deleted"].ToString().Equals("False"))
                    {
                        tempBuild = new Building(reader["ID"].ToString(), 
                            reader["Building_Name"].ToString());
                        buildingList.addAtTail(tempBuild);
                    }
                }
                CloseConnection();
            }
            catch 
            {

            }
        }
        /// <summary>
        ///     Loads all modules
        /// </summary>
        private void LoadModuleList()
        {
            Module tempModule;
            string sqlStatment = "SELECT * FROM Module";
            try
            {
                OpenConection();
                cmd = new OleDbCommand(sqlStatment, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["Deleted"].ToString().Equals("False"))
                    {
                        tempModule = new Module(reader["ID"].ToString(),
                        reader["Module_Name"].ToString(),
                        Convert.ToBoolean(reader["Pratcial"]),
                        Convert.ToInt32(reader["HoursPerWeek"]),
                        reader["RoomType"].ToString(),
                        Convert.ToBoolean(reader["DoubleSlots"]),
                        Convert.ToInt32(reader["MaxConsecHours"]));
                        moduleList.addAtTail(tempModule);
                    }
                }
                CloseConnection();
            }
            catch
            {
            }
        }
        /// <summary>
        ///     Save list of Lecturer to the database
        /// </summary>
        /// <param name="lecturers">The LinkedList of Lecturer</param>
        public void saveLecturers(LinkedList lecturers)
        {
            Node temp = lecturers.head;
            Lecturer tempLec ;

            while (temp.next != null)
            {
                tempLec = (Lecturer)temp.data;
                //if the lecturer is new i.e id=000 use Insert command
                if (tempLec.getId().Equals("000"))
                {
                    insertLecturer(tempLec);
                }
                else // update the lecturer entry
                {
                    updateLecturer(tempLec);
                }
                temp = temp.next;
            }
        }
        /// <summary>
        ///     Save's the list of Module to the database
        /// </summary>
        /// <param name="modules">the LinkedList of Module</param>
        public void saveModules(LinkedList modules)
        {
            Node temp = modules.head;
            Module tempModule;

            while (temp.next != null)
            {
                tempModule = (Module)temp.data;
                //if the modue isnt already in the database create a new entry
                if (tempModule.getID().Equals("000"))
                {
                    insertModule(tempModule);
                }
                else
                {
                    updateModule(tempModule);
                }
                temp = temp.next;
            }
        }
        /// <summary>
        ///     Saves a list of Room to the database
        /// </summary>
        /// <param name="rooms">The LinkedList of Room</param>
        public void saveRoom(LinkedList rooms)
        {
            Node temp = rooms.head;
            Room tempRoom;
            while (temp.next != null)
            {
                tempRoom = (Room)temp.data;
                //if the room isnt in the database insert it else update it
                if (tempRoom.ID.Equals("000"))
                {
                    insertRoom(tempRoom);
                }
                else
                {
                    updateRoom(tempRoom);
                }
                temp = temp.next;
            }
        }
        /// <summary>
        ///     Save a list of Department to the database
        /// </summary>
        /// <param name="depts">The LinkedList of Department</param>
        public void saveDepartments(LinkedList depts)
        {
            Node temp = depts.head;
            Department tempDept;
            while (temp.next != null)
            {
                tempDept = (Department)temp.data;
                //if the dept is'nt in the database insert a new one else
                if (tempDept.getID().Equals("000"))
                {
                    insertDept(tempDept);
                }
                else
                {
                    updateDept(tempDept);
                }
            }

        }
        /// <summary>
        /// update the list to match database
        /// </summary>
        public void update()
        {
            loadBuildingList();
            loadCourseList();
            loadDepartmentList();
            loadRoomList();
            loadLectuerList();
            LoadModuleList();
        }

        /// <summary>
        /// find room for a building
        /// </summary>
        /// <param name="build">the building the rooms are in</param>
        /// <returns></returns>
        public LinkedList getRoomList(Building build)
        {
            LinkedList list = new LinkedList();
            Node roomNode = roomList.head;

            while (roomNode != null)
            {
                Room tempRoom = (Room)roomNode.data;
                if (tempRoom.buildingId == build.getID())
                {
                    list.addAtTail(tempRoom);
                }
            }

        }
    }
}

