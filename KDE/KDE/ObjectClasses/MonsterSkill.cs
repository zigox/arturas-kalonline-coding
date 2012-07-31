using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ArturasServer.KalOnline.DataEditor.ObjectClasses
{
    public class MonsterSkill : ObjectClass
    {
        private Int32 _Value1;
        private Int32 _Value2;

        public override Dictionary<string, ObjectClass> GetLinks
        {
            get
            {
                return base.GetLinks;
            }
        }

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
    }
}
