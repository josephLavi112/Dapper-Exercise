﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_Exercise
{
    public interface IDepartmentrepo
    {
        public IEnumerable<Department> GetAllDepartments();
    }
}
