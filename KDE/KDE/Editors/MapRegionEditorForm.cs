using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ArturasServer.KalOnline.DataEditor.ObjectClasses;


namespace ArturasServer.KalOnline.DataEditor.Editors
{
    public partial class MapRegionEditorForm : Form
    {
        MapRegion MapRegion;

        public MapRegionEditorForm(ObjectClasses.MapRegion mapRegion)
        {
            InitializeComponent();
            this.MapRegion = mapRegion;

            mapDropDown.Items.Add(MinimapLoader.World);
            mapDropDown.Items.Add(MinimapLoader.Dungeon);

            x1NumericUpDown.Value = MapRegion.X1;
            y1NumericUpDown.Value = MapRegion.Y1;
            x2NumericUpDown.Value = MapRegion.X2;
            y2NumericUpDown.Value = MapRegion.Y2;

            mapRegionControl.MapRegion = mapRegion;
            mapRegionControl.Focus();
        }

        private void mapRegionControl_Click(object sender, EventArgs e)
        {
            this.ActiveControl = mapRegionControl;
        }

        private void x1NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            MapRegion.X1 = (int)x1NumericUpDown.Value;
        }

        private void y1NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            MapRegion.Y1 = (int)y1NumericUpDown.Value;
        }

        private void x2NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            MapRegion.X2 = (int)x2NumericUpDown.Value;
        }

        private void y2NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            MapRegion.Y2 = (int)y2NumericUpDown.Value;
        }

        private void mapDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mapDropDown.SelectedItem != null)
            {
                mapRegionControl.LoadMinimap((Minimap)mapDropDown.SelectedItem);
            }
        }

    }
}
