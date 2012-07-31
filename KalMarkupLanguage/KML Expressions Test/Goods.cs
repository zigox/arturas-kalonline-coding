using System;
using System.Collections.Generic;
using System.Text;

namespace KmlObjectMappingTest
{
    public enum GoodsType
    {
        Edible,
        NonEdible,
    }
    public class Goods
    {
        private int _Index;
        private GoodsType _GoodsType;
        private List<GoodsItem> _Items = new List<GoodsItem>();
        private bool _Use;

        public int Index
        {
            get { return _Index; }
            set { _Index = value; }
        }

        public bool Use
        {
            get { return _Use; }
            set { _Use = value; }
        }

        public GoodsType GoodsType
        {
            get { return _GoodsType; }
            set { _GoodsType = value; }
        }

        public List<GoodsItem> Items
        {
            get { return _Items; }
            set { _Items = value; }
        }
    }
}
