using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClassroomDBLab
{
    class Student
    {
        //properties
        [Key]
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string favFood { get; set; }
        public string Hometown { get; set; }

    }   
}
