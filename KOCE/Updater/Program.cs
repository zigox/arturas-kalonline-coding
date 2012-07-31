using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace Updater
{
    static class Program
    {

        static void Main()
        {
            try
            {
                Process.Start("KOCE.exe", "-update");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to start KOCE.exe: " + ex.Message);
            }
        }
    }
}
