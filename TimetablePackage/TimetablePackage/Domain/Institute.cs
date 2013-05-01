using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Institute
    {
        private static int autoNumber { get; set; }
        /// <summary>
        /// The Name of the Instuite
        /// </summary>
        private string name { get; set; }
        /// <summary>
        /// id of the instutite
        /// </summary>
        private string Id { get; set; }
        /// <summary>
        ///     Defualt Constructer that sets name.
        /// </summary>
        /// <param name="name">the Name</param>
        public Institute(string name)
        {
            setId(autoNumber++.ToString());
            setName(name);
        }
        /// <summary>
        /// Constructer for database
        /// </summary>
        /// <param name="id">The Id</param>
        /// /// <param name="name">The Name</param>
        public Institute(string id, string name)
        {
            setId(id);
            setName(name);
        }
        /// <summary>
        ///     add a Building to the Instutite
        /// </summary>
        /// <param name="building">The Building to add</param>
        public void addBuilding(Building building)
        {
            if (buildingList == null)
            {
                buildingList = new LinkedList();
            }
            buildingList.addAtTail(building);
        }
        /// <summary>
        ///     Add a Department to the Instutite
        /// </summary>
        /// <param name="dept">The Department to add</param>
        public void addDepartment(Department dept)
        {
            if (deptList == null)
            {
                deptList = new LinkedList();
            }
            deptList.addAtTail(dept);
        }
        //Get and Set methods
        /// <summary>
        ///     set the id 
        /// </summary>
        /// <param name="Id">The new Id</param>
        public void setId(string Id)
        {
            this.Id = Id;
        }
        /// <summary>
        ///     returns the id 
        /// </summary>
        /// <returns>The Id</returns>
        public string getID()
        {
            return this.Id;
        }
        
        /// <summary>
        ///     Set the Institute name
        /// </summary>
        /// <param name="name">The new Name</param>
        public void setName(string name)
        {
            this.name = name;
        }
        /// <summary>
        ///     Get the Institute name
        /// </summary>
        /// <returns>The Institute name</returns>
        public string getName()
        {
            return this.name;
        }
        /// <summary>
        ///     Set the Building LinkedList
        /// </summary>
        /// <param name="buildingList">The LinkedList Of Building</param>
        public void setBuildingList(LinkedList buildingList)
        {
            this.buildingList = buildingList;
        }
        /// <summary>
        ///     Get the Building LinkedList
        /// </summary>
        /// <returns>LinkedList of Building</returns>
        public LinkedList getBuildingList()
        {
            return this.buildingList;
        }
        /// <summary>
        ///     Set the Department LinkedList
        /// </summary>
        /// <param name="deptList">The LinkedList of Department</param>
        public void setDeptList(LinkedList deptList)
        {
            this.deptList = deptList;
        }
        /// <summary>
        ///     Get the Department LinkedList
        /// </summary>
        /// <returns>The LinkedList of Department</returns>
        public LinkedList getDeptList()
        {
            return this.deptList;
        }
        /// <summary>
        /// Return a Department with a given Id
        /// </summary>
        /// <param name="Id">The Id of desired Department</param>
        /// <returns>Department with given Id</returns>
        public Department getDeptById(string Id) // id of dept wanted 001
        {
            Department tempdept = null;
            Node deptNode = this.deptList.head;
            while (deptNode != null)
            {
                tempdept = (Department)deptNode.data;
                if (tempdept.getID() == Id)
                {
                    deptNode = null;
                }
                else
                {
                    deptNode = deptNode.next;
                }
            }
            return tempdept;
        }


       

    }//class
}
