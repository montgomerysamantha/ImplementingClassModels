using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingClassModels
{
    class Semester
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
