using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KOCE
{
    [Serializable]
    public class ProjectBuildGroup
    {
        public string Name;

        public List<ProjectBuildGroupEvent> Events;

        public ProjectBuildGroup(string Name)
        {
            this.Name = Name;
            this.Events = new List<ProjectBuildGroupEvent>();
        }

        public ProjectBuildGroup(string Name, List<ProjectBuildGroupEvent> Events)
        {
            this.Name = Name;
            this.Events = Events;
        }


        public override string ToString()
        {
            return Name;
        }
    }
}
