using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using ArturasServer.KalOnline.DataEditor.ObjectClasses;
using System.Windows.Forms;

namespace ArturasServer.KalOnline.DataEditor
{
    public class DataFileLoader
    {
        public event DataFileLoadedEvent OnDataFileLoaded;
        public event LoadingCompletedEvent OnLoadingCompleted;
        public delegate void DataFileLoadedEvent(DataFile dataFile, List<ObjectClass> objectClasses);
        public delegate void LoadingCompletedEvent();
        
        private List<DataFile> DataFiles;

        public void LoadDataFilesAsync(List<DataFile> dataFiles)
        {
            this.DataFiles = dataFiles;
            Thread t = new Thread(new ThreadStart(LoadDataFiles));
            t.Start();
        }

        private void LoadDataFiles()
        {
            foreach (DataFile dataFile in DataFiles)
            {
                List<ObjectClass> objectClasses = dataFile.Load();        
                if (OnDataFileLoaded != null)
                {
                    OnDataFileLoaded(dataFile, objectClasses);
                }
            }
            if (OnLoadingCompleted != null)
            {
                OnLoadingCompleted();
            }
        }
    }
}
