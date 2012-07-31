using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace KOCE
{
    class Builder
    {
        public ProjectBuildGroup BuildGroup;
        public StringTemplate Template;
        public List<Process> Processes;

        public Builder(ProjectBuildGroup BuildGroup)
        {
            this.BuildGroup = BuildGroup;
            Template = new StringTemplate();
            Processes = new List<Process>();
        }

        public void KillAll()
        {
            foreach (Process p in Processes)
            {
                if (!p.HasExited)
                {
                    p.Kill();
                }
            }
            Processes.Clear();
        }

        public void Build()
        {
            //sort
            BuildGroup.Events = BuildGroup.Events.OrderBy(x => x.Weight).ToList();

            //start each process
            foreach (ProjectBuildGroupEvent bevent in BuildGroup.Events)
            {
                try
                {
                    FileInfo fi = new FileInfo(Template.GetOutput(bevent.Program));

                    //delay start
                    Thread.Sleep(bevent.Delay);

                    //create process
                    Process p = new Process();
                    p.StartInfo.Arguments = Template.GetOutput(bevent.CommandLineArguments);
                    p.StartInfo.FileName = Template.GetOutput(bevent.Program);
                    p.StartInfo.WorkingDirectory = fi.DirectoryName;

                    //add to list
                    Processes.Add(p);
                    //start process
                    p.Start();
                }
                catch (Exception)
                {
                    MessageBox.Show(String.Format("Unable to launch process \"{0}\".", Template.GetOutput(bevent.Program)));
                }
            }
        }
    }
}
