using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Course
    {
        private static int autoNumber { get; set; }
        /// <summary>
        /// The Id of the course, mainly used for databse
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// The code of the course
        /// </summary>
        public string courseCode { get; set; }
        /// <summary>
        /// Name of the course
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Number of students in the course
        /// </summary>
        public int numOfStudents { get; set; }

        /// <summary>
        ///     Defuault Constructer
        ///     Sets Id to defualt 000 so as to know to use INSERT SQl command
        ///     Creates a new linkedlist and assigns it to moduleList to prevent addModule() 
        ///     trying to add to a non-existent list
        /// </summary>
        public Course()
        {
            this.ID = autoNumber++.ToString();
        }
        /// <summary>
        ///     Constructer for database
        /// </summary>
        /// <param name="courseCode">code of the course</param>
        /// <param name="name">name of the course</param>
        /// <param name="numOfStudents">number of students in the course</param>
        public Course(string id, string courseCode, string name, int numOfStudents)
        {
            this.ID = id;
            this.courseCode = courseCode;
            this.name = name;
            this.numOfStudents = numOfStudents;
        } 
      
    
    }
}
