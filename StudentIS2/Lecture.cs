using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentIS2
{
    public class Lecture
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Department> Departments { get; set; } = new List<Department>();

    }
}
