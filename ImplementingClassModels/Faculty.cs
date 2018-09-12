using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingClassModels
{
    
    class Faculty : IFaculty
    {
        private string _name;

        public Faculty(string n)
        {
            _name = n;
        }
        public void AssignSection(Section assignedSection)
        {
            
        }

        public string GetName()
        {
            return _name;
        }
    }
}
