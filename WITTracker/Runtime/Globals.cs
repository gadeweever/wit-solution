using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WITTracker.Runtime
{
    public class Globals
    {

        public static int _compositeAverage;
        

        public static int CompositeAverage
        {
            get
            {
                return _compositeAverage;
            }

            set
            {
                _compositeAverage = value;
            }
        }
    }
}