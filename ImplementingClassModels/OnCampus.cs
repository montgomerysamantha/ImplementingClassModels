using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingClassModels
{
    class OnCampus : Section
    {
        public OnCampus(Semester semester, Course course, Faculty teacher, string number, int cap)
        { 
            /*
             * can't decide if _semester and _faculty should be private, protected, or public
             * on diagram looks like private but since it's OnCampus is inherited it won't
             * get this initialization
             */
            _semester = semester;
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
