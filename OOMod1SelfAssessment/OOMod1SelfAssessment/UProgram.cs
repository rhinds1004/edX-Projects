using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOMod1SelfAssessment
{
    public class UProgram
    {
        public Degree Degree { get; set; }
        public string ProgramName { get; set; }

        public UProgram(string programName)
        {
            ProgramName = programName;
        }

    }
}
