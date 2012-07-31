using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace Kml_Editor_Updater
{
    static class Program
    {
        static void Main()
        {
            try
            {
                Process.Start("KML Editor.exe", "-update");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to start KML Editor.exe: " + ex.Message);
            }
        }
    }
}
