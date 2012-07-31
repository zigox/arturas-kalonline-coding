using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace KOCE
{
    static class ProjectLoader
    {
        //unused
        public static Project LoadProject(string FileName)
        {            
            //load xml
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(FileName);

            //creat new project
            Project project = new Project();
            project.FileName = FileName;

            //folders
            XmlNodeList xnodes = xdoc.SelectNodes("project/folder");

            project.Folders = LoadFolders(xnodes);

            //build groups
            xnodes = xdoc.SelectNodes("project/buildgroup");

            project.BuildGroups = LoadBuildGroups(xnodes);

            //variables
            xnodes = xdoc.SelectNodes("project/variable");

            project.Variables = LoadVariables(xnodes);

            return project;
        }

        private static List<ProjectFolder> LoadFolders(XmlNodeList xnodes)
        {
            List<ProjectFolder> folders = new List<ProjectFolder>();
            foreach (XmlNode xnode in xnodes)
            {
                string directoryName = xnode.Attributes["directoryname"].Value;
                string name = xnode.Attributes["name"].Value;
                //make a new folder
                ProjectFolder pFolder = new ProjectFolder(directoryName, name);

                //load editor filters
                pFolder.Editors = LoadEditors(xnode.SelectNodes("editor"));

                folders.Add(pFolder);
            }

            return folders;
        }

        private static List<Variable> LoadVariables(XmlNodeList xnodes)
        {
            List<Variable> variables = new List<Variable>();
            foreach (XmlNode xnode in xnodes)
            {
                string key = xnode.Attributes["key"].Value;
                string value = xnode.InnerText;

                //make a new variable
                Variable newVar = new Variable(key, value);

                variables.Add(newVar);
            }

            return variables;
        }

        private static List<ProjectBuildGroup> LoadBuildGroups(XmlNodeList xnodes)
        {
            List<ProjectBuildGroup> groups = new List<ProjectBuildGroup>();
            foreach (XmlNode xnode in xnodes)
            {
                string name = xnode.Attributes["name"].Value;

                //make a new group
                ProjectBuildGroup newGroup = new ProjectBuildGroup(name);

                newGroup.Events = LoadEvents(xnode.SelectNodes("event"));

                groups.Add(newGroup);
            }

            return groups;
        }

        private static List<ProjectFolderEditor> LoadEditors(XmlNodeList xnodes)
        {
            List<ProjectFolderEditor> editors = new List<ProjectFolderEditor>();

            foreach (XmlNode xnode in xnodes)
            {
                string editor = xnode.Attributes["program"].Value;
                string filter = xnode.Attributes["filter"].Value;
                string args = xnode.InnerText;

                editors.Add(new ProjectFolderEditor(editor, filter, args));
            }

            return editors;
        }

        private static List<ProjectBuildGroupEvent> LoadEvents(XmlNodeList xnodes)
        {
            List<ProjectBuildGroupEvent> events = new List<ProjectBuildGroupEvent>();

            foreach (XmlNode xnode in xnodes)
            { 
                string program = xnode.Attributes["program"].Value;
                int weight = Convert.ToInt32(xnode.Attributes["weight"].Value);
                int delay = Convert.ToInt32(xnode.Attributes["delay"].Value);
                string args = xnode.InnerText;

                events.Add(new ProjectBuildGroupEvent(program, args, weight, delay));
            }

            return events;
        }
    }
}
