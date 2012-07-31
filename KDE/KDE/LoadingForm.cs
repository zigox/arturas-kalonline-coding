using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ArturasServer.KalOnline.Kml;
using ArturasServer.KalOnline.Kml.ObjectMapping;
using ArturasServer.KalOnline.Kml.Tools;
using ArturasServer.KalOnline.DataEditor.ObjectClasses;

namespace ArturasServer.KalOnline.DataEditor
{
    public partial class LoadingForm : Form
    {
        int DataFilesLoaded = 0;

        public delegate void UpdateProgressDelegate();
        public delegate void CloseFormDelegate();

        public LoadingForm()
        {
            InitializeComponent();
            BeginLoading();
        }

        public void BeginLoading()
        {
            //load data files from project
            foreach (DataFile dataFile in MainForm.CurrentProject.DataFiles)
            {
                ObjectClassManager.AddDataFile(dataFile);
            }

            //ObjectClassManager.ObjectTypes.Add("monster", typeof(Monster));
            //ObjectClassManager.ObjectTypes.Add("genmonster", typeof(GenMonster));
            //ObjectClassManager.ObjectTypes.Add("monstername", typeof(MonsterName));
            //ObjectClassManager.ObjectTypes.Add("itemname", typeof(ItemName));
            //ObjectClassManager.ObjectTypes.Add("itemdesc", typeof(ItemDesc));

            ObjectClassManager.LoadObjectMaps();

            ObjectClassManager.DataFileLoader.OnDataFileLoaded += new DataFileLoader.DataFileLoadedEvent(DataFileLoader_OnDataFileLoaded);
            ObjectClassManager.DataFileLoader.OnLoadingCompleted += new DataFileLoader.LoadingCompletedEvent(DataFileLoader_OnLoadingCompleted);
            ObjectClassManager.LoadDataFilesAsync();
        }

        void DataFileLoader_OnLoadingCompleted()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new CloseFormDelegate(Close));
            }
            else
            {
                Close();
            }
        }

        void DataFileLoader_OnDataFileLoaded(DataFile dataFile, List<ObjectClass> objectClasses)
        {
            ObjectClassManager.ObjectClasses.AddRange(objectClasses);
            if (this.InvokeRequired)
            {
                this.Invoke(new UpdateProgressDelegate(UpdateProgress));
            }
            else
            {
                UpdateProgress();
            }
        }

        void UpdateProgress()
        {
            DataFilesLoaded++;
            int total = ObjectClassManager.DataFiles.Count;
            float percentage = (DataFilesLoaded * 100) / total;
            progressBar1.Value = (int)percentage;

            statusLabel.Text = String.Format("{0}% ({1}/{2})", percentage, DataFilesLoaded, total);
        }
    }
}
