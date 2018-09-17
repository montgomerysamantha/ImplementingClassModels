using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingClassModels
{
    /// <summary>
    /// This class is the interface for faculty members
    /// </summary>
    public interface IFaculty
    {
        string GetName();
        void AssignSection(Section assignedSection); 
    }
}
