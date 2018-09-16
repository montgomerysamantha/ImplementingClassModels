using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingClassModels
{
    public class Section
    {
        //Should be dones
        protected Faculty _faculty; //?? not sure if this is correct
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
