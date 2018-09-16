using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingClassModels
{
    
    public class Faculty : IFaculty
    {
        private string _name;
        private List<Section> _sections;
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
