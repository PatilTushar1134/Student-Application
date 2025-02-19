using System.ComponentModel.DataAnnotations;

namespace Student__System_With_Code_First.Models
{
    public class Student_Model
    {
        [Key]
        public int stud_id { get;set; }
        public string stud_name { get; set; }
        public string stud_email { get; set; }
        public string stud_phone { get; set; }
        public string stud_address { get; set; }
    }
}
