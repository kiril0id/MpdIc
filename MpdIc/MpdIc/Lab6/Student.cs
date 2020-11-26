
using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MpdIc.Lab6
{
    [Table("Student")]
    public class Student
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        public string LastName { get; set; }
        public int Group { get; set; }
        public string Faculty { get; set; }
    }
}
