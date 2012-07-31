using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ArturasServer.KalOnline.Kml
{
    [Serializable]
    public class KmlValue
    {
        //value it holds
        private string _Value;

        private KmlNode _Parent;

        //indicate if its a string (used for quoting)
        public bool IsString = false;
        //start position in source
        public CharPosition StartPosition;
        public CharPosition EndPosition;
        //comments
        public List<KmlComment> Comments = new List<KmlComment>();

        public KmlValue()
        {
            this._Value = "";
        }

        public KmlValue(string Value)
        {
            this._Value = Value;
        }

        public KmlValue(object Value)
        {
            this._Value = Value.ToString();
        }

        public KmlValue(string Value, bool IsString)
        {
            this._Value = Value;
            this.IsString = IsString;
        }

        public KmlValue(string Value, bool IsString, CharPosition StartPosition)
        {
            this._Value = Value;
            this.IsString = IsString;
            this.StartPosition = StartPosition;
        }

        public KmlValue(string Value, bool IsString, CharPosition StartPosition, CharPosition EndPosition)
        {
            this._Value = Value;
            this.IsString = IsString;
            this.StartPosition = StartPosition;
            this.EndPosition = EndPosition;
        }

        /// <summary>
        /// Gets or sets the parent node.
        /// </summary>
        public KmlNode Parent
        {
            get
            {
                return _Parent;
            }
            set
            {
                if (value == _Parent)
                {
                    return;
                }

                if (_Parent != null)
                {
                    _Parent.Values.Remove(this);
                }

                if (value != null && !value.Values.Contains(this))
                {
                    value.Values.Add(this);
                }

                _Parent = value;
            }
        }

        public bool IsNumeric
        {
            get
            {
                double num;
                return double.TryParse(this.Value, out num);
            }
        }

        public string Value
        {
            get
            {
                if (IsString)
                {
                    return this._Value;
                }
                else
                {
                    return this._Value.ToLower();
                }
            }
            set
            {
                this._Value = value;
            }
        }

        /// <summary>
        /// Returns the value with double quotes and escaping slashes.
        /// </summary>
        public string ValueAsString
        {
            get
            {
                string ret = this._Value;
                if (IsString)
                {
                    Regex regex = new Regex("[\"\\\x00]");
                    ret = regex.Replace(ret, @"\$&");

                    ret = "\"" + ret ;
                    
                    ret += "\"";
                }
                return ret;
            }
        }

        public int ValueAsInt
        {
            get
            {
                return Convert.ToInt32(this._Value);
            }
            set
            {
                this._Value = value.ToString();
            }
        }

        public override string ToString()
        {
            return ValueAsString;
        }

        public bool IsInt
        {
            get
            {
                int Num;

                bool isNum = int.TryParse(this.Value, out Num);

                return isNum;
            }
        }

        public KmlValue Clone()
        {
            KmlValue newKmlValue = new KmlValue(this._Value, this.IsString, StartPosition.Clone(), EndPosition.Clone());

            if (StartPosition != null)
            {
                newKmlValue.StartPosition = StartPosition.Clone();
            }
            if (EndPosition != null)
            {
                newKmlValue.EndPosition = EndPosition.Clone();
            }

            //comments
            foreach (KmlComment comment in Comments)
            {
                newKmlValue.Comments.Add(comment.Clone());
            }

            return newKmlValue;
        }

    }
}
