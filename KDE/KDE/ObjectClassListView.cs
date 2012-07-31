using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ArturasServer.KalOnline.DataEditor.ObjectClasses;

namespace ArturasServer.KalOnline.DataEditor
{
    class ObjectClassListView : ListView
    {
        private PropertyGrid _PropertyGrid;
        private ListView _ObjectLinksListView;

        public List<ObjectClassListViewItem> ListViewData = new List<ObjectClassListViewItem>();

        public ObjectClassListView()
        {
            this.SelectedIndexChanged += new EventHandler(ObjectClassListView_SelectedIndexChanged);
            this.RetrieveVirtualItem += new RetrieveVirtualItemEventHandler(ObjectClassListView_RetrieveVirtualItem);
        }

        void ObjectClassListView_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            e.Item = ListViewData[e.ItemIndex];
        }

        void ObjectClassListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            PropertyGrid.SelectedObjects = SelectedObjectClasses.ToArray();
            UpdateObjectLinks();
        }

        public void UpdateData()
        {
            this.VirtualListSize = ListViewData.Count();
        }

        public void UpdateObjectLinks()
        {
            //clear current items
            _ObjectLinksListView.Items.Clear();
            _ObjectLinksListView.Groups.Clear();

            //create dictionary to store current groups in.
            Dictionary<string, ListViewGroup> listViewGroups = new Dictionary<string, ListViewGroup>();

            //add each link into a group.
            foreach (ObjectClass objectClass in SelectedObjectClasses)
            {
                //get links
                Dictionary<string, ObjectClass> links = objectClass.GetLinks;

                foreach (string group in links.Keys)
                {
                    if (!listViewGroups.ContainsKey(group))
                    {
                        ListViewGroup listViewGroup = new ListViewGroup(group);
                        listViewGroups.Add(group, listViewGroup);
                        _ObjectLinksListView.Groups.Add(listViewGroup);
                    }
                }

                foreach (string key in links.Keys)
                {
                    ObjectClass objectClassLink = objectClass.GetLinks[key];
                    ObjectClassListViewItem newListViewItem = new ObjectClassListViewItem(objectClassLink);
                    newListViewItem.Group = listViewGroups[key];
                    _ObjectLinksListView.Items.Add(newListViewItem);
                }
            }
        }

        public PropertyGrid PropertyGrid
        {
            get
            {
                return _PropertyGrid;
            }
            set
            {
                if (_PropertyGrid != null)
                {
                    _PropertyGrid.PropertyValueChanged -= _PropertyGrid_PropertyValueChanged;
                }

                _PropertyGrid = value;

                //add events to new propertyGrid.
                if (_PropertyGrid != null)
                {
                    _PropertyGrid.PropertyValueChanged += new PropertyValueChangedEventHandler(_PropertyGrid_PropertyValueChanged);
                }
            }
        }

        public ListView ObjectLinksListView
        {
            get
            {
                return _ObjectLinksListView;
            }
            set
            {
                if (_ObjectLinksListView != null)
                {
                    _ObjectLinksListView.SelectedIndexChanged -= _ObjectLinksListView_SelectedIndexChanged;
                }

                _ObjectLinksListView = value;

                //add events to new propertyGrid.
                if (_ObjectLinksListView != null)
                {
                    _ObjectLinksListView.SelectedIndexChanged += new EventHandler(_ObjectLinksListView_SelectedIndexChanged);
                }
            }
        }

        void _ObjectLinksListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(_ObjectLinksListView.SelectedItems.Count > 0)
            {
                ObjectClassListViewItem selectedObjectListViewItem = (ObjectClassListViewItem)_ObjectLinksListView.SelectedItems[0];
                PropertyGrid.SelectedObject = selectedObjectListViewItem.ObjectClass;
            }
        }

        void _PropertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            UpdateSelectedObjectClasses();
        }

        public List<ObjectClass> SelectedObjectClasses
        {
            get
            {
                List<ObjectClass> objectClasses = new List<ObjectClass>();
                foreach (int i in this.SelectedIndices)
                {
                    objectClasses.Add(ListViewData[i].ObjectClass);
                }

                return objectClasses;
            }
        }



        private void UpdateSelectedObjectClasses()
        {
            foreach (int i in this.SelectedIndices)
            {
                ListViewData[i].UpdateLabels();
            }

            UpdateObjectLinks();
        }
    }
}
