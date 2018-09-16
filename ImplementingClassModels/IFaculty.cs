using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingClassModels
{
    public interface IFaculty
    {
        string GetName();
        void AssignSection(Section assignedSection); 
    }
}
