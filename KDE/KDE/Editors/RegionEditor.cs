using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using ArturasServer.KalOnline.DataEditor.ObjectClasses;

namespace ArturasServer.KalOnline.DataEditor.Editors
{
    class RegionEditor : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            MapRegion mapRegion = (MapRegion)value;
            MapRegionEditorForm form = new MapRegionEditorForm(mapRegion);
            form.ShowDialog();
            return mapRegion;
        }
    }
}
