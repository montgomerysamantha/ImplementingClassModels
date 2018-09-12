using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingClassModels
{
    class Online : Section
    {
        public Online(Semester semester, Course course, Faculty teacher, string number, int cap)
        {

        }

        public override string ToString()
        {
            /* TODO:
             * format string like this: 9899 section B06 (Advanced Black Arts) is being taught by Quirinus Quirrell in Fall
             *                  class number, section num, class name,         is being taught by teacher name, title of semester
             */
            return base.ToString();
        }
    }
}
