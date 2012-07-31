using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Windows.Forms;
using System.Threading;
using DDay.Update;
using DDay.Update.Utilities;
using DDay.Update.Configuration;
using System.IO;

namespace Kml_Editor_Bootstrap
{
    class Program
    {
        static private ILog log = new Log4NetLogger();
        static private DDayUpdateConfigurationSection cfg;

        static void Main()
        {
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            // Get the DDay.Update configuration section
            cfg = ConfigurationManager.GetSection("DDay.Update")
                as DDayUpdateConfigurationSection;

            string command = "";

            string[] args = GetArgs();

            //check if update arg has been passed
            if (args.Length > 0)
            {
                //check if first arg is a command
                if (args[0].StartsWith("-"))
                {
                    //if it is then assign it
                    command = args[0];
                    //and remove first arg
                    string[] newargs = new string[args.Length - 1];
                    Array.Copy(args, 1, newargs, 0, args.Length - 1);
                    //assign new args
                    args = newargs;
                }
            }

            // Set the command line parameters to the application
            UpdateManager.SetCommandLineParameters(args);

            if (command == "-updatelaunch" || cfg.Automatic)
            {
                Update();
                Launch();
            }
            else if (command == "-update")
            {
                Update();
            }
            else if (command == "-remove")
            {
                Remove();
            }
            else
            {
                Launch();
            }

            log.Debug("Exiting bootstrap application...");
        }

        static string[] GetArgs()
        {
            string[] args = Environment.GetCommandLineArgs();
            //remove first arg
            string[] newargs = new string[args.Length - 1];
            Array.Copy(args, 1, newargs, 0, args.Length - 1);
            //assign new args
            return args = newargs;

        }

        static void Update()
        {
            if (UpdateManager.IsUpdateAvailable(cfg.Uri, cfg.Username, cfg.Password, cfg.Domain))
            {
                log.Debug("Update is available, beginning update process...");

                // Perform the update, which performs the following steps:
                // 1. Updates to a new version of the application
                // 2. Saves new deployment and application manifests locally
                // 3. Removes previous versions of the application (depending on configuration settings)
                UpdateManager.Update();
            }
            else
            {
                log.Debug("Application is up-to-date.");
            }
        }

        static void Launch()
        {
            UpdateManager.StartApplication();
        }

        //remove all version and the manifest
        static void Remove()
        {
            UpdateManager.RemoveAllVersions();
            if (File.Exists(UpdateManager.LocalDeploymentManifestPath))
            {
                File.Delete(UpdateManager.LocalDeploymentManifestPath);
            }
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            log.Error("An unhandled exception occurred during the update process!", e.ExceptionObject as Exception);
            UpdateManager.StartApplication();
        }
    }
}
