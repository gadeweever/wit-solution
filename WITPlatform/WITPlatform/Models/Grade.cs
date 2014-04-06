using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WITPlatform.DAL;

namespace WITPlatform.Models
{
    public class Grade
    {

        public int ID { get; set; }
        public string Subject { get; set; }
        public int Score { get; set; }
    }
}