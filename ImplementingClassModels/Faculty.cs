using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingClassModels
{
    /// <summary>
    /// This class contains a constructor and two methods to help intialize and add to Faculty objects and their properties
    /// </summary>
    /// <remarks>
    /// This class contains a constructor which intializes the name field for faculty objects
    /// It also contains a method to add to the list of sections that is attached to each faculty member
    /// Lastly it has a get method for the name field
    /// </remarks>
    public class Faculty : IFaculty
    {
        private string _name;
        private List<Section> _sections = new List<Section>();
        public Faculty(string n)
        {
            _name = n;
        }
        public void AssignSection(Section assignedSection)
        {
            _sections.Add(assignedSection);
        }

        public string GetName()
        {
            return _name;
        }
    }
}
