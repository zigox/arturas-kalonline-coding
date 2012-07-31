using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KOCE
{
    [Serializable]
    public class ProjectFolderEditor
    {
        public string Program, Filter, CommandLineArguments;

        public ProjectFolderEditor(string Program, string Filter, string CommandLineArguments)
        {
            this.Program = Program;
            this.Filter = Filter;
            this.CommandLineArguments = CommandLineArguments;
        }

        public override string ToString()
        {
            return Filter + ": " + Program + " " + CommandLineArguments;
        }
    }
}
