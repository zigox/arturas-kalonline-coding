using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kml;

namespace KmlEditor
{
    class SyntaxValidationResult
    {
        public CharPosition ErrorPosition;
        public string Error;
        public bool Valid;

        public SyntaxValidationResult(bool Valid)
        {
            this.Valid = Valid;
        }

        public SyntaxValidationResult(bool Valid, string Error, CharPosition ErrorPosition)
        {
            this.Valid = Valid;
            this.Error = Error;
            this.ErrorPosition = ErrorPosition;
        }
    }
}
