using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace KOCE
{
    class FileListViewItem : ListViewItem
    {
        public string FileName;

        public FileListViewItem(string FileName)
        {
            this.FileName = FileName;

            FileInfo fi = new FileInfo(FileName);

            this.Text = fi.Name;
        }
    }
}
