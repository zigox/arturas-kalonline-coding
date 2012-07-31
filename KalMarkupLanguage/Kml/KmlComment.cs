using System;
using System.Collections.Generic;
using System.Text;

namespace ArturasServer.KalOnline.Kml
{
    public class KmlComment
    {
        //start position in source
        public CharPosition StartPosition;
        public CharPosition EndPosition;

        public string Value;

        public KmlComment(string Value)
        {
            this.Value = Value;
        }

        public KmlComment(string Value, CharPosition StartPosition)
        {
            this.Value = Value;
            this.StartPosition = StartPosition;
        }

        public KmlComment(string Value, CharPosition StartPosition, CharPosition EndPosition)
        {
            this.Value = Value;
            this.EndPosition = EndPosition;
        }

        public KmlComment Clone()
        {
            KmlComment newKmlComment = new KmlComment(this.Value);

            if (StartPosition != null)
            {
                newKmlComment.StartPosition = StartPosition.Clone();
            }
            if (EndPosition != null)
            {
                newKmlComment.EndPosition = EndPosition.Clone();
            }

            return newKmlComment;
        }
    }
}
