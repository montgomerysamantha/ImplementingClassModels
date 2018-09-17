using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingClassModels
{
    /// <summary>
    /// This class is for online and it extends the section class
    /// </summary>
    /// <remarks>
    /// This class contains a constructor that sets all the fields to their coresponding values passed in
    /// It also contains a override string method which formats the string the way it needs to be in the outpout
    /// </remarks>
    public class Online : Section
    {
        public Online(Semester semester, Course course, Faculty teacher, string number, int cap)
        {
            this._semester = semester;
            this._course = course;
            this._faculty = teacher;
            this.number = number;
            this.cap = cap;
        }

        public override string ToString()
        {
            /* TODO:
             * format string like this: 9899 section B06 (Advanced Black Arts) is being taught by Quirinus Quirrell in Fall
             *                  class number, section num, class name,         is being taught by teacher name, title of semester
             */
             string teacherName = this._faculty.GetName();
             string result = this._course.number + " section " + number + " (" + this._course.title + ") is being taught by " + teacherName + " in " + _semester.GetName();
             return result;
        }
    }
}
