using System;
using System.Collections.Generic;
using System.Text;

namespace WeekendExtention
{
    internal class Extention
    {
        private static int _id = 1000;

        public int Id { get; set; }

        public string Fullname { get; set; }

        public string Subject { get; set; }

        public string GroupName { get; set; }

        public Extention(string sub)
        {
            Subject = sub;
            _id++;
            Id = _id;
        }

        public string getSubject(string sub)
        {
            return char.ToUpper(sub[0]).ToString() + char.ToUpper(sub[1]).ToString();
        }
    }
}
