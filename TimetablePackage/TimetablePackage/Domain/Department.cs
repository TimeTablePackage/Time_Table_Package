using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Department
    {
        private static int autoNumber { get; set; }
        /// <summary>
        /// The Id of the Department mainly used in the database
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// The name of the Department
        /// </summary>
        public string name { get; set; }
        /// <summary>
        ///     Defuault Constructer
        ///     Sets Id to defualt 000 so as to know to use INSERT SQl command
        ///     Creates a new linkedlists and assigns it to lecturerList & courseList to prevent
        ///     trying to add to a non-existent list
        /// </summary>
        public Department()
        {
            this.ID = autoNumber++.ToString();
        }
        /// <summary>
        ///     Constructer that sets name
        ///     Creates a new linkedlists and assigns it to lecturerList & courseList to prevent
        ///     trying to add to a non-existent list
        /// </summary>
        /// <param name="name">The name of the Department</param>
        public Department(String name)
        {
            this.ID = autoNumber++.ToString();
            this.name = name;
        }
        /// <summary>
        ///     Constructer for load from database
        /// </summary>
        /// <param name="name">The name of the Department</param>
        public Department(string id,String name)
        {
            this.ID = id;
            this.name = name;
        }  
    }
}
