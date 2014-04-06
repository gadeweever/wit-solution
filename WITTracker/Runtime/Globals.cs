using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WITTracker.Runtime
{
    public class Globals
    {

        private static int _compositeAverage;
        private static string _toEmail;
        private static int _accountID;
        private static string _teacherName;
        private static int _englishAverage;
        private static int _mathAverage;
        private static int _writingAverage;
        private static int _readingAverage;
        private static int _scienceAverage;

        #region Grade Average Definitions
        public static int MathAverage
        {
            get
            {
                return _mathAverage;
            }
            set
            {
                _mathAverage = value;
            }
        }
        public static int ReadingAverage
        {
            get
            {
                return _readingAverage;
            }
            set
            {
                _readingAverage = value;
            }
        }
        public static int ScienceAverage
        {
            get
            {
                return _scienceAverage;
            }
            set
            {
                _scienceAverage = value;
            }
        }
        public static int EnglishAverage
        {
            get
            {
                return _englishAverage;
            }
            set
            {
                _englishAverage = value;
            }
        }

        public static int WritingAverage
        {
            get
            {
                return _writingAverage;
            }
            set
            {
                _writingAverage = value;
            }
        }
        #endregion

        #region Session Delclarations
        public static string TeacherName
        {
            get
            {
                return _teacherName;
            }
            set
            {
                _teacherName = value;
            }
        }

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
        #endregion
    }
}