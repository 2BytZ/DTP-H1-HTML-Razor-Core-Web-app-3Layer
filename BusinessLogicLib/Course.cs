using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLib
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Teacher { get; set; }
        public int DurationInWeeks { get; set; }
    }
}
