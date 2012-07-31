using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArturasServer.KalOnline.DataEditor.ObjectClasses
{
    public class MonsterQuest
    {
        private Int32 _Value1;
        private Int32 _Value2;
        private Int32 _Value3;
        private Int32 _Value4;

        public Int32 Value1
        {
            get { return _Value1; }
            set { _Value1 = value; }
        }

        public Int32 Value2
        {
            get { return _Value2; }
            set { _Value2 = value; }
        }

        public Int32 Value3
        {
            get { return _Value3; }
            set { _Value3 = value; }
        }

        public Int32 Value4
        {
            get { return _Value4; }
            set { _Value4 = value; }
        }
    }
}
