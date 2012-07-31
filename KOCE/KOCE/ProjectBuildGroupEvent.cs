using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KOCE
{
    [Serializable]
    public class ProjectBuildGroupEvent
    {
        public string Program, CommandLineArguments;
        public int Weight;
        public int Delay;

        public ProjectBuildGroupEvent(string Program, string CommandLineArguments, int Weight, int Delay)
        {
            this.Program = Program;
            this.CommandLineArguments = CommandLineArguments;
            this.Weight = Weight;
            this.Delay = Delay;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} - Delay: {2}, Weight: {3}", Program, CommandLineArguments, Delay, Weight);
        }
    }
}
