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

        public Exam(Exam exam)
        {
            this.Name = exam.Name;
            this.DivisionType = exam.DivisionType;
        }
        public Exam(string name, string divisionType)
        {
            this.Name = name;
            this.DivisionType = divisionType;
        }
    }
}
