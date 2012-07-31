using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using ArturasServer.KalOnline.DataEditor.Editors;

namespace ArturasServer.KalOnline.DataEditor.ObjectClasses
{
    class GenMonster : ObjectClass
    {
        private int _Index;
        private int _Map;
        private int _Area;
        private int _Max;
        private int _Cycle;
        private int _X1;
        private int _Y1;
        private int _X2;
        private int _Y2;

        public override Dictionary<string, ObjectClass> GetLinks
        {
            get
            {
                Dictionary<string, ObjectClass> links = new Dictionary<string, ObjectClass>();
                links.Add("Monster", Monster);
                links.Add("Monster Name", Monster.Name);
                return links;
            }
        }


        public override string ToString()
        {
            if (Monster == null || Monster.Name == null)
            {
                return "Unknown Gen Monster";
            }
            else
            {
                return Monster.Name.Value;
            }
        }

        [CategoryAttribute("System")]
        public Monster Monster
        {
            get
            {
                var selectedMonsters =
                    from o in ObjectClassManager.ObjectClasses
                    where o.GetType() == typeof(Monster)
                    where ((Monster)o).Index == Index
                    select o;

                foreach (Monster monster in selectedMonsters)
                {
                    return monster;
                }

                return null;
            }
        }

        [CategoryAttribute("System")]
        public int Index
        {
            get { return _Index; }
            set { _Index = value; }
        }

        [CategoryAttribute("Location")]
        public int Map
        {
            get { return _Map; }
            set { _Map = value; }
        }

        [CategoryAttribute("System")]
        public int Area
        {
            get { return _Area; }
            set { _Area = value; }
        }

        [CategoryAttribute("System")]
        public int Max
        {
            get { return _Max; }
            set { _Max = value; }
        }

        [CategoryAttribute("System")]
        public int Cycle
        {
            get { return _Cycle; }
            set { _Cycle = value; }
        }

        [CategoryAttribute("Location")]
        public int X1
        {
            get { return _X1; }
            set { _X1 = value; }
        }

        [CategoryAttribute("Location")]
        public int Y1
        {
            get { return _Y1; }
            set { _Y1 = value; }
        }

        [CategoryAttribute("Location")]
        public int X2
        {
            get { return _X2; }
            set { _X2 = value; }
        }

        [CategoryAttribute("Location")]
        public int Y2
        {
            get { return _Y2; }
            set { _Y2 = value; }
        }

        [CategoryAttribute("Location")]
        [Browsable(true)]
        [EditorAttribute(typeof(RegionEditor),
typeof(System.Drawing.Design.UITypeEditor))]
        public MapRegion SpawnLocation
        {
            get
            {
                return new MapRegion(X1, Y1, X2, Y2);
            }
            set
            {
                X1 = value.X1;
                Y1 = value.Y1;
                X2 = value.X2;
                Y2 = value.Y2;
            }
        }
    }
}
