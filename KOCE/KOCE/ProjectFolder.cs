using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KOCE
{
    [Serializable]
    public class ProjectFolder
    {
        public string DirectoryName;
        public string Name;

        public List<ProjectFolderEditor> Editors = new List<ProjectFolderEditor>();

        public ProjectFolder(string DirectoryName, string Name)
        {
            this.Name = Name;
            this.DirectoryName = DirectoryName;
        }

        public ProjectFolder(string DirectoryName, List<ProjectFolderEditor> Editors)
        {
            this.DirectoryName = DirectoryName;
            this.Editors = Editors;
        }

        public ProjectFolderEditor FindEditor(string Extension)
        {
            ProjectFolderEditor defaultEditor = new ProjectFolderEditor("notepad.exe", "*.*", "{file_name}");

            foreach (ProjectFolderEditor editor in Editors)
            {
                if (editor.Filter == "*" || editor.Filter == Extension)
                {
                    return editor;
                }
            }

            return defaultEditor;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
