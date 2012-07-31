using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace KOCE
{
    [Serializable]
    public class Project
    {
        public string FileName;

        public List<ProjectFolder> Folders;
        public List<ProjectBuildGroup> BuildGroups;
        public List<Variable> Variables;

        public Project()
        {
            this.FileName = "";
            this.Folders = new List<ProjectFolder>();
            this.BuildGroups = new List<ProjectBuildGroup>();
        }

        public Project(string FileName, List<ProjectFolder> Folders)
        {
            this.Folders = Folders;
            this.BuildGroups = new List<ProjectBuildGroup>();
            this.FileName = FileName;
        }

        public Project(string FileName, List<ProjectFolder> Folders, List<ProjectBuildGroup> BuildGroups)
        {
            this.Folders = Folders;
            this.FileName = FileName;
            this.BuildGroups = BuildGroups;
        }

        public string Name
        {
            get
            {
                if (File.Exists(FileName))
                {
                    FileInfo fi = new FileInfo(FileName);
                    return fi.Name.Substring(0, fi.Name.Length - fi.Extension.Length);
                }
                else
                {
                    return "Untitled Project";
                }
            }
        }

        
    }
}
