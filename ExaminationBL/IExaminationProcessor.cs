using ExaminationInfrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationBL
{
    public interface IExaminationProcessor
    {
        public int GetPassedCount(string input);
    }
}
