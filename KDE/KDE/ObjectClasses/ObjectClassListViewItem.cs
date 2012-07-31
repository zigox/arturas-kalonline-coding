using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArturasServer.KalOnline.DataEditor.ObjectClasses
{
    class ObjectClassListViewItem : ListViewItem
    {
        public ObjectClass ObjectClass;

        public ObjectClassListViewItem(ObjectClass objectClass)
        {
            this.ObjectClass = objectClass;
            UpdateLabels();
        }

        private int FindImageIndex
        {
            get
            {
                return MainForm.ObjectIcons.Images.IndexOfKey(ObjectClass.ImageKey);
            }
        }

        public void UpdateLabels()
        {
            this.Text = ObjectClass.ToString();
            this.SubItems.Add(ObjectClass.GetType().Name);
            this.SubItems.Add(ObjectClass.DataFile.Name);
            this.ImageIndex = FindImageIndex;
        }
    }
}
