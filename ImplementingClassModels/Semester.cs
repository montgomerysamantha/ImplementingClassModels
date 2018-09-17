using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingClassModels
{
    /// <summary>
    /// This class is for setting and adding the semester
    /// </summary>
    /// <remarks>
    /// This class contains a constructor which sets the passed in string to the name of the semester
    /// It also contains a get method to return the name
    /// Finally it has a void method that adds a new section to the _sections list
    /// </remarks>
    public class Semester
    {
        private string _name;
        public List<Section> _sections;
        public Semester(string n)
        {
            _name = n;
        }

        public string GetName()
        {
            return _name;
        }

        public void IncludeSection(Section newSection)
        {
            _sections.Add(newSection);
        }
    }
}
