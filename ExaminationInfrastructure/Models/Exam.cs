using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationInfrastructure
{
    public class Exam
    {
        public string Name { get; set; }
        public string DivisionType { get; set; }

        public Exam(string name, string divisionType)
        {
            this.Name = name;
            this.DivisionType = divisionType;
        }
    }
}
