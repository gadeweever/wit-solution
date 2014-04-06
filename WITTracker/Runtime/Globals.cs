using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WITTracker.Runtime
{
    public class Globals
    {

        public static int _compositeAverage;
        public static string _toEmail;
        

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

        public static string Email
        {
            get
            {
                return _toEmail;
            }
            set
            {
                _toEmail = value;
            }
        }
    }
}