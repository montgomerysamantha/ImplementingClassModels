﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingClassModels
{
    
    class Faculty : IFaculty
    {
        private string _name = "";

        Faculty(string n)
        {
            _name = n;
        }
        public void AssignSection()
        {
            throw new NotImplementedException();
        }

        public string GetName()
        {
            return _name;
        }
    }
}
