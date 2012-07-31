using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ArturasServer.KalOnline.DataEditor
{
    public static class Utilities
    {
        public static string GetResourceTextFile(string filename)
        {
            string result = string.Empty;

            using (Stream stream = typeof(Program).Assembly.GetManifestResourceStream("ArturasServer.KalOnline.DataEditor."+filename))
            {
                using (StreamReader sr = new StreamReader(stream))
                {
                    result = sr.ReadToEnd();
                }
            }

            return result;
        }

        public static bool IsSubclassOfRawGeneric(Type generic, Type toCheck)
        {
            while (toCheck != typeof(object))
            {
                var cur = toCheck.IsGenericType ? toCheck.GetGenericTypeDefinition() : toCheck;
                if (generic == cur)
                {
                    return true;
                }
                toCheck = toCheck.BaseType;
            }
            return false;
        }
    }
}
