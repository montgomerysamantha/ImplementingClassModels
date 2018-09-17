using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingClassModels
{
    /// <summary>
    /// This class is to set the course number and section number
    /// </summary>
    /// <remarks>
    /// This class contains both get and set methods for the respective section number and course number
    /// </remarks>
    public class Section
    {
        protected Faculty _faculty;
        //if I understand correctly each section can only have one faculty member so maybe
        /*
         * can't decide if _semester and _faculty should be private, protected, or public
         * on diagram looks like private but since it's OnCampus is inherited it won't
         * get this initialization
        */
        protected Semester _semester;
        protected Course _course;
        public string number;
        public int cap;

        public void SetNumber(string num)
        {
            number = num;
        }

        public string GetNumber()
        {
            return number;
        }

        public void SetCap(int c)
        {
            cap = c;
        }

        public int GetCap()
        {
            return cap;
        }
    }
}
