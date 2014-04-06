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
        public static int _accountID;
        

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

        public static int AccountID
        {
            get
            {
                return _accountID;
            }
            set
            {
                _accountID = value;
            }
        }
    }
}